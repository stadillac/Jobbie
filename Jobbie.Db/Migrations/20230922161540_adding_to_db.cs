using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobbie.Db.Migrations
{
    /// <inheritdoc />
    public partial class adding_to_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractorSoftware_Contractors_ContractorId",
                table: "ContractorSoftware");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractorSoftware_Software_SoftwareId",
                table: "ContractorSoftware");

            migrationBuilder.DropForeignKey(
                name: "FK_Software_Contractors_ContractorId",
                table: "Software");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitationRoleRequiredSoftware_SolicitationRoles_SolicitationRoleId",
                table: "SolicitationRoleRequiredSoftware");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitors_CompanyTypes_CompanyTypeId",
                table: "Solicitors");

            migrationBuilder.DropIndex(
                name: "IX_Solicitors_CompanyTypeId",
                table: "Solicitors");

            migrationBuilder.DropIndex(
                name: "IX_Software_ContractorId",
                table: "Software");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Solicitors");

            migrationBuilder.DropColumn(
                name: "CompanyTypeId",
                table: "Solicitors");

            migrationBuilder.DropColumn(
                name: "TeamMeetingDay",
                table: "Solicitations");

            migrationBuilder.DropColumn(
                name: "TechProvided",
                table: "SolicitationRoles");

            migrationBuilder.DropColumn(
                name: "TechRequired",
                table: "SolicitationRoles");

            migrationBuilder.DropColumn(
                name: "ContractorId",
                table: "Software");

            migrationBuilder.RenameColumn(
                name: "SubscriptionMontlyCost",
                table: "Software",
                newName: "SubscriptionMonthlyCost");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Solicitations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Documents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "StatusUpdate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitationContractorId = table.Column<int>(type: "int", nullable: false),
                    SolicitorId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusUpdate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatusUpdate_SolicitationContractors_SolicitationContractorId",
                        column: x => x.SolicitationContractorId,
                        principalTable: "SolicitationContractors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StatusUpdate_Solicitors_SolicitorId",
                        column: x => x.SolicitorId,
                        principalTable: "Solicitors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CompanyTypeId",
                table: "Accounts",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusUpdate_SolicitationContractorId",
                table: "StatusUpdate",
                column: "SolicitationContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusUpdate_SolicitorId",
                table: "StatusUpdate",
                column: "SolicitorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_CompanyTypes_CompanyTypeId",
                table: "Accounts",
                column: "CompanyTypeId",
                principalTable: "CompanyTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorSoftware_Contractors_ContractorId",
                table: "ContractorSoftware",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorSoftware_Software_SoftwareId",
                table: "ContractorSoftware",
                column: "SoftwareId",
                principalTable: "Software",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitationRoleRequiredSoftware_SolicitationRoles_SolicitationRoleId",
                table: "SolicitationRoleRequiredSoftware",
                column: "SolicitationRoleId",
                principalTable: "SolicitationRoles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_CompanyTypes_CompanyTypeId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractorSoftware_Contractors_ContractorId",
                table: "ContractorSoftware");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractorSoftware_Software_SoftwareId",
                table: "ContractorSoftware");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitationRoleRequiredSoftware_SolicitationRoles_SolicitationRoleId",
                table: "SolicitationRoleRequiredSoftware");

            migrationBuilder.DropTable(
                name: "StatusUpdate");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_CompanyTypeId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Solicitations");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "SubscriptionMonthlyCost",
                table: "Software",
                newName: "SubscriptionMontlyCost");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Solicitors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CompanyTypeId",
                table: "Solicitors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "TeamMeetingDay",
                table: "Solicitations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TechProvided",
                table: "SolicitationRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TechRequired",
                table: "SolicitationRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContractorId",
                table: "Software",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Solicitors_CompanyTypeId",
                table: "Solicitors",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Software_ContractorId",
                table: "Software",
                column: "ContractorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorSoftware_Contractors_ContractorId",
                table: "ContractorSoftware",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorSoftware_Software_SoftwareId",
                table: "ContractorSoftware",
                column: "SoftwareId",
                principalTable: "Software",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Software_Contractors_ContractorId",
                table: "Software",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitationRoleRequiredSoftware_SolicitationRoles_SolicitationRoleId",
                table: "SolicitationRoleRequiredSoftware",
                column: "SolicitationRoleId",
                principalTable: "SolicitationRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitors_CompanyTypes_CompanyTypeId",
                table: "Solicitors",
                column: "CompanyTypeId",
                principalTable: "CompanyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
