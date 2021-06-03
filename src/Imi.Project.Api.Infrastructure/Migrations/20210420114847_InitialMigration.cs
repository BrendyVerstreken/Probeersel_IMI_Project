using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LentOuts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LentOuts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productionhouses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Headquarters = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productionhouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    ProductionhouseId = table.Column<Guid>(nullable: false),
                    DirectorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Productionhouses_ProductionhouseId",
                        column: x => x.ProductionhouseId,
                        principalTable: "Productionhouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenre",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(nullable: false),
                    GenreId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenre", x => new { x.MovieId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_MovieGenre_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGenre_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieLentout",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(nullable: false),
                    LentOutId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieLentout", x => new { x.MovieId, x.LentOutId });
                    table.ForeignKey(
                        name: "FK_MovieLentout_LentOuts_LentOutId",
                        column: x => x.LentOutId,
                        principalTable: "LentOuts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieLentout_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3868b15c-93af-44fa-a147-6214358982e6"), "Chris Buck" },
                    { new Guid("a3da4185-e74f-47e8-9af2-4753cf728ab6"), "James Wan" },
                    { new Guid("d71f81c0-2ffa-49fc-9963-7d0aa57a4c9a"), "Mike Mitchell" },
                    { new Guid("f2842d85-39a7-429c-8ae1-81a3174629dd"), "Marco Brambilla" },
                    { new Guid("cb21d286-2eb3-4caf-a0e2-4385493925d1"), "Peter Jackson" },
                    { new Guid("ef26c1b5-5180-4831-b597-982bbbaba5f0"), "John Cohen" },
                    { new Guid("d0f18cc5-1344-4502-abb1-80d836e9e7da"), "Bryan Singer" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("77f84b77-9d6c-42a3-bd77-46cd04465a47"), "Fantasy" },
                    { new Guid("1dc8342d-057c-4e8c-b15a-a413ca9eaa6d"), "Sci-Fi" },
                    { new Guid("f8a15d32-4a87-44e8-836c-c5d119d28865"), "Adventure" },
                    { new Guid("eecba59f-dc81-4b60-b677-84aa3088f8fb"), "Family" },
                    { new Guid("e11caf64-8647-4472-b5ea-c1498b04e1d9"), "Ramance" },
                    { new Guid("d2c8a028-72e2-43fd-9e6b-845051451901"), "Comedy" },
                    { new Guid("cd9782b8-015e-4099-bdce-ab1e95b1dd37"), "Horror" },
                    { new Guid("f8bc440a-f47b-4376-8c83-2537a9e32afb"), "Thriller" },
                    { new Guid("56f74a86-c9a5-4700-bf41-754db7a7a432"), "Animation" },
                    { new Guid("2a11f3de-7052-43e9-86a0-529f01de586a"), "Action" }
                });

            migrationBuilder.InsertData(
                table: "LentOuts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bcab7b0b-529a-4243-aac0-6a9daf3a63da"), "Hilde" },
                    { new Guid("5779b386-192f-45f0-a77c-e0c3ada65801"), "Amalia" },
                    { new Guid("0855fe6f-1966-4c14-8a50-33d2f5924cd6"), "Sharona" },
                    { new Guid("f8ab5013-ef70-4cd6-8327-2c526beceb3b"), "Steve" },
                    { new Guid("0db643f3-115e-4c5e-b8f1-22e9e0b9659f"), "Brendy" },
                    { new Guid("d610ddc2-66e1-4c5e-840b-6174964d3a90"), "Imana" }
                });

            migrationBuilder.InsertData(
                table: "Productionhouses",
                columns: new[] { "Id", "Headquarters", "Name" },
                values: new object[,]
                {
                    { new Guid("64b4720b-d751-4d14-bbd1-a51807be65b8"), "Century City, Los Angeles", "20th Century Studios" },
                    { new Guid("1194f1d0-cc0a-41b8-9b9b-43e9d83d3bcf"), "Burbank, Californië", "Disney" },
                    { new Guid("6e835b5a-699e-49cd-b330-d4214ea37e86"), "Hollywood", "New Line Cinema" },
                    { new Guid("38df2e17-c2ba-49e1-8f83-16d1b070c96c"), "Rendwoon City, Califorië", "DreamWorks Animation" },
                    { new Guid("d09684c4-0097-4d14-85a6-5523f30f4360"), "Cologne, Germany", "RTL Television Germany" },
                    { new Guid("a78c00a4-36e9-460a-9e52-eef287bf2977"), "Los Angeles, Califorië", "BlumHouse Productions" },
                    { new Guid("cd8a9b27-8e95-4407-ad81-e277d15f03ae"), "Culver City, Californië", "Columbia Pictures" },
                    { new Guid("272a59bb-9de3-4237-9417-183fc3128c98"), "Burbank, Californië", "Warner Bros" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DirectorId", "Image", "ProductionhouseId", "Title" },
                values: new object[,]
                {
                    { new Guid("28634eed-5342-4a54-bd55-957e8a0193f1"), new Guid("3868b15c-93af-44fa-a147-6214358982e6"), "https://www.moviemeter.nl/images/cover/1123000/1123486.jpg?cb=1572281329", new Guid("1194f1d0-cc0a-41b8-9b9b-43e9d83d3bcf"), "Frozen 2" },
                    { new Guid("f34d6513-8899-4d9f-98d7-6d521f7c1f3e"), new Guid("a3da4185-e74f-47e8-9af2-4753cf728ab6"), "https://1.bp.blogspot.com/-Gi_sYA5EeOc/XxnkznABTII/AAAAAAAADVo/v1np_MuLBpELyHgf5AwEyHDYhlR1V9v_ACLcBGAsYHQ/s1600/The%2BConjuring%2B2013.jpg", new Guid("6e835b5a-699e-49cd-b330-d4214ea37e86"), "The Conjouring" },
                    { new Guid("85518b4d-918e-447b-847b-5769a2f919c9"), new Guid("d71f81c0-2ffa-49fc-9963-7d0aa57a4c9a"), "http://4.bp.blogspot.com/-wuPeTulesvs/VijDC-98v1I/AAAAAAAAALQ/xjD6dzeVFlQ/s1600/shrek_forever_after_2010-movie-poster_1371176093.jpg", new Guid("38df2e17-c2ba-49e1-8f83-16d1b070c96c"), "Shrek voor eeuwig en altijd" },
                    { new Guid("3417e49d-ddc7-48ff-8f96-146cf349d9ed"), new Guid("f2842d85-39a7-429c-8ae1-81a3174629dd"), "http://www.moriareviews.com/rongulator/wp-content/uploads/Dinotopia-2002-poster.jpg", new Guid("d09684c4-0097-4d14-85a6-5523f30f4360"), "Dinotopia" },
                    { new Guid("5a198a0c-e639-4bc0-8160-c114ccb9ecc4"), new Guid("a3da4185-e74f-47e8-9af2-4753cf728ab6"), "https://heyitsbenito.files.wordpress.com/2013/10/insidious_2010_3.jpg", new Guid("a78c00a4-36e9-460a-9e52-eef287bf2977"), "Insidious" },
                    { new Guid("98218d60-871c-4bba-95f4-5f3eca33bfdc"), new Guid("ef26c1b5-5180-4831-b597-982bbbaba5f0"), "https://fanart.tv/fanart/movies/153518/movieposter/angry-birds-57529afceafe7.jpg", new Guid("cd8a9b27-8e95-4407-ad81-e277d15f03ae"), "The Angry Birds" },
                    { new Guid("9421dc55-90ae-4ceb-b7b8-9dd494feb850"), new Guid("d0f18cc5-1344-4502-abb1-80d836e9e7da"), "https://upload.wikimedia.org/wikipedia/pt/f/f8/X-Men_Dias_Futuro_Esquecido_2014.jpg", new Guid("64b4720b-d751-4d14-bbd1-a51807be65b8"), "X-men: Days of future past" },
                    { new Guid("76826400-6497-4cfe-8e46-cb4a1e2cea2a"), new Guid("cb21d286-2eb3-4caf-a0e2-4385493925d1"), "https://www.newdvdreleasedates.com/images/posters/large/the-hobbit-an-unexpected-journey-2012-5.jpg", new Guid("272a59bb-9de3-4237-9417-183fc3128c98"), "The Hobbit" }
                });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "MovieId", "GenreId" },
                values: new object[,]
                {
                    { new Guid("28634eed-5342-4a54-bd55-957e8a0193f1"), new Guid("56f74a86-c9a5-4700-bf41-754db7a7a432") },
                    { new Guid("76826400-6497-4cfe-8e46-cb4a1e2cea2a"), new Guid("f8a15d32-4a87-44e8-836c-c5d119d28865") },
                    { new Guid("9421dc55-90ae-4ceb-b7b8-9dd494feb850"), new Guid("1dc8342d-057c-4e8c-b15a-a413ca9eaa6d") },
                    { new Guid("9421dc55-90ae-4ceb-b7b8-9dd494feb850"), new Guid("77f84b77-9d6c-42a3-bd77-46cd04465a47") },
                    { new Guid("9421dc55-90ae-4ceb-b7b8-9dd494feb850"), new Guid("f8a15d32-4a87-44e8-836c-c5d119d28865") },
                    { new Guid("9421dc55-90ae-4ceb-b7b8-9dd494feb850"), new Guid("2a11f3de-7052-43e9-86a0-529f01de586a") },
                    { new Guid("98218d60-871c-4bba-95f4-5f3eca33bfdc"), new Guid("d2c8a028-72e2-43fd-9e6b-845051451901") },
                    { new Guid("98218d60-871c-4bba-95f4-5f3eca33bfdc"), new Guid("56f74a86-c9a5-4700-bf41-754db7a7a432") },
                    { new Guid("76826400-6497-4cfe-8e46-cb4a1e2cea2a"), new Guid("77f84b77-9d6c-42a3-bd77-46cd04465a47") },
                    { new Guid("3417e49d-ddc7-48ff-8f96-146cf349d9ed"), new Guid("77f84b77-9d6c-42a3-bd77-46cd04465a47") },
                    { new Guid("5a198a0c-e639-4bc0-8160-c114ccb9ecc4"), new Guid("cd9782b8-015e-4099-bdce-ab1e95b1dd37") },
                    { new Guid("85518b4d-918e-447b-847b-5769a2f919c9"), new Guid("77f84b77-9d6c-42a3-bd77-46cd04465a47") },
                    { new Guid("85518b4d-918e-447b-847b-5769a2f919c9"), new Guid("f8a15d32-4a87-44e8-836c-c5d119d28865") },
                    { new Guid("85518b4d-918e-447b-847b-5769a2f919c9"), new Guid("56f74a86-c9a5-4700-bf41-754db7a7a432") },
                    { new Guid("f34d6513-8899-4d9f-98d7-6d521f7c1f3e"), new Guid("f8bc440a-f47b-4376-8c83-2537a9e32afb") },
                    { new Guid("f34d6513-8899-4d9f-98d7-6d521f7c1f3e"), new Guid("cd9782b8-015e-4099-bdce-ab1e95b1dd37") },
                    { new Guid("28634eed-5342-4a54-bd55-957e8a0193f1"), new Guid("f8a15d32-4a87-44e8-836c-c5d119d28865") },
                    { new Guid("85518b4d-918e-447b-847b-5769a2f919c9"), new Guid("d2c8a028-72e2-43fd-9e6b-845051451901") }
                });

            migrationBuilder.InsertData(
                table: "MovieLentout",
                columns: new[] { "MovieId", "LentOutId" },
                values: new object[,]
                {
                    { new Guid("5a198a0c-e639-4bc0-8160-c114ccb9ecc4"), new Guid("f8ab5013-ef70-4cd6-8327-2c526beceb3b") },
                    { new Guid("5a198a0c-e639-4bc0-8160-c114ccb9ecc4"), new Guid("0855fe6f-1966-4c14-8a50-33d2f5924cd6") },
                    { new Guid("f34d6513-8899-4d9f-98d7-6d521f7c1f3e"), new Guid("d610ddc2-66e1-4c5e-840b-6174964d3a90") },
                    { new Guid("28634eed-5342-4a54-bd55-957e8a0193f1"), new Guid("0855fe6f-1966-4c14-8a50-33d2f5924cd6") },
                    { new Guid("9421dc55-90ae-4ceb-b7b8-9dd494feb850"), new Guid("0db643f3-115e-4c5e-b8f1-22e9e0b9659f") },
                    { new Guid("76826400-6497-4cfe-8e46-cb4a1e2cea2a"), new Guid("bcab7b0b-529a-4243-aac0-6a9daf3a63da") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenre_GenreId",
                table: "MovieGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieLentout_LentOutId",
                table: "MovieLentout",
                column: "LentOutId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DirectorId",
                table: "Movies",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProductionhouseId",
                table: "Movies",
                column: "ProductionhouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieGenre");

            migrationBuilder.DropTable(
                name: "MovieLentout");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "LentOuts");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Productionhouses");
        }
    }
}
