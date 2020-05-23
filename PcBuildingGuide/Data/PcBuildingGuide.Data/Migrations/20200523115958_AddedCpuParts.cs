namespace PcBuildingGuide.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddedCpuParts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Parts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Cpus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    ProcesorType = table.Column<string>(nullable: true),
                    Series = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    CPUSocketType = table.Column<string>(nullable: true),
                    NumberOfCores = table.Column<string>(nullable: true),
                    NumberOfThreads = table.Column<string>(nullable: true),
                    ManufacturingTech = table.Column<string>(nullable: true),
                    TDP = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cpus");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Parts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
