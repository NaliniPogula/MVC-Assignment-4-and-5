//using HOL_4.Models;

//namespace HOL_4.Migrations
//{
//    using System;
//    using System.Data.Entity.Migrations;

//    public partial class Create : DbMigration
//    {
//        public override void Up()
//        {
//            AlterColumn("dbo.Accounts", "Name", c => c.String(nullable: false, maxLength: 255));
//        }

//        public override void Down()
//        {
//            AlterColumn("dbo.Accounts", "Name", c => c.String());
//        }
//    }
//}

namespace HOL_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
            "dbo.Accounts",
            c => new
            {
                AccountNumber = c.Int(nullable: false),
                Name = c.String(),
                CurrentBalance = c.Double(nullable: false),
            })
            .PrimaryKey(t => t.AccountNumber);

        }

        public override void Down()
        {
            DropTable("dbo.Accounts");
        }
    }
}
