namespace Vidly_Clone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixDiscountRate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.MembershipTypes", "DiscountFee");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DiscountFee", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.MembershipTypes", "DiscountRate");
        }
    }
}
