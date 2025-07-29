using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sadie.Db.Models.Catalog.FrontPage;
using Sadie.Db.Models.Catalog.Pages;
using Sadie.Db.Models.Constants;

namespace Sadie.Db;

public static class DatabaseServiceCollection
{
    public static void AddServices(IServiceCollection serviceCollection, IConfiguration config)
    {
        serviceCollection.AddDbContextFactory<SadieDbContext>(); 
        
        serviceCollection.AddDbContext<SadieDbContext>(options =>
        {
            options.UseMySql(config.GetConnectionString("Default"), MySqlServerVersion.LatestSupportedServerVersion, mySqlOptions =>
            {
                mySqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 10,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null);
                
                mySqlOptions.MigrationsAssembly("Sadie.Db");
            });
        
            options.UseSnakeCaseNamingConvention();
        }, ServiceLifetime.Transient);
        
        serviceCollection.AddDbContextFactory<SadieMigrationsDbContext>();

        serviceCollection.AddSingleton<ServerPlayerConstants>(provider =>
            provider.GetRequiredService<SadieDbContext>()
                .ServerPlayerConstants
                .First()
            );

        serviceCollection.AddSingleton<ServerRoomConstants>(provider =>
            provider.GetRequiredService<SadieDbContext>()
                .ServerRoomConstants
                .OrderByDescending(x => x.CreatedAt)
                .First()
            );
        
        serviceCollection.AddSingleton(provider =>
        {
            var context = provider.GetRequiredService<SadieDbContext>();
            var pages = context.Set<CatalogPage>()
                .Include(c => c.Items)
                .ThenInclude(x => x.FurnitureItems)
                .ToList();

            foreach (var page in pages)
            {
                LoadPagesRecursively(context, page.Pages);
            }

            return pages;
        });

        serviceCollection.AddSingleton(provider =>
            provider.GetRequiredService<SadieDbContext>()
                .Set<CatalogFrontPageItem>()
                .Include(x => x.CatalogPage)
                .ToList());
    }
    
    private static void LoadPagesRecursively(SadieDbContext dbContext, ICollection<CatalogPage> pages)
    {
        if (pages.Count == 0)
        {
            return;
        }

        foreach (var page in pages.Where(page => page.Pages.Count > 0))
        {
            dbContext.Entry(page).Collection(p => p.Pages).Load();

            if (page.Pages.Count <= 0)
            {
                continue;
            }
            
            LoadPagesRecursively(dbContext, page.Pages);
        }
    }
}