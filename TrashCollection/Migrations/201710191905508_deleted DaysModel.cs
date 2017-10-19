namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedDaysModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerModels", "ChangeWeeklyPickUp", c => c.Boolean(nullable: false));
            AddColumn("dbo.CustomerModels", "NewPickUpDay", c => c.String());
            AddColumn("dbo.CustomerModels", "PickUpsThisMonth", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerModels", "PickUpsThisMonth");
            DropColumn("dbo.CustomerModels", "NewPickUpDay");
            DropColumn("dbo.CustomerModels", "ChangeWeeklyPickUp");
        }
    }
}
