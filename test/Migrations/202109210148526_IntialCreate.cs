namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128, unicode: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128, unicode: false),
                        Studentname = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student");
            DropTable("dbo.Accounts");
        }
    }
}
