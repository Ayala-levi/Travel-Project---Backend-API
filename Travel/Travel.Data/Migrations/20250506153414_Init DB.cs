using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Travel.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__1788CCAC1BD66CD2", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizerID = table.Column<int>(type: "int", nullable: false),
                    TourName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tours__604CEA1097E15B05", x => x.TourID);
                    table.ForeignKey(
                        name: "FK__Tours__Organizer__5070F446",
                        column: x => x.OrganizerID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserDeta__1788CCACA1DC41D3", x => x.UserID);
                    table.ForeignKey(
                        name: "FK__UserDetai__UserI__4D94879B",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    TourID = table.Column<int>(type: "int", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Particip__018C020DC9ADA893", x => new { x.UserID, x.TourID });
                    table.ForeignKey(
                        name: "FK__Participa__TourI__5535A963",
                        column: x => x.TourID,
                        principalTable: "Tours",
                        principalColumn: "TourID");
                    table.ForeignKey(
                        name: "FK__Participa__UserI__5441852A",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participants_TourID",
                table: "Participants",
                column: "TourID");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_OrganizerID",
                table: "Tours",
                column: "OrganizerID");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__536C85E4C0F7173F",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Users__A9D105342AE15663",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
