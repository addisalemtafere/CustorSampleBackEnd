using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RecipesFinal.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Regions",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "RegionId",
                table: "Regions",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "BirthDate",
                table: "customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseNo",
                table: "customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kebele",
                table: "customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNo",
                table: "customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Wereda",
                table: "customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zone",
                table: "customers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "kebeles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AfanOromo = table.Column<string>(nullable: true),
                    Afar = table.Column<string>(nullable: true),
                    Somali = table.Column<string>(nullable: true),
                    Tigrigna = table.Column<string>(nullable: true),
                    amDescription = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    parent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kebeles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Woredas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AfanOromo = table.Column<string>(nullable: true),
                    Afar = table.Column<string>(nullable: true),
                    Somali = table.Column<string>(nullable: true),
                    Tigrigna = table.Column<string>(nullable: true),
                    amDescription = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    parent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Woredas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AfanOromo = table.Column<string>(nullable: true),
                    Afar = table.Column<string>(nullable: true),
                    Somali = table.Column<string>(nullable: true),
                    Tigrigna = table.Column<string>(nullable: true),
                    amDescription = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    parent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kebeles");

            migrationBuilder.DropTable(
                name: "Woredas");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "HouseNo",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "Kebele",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "MobileNo",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "Wereda",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "Zone",
                table: "customers");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Regions",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Regions",
                newName: "RegionId");
        }
    }
}
