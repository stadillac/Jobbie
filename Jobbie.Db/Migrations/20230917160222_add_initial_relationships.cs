using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobbie.Db.Migrations
{
    /// <inheritdoc />
    public partial class add_initial_relationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Address_AddressId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_BankAccounts_BankAccountId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Contractors_ContractorId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_States_StateId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Contractors_JobTypeJobSubtypes_JobTypeJobSubtypeId",
                table: "Contractors");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Accounts_AccountId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTypeJobSubtypes_JobSubtypes_JobSubtypeId",
                table: "JobTypeJobSubtypes");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTypeJobSubtypes_JobTypes_JobTypeId",
                table: "JobTypeJobSubtypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Contractors_ContractorId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_States_StateId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitationContractors_Contractors_ContractorId",
                table: "SolicitationContractors");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitationContractors_Solicitations_SolicitationId",
                table: "SolicitationContractors");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitationDeadlines_DeadlineTypes_DeadlineTypeId",
                table: "SolicitationDeadlines");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitationDeadlines_Solicitations_SolicitationId",
                table: "SolicitationDeadlines");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitations_Solicitors_SolicitorId",
                table: "Solicitations");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialties_JobSubtypes_JobSubtypeId",
                table: "Specialties");

            migrationBuilder.DropIndex(
                name: "IX_Address_StateId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_AddressId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_BankAccountId",
                table: "Accounts");

            migrationBuilder.CreateIndex(
                name: "IX_Address_StateId",
                table: "Address",
                column: "StateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AddressId",
                table: "Accounts",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_BankAccountId",
                table: "Accounts",
                column: "BankAccountId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Address_AddressId",
                table: "Accounts",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_BankAccounts_BankAccountId",
                table: "Accounts",
                column: "BankAccountId",
                principalTable: "BankAccounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Contractors_ContractorId",
                table: "Accounts",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_States_StateId",
                table: "Address",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contractors_JobTypeJobSubtypes_JobTypeJobSubtypeId",
                table: "Contractors",
                column: "JobTypeJobSubtypeId",
                principalTable: "JobTypeJobSubtypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Accounts_AccountId",
                table: "Documents",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTypeJobSubtypes_JobSubtypes_JobSubtypeId",
                table: "JobTypeJobSubtypes",
                column: "JobSubtypeId",
                principalTable: "JobSubtypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTypeJobSubtypes_JobTypes_JobTypeId",
                table: "JobTypeJobSubtypes",
                column: "JobTypeId",
                principalTable: "JobTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Contractors_ContractorId",
                table: "Licenses",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_States_StateId",
                table: "Licenses",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitationContractors_Contractors_ContractorId",
                table: "SolicitationContractors",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitationContractors_Solicitations_SolicitationId",
                table: "SolicitationContractors",
                column: "SolicitationId",
                principalTable: "Solicitations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitationDeadlines_DeadlineTypes_DeadlineTypeId",
                table: "SolicitationDeadlines",
                column: "DeadlineTypeId",
                principalTable: "DeadlineTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitationDeadlines_Solicitations_SolicitationId",
                table: "SolicitationDeadlines",
                column: "SolicitationId",
                principalTable: "Solicitations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitations_Solicitors_SolicitorId",
                table: "Solicitations",
                column: "SolicitorId",
                principalTable: "Solicitors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialties_JobSubtypes_JobSubtypeId",
                table: "Specialties",
                column: "JobSubtypeId",
                principalTable: "JobSubtypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Address_AddressId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_BankAccounts_BankAccountId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Contractors_ContractorId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_States_StateId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Contractors_JobTypeJobSubtypes_JobTypeJobSubtypeId",
                table: "Contractors");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Accounts_AccountId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTypeJobSubtypes_JobSubtypes_JobSubtypeId",
                table: "JobTypeJobSubtypes");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTypeJobSubtypes_JobTypes_JobTypeId",
                table: "JobTypeJobSubtypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Contractors_ContractorId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_States_StateId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitationContractors_Contractors_ContractorId",
                table: "SolicitationContractors");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitationContractors_Solicitations_SolicitationId",
                table: "SolicitationContractors");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitationDeadlines_DeadlineTypes_DeadlineTypeId",
                table: "SolicitationDeadlines");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitationDeadlines_Solicitations_SolicitationId",
                table: "SolicitationDeadlines");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitations_Solicitors_SolicitorId",
                table: "Solicitations");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialties_JobSubtypes_JobSubtypeId",
                table: "Specialties");

            migrationBuilder.DropIndex(
                name: "IX_Address_StateId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_AddressId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_BankAccountId",
                table: "Accounts");

            migrationBuilder.CreateIndex(
                name: "IX_Address_StateId",
                table: "Address",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AddressId",
                table: "Accounts",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_BankAccountId",
                table: "Accounts",
                column: "BankAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Address_AddressId",
                table: "Accounts",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_BankAccounts_BankAccountId",
                table: "Accounts",
                column: "BankAccountId",
                principalTable: "BankAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Contractors_ContractorId",
                table: "Accounts",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_States_StateId",
                table: "Address",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contractors_JobTypeJobSubtypes_JobTypeJobSubtypeId",
                table: "Contractors",
                column: "JobTypeJobSubtypeId",
                principalTable: "JobTypeJobSubtypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Accounts_AccountId",
                table: "Documents",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTypeJobSubtypes_JobSubtypes_JobSubtypeId",
                table: "JobTypeJobSubtypes",
                column: "JobSubtypeId",
                principalTable: "JobSubtypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTypeJobSubtypes_JobTypes_JobTypeId",
                table: "JobTypeJobSubtypes",
                column: "JobTypeId",
                principalTable: "JobTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Contractors_ContractorId",
                table: "Licenses",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_States_StateId",
                table: "Licenses",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitationContractors_Contractors_ContractorId",
                table: "SolicitationContractors",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitationContractors_Solicitations_SolicitationId",
                table: "SolicitationContractors",
                column: "SolicitationId",
                principalTable: "Solicitations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitationDeadlines_DeadlineTypes_DeadlineTypeId",
                table: "SolicitationDeadlines",
                column: "DeadlineTypeId",
                principalTable: "DeadlineTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitationDeadlines_Solicitations_SolicitationId",
                table: "SolicitationDeadlines",
                column: "SolicitationId",
                principalTable: "Solicitations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitations_Solicitors_SolicitorId",
                table: "Solicitations",
                column: "SolicitorId",
                principalTable: "Solicitors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialties_JobSubtypes_JobSubtypeId",
                table: "Specialties",
                column: "JobSubtypeId",
                principalTable: "JobSubtypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
