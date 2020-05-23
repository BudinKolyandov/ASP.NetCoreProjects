namespace PcBuildingGuide.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddedAllModelsForParts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Cpus",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AirCoolers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    FanSize = table.Column<string>(nullable: true),
                    CPUSocketCompatibility = table.Column<string>(nullable: true),
                    RPM = table.Column<string>(nullable: true),
                    PowerConnector = table.Column<string>(nullable: true),
                    MaxCPUCoolerHeight = table.Column<string>(nullable: true),
                    HeatsinkDimensions = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirCoolers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirCoolers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    CaseMaterial = table.Column<string>(nullable: true),
                    MotherboardCompatibility = table.Column<string>(nullable: true),
                    MaxGPULengthAllowance = table.Column<string>(nullable: true),
                    MaxCPUCoolerHeightAllowance = table.Column<string>(nullable: true),
                    SidePanelWindow = table.Column<string>(nullable: true),
                    ExpansionSlots = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cases_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HardDiskDrives",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Interface = table.Column<string>(nullable: true),
                    Capacity = table.Column<string>(nullable: true),
                    RPM = table.Column<string>(nullable: true),
                    Cache = table.Column<string>(nullable: true),
                    Usage = table.Column<string>(nullable: true),
                    FormFactor = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardDiskDrives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HardDiskDrives_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Memories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Capacity = table.Column<string>(nullable: true),
                    Series = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Speed = table.Column<string>(nullable: true),
                    CASLatency = table.Column<string>(nullable: true),
                    Timing = table.Column<string>(nullable: true),
                    HeatSpreader = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Memories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    CPUSocketType = table.Column<string>(nullable: true),
                    CPUType = table.Column<string>(nullable: true),
                    Chipset = table.Column<string>(nullable: true),
                    MemoryStandard = table.Column<string>(nullable: true),
                    NumberOfMemorySlots = table.Column<string>(nullable: true),
                    AudioChipset = table.Column<string>(nullable: true),
                    LANChipset = table.Column<string>(nullable: true),
                    MaxLANSpeed = table.Column<string>(nullable: true),
                    FormFactor = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motherboards_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PowerSupplies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    MaximumPower = table.Column<string>(nullable: true),
                    Fans = table.Column<string>(nullable: true),
                    Modular = table.Column<string>(nullable: true),
                    EnergyEfficiency = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerSupplies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PowerSupplies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolidStateDrives",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    DeviceType = table.Column<string>(nullable: true),
                    UsedFor = table.Column<string>(nullable: true),
                    FormFactor = table.Column<string>(nullable: true),
                    Capacity = table.Column<string>(nullable: true),
                    Interface = table.Column<string>(nullable: true),
                    MemoryComponents = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolidStateDrives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolidStateDrives_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VideoCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Interface = table.Column<string>(nullable: true),
                    GPU = table.Column<string>(nullable: true),
                    StreamProcessors = table.Column<string>(nullable: true),
                    DirectX = table.Column<string>(nullable: true),
                    OpenGL = table.Column<string>(nullable: true),
                    Cooler = table.Column<string>(nullable: true),
                    SystemRequirements = table.Column<string>(nullable: true),
                    FormFactor = table.Column<string>(nullable: true),
                    MaxGPULength = table.Column<string>(nullable: true),
                    SlotWidth = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoCards_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WaterCoolers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    BlockCompatibility = table.Column<string>(nullable: true),
                    PumpCapacity = table.Column<string>(nullable: true),
                    RadiatorDim = table.Column<string>(nullable: true),
                    FanSize = table.Column<string>(nullable: true),
                    FanRPM = table.Column<string>(nullable: true),
                    FanAirFlow = table.Column<string>(nullable: true),
                    TubeDim = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterCoolers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterCoolers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cpus_CategoryId",
                table: "Cpus",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AirCoolers_CategoryId",
                table: "AirCoolers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CategoryId",
                table: "Cases",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HardDiskDrives_CategoryId",
                table: "HardDiskDrives",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Memories_CategoryId",
                table: "Memories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboards_CategoryId",
                table: "Motherboards",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PowerSupplies_CategoryId",
                table: "PowerSupplies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SolidStateDrives_CategoryId",
                table: "SolidStateDrives",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoCards_CategoryId",
                table: "VideoCards",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterCoolers_CategoryId",
                table: "WaterCoolers",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cpus_Categories_CategoryId",
                table: "Cpus",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cpus_Categories_CategoryId",
                table: "Cpus");

            migrationBuilder.DropTable(
                name: "AirCoolers");

            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "HardDiskDrives");

            migrationBuilder.DropTable(
                name: "Memories");

            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "PowerSupplies");

            migrationBuilder.DropTable(
                name: "SolidStateDrives");

            migrationBuilder.DropTable(
                name: "VideoCards");

            migrationBuilder.DropTable(
                name: "WaterCoolers");

            migrationBuilder.DropIndex(
                name: "IX_Cpus_CategoryId",
                table: "Cpus");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Cpus");
        }
    }
}
