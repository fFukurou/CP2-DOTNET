﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OsTresMotoqueirosDoApocalipseVerde.Migrations
{
    /// <inheritdoc />
    public partial class CreatetablesMotoristaandMotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Placa = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Chassi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motoristas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Plano = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    MotoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    MotoId1 = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motoristas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motoristas_Motos_MotoId",
                        column: x => x.MotoId,
                        principalTable: "Motos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Motoristas_Motos_MotoId1",
                        column: x => x.MotoId1,
                        principalTable: "Motos",
                        principalColumn: "Id");
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motoristas");

            migrationBuilder.DropTable(
                name: "Motos");
        }
    }
}
