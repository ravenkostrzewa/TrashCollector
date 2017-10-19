namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createduserinputtableincustomerinformation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerModels", "RescheduledDay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerModels", "RescheduledDay");
        }
    }
}
