using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TasksManager.Data.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Tasks",
                columns: new[] { "Id", "Description", "IsCompleted", "Title" },
                values: new object[,]
                {
                    { new Guid("c4677755-b803-41f1-9908-78b596992bb2"), "Description for Task 1", false, "Task #1" },
                    { new Guid("ae5f3e13-62bf-4c2f-8455-02107a8fb1d4"), "Description for Task 2", false, "Task #2" },
                    { new Guid("df95e8d0-9965-4cbe-a6f7-924c4d2e64db"), "Description for Task 3", false, "Task #3" },
                    { new Guid("09dbc7bf-8752-4f1e-8c4a-f547fbccff29"), "Description for Task 4", false, "Task #4" },
                    { new Guid("16626d47-3461-4f13-87de-369a4fdd0a18"), "Description for Task 5", false, "Task #5" },
                    { new Guid("1edf5d30-d6c9-4612-995c-2d44be3ca896"), "Description for Task 6", false, "Task #6" },
                    { new Guid("7387e595-5220-4768-9a4a-03da27a716fe"), "Description for Task 7", false, "Task #7" },
                    { new Guid("662df157-1df3-4203-9168-351dd8beba6c"), "Description for Task 8", false, "Task #8" },
                    { new Guid("0cd28c87-dc9e-4f8e-83d0-c6d86e717c56"), "Description for Task 8", false, "Task #9" },
                    { new Guid("3c3239ed-561a-443c-a789-35958f902b2a"), "Description for Task 8", false, "Task #10" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("09dbc7bf-8752-4f1e-8c4a-f547fbccff29"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("0cd28c87-dc9e-4f8e-83d0-c6d86e717c56"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("16626d47-3461-4f13-87de-369a4fdd0a18"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("1edf5d30-d6c9-4612-995c-2d44be3ca896"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("3c3239ed-561a-443c-a789-35958f902b2a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("662df157-1df3-4203-9168-351dd8beba6c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("7387e595-5220-4768-9a4a-03da27a716fe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("ae5f3e13-62bf-4c2f-8455-02107a8fb1d4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("c4677755-b803-41f1-9908-78b596992bb2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("df95e8d0-9965-4cbe-a6f7-924c4d2e64db"));
        }
    }
}
