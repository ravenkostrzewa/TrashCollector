namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedcustomertable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerModels", "CustomerZip", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerModels", "CustomerZip", c => c.Int(nullable: false));
        }
    }
}
