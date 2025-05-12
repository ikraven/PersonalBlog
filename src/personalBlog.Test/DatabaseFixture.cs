using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using personalBlog.DAta.DbContext;


public class DatabaseFixture : IDisposable
{
    public BlogDbContext Context { get; private set; }
    private readonly string _dbFileName;

    public DatabaseFixture()
    {
        // Genera un nombre de archivo temporal para la base de datos
        _dbFileName = Path.GetTempFileName(); 
        // Si prefieres algo más controlado: _dbFileName = "test_integration.db";
        
        // Crea las opciones de DbContext usando el archivo SQLite
        var options = new DbContextOptionsBuilder<BlogDbContext>()
            .UseSqlite($"Data Source={_dbFileName}")
            .Options;
        
        // Crea el DbContext y aplica cualquier migración pendiente
        Context = new BlogDbContext();
        Context.Database.Migrate();
    }

    public void Dispose()
    {
        // Cerramos el contexto
        Context.Dispose();
        
        // Eliminamos el archivo de la base de datos
        if (File.Exists(_dbFileName))
        {
            File.Delete(_dbFileName);
        }
    }
}