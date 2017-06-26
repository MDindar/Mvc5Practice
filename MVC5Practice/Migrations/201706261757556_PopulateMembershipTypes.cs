namespace MVC5Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) values(1,0,0,0)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) values(2,30,1,10)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) values(3,90,3,15)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) values(4,300,12,25)");
        }
        
        public override void Down()
        {
            Sql("truncate table MembershipTypes");
        }
    }
}
