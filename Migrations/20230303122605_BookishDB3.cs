using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookish.Migrations
{
    /// <inheritdoc />
    public partial class BookishDB3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Checkout_BooksId",
                table: "Checkout",
                column: "BooksId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_MembersId",
                table: "Checkout",
                column: "MembersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkout_Books_BooksId",
                table: "Checkout",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "BooksId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkout_Members_MembersId",
                table: "Checkout",
                column: "MembersId",
                principalTable: "Members",
                principalColumn: "MembersId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkout_Books_BooksId",
                table: "Checkout");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkout_Members_MembersId",
                table: "Checkout");

            migrationBuilder.DropIndex(
                name: "IX_Checkout_BooksId",
                table: "Checkout");

            migrationBuilder.DropIndex(
                name: "IX_Checkout_MembersId",
                table: "Checkout");
        }
    }
}
