using Microsoft.EntityFrameworkCore;

namespace Sadie.Db;

public static class SeedData
{
    public static async Task SeedInitialDataAsync(SadieDbContext dbContext)
    {
        using var httpClient = new HttpClient();
        var initialSql = await httpClient.GetStringAsync("https://cdn.sadie.pw/initialData.sql");
        await dbContext.Database.ExecuteSqlRawAsync(initialSql);
    }
}