using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class UpdatedDictionaries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5835), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.InsertData(
                table: "LessonTypes",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "EnumId", "Name" },
                values: new object[] { new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5847), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5847), 4, "Занятие" });

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
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5903), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5891), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.InsertData(
                table: "StatusOnLessons",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "EnumId", "Name" },
                values: new object[,]
                {
                    { new Guid("075eb8de-9471-4542-958d-d8ab12320a71"), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5931), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5931), 6, "Невозможно рассчитать" },
                    { new Guid("79765635-f6e4-49bf-a7ac-11c3458f2fa9"), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5916), new DateTime(2022, 6, 29, 14, 16, 45, 166, DateTimeKind.Local).AddTicks(5917), 5, "Отсутствовал (уважительная причина)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"));

            migrationBuilder.DeleteData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("075eb8de-9471-4542-958d-d8ab12320a71"));

            migrationBuilder.DeleteData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("79765635-f6e4-49bf-a7ac-11c3458f2fa9"));

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
        }
    }
}
