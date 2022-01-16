namespace shoes_shop_entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Eventshoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        company = c.String(),
                        gender = c.String(),
                        heels = c.Boolean(nullable: false),
                        instock = c.Boolean(nullable: false),
                        size = c.Int(nullable: false),
                        price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Eventshoes");
        }
    }
}
