using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class ComparisonModelMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comparisons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value_One = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Value_one_Unit = table.Column<string>(nullable: false),
                    Value_Two = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Value_Two_Unit = table.Column<string>(nullable: false),
                    Result = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comparisons", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comparisons");
        }
    }
}
