using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IndoWars.Migrations
{
    public partial class ChapterList20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActionName",
                table: "ChapterLists",
                nullable: true);

            migrationBuilder.Sql("update ChapterLists set ActionName='Introduction' where id='1'");
            migrationBuilder.Sql("update ChapterLists set ActionName='HindiaBelanda' where id='2'");
            migrationBuilder.Sql("update ChapterLists set ActionName='TarakanBattle' where id='3'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionName",
                table: "ChapterLists");
        }
    }
}
