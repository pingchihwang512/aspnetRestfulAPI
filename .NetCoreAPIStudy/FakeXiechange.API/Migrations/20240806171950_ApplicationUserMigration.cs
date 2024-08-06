using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeXiecheng.API.Migrations
{
    public partial class ApplicationUserMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "308660dc-ae51-480f-824d-7dca6714c3e2",
                column: "ConcurrencyStamp",
                value: "52b52244-24a1-46f1-bee6-e449424ac90e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90184155-dee0-40c9-bb1e-b5ed07afc04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10e8986d-ea8c-46ea-bf90-cdc47d52ca60", "AQAAAAEAACcQAAAAEPLi74qbT3gy4eLrslhmx3RFxHarK5Xb+KUUspH+6qIVSOIq09GtChwmlxjujPdurg==", "839428b4-a912-493b-a7fa-2933381aead1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "308660dc-ae51-480f-824d-7dca6714c3e2",
                column: "ConcurrencyStamp",
                value: "e51ed23c-98e9-4337-ab58-b6b04a948f8d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90184155-dee0-40c9-bb1e-b5ed07afc04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6b0fc1c-a1ac-4c14-9401-765bbdde3822", "AQAAAAEAACcQAAAAELeFsRmISoy+NbQVWAUhnU57/ipXrb0qZ3RWkDPPawDvXieCXM9BMGSXodN5vfvGzA==", "3fbe9ce8-a77a-408a-8965-e848147aa898" });
        }
    }
}
