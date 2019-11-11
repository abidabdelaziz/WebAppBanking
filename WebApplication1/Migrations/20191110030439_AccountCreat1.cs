using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class AccountCreat1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(maxLength: 2, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    pWord = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    toAccountId = table.Column<int>(nullable: false),
                    toAccType = table.Column<string>(nullable: true),
                    fromAccountId = table.Column<int>(nullable: false),
                    fromAccType = table.Column<string>(nullable: true),
                    tranSum = table.Column<int>(nullable: false),
                    timeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    OpenDate = table.Column<DateTime>(nullable: false),
                    Sum = table.Column<int>(nullable: false),
                    accType = table.Column<string>(nullable: false),
                    CustomerId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Customer_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CustomerId1",
                table: "Accounts",
                column: "CustomerId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
