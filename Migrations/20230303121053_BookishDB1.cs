using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookish.Migrations
{
    /// <inheritdoc />
    public partial class BookishDB1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "Checkout",
                newName: "MembersId");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Checkout",
                newName: "BooksId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MembersId",
                table: "Checkout",
                newName: "MemberId");

            migrationBuilder.RenameColumn(
                name: "BooksId",
                table: "Checkout",
                newName: "BookId");
        }
    }
}
