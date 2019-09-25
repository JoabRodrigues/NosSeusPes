namespace NosSeusPes
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelNosSeusPes : DbContext
    {
        // Your context has been configured to use a 'ModelNosSeusPes' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'NosSeusPes.ModelNosSeusPes' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelNosSeusPes' 
        // connection string in the application configuration file.
        public ModelNosSeusPes()
            : base("ModelNosSeusPes")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Cor> Cores { get; set; }
        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public virtual DbSet<Sapato> Sapatos { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}