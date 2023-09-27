using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobbie.Db.Migrations
{
    /// <inheritdoc />
    public partial class adding_name_field_to_two_entities_removing_has_specialty_from_discipline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasSpecialty",
                table: "Disciplines");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Specialties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Focuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Focuses");

            migrationBuilder.AddColumn<bool>(
                name: "HasSpecialty",
                table: "Disciplines",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
