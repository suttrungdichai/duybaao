namespace lab3._4._5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES(1, 'development')");
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES(2, 'busmeiss')");
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES(3, 'trainer')");
        }
        
        public override void Down()
        {
        }
    }
}
