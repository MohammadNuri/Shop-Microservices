using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Products.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false),
                    Permalink = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    BannerUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://placehold.co/500x100.png"),
                    IconUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://placehold.co/85.png"),
                    ThumbnailUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://placehold.co/150.png"),
                    ParentCategoryId = table.Column<int>(type: "integer", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 5, 30, 20, 39, 33, 951, DateTimeKind.Utc).AddTicks(120)),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 5, 30, 20, 39, 33, 951, DateTimeKind.Utc).AddTicks(414))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Permalink = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    CoverImageUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://placehold.co/150.png"),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 5, 30, 20, 39, 33, 950, DateTimeKind.Utc).AddTicks(7917)),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 5, 30, 20, 39, 33, 950, DateTimeKind.Utc).AddTicks(8265))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Active", "Description", "ParentCategoryId", "Permalink", "Priority", "Title" },
                values: new object[,]
                {
                    { 66, false, "Dolore dolor pariatur magna ad esse. Enim nisi consectetur duis duis aute mollit Lorem culpa. Irure excepteur voluptate do enim aliqua nisi. Et irure enim fugiat tempor culpa ad proident nisi nulla exercitation irure ipsum irure in.\r\n", null, "Clarke-Hammond", 0, "Jodie Baxter" },
                    { 67, true, "Exercitation ad exercitation consequat quis Lorem aute. Veniam ut irure irure est Lorem Lorem ullamco voluptate tempor. Labore eiusmod officia sint cupidatat eiusmod voluptate anim culpa amet quis adipisicing do ipsum. Cillum cupidatat in sunt enim consequat. Officia cupidatat est deserunt enim sunt. Dolore laborum consequat est incididunt incididunt eiusmod nostrud. Et sint sunt esse incididunt eu dolore velit enim voluptate qui ut.\r\n", null, "Turner-Henry", 0, "Jacqueline Kidd" },
                    { 89, false, "Proident deserunt nisi esse eu commodo ea incididunt aliqua. Id id amet id adipisicing voluptate. Est duis non nisi laboris tempor.\r\n", null, "Myra-Francis", 0, "Mara Wade" },
                    { 124, true, "Ut ipsum veniam sint et do id pariatur duis. Commodo officia velit duis fugiat sint deserunt officia duis proident quis. Eu quis sunt Lorem reprehenderit quis ea pariatur tempor fugiat dolor incididunt. Est enim tempor irure non dolore proident culpa laborum. Anim exercitation sunt proident eu occaecat cupidatat. Incididunt nisi amet id ea qui amet magna qui fugiat. Laborum sit qui ea exercitation reprehenderit.\r\n", null, "Bettye-Gregory", 0, "Jan Delgado" },
                    { 155, false, "Nisi quis enim proident duis mollit exercitation eiusmod reprehenderit. Ex ex deserunt laboris esse commodo commodo. Ut officia est tempor incididunt qui eu laborum elit mollit eu irure veniam. Aute reprehenderit occaecat labore elit ullamco. Nulla deserunt aliqua esse culpa velit sit elit et nostrud labore dolore. Pariatur qui consectetur deserunt eu officia est magna in amet ea qui. Cillum labore proident ipsum in sunt exercitation veniam ipsum sit.\r\n", null, "Rosemary-Burnett", 0, "Pacheco Vega" },
                    { 168, false, "Cupidatat ea ut cupidatat aliquip id enim irure cillum reprehenderit magna. Voluptate dolor cupidatat deserunt sint ipsum aliqua sint ut pariatur cupidatat anim. Mollit cupidatat sit do nisi ad amet labore velit minim officia officia ad in id. Ut nulla aute nulla dolor.\r\n", null, "Beverly-Fitzpatrick", 0, "Ware Daugherty" },
                    { 175, true, "Lorem cupidatat id ea aute et voluptate consequat quis. Irure cillum aute veniam sit exercitation ex Lorem ex eu fugiat aliqua non incididunt qui. Non mollit culpa velit eiusmod commodo anim proident laborum voluptate ipsum. Dolor voluptate consectetur sint culpa esse nostrud quis amet. Mollit eiusmod ex deserunt consectetur tempor dolore eiusmod cillum occaecat.\r\n", null, "Terry-May", 0, "Janet Pacheco" },
                    { 182, true, "Minim occaecat eu ea anim excepteur qui. Voluptate adipisicing sunt in enim deserunt labore esse ut non occaecat anim elit. Cillum laborum nostrud veniam magna do.\r\n", null, "Olga-Guthrie", 0, "Maryanne Clements" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
