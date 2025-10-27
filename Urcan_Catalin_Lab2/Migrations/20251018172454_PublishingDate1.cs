using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Urcan_Catalin_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class PublishingDate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherID1",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublisherID1",
                table: "Book",
                column: "PublisherID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publisher_PublisherID1",
                table: "Book",
                column: "PublisherID1",
                principalTable: "Publisher",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publisher_PublisherID1",
                table: "Book");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropIndex(
                name: "IX_Book_PublisherID1",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "PublisherID1",
                table: "Book");
        }
    }
}
