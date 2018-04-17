using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RecipesFinal.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AfanOromo = table.Column<string>(nullable: true),
                    Afar = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Parent = table.Column<string>(nullable: true),
                    SiteCode = table.Column<string>(nullable: true),
                    Somali = table.Column<string>(nullable: true),
                    Tigrigna = table.Column<string>(nullable: true),
                    amDescription = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
