using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Crm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "Orders",
                type: "BIGINT",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "Clients",
                type: "VARCHAR(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "Clients",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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
                name: "pk_id",
                table: "Clients",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ClientId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "pk_id",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Orders");

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

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "client",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)");

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "client",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "SERIAL")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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
    }
}
