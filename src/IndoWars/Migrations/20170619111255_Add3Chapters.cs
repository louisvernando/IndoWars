using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IndoWars.Migrations
{
    public partial class Add3Chapters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into ChapterLists (Name, ActionName, Image) values ('Chapter 4) Battle of Palembang','PalembangBattle','/img/palembang/title.jpg')");
            migrationBuilder.Sql("insert into ChapterLists (Name, ActionName, Image) values ('Chapter 5) Battle of Java Sea','JavaSeaBattle','/img/java-sea/title.jpg')");
            migrationBuilder.Sql("insert into ChapterLists (Name, ActionName, Image) values ('Chapter 6) Battle of Timor','TimorBattle','/img/timor/title.jpg')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from ChapterLists where (Name, ActionName, Image) in ('Chapter 6) Battle of Timor','TimorBattle','/img/timor/title.jpg')");
            migrationBuilder.Sql("delete from ChapterLists where (Name, ActionName, Image) in ('Chapter 4) Battle of Palembang','PalembangBattle','/img/palembang/title.jpg')");
            migrationBuilder.Sql("delete from ChapterLists where (Name, ActionName, Image) in ('Chapter 5) Battle of Java Sea','JavaSeaBattle','/img/java-sea/title.jpg')");
        }
    }
}
