namespace Vidly_Clone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetRequiredToNameInCustoer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
    }
}
