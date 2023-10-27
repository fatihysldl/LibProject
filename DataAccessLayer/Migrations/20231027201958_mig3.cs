using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bookId",
                table: "borrowedBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_borrowedBooks_bookId",
                table: "borrowedBooks",
                column: "bookId");

            migrationBuilder.AddForeignKey(
                name: "FK_borrowedBooks_books_bookId",
                table: "borrowedBooks",
                column: "bookId",
                principalTable: "books",
                principalColumn: "bookId",
                 onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_borrowedBooks_books_bookId",
                table: "borrowedBooks");

            migrationBuilder.DropIndex(
                name: "IX_borrowedBooks_bookId",
                table: "borrowedBooks");

            migrationBuilder.DropColumn(
                name: "bookId",
                table: "borrowedBooks");
        }
    }
}
