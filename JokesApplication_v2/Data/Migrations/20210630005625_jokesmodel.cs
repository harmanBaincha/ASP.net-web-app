using Microsoft.EntityFrameworkCore.Migrations;

namespace JokesApplication_v2.Data.Migrations
{
    public partial class jokesmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JokeQues",
                table: "Jokes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "JokeAns",
                table: "Jokes",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "JokeQues",
                table: "Jokes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JokeAns",
                table: "Jokes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
