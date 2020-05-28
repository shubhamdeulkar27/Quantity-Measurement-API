using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class UpdateComparisonModelMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value_one_Unit",
                table: "Comparisons",
                newName: "Value_One_Unit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value_One_Unit",
                table: "Comparisons",
                newName: "Value_one_Unit");
        }
    }
}
