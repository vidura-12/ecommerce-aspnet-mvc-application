using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Actors_actorId",
                table: "Actor_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Produsers_Produser_Id",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_Produser_Id",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieCatogory",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureUrl",
                table: "Produsers",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Movies",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Produser_Id",
                table: "Movies",
                newName: "MovieCategory");

            migrationBuilder.RenameColumn(
                name: "PosterUrl",
                table: "Movies",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureUrl",
                table: "Actors",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "actorId",
                table: "Actor_Movies",
                newName: "ActorId");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Produsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                column: "ProducerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Actors_ActorId",
                table: "Actor_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Produsers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Produsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Actors_ActorId",
                table: "Actor_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Produsers_ProducerId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Produsers",
                newName: "ProfilePictureUrl");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Movies",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "MovieCategory",
                table: "Movies",
                newName: "Produser_Id");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Movies",
                newName: "PosterUrl");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movies",
                newName: "MId");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Actors",
                newName: "ProfilePictureUrl");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Actor_Movies",
                newName: "actorId");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Produsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "MovieCatogory",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Produser_Id",
                table: "Movies",
                column: "Produser_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Actors_actorId",
                table: "Actor_Movies",
                column: "actorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Produsers_Produser_Id",
                table: "Movies",
                column: "Produser_Id",
                principalTable: "Produsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
