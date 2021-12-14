namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies3 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, DateAddedToDatabase, ReleaseDate, NumberInStock, GenreId) VALUES ('The Hangover', '20211212', '20090615', 5, 1)");
            Sql("INSERT INTO Movies (Name, DateAddedToDatabase, ReleaseDate, NumberInStock, GenreId) VALUES ('Die Hard', '20211212', '19880701', 2, 2)");
            Sql("INSERT INTO Movies (Name, DateAddedToDatabase, ReleaseDate, NumberInStock, GenreId) VALUES ('Toy Story', '20211212', '19950110', 10, 4)");
            Sql("INSERT INTO Movies (Name, DateAddedToDatabase, ReleaseDate, NumberInStock, GenreId) VALUES ('Titanic', '20211212', '19970522', 3, 3)");
            Sql("INSERT INTO Movies (Name, DateAddedToDatabase, ReleaseDate, NumberInStock, GenreId) VALUES ('The Terminator', '20211212', '19840913', 4, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
