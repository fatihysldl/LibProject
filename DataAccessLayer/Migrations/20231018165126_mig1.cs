using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminNick = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    AdminPassword = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    AdminMail = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "bookCategories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookCategories", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "members",
                columns: table => new
                {
                    memberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    memberName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    memberSurname = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    memberPhone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_members", x => x.memberId);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    bookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    bookStock = table.Column<int>(type: "int", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.bookId);
                    table.ForeignKey(
                        name: "FK_books_bookCategories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "bookCategories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "borrowedBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    memberId = table.Column<int>(type: "int", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_borrowedBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_borrowedBooks_bookCategories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "bookCategories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_borrowedBooks_members_memberId",
                        column: x => x.memberId,
                        principalTable: "members",
                        principalColumn: "memberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_categoryId",
                table: "books",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_borrowedBooks_categoryId",
                table: "borrowedBooks",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_borrowedBooks_memberId",
                table: "borrowedBooks",
                column: "memberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "borrowedBooks");

            migrationBuilder.DropTable(
                name: "bookCategories");

            migrationBuilder.DropTable(
                name: "members");
        }
    }
}
