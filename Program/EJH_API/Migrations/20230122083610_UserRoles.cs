using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class UserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8564), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8525), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8533) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8624), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "LessonTypes",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8576), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "DateCreate", "DateUpdate", "Email", "Midname", "Name", "PhoneNumber", "Surname" },
                values: new object[] { new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"), "Admin@", new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8775), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8776), "Admin@", "Admin", "Admin", "Admin0", "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8740), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8740), "Teacher" },
                    { new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8726), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8727), "Admin" },
                    { new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8759), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8760), "Student" },
                    { new Guid("f69a359a-4986-4253-9409-078660dc8fc8"), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8750), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8750), "Headman" }
                });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("075eb8de-9471-4542-958d-d8ab12320a71"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8708), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("3e46ecb0-a6e6-49eb-9f9e-32daa6595bc9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8657), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8642), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("79765635-f6e4-49bf-a7ac-11c3458f2fa9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8691), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("bc9474a1-4fb2-4638-b1c4-f4ca21c68bb9"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8679), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "StatusOnLessons",
                keyColumn: "Id",
                keyValue: new Guid("f69a359a-4986-4253-9409-078660dc8fc8"),
                columns: new[] { "DateCreate", "DateUpdate" },
                values: new object[] { new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8668), new DateTime(2023, 1, 22, 11, 36, 9, 559, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "PasswordHash", "PersonId", "Username" },
                values: new object[] { new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"), new DateTime(2023, 1, 22, 11, 36, 9, 706, DateTimeKind.Local).AddTicks(8382), new DateTime(2023, 1, 22, 11, 36, 9, 706, DateTimeKind.Local).AddTicks(8395), "$2a$11$LBqxRnD2gtUPmlQIpPi6CuhCUmrfZ9c9s.znNiVWIpsBx/5Fvuu4C", new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"), "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "RoleId", "UserId" },
                values: new object[] { new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"), new DateTime(2023, 1, 22, 11, 36, 9, 706, DateTimeKind.Local).AddTicks(8648), new DateTime(2023, 1, 22, 11, 36, 9, 706, DateTimeKind.Local).AddTicks(8649), new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"), new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130") });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6aa74582-0eba-4eee-a960-3b6fc3092130"));

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
    }
}
