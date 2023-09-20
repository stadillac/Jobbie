using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobbie.Db.Migrations
{
    /// <inheritdoc />
    public partial class tying_companytype_to_solicitor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyTypeId",
                table: "Solicitors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Solicitors_CompanyTypeId",
                table: "Solicitors",
                column: "CompanyTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitors_CompanyTypes_CompanyTypeId",
                table: "Solicitors",
                column: "CompanyTypeId",
                principalTable: "CompanyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitors_CompanyTypes_CompanyTypeId",
                table: "Solicitors");

            migrationBuilder.DropIndex(
                name: "IX_Solicitors_CompanyTypeId",
                table: "Solicitors");

            migrationBuilder.DropColumn(
                name: "CompanyTypeId",
                table: "Solicitors");
        }
    }
}
