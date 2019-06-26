namespace EntityFrameworkExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Barrel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Barrels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Radius = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Employees");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        wage = c.Double(nullable: false),
                        totalHours = c.Int(nullable: false),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.Barrels");
        }
    }
}
