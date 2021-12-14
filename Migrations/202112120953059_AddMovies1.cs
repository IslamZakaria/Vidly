namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies1 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Movies");
            Sql("INSERT INTO Movies (Name, Genre, DateAddedToDatabase, ReleaseDate, NumberInStock) VALUES ('The Hangover', 'Comedy', '20211212', '20090615', 5)");

        }

        public override void Down()
        {
        }
    }
}
