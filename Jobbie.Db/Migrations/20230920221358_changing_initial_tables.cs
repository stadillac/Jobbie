using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobbie.Db.Migrations
{
    /// <inheritdoc />
    public partial class changing_initial_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Address_AddressId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_States_StateId",
                table: "Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "HourlyRate",
                table: "Solicitations");

            migrationBuilder.DropColumn(
                name: "LumpSum",
                table: "Solicitations");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameColumn(
                name: "GovernmentId",
                table: "Licenses",
                newName: "LicenseNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Address_StateId",
                table: "Addresses",
                newName: "IX_Addresses_StateId");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Solicitations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "County",
                table: "Solicitations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EstimatedEndDate",
                table: "Solicitations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SharedDriveUrl",
                table: "Solicitations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Solicitations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Solicitations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "TeamMeetingDay",
                table: "Solicitations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TeamMeetingTime",
                table: "Solicitations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SolicitationRoleId",
                table: "SolicitationContractors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Licenses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "BankAccounts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CompanyTypeId",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentWorkload",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmployerIdentificationNumber",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "HoursAvailablePerWeek",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Accounts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SocialSecurityNumber",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDeliverables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDeliverables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Software",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSubscription = table.Column<bool>(type: "bit", nullable: false),
                    SubscriptionMontlyCost = table.Column<double>(type: "float", nullable: false),
                    InitialPurchaseCost = table.Column<double>(type: "float", nullable: false),
                    ContractorId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Software", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Software_Contractors_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "Contractors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SolicitationRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitationId = table.Column<int>(type: "int", nullable: false),
                    ProjectDeliverableId = table.Column<int>(type: "int", nullable: false),
                    HasContractor = table.Column<bool>(type: "bit", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LumpSum = table.Column<double>(type: "float", nullable: false),
                    HourlyRate = table.Column<double>(type: "float", nullable: false),
                    SignBonus = table.Column<double>(type: "float", nullable: false),
                    Workload = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechRequired = table.Column<int>(type: "int", nullable: false),
                    TechProvided = table.Column<int>(type: "int", nullable: false),
                    DeliverableDeadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractorTerminated = table.Column<bool>(type: "bit", nullable: false),
                    ContractorPaid = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitationRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitationRoles_ProjectDeliverables_ProjectDeliverableId",
                        column: x => x.ProjectDeliverableId,
                        principalTable: "ProjectDeliverables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitationRoles_Solicitations_SolicitationId",
                        column: x => x.SolicitationId,
                        principalTable: "Solicitations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContractorSoftware",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorId = table.Column<int>(type: "int", nullable: false),
                    SoftwareId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorSoftware", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractorSoftware_Contractors_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "Contractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractorSoftware_Software_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "Software",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorAccountId = table.Column<int>(type: "int", nullable: true),
                    SolicitorAccountId = table.Column<int>(type: "int", nullable: true),
                    ReviewerId = table.Column<int>(type: "int", nullable: false),
                    SolicitationRoleId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Accounts_ContractorAccountId",
                        column: x => x.ContractorAccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Accounts_SolicitorAccountId",
                        column: x => x.SolicitorAccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_SolicitationRoles_SolicitationRoleId",
                        column: x => x.SolicitationRoleId,
                        principalTable: "SolicitationRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolicitationRoleProvidedSoftware",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitationRoleId = table.Column<int>(type: "int", nullable: false),
                    SoftwareId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitationRoleProvidedSoftware", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitationRoleProvidedSoftware_Software_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "Software",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitationRoleProvidedSoftware_SolicitationRoles_SolicitationRoleId",
                        column: x => x.SolicitationRoleId,
                        principalTable: "SolicitationRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SolicitationRoleRequiredSoftware",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitationRoleId = table.Column<int>(type: "int", nullable: false),
                    SoftwareId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitationRoleRequiredSoftware", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitationRoleRequiredSoftware_Software_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "Software",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitationRoleRequiredSoftware_SolicitationRoles_SolicitationRoleId",
                        column: x => x.SolicitationRoleId,
                        principalTable: "SolicitationRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SolicitationContractors_SolicitationRoleId",
                table: "SolicitationContractors",
                column: "SolicitationRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorSoftware_ContractorId",
                table: "ContractorSoftware",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorSoftware_SoftwareId",
                table: "ContractorSoftware",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ContractorAccountId",
                table: "Reviews",
                column: "ContractorAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_SolicitationRoleId",
                table: "Reviews",
                column: "SolicitationRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_SolicitorAccountId",
                table: "Reviews",
                column: "SolicitorAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Software_ContractorId",
                table: "Software",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitationRoleProvidedSoftware_SoftwareId",
                table: "SolicitationRoleProvidedSoftware",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitationRoleProvidedSoftware_SolicitationRoleId",
                table: "SolicitationRoleProvidedSoftware",
                column: "SolicitationRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitationRoleRequiredSoftware_SoftwareId",
                table: "SolicitationRoleRequiredSoftware",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitationRoleRequiredSoftware_SolicitationRoleId",
                table: "SolicitationRoleRequiredSoftware",
                column: "SolicitationRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitationRoles_ProjectDeliverableId",
                table: "SolicitationRoles",
                column: "ProjectDeliverableId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitationRoles_SolicitationId",
                table: "SolicitationRoles",
                column: "SolicitationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Addresses_AddressId",
                table: "Accounts",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_States_StateId",
                table: "Addresses",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitationContractors_SolicitationRoles_SolicitationRoleId",
                table: "SolicitationContractors",
                column: "SolicitationRoleId",
                principalTable: "SolicitationRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Addresses_AddressId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_States_StateId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitationContractors_SolicitationRoles_SolicitationRoleId",
                table: "SolicitationContractors");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "ContractorSoftware");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "SolicitationRoleProvidedSoftware");

            migrationBuilder.DropTable(
                name: "SolicitationRoleRequiredSoftware");

            migrationBuilder.DropTable(
                name: "Software");

            migrationBuilder.DropTable(
                name: "SolicitationRoles");

            migrationBuilder.DropTable(
                name: "ProjectDeliverables");

            migrationBuilder.DropIndex(
                name: "IX_SolicitationContractors_SolicitationRoleId",
                table: "SolicitationContractors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Solicitations");

            migrationBuilder.DropColumn(
                name: "County",
                table: "Solicitations");

            migrationBuilder.DropColumn(
                name: "EstimatedEndDate",
                table: "Solicitations");

            migrationBuilder.DropColumn(
                name: "SharedDriveUrl",
                table: "Solicitations");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Solicitations");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Solicitations");

            migrationBuilder.DropColumn(
                name: "TeamMeetingDay",
                table: "Solicitations");

            migrationBuilder.DropColumn(
                name: "TeamMeetingTime",
                table: "Solicitations");

            migrationBuilder.DropColumn(
                name: "SolicitationRoleId",
                table: "SolicitationContractors");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Licenses");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "CompanyTypeId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "CurrentWorkload",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "EmployerIdentificationNumber",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "HoursAvailablePerWeek",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "SocialSecurityNumber",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "LicenseNumber",
                table: "Licenses",
                newName: "GovernmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_StateId",
                table: "Address",
                newName: "IX_Address_StateId");

            migrationBuilder.AddColumn<decimal>(
                name: "HourlyRate",
                table: "Solicitations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LumpSum",
                table: "Solicitations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Address_AddressId",
                table: "Accounts",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_States_StateId",
                table: "Address",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id");
        }
    }
}
