﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaelumBlog.Migrations
{
    public partial class ControlePublicacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataPublicacao",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Publicado",
                table: "Posts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataPublicacao",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Publicado",
                table: "Posts");
        }
    }
}
