using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeMate.Migrations
{
    /// <inheritdoc />
    public partial class TimemateLMS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerApproval",
                table: "leaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManagerApproval",
                table: "leaveRequests");
        }
    }
}
