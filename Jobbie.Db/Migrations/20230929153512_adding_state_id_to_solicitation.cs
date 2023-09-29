using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobbie.Db.Migrations
{
    /// <inheritdoc />
    public partial class adding_state_id_to_solicitation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Solicitations");

            migrationBuilder.AddColumn<int>(
                name: "SolicitationId",
                table: "States",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "Solicitations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_States_SolicitationId",
                table: "States",
                column: "SolicitationId");

            migrationBuilder.AddForeignKey(
                name: "FK_States_Solicitations_SolicitationId",
                table: "States",
                column: "SolicitationId",
                principalTable: "Solicitations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_States_Solicitations_SolicitationId",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_States_SolicitationId",
                table: "States");

            migrationBuilder.DropColumn(
                name: "SolicitationId",
                table: "States");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Solicitations");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Solicitations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
