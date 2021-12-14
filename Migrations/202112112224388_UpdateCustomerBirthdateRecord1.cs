namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerBirthdateRecord1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate=1/1/1980 Where Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
