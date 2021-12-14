namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerBirthdateRecord2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate= 1980-01-01 WHERE Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
