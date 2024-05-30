using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Products.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3634),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3068),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(2983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4994),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4441),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3068), new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3068), new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3068), new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3068), new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3068), new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3068), new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3068), new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3068), new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3068), new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3068), new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3634) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(3351),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(2983),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 22, 8, 33, 191, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9900),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(9581),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 5, 30, 22, 8, 33, 190, DateTimeKind.Utc).AddTicks(4441));

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDateTime", "ModificationDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 5, 30, 21, 21, 25, 581, DateTimeKind.Utc).AddTicks(3351) });
        }
    }
}
