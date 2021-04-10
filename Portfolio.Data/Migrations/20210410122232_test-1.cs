﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Data.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReadingLogs_Books_BookId1",
                table: "ReadingLogs");

            migrationBuilder.DropIndex(
                name: "IX_ReadingLogs_BookId1",
                table: "ReadingLogs");

            migrationBuilder.DropColumn(
                name: "BookId1",
                table: "ReadingLogs");

            migrationBuilder.DropColumn(
                name: "ReadingLogId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "ReadingLogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingLogs_BookId",
                table: "ReadingLogs",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReadingLogs_Books_BookId",
                table: "ReadingLogs",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReadingLogs_Books_BookId",
                table: "ReadingLogs");

            migrationBuilder.DropIndex(
                name: "IX_ReadingLogs_BookId",
                table: "ReadingLogs");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "ReadingLogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookId1",
                table: "ReadingLogs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReadingLogId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ReadingLogs_BookId1",
                table: "ReadingLogs",
                column: "BookId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ReadingLogs_Books_BookId1",
                table: "ReadingLogs",
                column: "BookId1",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
