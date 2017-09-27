namespace TaskUltimate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TraineeDetails",
                c => new
                    {
                        LearnerId = c.Int(nullable: false),
                        CurrentAddress = c.String(),
                        Stream = c.String(),
                        PermanentAddress = c.String(),
                        FatherName = c.String(),
                    })
                .PrimaryKey(t => t.LearnerId)
                .ForeignKey("dbo.Trainees", t => t.LearnerId)
                .Index(t => t.LearnerId);
            
            CreateTable(
                "dbo.Trainees",
                c => new
                    {
                        LearnerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.LearnerId);
            
            CreateTable(
                "dbo.TraineeVMs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrentAddress = c.String(),
                        Stream = c.String(),
                        PermanentAddress = c.String(),
                        FatherName = c.String(),
                        Name = c.String(),
                        Email = c.String(),
                        Age = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TraineeDetails", "LearnerId", "dbo.Trainees");
            DropIndex("dbo.TraineeDetails", new[] { "LearnerId" });
            DropTable("dbo.TraineeVMs");
            DropTable("dbo.Trainees");
            DropTable("dbo.TraineeDetails");
        }
    }
}
