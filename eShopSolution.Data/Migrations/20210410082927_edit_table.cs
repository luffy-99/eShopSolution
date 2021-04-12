using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class edit_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 7, 0, 4, 58, 864, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "97e35b8a-6d43-4799-8b2a-1e5001ca135d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3fcdca6e-7abe-40a4-beb2-4c9c5054057b", "AQAAAAEAACcQAAAAEPYeG4HTwj9INuMeL2/DGmQeBhR5Nt2QaKLz6UQtNTpbGMpT8mG69iIBZDi3Mk+Dsw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 10, 15, 29, 24, 778, DateTimeKind.Local).AddTicks(3088));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 7, 0, 4, 58, 864, DateTimeKind.Local).AddTicks(1173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9ddc6a0f-7337-409f-b414-55d5a083762b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ec33139-ce70-4107-9346-d3dbf9368e2f", "AQAAAAEAACcQAAAAEBZ/SRtWJxj7ee4MCyOMi2doiJ9+jhnjvbur/8QXW4BFiQ9Ido51o7NjPYVFIsqJ/A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 7, 0, 4, 58, 934, DateTimeKind.Local).AddTicks(4397));
        }
    }
}
