using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCA.Migrations
{
    public partial class TenantChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_Industries_IndustryId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Shifts_AbpTenants_TenantId",
                table: "Shifts");

            migrationBuilder.DropIndex(
                name: "IX_Shifts_TenantId",
                table: "Shifts");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Shifts");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "cardnumber",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "company",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "cvv",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "expiry",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "name_on_card",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "package",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "payment_methode",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "purpose",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "savecard",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "teamsize",
                table: "AbpTenants");

            migrationBuilder.AlterColumn<Guid>(
                name: "IndustryId",
                table: "AbpTenants",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_Industries_IndustryId",
                table: "AbpTenants",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_Industries_IndustryId",
                table: "AbpTenants");

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Shifts",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IndustryId",
                table: "AbpTenants",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "AbpTenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cardnumber",
                table: "AbpTenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "company",
                table: "AbpTenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cvv",
                table: "AbpTenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "expiry",
                table: "AbpTenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name_on_card",
                table: "AbpTenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "package",
                table: "AbpTenants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "payment_methode",
                table: "AbpTenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "purpose",
                table: "AbpTenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "savecard",
                table: "AbpTenants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "teamsize",
                table: "AbpTenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_TenantId",
                table: "Shifts",
                column: "TenantId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_Industries_IndustryId",
                table: "AbpTenants",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shifts_AbpTenants_TenantId",
                table: "Shifts",
                column: "TenantId",
                principalTable: "AbpTenants",
                principalColumn: "Id");
        }
    }
}
