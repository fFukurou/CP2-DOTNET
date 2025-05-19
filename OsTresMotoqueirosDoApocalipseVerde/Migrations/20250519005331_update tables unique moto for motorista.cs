using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OsTresMotoqueirosDoApocalipseVerde.Migrations
{
    /// <inheritdoc />
    public partial class updatetablesuniquemotoformotorista : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Motoristas_Motos_MotoId",
                table: "Motoristas");

            migrationBuilder.DropIndex(
                name: "IX_Motoristas_MotoId",
                table: "Motoristas");

            migrationBuilder.AlterColumn<int>(
                name: "MotoId",
                table: "Motoristas",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotoId1",
                table: "Motoristas",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Motoristas_MotoId",
                table: "Motoristas",
                column: "MotoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Motoristas_MotoId1",
                table: "Motoristas",
                column: "MotoId1",
                unique: true,
                filter: "\"MotoId1\" IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Motoristas_Motos_MotoId",
                table: "Motoristas",
                column: "MotoId",
                principalTable: "Motos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motoristas_Motos_MotoId1",
                table: "Motoristas",
                column: "MotoId1",
                principalTable: "Motos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Motoristas_Motos_MotoId",
                table: "Motoristas");

            migrationBuilder.DropForeignKey(
                name: "FK_Motoristas_Motos_MotoId1",
                table: "Motoristas");

            migrationBuilder.DropIndex(
                name: "IX_Motoristas_MotoId",
                table: "Motoristas");

            migrationBuilder.DropIndex(
                name: "IX_Motoristas_MotoId1",
                table: "Motoristas");

            migrationBuilder.DropColumn(
                name: "MotoId1",
                table: "Motoristas");

            migrationBuilder.AlterColumn<int>(
                name: "MotoId",
                table: "Motoristas",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.CreateIndex(
                name: "IX_Motoristas_MotoId",
                table: "Motoristas",
                column: "MotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Motoristas_Motos_MotoId",
                table: "Motoristas",
                column: "MotoId",
                principalTable: "Motos",
                principalColumn: "Id");
        }
    }
}
