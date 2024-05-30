using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Products.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixinitdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(6078),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 20, 39, 33, 950, DateTimeKind.Utc).AddTicks(8265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(5705),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 20, 39, 33, 950, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8487),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 20, 39, 33, 951, DateTimeKind.Utc).AddTicks(414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8184),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 20, 39, 33, 951, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Active", "Description", "ParentCategoryId", "Permalink", "Priority", "Title" },
                values: new object[,]
                {
                    { 3, true, "In aute dolor adipisicing deserunt magna nisi exercitation ut velit reprehenderit est Lorem dolor. Ipsum ea id et ullamco exercitation non quis id Lorem elit culpa mollit laboris culpa. Incididunt minim ut est qui excepteur. Do voluptate officia nisi consectetur sit ullamco est sit commodo nulla laborum ex eu veniam. Proident ad est est ullamco consectetur cillum.\r\n", null, "Mccullough-Gentry", 1, "Erna Terrell" },
                    { 4, false, "Qui laboris amet dolore cillum deserunt aliquip do aliqua in. Qui ut elit sit laborum amet ipsum. Deserunt proident voluptate occaecat irure sunt consequat amet cupidatat ullamco laborum consequat labore nisi. Nostrud eu eu consequat aliqua Lorem sint do amet qui dolore ut. Eiusmod occaecat excepteur sit et irure sunt officia anim dolor aute veniam quis incididunt. In cillum consectetur deserunt cillum commodo excepteur irure.\r\n", null, "Kelli-Guzman", 1, "Briana Maldonado" },
                    { 5, true, "Labore elit ipsum ut enim deserunt. Enim labore cillum laborum laboris in consequat cillum veniam est. Commodo adipisicing enim commodo dolor esse ullamco dolor esse voluptate pariatur esse commodo non ex. Nostrud nisi laboris elit ex tempor pariatur Lorem qui est eu ex.\r\n", null, "Jeri-Buckner", 2, "Copeland Holcomb" },
                    { 6, false, "Magna officia quis consectetur aliqua enim dolor consectetur magna cillum. Enim est magna nostrud duis tempor sunt id Lorem. Eiusmod quis dolore occaecat et exercitation. Est magna fugiat dolore non non occaecat. Ex id laboris excepteur eu est consectetur deserunt minim aliqua veniam labore.\r\n", null, "Francis-Curtis", 1, "Elnora Kane" },
                    { 7, false, "Anim deserunt eu occaecat sint nisi veniam qui fugiat aute. Commodo nisi nisi aliqua ullamco consequat. Excepteur dolore adipisicing mollit eu laborum cillum nisi. Esse voluptate quis amet dolore nisi voluptate nisi Lorem cillum magna officia. Nostrud irure nulla esse voluptate labore elit excepteur reprehenderit.\r\n", null, "Tasha-Craft", 1, "Smith Wagner" },
                    { 1, false, "Mollit exercitation sit laborum id eiusmod eu ad. Qui magna adipisicing amet in magna voluptate id proident qui excepteur minim qui pariatur. Id labore laboris ullamco mollit do deserunt cillum nostrud aliquip consectetur exercitation. Labore aliqua in tempor et qui ullamco commodo ullamco non irure. Excepteur ut sunt in sint id voluptate laborum in ut anim veniam amet laboris tempor. Ex ex magna sunt culpa consectetur.\r\n", 7, "Head-Moody", 1, "Morrison Koch" },
                    { 9, false, "Velit magna pariatur laborum est ea commodo in ut velit sunt cupidatat incididunt. Mollit et minim sint non labore in excepteur tempor sit. Laboris Lorem incididunt commodo laborum velit proident nulla veniam sunt. Mollit dolor veniam aliqua proident fugiat cillum tempor dolor. Dolore veniam incididunt nisi consectetur deserunt in labore Lorem deserunt.\r\n", 3, "Elisa-Coleman", 2, "Adriana Galloway" },
                    { 8, false, "Tempor excepteur qui laborum nulla consectetur. Nulla adipisicing ad incididunt voluptate. Excepteur deserunt dolor non ut aliquip. Et dolor reprehenderit tempor enim do. Culpa adipisicing non consequat cupidatat veniam proident esse et cupidatat amet ea.\r\n", 9, "Janelle-Lane", 2, "Olive James" },
                    { 10, false, "Irure consectetur et excepteur pariatur minim culpa. Enim quis officia reprehenderit veniam. Aliqua veniam laborum esse officia consectetur laboris aliqua occaecat fugiat mollit. Aute do pariatur irure do irure fugiat officia sunt amet dolor. Ad consequat quis qui sunt cupidatat laborum excepteur ullamco veniam qui culpa esse commodo sunt.\r\n", 8, "Justine-Duffy", 1, "Leslie Jacobs" },
                    { 2, false, "Culpa esse nulla ipsum dolor in proident irure elit. Sit sunt deserunt fugiat reprehenderit. Enim id eu tempor deserunt laboris deserunt magna. Excepteur aute velit ullamco proident dolore et qui. Sit ut nulla ipsum veniam commodo quis ipsum. Ad aliquip cupidatat pariatur Lorem reprehenderit proident nisi tempor amet aute reprehenderit ipsum excepteur. Eu nulla nostrud velit reprehenderit duis ad proident tempor occaecat quis esse id deserunt.\r\n", 10, "Amie-Ramos", 2, "Francisca Shields" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 20, 39, 33, 950, DateTimeKind.Utc).AddTicks(8265),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 20, 39, 33, 950, DateTimeKind.Utc).AddTicks(7917),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 20, 39, 33, 951, DateTimeKind.Utc).AddTicks(414),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 20, 39, 33, 951, DateTimeKind.Utc).AddTicks(120),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8184));

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
        }
    }
}
