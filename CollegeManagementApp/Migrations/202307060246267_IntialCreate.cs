namespace CollegeManagementApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable:false),
                        SubjectId = c.String(nullable:false,maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectId)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.String(nullable: false, maxLength: 128),
                        SubjectName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SubjectId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(nullable: false),
                        SubjectId = c.String(nullable: false, maxLength: 128),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectId)
                .Index(t => t.SubjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Teachers", "SubjectId", "dbo.Subjects");
            DropIndex("dbo.Teachers", new[] { "SubjectId" });
            DropIndex("dbo.Students", new[] { "SubjectId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Subjects");
            DropTable("dbo.Students");
        }
    }
}
