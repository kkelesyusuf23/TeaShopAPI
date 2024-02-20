using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeaShopAPI.DataAccess.Migrations
{
    public partial class mig_add_column_in_reservation_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ReservationTime",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationTime",
                table: "Reservations");
        }
    }
}
