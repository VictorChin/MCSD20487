namespace NorthwindModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addproc : DbMigration
    {
        public override void Up()
        {
         
            CreateStoredProcedure(
                "dbo.Region_Insert",
                p => new
                    {
                        RegionID = p.Int(),
                        RegionDescription = p.String(maxLength: 50, fixedLength: true),
                    },
                body:
                    @"INSERT [dbo].[Region]([RegionID], [RegionDescription])
                      VALUES (@RegionID, @RegionDescription)"
            );
            
            CreateStoredProcedure(
                "dbo.Region_Update",
                p => new
                    {
                        RegionID = p.Int(),
                        RegionDescription = p.String(maxLength: 50, fixedLength: true),
                    },
                body:
                    @"UPDATE [dbo].[Region]
                      SET [RegionDescription] = @RegionDescription
                      WHERE ([RegionID] = @RegionID)"
            );
            
            CreateStoredProcedure(
                "dbo.Region_Delete",
                p => new
                    {
                        RegionID = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Region]
                      WHERE ([RegionID] = @RegionID)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Region_Delete");
            DropStoredProcedure("dbo.Region_Update");
            DropStoredProcedure("dbo.Region_Insert");
         
        }
    }
}
