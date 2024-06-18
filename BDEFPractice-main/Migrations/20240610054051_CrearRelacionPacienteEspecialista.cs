﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDProductCatalog.Migrations
{
    /// <inheritdoc />
    public partial class CrearRelacionPacienteEspecialista : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SpecialistId",
                table: "Patients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_SpecialistId",
                table: "Patients",
                column: "SpecialistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Specialists_SpecialistId",
                table: "Patients",
                column: "SpecialistId",
                principalTable: "Specialists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Specialists_SpecialistId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_SpecialistId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "SpecialistId",
                table: "Patients");
        }
    }
}
