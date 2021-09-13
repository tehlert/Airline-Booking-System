using Microsoft.EntityFrameworkCore.Migrations;

namespace Air3550.Migrations
{
    public partial class FinalCreateWithComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                column: "CustomerPassword",
                value: "IUoU8DGKA7ho7B12cXFCgJfApfVkUJcNZLfjh8q4qVYWnHOBhzm/8goVcRe0y9RwTBbk+hKQKtfcZhJUslQBuVtyfH9holmvv1+3gA==");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                column: "CustomerPassword",
                value: "w6Kdprd+5CCjEouT6HhJNBkvr8+tOpS3lHHOSdM/5CpJyF1YiJA+WGAH4oU4ruVrsnGO8f96K5eEeX8vEtN25U9v/7WvfbWLGOq6qmuO");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                column: "CustomerPassword",
                value: "0MWYIWWsQe3oNB/awcBsEvhVB5670EN1AwHU43Dn6fhYzN1ml7SbfAOPeVT00LXgJtTF70N2r5mWbo01wzpZMfNvBDMX2oXjrtnxJhw=");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                column: "CustomerPassword",
                value: "Fxp74HHCTNhRUXsJWjJPrKIlGiM70WcfWufL9UREKl+e6Uo/hMaqL2XQffbIWtxyPYg3Jpz9bh8GNZY9FcOzG+dI/cteOeblD2NM65aP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                column: "CustomerPassword",
                value: "CkUr/9qzo+RG6KmxbOG4pmhSdZj28kLqQWfMVVCev214e/xDfHkHECGnqdLoeruRdT01jlPqAsAQoa79RyFg2iocTW//");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                column: "CustomerPassword",
                value: "kPENY3iPYXZ8NHy73Xb9dvsqr6ulVn+aOWiBO8HPGvde5FZj/RmrV6sHXG6D+7yH1bpGLK+Zf4pKTqSlDyoPE6pJwiAUeDNsRw==");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                column: "CustomerPassword",
                value: "PQ86GB9720AOnAvx/EptQ1umzC6InrghCtTmc2iwXP/iIpYuASVBrWvr/o8h1SfZXtpZUmk2orsmhlZCqat6btMkH8b2Hnb4/e4u");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                column: "CustomerPassword",
                value: "/ye1E/NpN0Y5FABSBdZDn2BxINlXBoeRj7vHCybDM46Gm9RHrjC2KpawIs8/ABDw1njYj1NAPf9mkczoJYchsDdTxmpPh6/WWwOb/g==");
        }
    }
}
