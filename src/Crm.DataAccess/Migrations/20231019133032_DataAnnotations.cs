using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DataAnnotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "client");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "client",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "client",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "client",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "client",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PassportNumber",
                table: "client",
                newName: "passport_number");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "client",
                newName: "middle_name");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "client",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "client",
                newName: "first_name");

            migrationBuilder.AlterColumn<string>(
                name: "passport_number",
                table: "client",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "middle_name",
                table: "client",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_client",
                table: "client",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_client",
                table: "client");

            migrationBuilder.RenameTable(
                name: "client",
                newName: "Clients");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Clients",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Clients",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Clients",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Clients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "passport_number",
                table: "Clients",
                newName: "PassportNumber");

            migrationBuilder.RenameColumn(
                name: "middle_name",
                table: "Clients",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Clients",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Clients",
                newName: "FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "PassportNumber",
                table: "Clients",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "Clients",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Id");
        }
    }
}
