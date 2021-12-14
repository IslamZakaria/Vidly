namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, DateAddedToDatabase, ReleaseDate, NumberInStock) VALUES ('The Hangover', 'Comedy', 2021-12-12, 2009-06-15, 5)");
            Sql("INSERT INTO Movies (Name, Genre, DateAddedToDatabase, ReleaseDate, NumberInStock) VALUES ('Die Hard', 'Action', 2021-12-12, 1988-07-01, 2)");
            Sql("INSERT INTO Movies (Name, Genre, DateAddedToDatabase, ReleaseDate, NumberInStock) VALUES ('Toy Story', 'Family', 2021-12-12, 1995-01-10, 10)");
            Sql("INSERT INTO Movies (Name, Genre, DateAddedToDatabase, ReleaseDate, NumberInStock) VALUES ('Titanic', 'Romance', 2021-12-12, 1997-05-22, 3)");
            Sql("INSERT INTO Movies (Name, Genre, DateAddedToDatabase, ReleaseDate, NumberInStock) VALUES ('The Terminator', 'Action', 2021-12-12, 1984-09-13, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
