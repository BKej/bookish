using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookish.Migrations
{
    /// <inheritdoc />
    public partial class BookishDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Members",
                newName: "MembersId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Books",
                newName: "BooksId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MembersId",
                table: "Members",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BooksId",
                table: "Books",
                newName: "Id");
        }
    }
}
