using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndcsvfile.Migrations
{
    public partial class AdditionalFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "CsvFile",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "CsvFile",
                table: "CsvFile",
                newName: "StudentNumber");

            migrationBuilder.AddColumn<string>(
                name: "CourseCode",
                table: "CsvFile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseDescription",
                table: "CsvFile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "CsvFile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "CsvFile",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseCode",
                table: "CsvFile");

            migrationBuilder.DropColumn(
                name: "CourseDescription",
                table: "CsvFile");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "CsvFile");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "CsvFile");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "CsvFile",
                newName: "FileName");

            migrationBuilder.RenameColumn(
                name: "StudentNumber",
                table: "CsvFile",
                newName: "CsvFile");
        }
    }
}
