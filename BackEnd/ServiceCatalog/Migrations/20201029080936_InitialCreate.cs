using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceCatalog.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceItems",
                columns: table => new
                {
                    ServiceItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CategoryId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceItems", x => x.ServiceItemId);
                    table.ForeignKey(
                        name: "FK_ServiceItems_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"), "Кузовные работы" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"), "Ходовая часть" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea316"), "Электроника" });

            migrationBuilder.InsertData(
                table: "ServiceItems",
                columns: new[] { "ServiceItemId", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 8, new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"), "Полировка кузова", "Полировка", 1000m },
                    { 1, new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"), "Покраска кузова", "Покраска", 50000m },
                    { 2, new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"), "Диагностика подвески", "Диагностика", 3000m },
                    { 3, new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"), "Замена сайлентблоков", "Замена сайлентблоков", 1500m },
                    { 4, new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"), "Ремонт стоек стабилизатора", "Ремонт стоек стаблилизатора", 5000m },
                    { 5, new Guid("cfb88e29-4744-48c0-94fa-b25b92dea316"), "Диагностика системы зажигания", "Диагностика системы зажигания", 500m },
                    { 6, new Guid("cfb88e29-4744-48c0-94fa-b25b92dea316"), "Ремонт генератора", "Ремонт генератора", 3500m },
                    { 7, new Guid("cfb88e29-4744-48c0-94fa-b25b92dea316"), "Установка парктроника", "Установка парктроника", 1000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceItems_CategoryId",
                table: "ServiceItems",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceItems");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
