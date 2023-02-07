using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class personmodelupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Persons",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Persons",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4372), new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4334), new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4400), new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4386), new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("075eb8de-9471-4542-958d-d8ab12320a71"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4536), new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4442), new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4420), new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("79765635-f6e4-49bf-a7ac-11c3458f2fa9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4520), new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4506), new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4455), new DateTime(2022, 8, 12, 10, 2, 34, 265, DateTimeKind.Local).AddTicks(4456) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Persons",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Persons",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8219), new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8178), new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8247), new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8233), new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("075eb8de-9471-4542-958d-d8ab12320a71"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8340), new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8282), new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8266), new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("79765635-f6e4-49bf-a7ac-11c3458f2fa9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8324), new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8310), new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8296), new DateTime(2022, 8, 12, 9, 55, 32, 61, DateTimeKind.Local).AddTicks(8297) });
        }
    }
}
