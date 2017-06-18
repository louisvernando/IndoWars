using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IndoWars.Migrations
{
    public partial class ChapterListAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChapterLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterLists", x => x.Id);
                });

            migrationBuilder.Sql("INSERT INTO ChapterLists (Name, Image) VALUES ('Chapter 1) Introduction','~/img/introduction/title.jpg')");
            migrationBuilder.Sql("INSERT INTO ChapterLists (Name, Image) VALUES ('Chapter 2) Dutch East Indies','~/img/Ekspedisi Hindia Belanda/title.jpg')");
            migrationBuilder.Sql("INSERT INTO ChapterLists (Name, Image) VALUES ('Chapter 3) Battle Of Tarakan','~/img/tarakan/title.jpg')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChapterLists");
        }
    }
}
