using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Products.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(3351),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(2983),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9900),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9581),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9581), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9581), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9581), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9581), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9581), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9581), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9581), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9581), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9581), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9581), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Active", "CategoryId", "Code", "Description", "Permalink", "Price", "Title" },
                values: new object[,]
                {
                    { 11, true, 6, "Vicky", "Laboris velit aliquip exercitation eu pariatur magna qui. Aliqua reprehenderit ad reprehenderit Lorem sit do dolor dolor non. Labore fugiat id voluptate nostrud labore eiusmod proident minim. Proident pariatur proident et commodo et anim.\r\n", "Cara-Burt", 0m, "Latonya Fuentes" },
                    { 12, false, 1, "Suzanne", "Non amet irure cupidatat incididunt consectetur nulla officia. Id ea non et ad dolore in consectetur duis dolore consectetur aute. Occaecat duis excepteur magna reprehenderit commodo.\r\n", "Lee-Brooks", 0m, "Shelby Bray" },
                    { 13, true, 7, "Daisy", "Magna voluptate aute ut consectetur consequat non est occaecat do non cillum non qui. Labore excepteur ex cupidatat voluptate. Proident elit fugiat ipsum laboris. Dolore pariatur magna aute excepteur ullamco. Laborum elit aliqua id exercitation in incididunt exercitation in nisi. Amet et do non do fugiat labore laborum ullamco pariatur incididunt. Voluptate mollit est id dolore ea id non adipisicing magna minim.\r\n", "Linda-Barrera", 0m, "Wallace Vang" },
                    { 14, true, 7, "Roy", "Eu ex irure in non ullamco ea mollit laborum esse aliquip ad pariatur consectetur ex. Aute consectetur anim qui in excepteur amet dolor ea qui. Velit consectetur cillum elit non ut pariatur esse cillum incididunt voluptate dolore ut. Quis commodo exercitation ullamco mollit occaecat.\r\n", "Stella-Carrillo", 0m, "Kirk Torres" },
                    { 15, false, 2, "Erickson", "In cillum enim qui et anim excepteur labore esse magna magna aliqua. Aliquip do commodo veniam anim eu consectetur ex ex aliqua dolor. Adipisicing amet eiusmod sint sint labore pariatur. Fugiat elit consequat magna laboris minim qui. Veniam veniam nulla laboris laboris dolor ullamco dolor.\r\n", "Yesenia-Solis", 0m, "Cote Owens" },
                    { 16, false, 1, "Traci", "Qui consectetur cillum ullamco adipisicing sint do amet sint commodo consectetur. Pariatur enim ex consequat exercitation reprehenderit proident nostrud commodo nostrud voluptate. Nulla nostrud culpa nulla dolor enim mollit duis ullamco. Esse dolore id ut ex culpa do aute sint. Exercitation ut in eiusmod eu. Enim enim cupidatat deserunt deserunt esse id est. Aliqua sint voluptate in sit ipsum irure.\r\n", "Rosalind-Porter", 0m, "Massey Campbell" },
                    { 17, true, 3, "Catherine", "Ea duis eu exercitation labore ullamco occaecat elit et et. Sunt est pariatur eu elit consequat aute velit. Laborum adipisicing nisi est voluptate veniam commodo. Consequat consectetur sint do adipisicing esse enim aliqua. Elit irure ut ipsum esse culpa ipsum laboris velit deserunt nisi ipsum aute reprehenderit labore. Aliquip aute do sit anim aute aliquip esse. Non aliquip enim sunt deserunt minim amet laborum consequat laborum laboris mollit commodo eiusmod anim.\r\n", "Marisa-Shepard", 0m, "Betty Thornton" },
                    { 18, false, 3, "Sherman", "Consectetur culpa ullamco elit eiusmod quis pariatur duis nostrud laboris occaecat aliqua mollit. Labore incididunt consequat dolor reprehenderit quis quis est. Enim sint laboris velit qui. Aliquip in qui amet sint magna cillum sunt mollit. Incididunt magna id in occaecat proident qui aliquip. Eiusmod incididunt cillum ea ullamco ex cillum ipsum ad sit aute. Consectetur amet sunt consectetur enim.\r\n", "Elena-Nielsen", 0m, "Wells Glenn" },
                    { 19, true, 9, "Walton", "Laboris et deserunt deserunt consequat. Pariatur occaecat consectetur in ea mollit ad mollit esse esse aliquip. Quis sint sunt est excepteur magna eu id est amet aliqua deserunt in. Minim laborum aute velit mollit laborum consectetur laborum nostrud sit elit. Eiusmod consequat Lorem minim do occaecat eu aliquip dolore in pariatur consequat commodo cupidatat magna. Enim excepteur culpa non sit eiusmod. Id amet officia aliqua esse culpa eu eu mollit consequat proident est eiusmod proident reprehenderit.\r\n", "Meredith-Head", 0m, "Fay Arnold" },
                    { 20, false, 4, "Davidson", "Eiusmod sint id consectetur incididunt ex eiusmod occaecat officia dolore commodo quis. Veniam aliquip ut minim elit irure cupidatat aute magna elit in. Velit exercitation duis minim duis Lorem commodo do. Duis eu dolor do et minim nulla ad id adipisicing pariatur culpa.\r\n", "Isabel-Cooley", 0m, "Joy Barnett" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(6078),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(5705),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(2983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8487),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8184),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8184), new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8184), new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8184), new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8184), new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8184), new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8184), new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8184), new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8184), new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8184), new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8184), new DateTime(2024, 5, 30, 20, 54, 42, 206, DateTimeKind.Utc).AddTicks(8487) });
        }
    }
}
