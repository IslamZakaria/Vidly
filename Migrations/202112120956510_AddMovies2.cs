namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, DateAddedToDatabase, ReleaseDate, NumberInStock) VALUES ('Die Hard', 'Action', '20211212', '19880701', 2)");
            Sql("INSERT INTO Movies (Name, Genre, DateAddedToDatabase, ReleaseDate, NumberInStock) VALUES ('Toy Story', 'Family', '20211212', '19950110', 10)");
            Sql("INSERT INTO Movies (Name, Genre, DateAddedToDatabase, ReleaseDate, NumberInStock) VALUES ('Titanic', 'Romance', '20211212', '19970522', 3)");
            Sql("INSERT INTO Movies (Name, Genre, DateAddedToDatabase, ReleaseDate, NumberInStock) VALUES ('The Terminator', 'Action', '20211212', '19840913', 4)");
        }
        
        public override void Down()
        {
        }
    }
}
