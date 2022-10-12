using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cineweb_orders_api.Migrations
{
    public partial class CreateTableOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    UserId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    MovieId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    OrderAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "order");
        }
    }
}
