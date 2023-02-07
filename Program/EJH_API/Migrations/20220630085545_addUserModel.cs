using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class addUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

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
    }
}
