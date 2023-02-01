using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace TestXSIS.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "longtext", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false),
                    rating = table.Column<float>(type: "float", nullable: true),
                    image = table.Column<string>(type: "longtext", nullable: true),
                    createdat = table.Column<DateTime>(name: "created_at", type: "datetime(6)", nullable: true),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
