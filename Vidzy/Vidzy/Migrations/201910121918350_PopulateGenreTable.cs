namespace Vidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES VALUES (1, 'HORROR'), " +
                "(2, 'FANTASY'), " +
                "(3, 'ACTION')");

        }
        
        public override void Down()
        {
        }
    }
}
