using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneContactWebsite.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    PhoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.PhoneId);
                });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "PhoneId", "Address", "Name", "Note", "Number" },
                values: new object[] { 1, "1337 Long Beach Drive", "John Doe", "This is a note!", 911 });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "PhoneId", "Address", "Name", "Note", "Number" },
                values: new object[] { 2, "1337 Long Beach Drive", "Jane Doe", "This is another note!", 911 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phones");
        }
    }
}
