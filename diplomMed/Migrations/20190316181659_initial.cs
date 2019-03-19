using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace diplomMed.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EquipType = table.Column<string>(nullable: true),
                    Photo = table.Column<byte[]>(nullable: true),
                    Developer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Categ1 = table.Column<bool>(nullable: false),
                    Categ2 = table.Column<bool>(nullable: false),
                    Categ3 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Defs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Manual = table.Column<string>(nullable: true),
                    Auto = table.Column<string>(nullable: true),
                    Synchr = table.Column<string>(nullable: true),
                    Voice = table.Column<string>(nullable: true),
                    Ekg = table.Column<string>(nullable: true),
                    Printer = table.Column<string>(nullable: true),
                    PulsOxx = table.Column<string>(nullable: true),
                    Press = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    EquipId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Defs_Equips_EquipId",
                        column: x => x.EquipId,
                        principalTable: "Equips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ekgs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConnectPc = table.Column<string>(nullable: true),
                    SignalProccesing = table.Column<string>(nullable: true),
                    MemorySize = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    EquipId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ekgs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ekgs_Equips_EquipId",
                        column: x => x.EquipId,
                        principalTable: "Equips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ivls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Time = table.Column<string>(nullable: true),
                    BatteryType = table.Column<string>(nullable: true),
                    TimeCharging = table.Column<string>(nullable: true),
                    WorkModes = table.Column<string>(nullable: true),
                    EquipId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ivls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ivls_Equips_EquipId",
                        column: x => x.EquipId,
                        principalTable: "Equips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ekg = table.Column<string>(nullable: true),
                    Ad = table.Column<string>(nullable: true),
                    Kapn = table.Column<string>(nullable: true),
                    Pulsoxxx = table.Column<string>(nullable: true),
                    Diagonal = table.Column<string>(nullable: true),
                    Resol = table.Column<string>(nullable: true),
                    EquipId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitors_Equips_EquipId",
                        column: x => x.EquipId,
                        principalTable: "Equips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PulsOxx",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Memory = table.Column<string>(nullable: true),
                    Display = table.Column<string>(nullable: true),
                    Batteries = table.Column<string>(nullable: true),
                    Battery = table.Column<string>(nullable: true),
                    EquipId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PulsOxx", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PulsOxx_Equips_EquipId",
                        column: x => x.EquipId,
                        principalTable: "Equips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stretchers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkingCondition = table.Column<string>(nullable: true),
                    FoldedCondition = table.Column<string>(nullable: true),
                    EquipId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stretchers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stretchers_Equips_EquipId",
                        column: x => x.EquipId,
                        principalTable: "Equips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Defs_EquipId",
                table: "Defs",
                column: "EquipId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ekgs_EquipId",
                table: "Ekgs",
                column: "EquipId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ivls_EquipId",
                table: "Ivls",
                column: "EquipId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_EquipId",
                table: "Monitors",
                column: "EquipId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PulsOxx_EquipId",
                table: "PulsOxx",
                column: "EquipId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stretchers_EquipId",
                table: "Stretchers",
                column: "EquipId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Defs");

            migrationBuilder.DropTable(
                name: "Ekgs");

            migrationBuilder.DropTable(
                name: "Ivls");

            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropTable(
                name: "PulsOxx");

            migrationBuilder.DropTable(
                name: "Stretchers");

            migrationBuilder.DropTable(
                name: "Equips");
        }
    }
}
