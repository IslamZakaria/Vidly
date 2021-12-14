namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeNameRecords : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name='Pay As You Go' WHERE Id=1");
            Sql("UPDATE MembershipTypes SET Name='Monthly' WHERE Id=2");
        }

        private void Sql()
        {
            throw new NotImplementedException();
        }

        public override void Down()
        {
        }
    }
}
