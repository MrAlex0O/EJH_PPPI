using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class addUserPersonRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "Users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonId",
                table: "Users",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Persons_PersonId",
                table: "Users",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Persons_PersonId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PersonId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4408), new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4370), new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4435), new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4421), new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("075eb8de-9471-4542-958d-d8ab12320a71"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4527), new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4471), new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4453), new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("79765635-f6e4-49bf-a7ac-11c3458f2fa9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4511), new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4496), new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4483), new DateTime(2022, 6, 30, 11, 55, 44, 848, DateTimeKind.Local).AddTicks(4484) });
        }
    }
}
