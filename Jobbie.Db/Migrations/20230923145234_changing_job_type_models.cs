using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobbie.Db.Migrations
{
    /// <inheritdoc />
    public partial class changing_job_type_models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contractors_JobTypeJobSubtypes_JobTypeJobSubtypeId",
                table: "Contractors");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialties_JobSubtypes_JobSubtypeId",
                table: "Specialties");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusUpdate_SolicitationContractors_SolicitationContractorId",
                table: "StatusUpdate");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusUpdate_Solicitors_SolicitorId",
                table: "StatusUpdate");

            migrationBuilder.DropTable(
                name: "JobTypeJobSubtypes");

            migrationBuilder.DropTable(
                name: "JobSubtypes");

            migrationBuilder.DropTable(
                name: "JobTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusUpdate",
                table: "StatusUpdate");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Specialties");

            migrationBuilder.RenameTable(
                name: "StatusUpdate",
                newName: "StatusUpdates");

            migrationBuilder.RenameColumn(
                name: "JobSubtypeId",
                table: "Specialties",
                newName: "ExpertiseId");

            migrationBuilder.RenameIndex(
                name: "IX_Specialties_JobSubtypeId",
                table: "Specialties",
                newName: "IX_Specialties_ExpertiseId");

            migrationBuilder.RenameColumn(
                name: "JobTypeJobSubtypeId",
                table: "Contractors",
                newName: "ProfessionDisciplineId");

            migrationBuilder.RenameIndex(
                name: "IX_Contractors_JobTypeJobSubtypeId",
                table: "Contractors",
                newName: "IX_Contractors_ProfessionDisciplineId");

            migrationBuilder.RenameIndex(
                name: "IX_StatusUpdate_SolicitorId",
                table: "StatusUpdates",
                newName: "IX_StatusUpdates_SolicitorId");

            migrationBuilder.RenameIndex(
                name: "IX_StatusUpdate_SolicitationContractorId",
                table: "StatusUpdates",
                newName: "IX_StatusUpdates_SolicitationContractorId");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyTypeId",
                table: "Accounts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SolicitorId",
                table: "StatusUpdates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SolicitationContractorId",
                table: "StatusUpdates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusUpdates",
                table: "StatusUpdates",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasSpecialty = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasSubtype = table.Column<bool>(type: "bit", nullable: false),
                    HasLicense = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Focuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisciplineId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Focuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Focuses_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionDisciplines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessionId = table.Column<int>(type: "int", nullable: false),
                    DisciplineId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionDisciplines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionDisciplines_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProfessionDisciplines_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Expertises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FocusId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expertises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expertises_Focuses_FocusId",
                        column: x => x.FocusId,
                        principalTable: "Focuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expertises_FocusId",
                table: "Expertises",
                column: "FocusId");

            migrationBuilder.CreateIndex(
                name: "IX_Focuses_DisciplineId",
                table: "Focuses",
                column: "DisciplineId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionDisciplines_DisciplineId",
                table: "ProfessionDisciplines",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionDisciplines_ProfessionId",
                table: "ProfessionDisciplines",
                column: "ProfessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contractors_ProfessionDisciplines_ProfessionDisciplineId",
                table: "Contractors",
                column: "ProfessionDisciplineId",
                principalTable: "ProfessionDisciplines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialties_Expertises_ExpertiseId",
                table: "Specialties",
                column: "ExpertiseId",
                principalTable: "Expertises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusUpdates_SolicitationContractors_SolicitationContractorId",
                table: "StatusUpdates",
                column: "SolicitationContractorId",
                principalTable: "SolicitationContractors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StatusUpdates_Solicitors_SolicitorId",
                table: "StatusUpdates",
                column: "SolicitorId",
                principalTable: "Solicitors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contractors_ProfessionDisciplines_ProfessionDisciplineId",
                table: "Contractors");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialties_Expertises_ExpertiseId",
                table: "Specialties");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusUpdates_SolicitationContractors_SolicitationContractorId",
                table: "StatusUpdates");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusUpdates_Solicitors_SolicitorId",
                table: "StatusUpdates");

            migrationBuilder.DropTable(
                name: "Expertises");

            migrationBuilder.DropTable(
                name: "ProfessionDisciplines");

            migrationBuilder.DropTable(
                name: "Focuses");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusUpdates",
                table: "StatusUpdates");

            migrationBuilder.RenameTable(
                name: "StatusUpdates",
                newName: "StatusUpdate");

            migrationBuilder.RenameColumn(
                name: "ExpertiseId",
                table: "Specialties",
                newName: "JobSubtypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Specialties_ExpertiseId",
                table: "Specialties",
                newName: "IX_Specialties_JobSubtypeId");

            migrationBuilder.RenameColumn(
                name: "ProfessionDisciplineId",
                table: "Contractors",
                newName: "JobTypeJobSubtypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Contractors_ProfessionDisciplineId",
                table: "Contractors",
                newName: "IX_Contractors_JobTypeJobSubtypeId");

            migrationBuilder.RenameIndex(
                name: "IX_StatusUpdates_SolicitorId",
                table: "StatusUpdate",
                newName: "IX_StatusUpdate_SolicitorId");

            migrationBuilder.RenameIndex(
                name: "IX_StatusUpdates_SolicitationContractorId",
                table: "StatusUpdate",
                newName: "IX_StatusUpdate_SolicitationContractorId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Specialties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyTypeId",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SolicitorId",
                table: "StatusUpdate",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SolicitationContractorId",
                table: "StatusUpdate",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusUpdate",
                table: "StatusUpdate",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "JobSubtypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasSpecialty = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSubtypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasLicense = table.Column<bool>(type: "bit", nullable: false),
                    HasSubtype = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTypeJobSubtypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobSubtypeId = table.Column<int>(type: "int", nullable: false),
                    JobTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypeJobSubtypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTypeJobSubtypes_JobSubtypes_JobSubtypeId",
                        column: x => x.JobSubtypeId,
                        principalTable: "JobSubtypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobTypeJobSubtypes_JobTypes_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobTypeJobSubtypes_JobSubtypeId",
                table: "JobTypeJobSubtypes",
                column: "JobSubtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTypeJobSubtypes_JobTypeId",
                table: "JobTypeJobSubtypes",
                column: "JobTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contractors_JobTypeJobSubtypes_JobTypeJobSubtypeId",
                table: "Contractors",
                column: "JobTypeJobSubtypeId",
                principalTable: "JobTypeJobSubtypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialties_JobSubtypes_JobSubtypeId",
                table: "Specialties",
                column: "JobSubtypeId",
                principalTable: "JobSubtypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StatusUpdate_SolicitationContractors_SolicitationContractorId",
                table: "StatusUpdate",
                column: "SolicitationContractorId",
                principalTable: "SolicitationContractors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StatusUpdate_Solicitors_SolicitorId",
                table: "StatusUpdate",
                column: "SolicitorId",
                principalTable: "Solicitors",
                principalColumn: "Id");
        }
    }
}
