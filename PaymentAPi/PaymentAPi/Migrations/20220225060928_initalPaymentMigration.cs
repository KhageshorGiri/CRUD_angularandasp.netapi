using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentAPi.Migrations
{
    public partial class initalPaymentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    PyamentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardOwnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpirationDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.PyamentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "payments");
        }
    }
}
