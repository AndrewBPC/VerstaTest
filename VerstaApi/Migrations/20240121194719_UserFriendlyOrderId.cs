using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VerstaApi.Migrations
{
    /// <inheritdoc />
    public partial class UserFriendlyOrderId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserFriendlyId",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserFriendlyId",
                table: "Orders");
        }
    }
}
