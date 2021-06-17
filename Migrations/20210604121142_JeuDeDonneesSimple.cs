using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace projetApiAsp.Migrations
{
    public partial class JeuDeDonneesSimple : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Entreprises",
                columns: new[] { "EntrepriseId", "Adresse", "Nom", "Pays" },
                values: new object[] { new Guid("77244da1-8235-4420-97e5-621dc1af1277"), "Dampierre - Valarep", "Valarep", "France" });

            migrationBuilder.InsertData(
                table: "Entreprises",
                columns: new[] { "EntrepriseId", "Adresse", "Nom", "Pays" },
                values: new object[] { new Guid("20b02fd7-6b6e-494c-8769-b1c351b27e1d"), "Dampierre - Valarep", "Dampierre", "France" });

            migrationBuilder.InsertData(
                table: "Employes",
                columns: new[] { "EmployeId", "Age", "EntrepriseId", "Nom", "Poste" },
                values: new object[] { new Guid("43f1944b-171c-40f7-87b1-c337a9b5e2b7"), 29, new Guid("77244da1-8235-4420-97e5-621dc1af1277"), "Patrice Gahide", "Formateur" });

            migrationBuilder.InsertData(
                table: "Employes",
                columns: new[] { "EmployeId", "Age", "EntrepriseId", "Nom", "Poste" },
                values: new object[] { new Guid("9f0686e4-6340-4f81-8a79-fdd4010ad428"), 28, new Guid("20b02fd7-6b6e-494c-8769-b1c351b27e1d"), "Vincent Brocheton", "Formateur" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "EmployeId",
                keyValue: new Guid("43f1944b-171c-40f7-87b1-c337a9b5e2b7"));

            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "EmployeId",
                keyValue: new Guid("9f0686e4-6340-4f81-8a79-fdd4010ad428"));

            migrationBuilder.DeleteData(
                table: "Entreprises",
                keyColumn: "EntrepriseId",
                keyValue: new Guid("20b02fd7-6b6e-494c-8769-b1c351b27e1d"));

            migrationBuilder.DeleteData(
                table: "Entreprises",
                keyColumn: "EntrepriseId",
                keyValue: new Guid("77244da1-8235-4420-97e5-621dc1af1277"));
        }
    }
}
