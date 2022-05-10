﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UuidMasterApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Source = table.Column<int>(type: "int", nullable: false),
                    SourceEntityId = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    EntityType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntityVersion = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Uuid);
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Uuid", "EntityType", "EntityVersion", "Source", "SourceEntityId" },
                values: new object[] { new Guid("fed92226-4b82-47da-a0e5-85855faa9a17"), "user", 1m, 2, 1m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resources");
        }
    }
}