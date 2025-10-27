using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Urcan_Catalin_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publisher_PublisherID1",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "PublisherID1",
                table: "Book",
                newName: "PublisherID");

            migrationBuilder.RenameIndex(
                name: "IX_Book_PublisherID1",
                table: "Book",
                newName: "IX_Book_PublisherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publisher_PublisherID",
                table: "Book",
                column: "PublisherID",
                principalTable: "Publisher",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publisher_PublisherID",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "PublisherID",
                table: "Book",
                newName: "PublisherID1");

            migrationBuilder.RenameIndex(
                name: "IX_Book_PublisherID",
                table: "Book",
                newName: "IX_Book_PublisherID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publisher_PublisherID1",
                table: "Book",
                column: "PublisherID1",
                principalTable: "Publisher",
                principalColumn: "ID");
        }
    }
}
