using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class RenamedLessonVisitors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9553), new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9516), new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9578), new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9566), new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("075eb8de-9471-4542-958d-d8ab12320a71"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9663), new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9611), new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9593), new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("79765635-f6e4-49bf-a7ac-11c3458f2fa9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9648), new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9635), new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9623), new DateTime(2022, 6, 29, 15, 4, 20, 187, DateTimeKind.Local).AddTicks(9624) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5822), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5786), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5847), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5835), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("075eb8de-9471-4542-958d-d8ab12320a71"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5931), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5880), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5863), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("79765635-f6e4-49bf-a7ac-11c3458f2fa9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5916), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5903), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5891), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5892) });
        }
    }
}
