using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestXSIS.Migrations
{
    /// <inheritdoc />
    public partial class updateNullableImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "movies",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<float>(
                name: "rating",
                table: "movies",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "movies",
                type: "varchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "movies",
                type: "varchar(4000)",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "movies",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<float>(
                name: "rating",
                table: "movies",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "movies",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "movies",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(4000)",
                oldMaxLength: 4000);
        }
    }
}
