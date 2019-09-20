using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Challenge_3_Web.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RowData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    GroupNumber = table.Column<int>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    xAco = table.Column<double>(nullable: false),
                    yAco = table.Column<double>(nullable: false),
                    zAco = table.Column<double>(nullable: false),
                    AcoSMV = table.Column<double>(nullable: false),
                    xGyro = table.Column<double>(nullable: false),
                    yGyro = table.Column<double>(nullable: false),
                    zGyro = table.Column<double>(nullable: false),
                    GyroSMV = table.Column<double>(nullable: false),
                    xLinAco = table.Column<double>(nullable: false),
                    yLinAco = table.Column<double>(nullable: false),
                    zLinAco = table.Column<double>(nullable: false),
                    LinAcoSMV = table.Column<double>(nullable: false),
                    xMag = table.Column<double>(nullable: false),
                    yMag = table.Column<double>(nullable: false),
                    zMag = table.Column<double>(nullable: false),
                    Activity = table.Column<int>(nullable: false),
                    Pred = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RowData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Windows",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    MaxAcoSMV = table.Column<double>(nullable: false),
                    MinAcoSMV = table.Column<double>(nullable: false),
                    MeanAcoSMV = table.Column<double>(nullable: false),
                    ModeAcoSMV = table.Column<double>(nullable: false),
                    StdAcoSMV = table.Column<double>(nullable: false),
                    MaxLinAcoSMV = table.Column<double>(nullable: false),
                    MinLinAcoSMV = table.Column<double>(nullable: false),
                    MeanLinAcoSMV = table.Column<double>(nullable: false),
                    ModeLinAcoSMV = table.Column<double>(nullable: false),
                    StdLinAcoSMV = table.Column<double>(nullable: false),
                    MaxGyroSMV = table.Column<double>(nullable: false),
                    MinGyroSMV = table.Column<double>(nullable: false),
                    MeanGyroSMV = table.Column<double>(nullable: false),
                    ModeGyroSMV = table.Column<double>(nullable: false),
                    StdGyroSMV = table.Column<double>(nullable: false),
                    Activity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Windows", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RowData");

            migrationBuilder.DropTable(
                name: "Windows");
        }
    }
}
