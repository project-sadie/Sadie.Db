using Microsoft.EntityFrameworkCore;

namespace Sadie.Db;

public static class SeedData
{
    public static async Task SeedRawSqlFilesAsync(SadieContext context)
    {
        var baseDir = AppContext.BaseDirectory;
        var seedersPath = Path.Combine(baseDir, "Seeders");

        var rawSqlFiles = Directory
            .EnumerateFiles(seedersPath, "*.sql")
            .OrderBy(f => f)
            .ToList();

        foreach (var file in rawSqlFiles)
        {
            var sql = await File.ReadAllTextAsync(file);
            await context.Database.ExecuteSqlRawAsync(sql);
        }
    }
}