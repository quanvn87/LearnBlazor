using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnBlazor.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    MHID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MHTEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MHCODE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GIABANLE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CREATEDDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.MHID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
