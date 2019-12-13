namespace ClassCoustmer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cilidindu20191212 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Name", c => c.String(maxLength: 10, fixedLength: true));
        }
    }
}
