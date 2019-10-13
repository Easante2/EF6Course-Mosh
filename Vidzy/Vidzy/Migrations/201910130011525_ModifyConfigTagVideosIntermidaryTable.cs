namespace Vidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyConfigTagVideosIntermidaryTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TagVideos", newName: "VideoTags");
            RenameColumn(table: "dbo.VideoTags", name: "Tag_Id", newName: "VideoId");
            RenameColumn(table: "dbo.VideoTags", name: "Video_Id", newName: "TagId");
            RenameIndex(table: "dbo.VideoTags", name: "IX_Video_Id", newName: "IX_TagId");
            RenameIndex(table: "dbo.VideoTags", name: "IX_Tag_Id", newName: "IX_VideoId");
            DropPrimaryKey("dbo.VideoTags");
            AddPrimaryKey("dbo.VideoTags", new[] { "TagId", "VideoId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.VideoTags");
            AddPrimaryKey("dbo.VideoTags", new[] { "Tag_Id", "Video_Id" });
            RenameIndex(table: "dbo.VideoTags", name: "IX_VideoId", newName: "IX_Tag_Id");
            RenameIndex(table: "dbo.VideoTags", name: "IX_TagId", newName: "IX_Video_Id");
            RenameColumn(table: "dbo.VideoTags", name: "TagId", newName: "Video_Id");
            RenameColumn(table: "dbo.VideoTags", name: "VideoId", newName: "Tag_Id");
            RenameTable(name: "dbo.VideoTags", newName: "TagVideos");
        }
    }
}
