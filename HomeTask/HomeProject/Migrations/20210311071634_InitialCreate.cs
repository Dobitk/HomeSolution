using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DateBirth = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Families",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Yearbirth = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Families", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Families_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkHistories_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateBirth", "DepartmentName", "FirstName", "LastName", "Phone" },
                values: new object[] { 1, new DateTime(1996, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Директор", "Иван", "Иванов", "111-11-11" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateBirth", "DepartmentName", "FirstName", "LastName", "Phone" },
                values: new object[] { 2, new DateTime(1986, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Заместитель директора", "Сергей", "Петров", "111-11-11" });

            migrationBuilder.InsertData(
                table: "Families",
                columns: new[] { "Id", "Description", "EmployeeId", "Yearbirth" },
                values: new object[,]
                {
                    { 1, "Жена - Иванова Марина", 1, "1975" },
                    { 2, "Сын - Иванов Сергей", 1, "1999" },
                    { 3, "Жена - Петрова Ирина", 2, "1986" },
                    { 4, "Дочь - Метрова Таня", 2, "1995" }
                });

            migrationBuilder.InsertData(
                table: "WorkHistories",
                columns: new[] { "Id", "EmployeeId", "EndDate", "StartDate", "WorkName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2006, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "СШ №1 Учитель информатики" },
                    { 2, 1, new DateTime(2015, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "СШ №2 Завуч" },
                    { 3, 2, new DateTime(2006, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "СШ №15 Учитель физики" },
                    { 4, 2, new DateTime(2015, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "СШ №100 Директор" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Families_EmployeeId",
                table: "Families",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistories_EmployeeId",
                table: "WorkHistories",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Families");

            migrationBuilder.DropTable(
                name: "WorkHistories");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
