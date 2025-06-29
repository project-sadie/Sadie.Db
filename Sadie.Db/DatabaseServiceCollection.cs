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
        serviceCollection.AddDbContextFactory<SadieContext>(); 
        
        serviceCollection.AddDbContext<SadieContext>(options =>
        {
            options.UseMySql(config.GetConnectionString("Default"), MySqlServerVersion.LatestSupportedServerVersion, mySqlOptions =>
            {
                mySqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 10,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null);
                
                mySqlOptions.MigrationsAssembly("Sadie.Migrations");
            });
        
            options.UseSnakeCaseNamingConvention();
        }, ServiceLifetime.Transient);

        serviceCollection.AddSingleton<ServerPlayerConstants>(provider =>
            provider.GetRequiredService<SadieContext>()
                .ServerPlayerConstants
                .First()
            );

        serviceCollection.AddSingleton<ServerRoomConstants>(provider =>
            provider.GetRequiredService<SadieContext>()
                .ServerRoomConstants
                .OrderByDescending(x => x.CreatedAt)
                .First()
            );
        
        serviceCollection.AddSingleton(provider =>
        {
            var context = provider.GetRequiredService<SadieContext>();
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
            provider.GetRequiredService<SadieContext>()
                .Set<CatalogFrontPageItem>()
                .Include(x => x.CatalogPage)
                .ToList());
    }
    
    private static void LoadPagesRecursively(SadieContext context, ICollection<CatalogPage> pages)
    {
        if (pages.Count == 0)
        {
            return;
        }

        context.Entry(pages).Collection(p => p).Load();

        foreach (var page in pages.Where(page => page.Pages.Count > 0))
        {
            LoadPagesRecursively(context, page.Pages);
        }
    }
}