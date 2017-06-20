using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IndoWars.Migrations
{
    public partial class AddDescOnChapterLists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ChapterLists",
                nullable: true);

            migrationBuilder.Sql("update chapterlists set Description='Chapter ini merupakan sebuah prolog yang menceritakan tentang bagaimana Perang Dunia II tersebut dapat terjadi' where id='1'");
            migrationBuilder.Sql("update chapterlists set Description='Chapter ini menceritakan tentang Hindia Belanda (Sebutan Indonesia pada saat itu) yang merupakan sebuah koloni dari negara Belanda " +
                                 "ternyata menjadi sebuah titik yang diperebutkan dan dipertahankan oleh berbagai negara saat itu' where id='2'");
            migrationBuilder.Sql("update chapterlists set Description='Ekspedisi atau perang pertama yang dilakukan oleh penduduk lokal Hindia Belanda terjadi pada chapter ini. Perang Tarakan " +
                                 "merupakan sebuah ekspedisi yang dilakukan untuk mengamankan pulau kecil berbentuk segitiga yang bernama Tarakan' where id='3'");
            migrationBuilder.Sql("update chapterlists set Description='Battle of Palembang merupakan sebuah perang antara Sekutu dengan Jepang dalam usahanya mengambil alih Palembang yang mempunyai potensi sumber daya " +
                                 "minyak dan lahan bandar udara yang luas.' where id='4'");
            migrationBuilder.Sql("update chapterlists set Description='Battle of Java Sea adalah perang naval yang sangat vital dalam perkembangan perang dunia II saat itu. Kemenangan telak Jepang atas sekutu saat itu langsung menandai " +
                                 "awal mulanya kekuasaan mutlak jepang terhadap Hindia Belanda saat perang dunia II tersebut berlangsung' where id='5'");
            migrationBuilder.Sql("update chapterlists set Description='Under Construction' where id='6'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ChapterLists");
        }
    }
}
