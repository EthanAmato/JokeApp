using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JokeApp.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            // - By running 'add-migration "initialsetup"' in package manager console, we setup
            //this object relation mapper which acts as an intermediary between a model (e.g. Jokes) and
            //a table in our SQL database
            // - allows computer to generate db tables based on classes defined in app
            //good for SIMPLE/BASIC APPS
            // - the alternative of manually creating tables, SQL statements, etc. is better for more sophisticated
            //projects (this method is called Data Access Object / DAO)
            // - update all db tables using these migrations by writing update-database in PMC
            migrationBuilder.CreateTable(
                name: "Joke",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JokeQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JokeAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joke", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Joke");
        }
    }
}
