using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetSerwer.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { new Guid("2581c5af-5a4c-470c-8e9d-f4e21ddb9b93"), "This is post 4 and has some interesting content", "Post 4" },
                    { new Guid("5b97091f-a099-4ce0-9084-cd37976a2db7"), "This is post 1 and has some interesting content", "Post 1" },
                    { new Guid("65d2e60c-7cd4-4af3-8669-7678e26eff1a"), "This is post 7 and has some interesting content", "Post 7" },
                    { new Guid("a82b6814-6749-495b-9ed9-bd121085f053"), "This is post 3 and has some interesting content", "Post 3" },
                    { new Guid("c82ab38b-24e8-4d5e-a7ae-f1bf16e195e3"), "This is post 6 and has some interesting content", "Post 6" },
                    { new Guid("ce17d3f7-7509-4b72-96bd-87d3d44323dd"), "This is post 5 and has some interesting content", "Post 5" },
                    { new Guid("f5aa1bfb-b5a8-493c-a579-7dac454e8ee1"), "This is post 2 and has some interesting content", "Post 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
