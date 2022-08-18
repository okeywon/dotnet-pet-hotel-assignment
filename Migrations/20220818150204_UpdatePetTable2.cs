using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_bakery.Migrations
{
    public partial class UpdatePetTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Pets_ownedById",
                table: "Pets",
                column: "ownedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetOwners_ownedById",
                table: "Pets",
                column: "ownedById",
                principalTable: "PetOwners",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetOwners_ownedById",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_ownedById",
                table: "Pets");
        }
    }
}
