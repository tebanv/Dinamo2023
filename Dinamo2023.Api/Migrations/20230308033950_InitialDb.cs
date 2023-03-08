using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dinamo2023.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParamSys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdParameterFather = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Parameter = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ParameterValue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ParameterDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ParameterAbreviature = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParamSys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameDeliverer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PickUpAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PickUpInstructions = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PickUpPhoneNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PackageInformation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdPackegeSize = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    NameRecipient = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DeliveryInstructions = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DeliveryPhoneNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PurchaseInformation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CostService = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    StatusService = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdPlan = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    IdUser = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    IdCourier = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    IdServiceType = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    FinalNote = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParamSys_IdParameterFather",
                table: "ParamSys",
                column: "IdParameterFather",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParamSys");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
