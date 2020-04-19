using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace applications_api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    Form = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "ApplicationId", "Created", "Form", "LastUpdated" },
                values: new object[] { new Guid("b4c4e316-29c3-4ca1-8254-379f12a8c62a"), new DateTime(2020, 4, 18, 13, 1, 54, 126, DateTimeKind.Local).AddTicks(7781), "{\"Name\": \"John Doe\"}", new DateTime(2020, 4, 18, 13, 1, 54, 126, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "ApplicationId", "Created", "Form", "LastUpdated" },
                values: new object[] { new Guid("d9d85732-b2b8-4615-af41-781b7d609001"), new DateTime(2020, 4, 18, 13, 1, 54, 127, DateTimeKind.Local).AddTicks(492), "{\"Name\": \"Sue Hunter\"}", new DateTime(2020, 4, 18, 13, 1, 54, 127, DateTimeKind.Local).AddTicks(526) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");
        }
    }
}
