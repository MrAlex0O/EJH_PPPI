using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class DisciplineLectorBugfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplines_Persons_LectorId",
                table: "Disciplines");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "Teachers",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Teachers",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "Students",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Students",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "StatusOnLessons",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "StatusOnLessons",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "Persons",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Persons",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "LessonTypes",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "LessonTypes",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "LessonsVisitors",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "LessonsVisitors",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "Lessons",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Lessons",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Lessons",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "Groups",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Groups",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "Disciplines",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Disciplines",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "Assistants",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Assistants",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 28, 13, 54, 43, 344, DateTimeKind.Local).AddTicks(2741), new DateTime(2022, 6, 28, 13, 54, 43, 344, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 28, 13, 54, 43, 344, DateTimeKind.Local).AddTicks(2678), new DateTime(2022, 6, 28, 13, 54, 43, 344, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 28, 13, 54, 43, 344, DateTimeKind.Local).AddTicks(2755), new DateTime(2022, 6, 28, 13, 54, 43, 344, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 28, 13, 54, 43, 344, DateTimeKind.Local).AddTicks(2787), new DateTime(2022, 6, 28, 13, 54, 43, 344, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 28, 13, 54, 43, 344, DateTimeKind.Local).AddTicks(2772), new DateTime(2022, 6, 28, 13, 54, 43, 344, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 28, 13, 54, 43, 344, DateTimeKind.Local).AddTicks(2813), new DateTime(2022, 6, 28, 13, 54, 43, 344, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 28, 13, 54, 43, 344, DateTimeKind.Local).AddTicks(2800), new DateTime(2022, 6, 28, 13, 54, 43, 344, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_Teachers_LectorId",
                table: "Disciplines",
                column: "LectorId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplines_Teachers_LectorId",
                table: "Disciplines");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "Teachers",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Teachers",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "Students",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Students",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "StatusOnLessons",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "StatusOnLessons",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "Persons",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Persons",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "LessonTypes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "LessonTypes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "LessonsVisitors",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "LessonsVisitors",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "Lessons",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Lessons",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Lessons",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "Groups",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Groups",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "Disciplines",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Disciplines",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdate",
                table: "Assistants",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Assistants",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_Persons_LectorId",
                table: "Disciplines",
                column: "LectorId",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
