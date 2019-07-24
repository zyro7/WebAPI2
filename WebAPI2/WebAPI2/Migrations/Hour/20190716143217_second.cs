using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI2.Migrations.Hour
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HourDetails",
                columns: table => new
                {
                    HourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hour = table.Column<string>(type: "varchar(10)", nullable: false),
                    Day = table.Column<string>(type: "varchar(10)", nullable: false),
                    TattooArtist = table.Column<string>(type: "varchar(20)", nullable: false),
                    Client = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourDetails", x => x.HourId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HourDetails");
        }
    }
}
