﻿// <auto-generated />
using System;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210401195850_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Director", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3868b15c-93af-44fa-a147-6214358982e6"),
                            Name = "Chris Buck"
                        },
                        new
                        {
                            Id = new Guid("a3da4185-e74f-47e8-9af2-4753cf728ab6"),
                            Name = "James Wan"
                        },
                        new
                        {
                            Id = new Guid("d71f81c0-2ffa-49fc-9963-7d0aa57a4c9a"),
                            Name = "Mike Mitchell"
                        },
                        new
                        {
                            Id = new Guid("f2842d85-39a7-429c-8ae1-81a3174629dd"),
                            Name = "Marco Brambilla"
                        },
                        new
                        {
                            Id = new Guid("cb21d286-2eb3-4caf-a0e2-4385493925d1"),
                            Name = "Peter Jackson"
                        },
                        new
                        {
                            Id = new Guid("ef26c1b5-5180-4831-b597-982bbbaba5f0"),
                            Name = "John Cohen"
                        },
                        new
                        {
                            Id = new Guid("d0f18cc5-1344-4502-abb1-80d836e9e7da"),
                            Name = "Bryan Singer"
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("56f74a86-c9a5-4700-bf41-754db7a7a432"),
                            Name = "Animation"
                        },
                        new
                        {
                            Id = new Guid("f8bc440a-f47b-4376-8c83-2537a9e32afb"),
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = new Guid("cd9782b8-015e-4099-bdce-ab1e95b1dd37"),
                            Name = "Horror"
                        },
                        new
                        {
                            Id = new Guid("d2c8a028-72e2-43fd-9e6b-845051451901"),
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = new Guid("2a11f3de-7052-43e9-86a0-529f01de586a"),
                            Name = "Action"
                        },
                        new
                        {
                            Id = new Guid("eecba59f-dc81-4b60-b677-84aa3088f8fb"),
                            Name = "Family"
                        },
                        new
                        {
                            Id = new Guid("f8a15d32-4a87-44e8-836c-c5d119d28865"),
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = new Guid("1dc8342d-057c-4e8c-b15a-a413ca9eaa6d"),
                            Name = "Sci-Fi"
                        },
                        new
                        {
                            Id = new Guid("e11caf64-8647-4472-b5ea-c1498b04e1d9"),
                            Name = "Ramance"
                        },
                        new
                        {
                            Id = new Guid("77f84b77-9d6c-42a3-bd77-46cd04465a47"),
                            Name = "Fantasy"
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.LentOut", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LentOuts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0db643f3-115e-4c5e-b8f1-22e9e0b9659f"),
                            Name = "Brendy"
                        },
                        new
                        {
                            Id = new Guid("f8ab5013-ef70-4cd6-8327-2c526beceb3b"),
                            Name = "Steve"
                        },
                        new
                        {
                            Id = new Guid("d610ddc2-66e1-4c5e-840b-6174964d3a90"),
                            Name = "Imana"
                        },
                        new
                        {
                            Id = new Guid("5779b386-192f-45f0-a77c-e0c3ada65801"),
                            Name = "Amalia"
                        },
                        new
                        {
                            Id = new Guid("0855fe6f-1966-4c14-8a50-33d2f5924cd6"),
                            Name = "Sharona"
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DirectorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductionhouseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearRealase")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.HasIndex("ProductionhouseId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("28634eed-5342-4a54-bd55-957e8a0193f1"),
                            DirectorId = new Guid("3868b15c-93af-44fa-a147-6214358982e6"),
                            Image = "https://www.moviemeter.nl/images/cover/1123000/1123486.jpg?cb=1572281329",
                            ProductionhouseId = new Guid("1194f1d0-cc0a-41b8-9b9b-43e9d83d3bcf"),
                            Title = "Frozen 2",
                            YearRealase = 2019
                        },
                        new
                        {
                            Id = new Guid("f34d6513-8899-4d9f-98d7-6d521f7c1f3e"),
                            DirectorId = new Guid("a3da4185-e74f-47e8-9af2-4753cf728ab6"),
                            Image = "https://1.bp.blogspot.com/-Gi_sYA5EeOc/XxnkznABTII/AAAAAAAADVo/v1np_MuLBpELyHgf5AwEyHDYhlR1V9v_ACLcBGAsYHQ/s1600/The%2BConjuring%2B2013.jpg",
                            ProductionhouseId = new Guid("6e835b5a-699e-49cd-b330-d4214ea37e86"),
                            Title = "The Conjouring",
                            YearRealase = 2013
                        },
                        new
                        {
                            Id = new Guid("85518b4d-918e-447b-847b-5769a2f919c9"),
                            DirectorId = new Guid("d71f81c0-2ffa-49fc-9963-7d0aa57a4c9a"),
                            Image = "http://4.bp.blogspot.com/-wuPeTulesvs/VijDC-98v1I/AAAAAAAAALQ/xjD6dzeVFlQ/s1600/shrek_forever_after_2010-movie-poster_1371176093.jpg",
                            ProductionhouseId = new Guid("38df2e17-c2ba-49e1-8f83-16d1b070c96c"),
                            Title = "Shrek voor eeuwig en altijd",
                            YearRealase = 2010
                        },
                        new
                        {
                            Id = new Guid("3417e49d-ddc7-48ff-8f96-146cf349d9ed"),
                            DirectorId = new Guid("f2842d85-39a7-429c-8ae1-81a3174629dd"),
                            Image = "http://www.moriareviews.com/rongulator/wp-content/uploads/Dinotopia-2002-poster.jpg",
                            ProductionhouseId = new Guid("d09684c4-0097-4d14-85a6-5523f30f4360"),
                            Title = "Dinotopia",
                            YearRealase = 2002
                        },
                        new
                        {
                            Id = new Guid("5a198a0c-e639-4bc0-8160-c114ccb9ecc4"),
                            DirectorId = new Guid("a3da4185-e74f-47e8-9af2-4753cf728ab6"),
                            Image = "https://heyitsbenito.files.wordpress.com/2013/10/insidious_2010_3.jpg",
                            ProductionhouseId = new Guid("a78c00a4-36e9-460a-9e52-eef287bf2977"),
                            Title = "Insidious",
                            YearRealase = 2010
                        },
                        new
                        {
                            Id = new Guid("76826400-6497-4cfe-8e46-cb4a1e2cea2a"),
                            DirectorId = new Guid("cb21d286-2eb3-4caf-a0e2-4385493925d1"),
                            Image = "https://www.newdvdreleasedates.com/images/posters/large/the-hobbit-an-unexpected-journey-2012-5.jpg",
                            ProductionhouseId = new Guid("272a59bb-9de3-4237-9417-183fc3128c98"),
                            Title = "The Hobbit",
                            YearRealase = 2012
                        },
                        new
                        {
                            Id = new Guid("98218d60-871c-4bba-95f4-5f3eca33bfdc"),
                            DirectorId = new Guid("ef26c1b5-5180-4831-b597-982bbbaba5f0"),
                            Image = "https://fanart.tv/fanart/movies/153518/movieposter/angry-birds-57529afceafe7.jpg",
                            ProductionhouseId = new Guid("cd8a9b27-8e95-4407-ad81-e277d15f03ae"),
                            Title = "The Angry Birds",
                            YearRealase = 2016
                        },
                        new
                        {
                            Id = new Guid("9421dc55-90ae-4ceb-b7b8-9dd494feb850"),
                            DirectorId = new Guid("d0f18cc5-1344-4502-abb1-80d836e9e7da"),
                            Image = "https://upload.wikimedia.org/wikipedia/pt/f/f8/X-Men_Dias_Futuro_Esquecido_2014.jpg",
                            ProductionhouseId = new Guid("64b4720b-d751-4d14-bbd1-a51807be65b8"),
                            Title = "X-men: Days of future past",
                            YearRealase = 2014
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.MovieGenre", b =>
                {
                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("MovieGenre");

                    b.HasData(
                        new
                        {
                            MovieId = new Guid("28634eed-5342-4a54-bd55-957e8a0193f1"),
                            GenreId = new Guid("56f74a86-c9a5-4700-bf41-754db7a7a432")
                        },
                        new
                        {
                            MovieId = new Guid("28634eed-5342-4a54-bd55-957e8a0193f1"),
                            GenreId = new Guid("f8a15d32-4a87-44e8-836c-c5d119d28865")
                        },
                        new
                        {
                            MovieId = new Guid("f34d6513-8899-4d9f-98d7-6d521f7c1f3e"),
                            GenreId = new Guid("cd9782b8-015e-4099-bdce-ab1e95b1dd37")
                        },
                        new
                        {
                            MovieId = new Guid("f34d6513-8899-4d9f-98d7-6d521f7c1f3e"),
                            GenreId = new Guid("f8bc440a-f47b-4376-8c83-2537a9e32afb")
                        },
                        new
                        {
                            MovieId = new Guid("85518b4d-918e-447b-847b-5769a2f919c9"),
                            GenreId = new Guid("56f74a86-c9a5-4700-bf41-754db7a7a432")
                        },
                        new
                        {
                            MovieId = new Guid("85518b4d-918e-447b-847b-5769a2f919c9"),
                            GenreId = new Guid("f8a15d32-4a87-44e8-836c-c5d119d28865")
                        },
                        new
                        {
                            MovieId = new Guid("85518b4d-918e-447b-847b-5769a2f919c9"),
                            GenreId = new Guid("77f84b77-9d6c-42a3-bd77-46cd04465a47")
                        },
                        new
                        {
                            MovieId = new Guid("85518b4d-918e-447b-847b-5769a2f919c9"),
                            GenreId = new Guid("d2c8a028-72e2-43fd-9e6b-845051451901")
                        },
                        new
                        {
                            MovieId = new Guid("3417e49d-ddc7-48ff-8f96-146cf349d9ed"),
                            GenreId = new Guid("77f84b77-9d6c-42a3-bd77-46cd04465a47")
                        },
                        new
                        {
                            MovieId = new Guid("5a198a0c-e639-4bc0-8160-c114ccb9ecc4"),
                            GenreId = new Guid("cd9782b8-015e-4099-bdce-ab1e95b1dd37")
                        },
                        new
                        {
                            MovieId = new Guid("76826400-6497-4cfe-8e46-cb4a1e2cea2a"),
                            GenreId = new Guid("f8a15d32-4a87-44e8-836c-c5d119d28865")
                        },
                        new
                        {
                            MovieId = new Guid("76826400-6497-4cfe-8e46-cb4a1e2cea2a"),
                            GenreId = new Guid("77f84b77-9d6c-42a3-bd77-46cd04465a47")
                        },
                        new
                        {
                            MovieId = new Guid("98218d60-871c-4bba-95f4-5f3eca33bfdc"),
                            GenreId = new Guid("56f74a86-c9a5-4700-bf41-754db7a7a432")
                        },
                        new
                        {
                            MovieId = new Guid("98218d60-871c-4bba-95f4-5f3eca33bfdc"),
                            GenreId = new Guid("d2c8a028-72e2-43fd-9e6b-845051451901")
                        },
                        new
                        {
                            MovieId = new Guid("9421dc55-90ae-4ceb-b7b8-9dd494feb850"),
                            GenreId = new Guid("2a11f3de-7052-43e9-86a0-529f01de586a")
                        },
                        new
                        {
                            MovieId = new Guid("9421dc55-90ae-4ceb-b7b8-9dd494feb850"),
                            GenreId = new Guid("f8a15d32-4a87-44e8-836c-c5d119d28865")
                        },
                        new
                        {
                            MovieId = new Guid("9421dc55-90ae-4ceb-b7b8-9dd494feb850"),
                            GenreId = new Guid("77f84b77-9d6c-42a3-bd77-46cd04465a47")
                        },
                        new
                        {
                            MovieId = new Guid("9421dc55-90ae-4ceb-b7b8-9dd494feb850"),
                            GenreId = new Guid("1dc8342d-057c-4e8c-b15a-a413ca9eaa6d")
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.MovieLentout", b =>
                {
                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LentOutId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MovieId", "LentOutId");

                    b.HasIndex("LentOutId");

                    b.ToTable("MovieLentout");

                    b.HasData(
                        new
                        {
                            MovieId = new Guid("28634eed-5342-4a54-bd55-957e8a0193f1"),
                            LentOutId = new Guid("0855fe6f-1966-4c14-8a50-33d2f5924cd6")
                        },
                        new
                        {
                            MovieId = new Guid("f34d6513-8899-4d9f-98d7-6d521f7c1f3e"),
                            LentOutId = new Guid("d610ddc2-66e1-4c5e-840b-6174964d3a90")
                        },
                        new
                        {
                            MovieId = new Guid("9421dc55-90ae-4ceb-b7b8-9dd494feb850"),
                            LentOutId = new Guid("0db643f3-115e-4c5e-b8f1-22e9e0b9659f")
                        },
                        new
                        {
                            MovieId = new Guid("5a198a0c-e639-4bc0-8160-c114ccb9ecc4"),
                            LentOutId = new Guid("f8ab5013-ef70-4cd6-8327-2c526beceb3b")
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Productionhouse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Headquarters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Productionhouses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1194f1d0-cc0a-41b8-9b9b-43e9d83d3bcf"),
                            Headquarters = "Burbank, Californië",
                            Name = "Disney"
                        },
                        new
                        {
                            Id = new Guid("6e835b5a-699e-49cd-b330-d4214ea37e86"),
                            Headquarters = "Hollywood",
                            Name = "New Line Cinema"
                        },
                        new
                        {
                            Id = new Guid("38df2e17-c2ba-49e1-8f83-16d1b070c96c"),
                            Headquarters = "Rendwoon City, Califorië",
                            Name = "DreamWorks Animation"
                        },
                        new
                        {
                            Id = new Guid("d09684c4-0097-4d14-85a6-5523f30f4360"),
                            Headquarters = "Cologne, Germany",
                            Name = "RTL Television Germany"
                        },
                        new
                        {
                            Id = new Guid("a78c00a4-36e9-460a-9e52-eef287bf2977"),
                            Headquarters = "Los Angeles, Califorië",
                            Name = "BlumHouse Productions"
                        },
                        new
                        {
                            Id = new Guid("cd8a9b27-8e95-4407-ad81-e277d15f03ae"),
                            Headquarters = "Culver City, Californië",
                            Name = "Columbia Pictures"
                        },
                        new
                        {
                            Id = new Guid("64b4720b-d751-4d14-bbd1-a51807be65b8"),
                            Headquarters = "Century City, Los Angeles",
                            Name = "20th Century Studios"
                        },
                        new
                        {
                            Id = new Guid("272a59bb-9de3-4237-9417-183fc3128c98"),
                            Headquarters = "Burbank, Californië",
                            Name = "Warner Bros"
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Movie", b =>
                {
                    b.HasOne("Imi.Project.Api.Core.Entities.Director", null)
                        .WithMany("Movies")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Imi.Project.Api.Core.Entities.Productionhouse", null)
                        .WithMany("Movies")
                        .HasForeignKey("ProductionhouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.MovieGenre", b =>
                {
                    b.HasOne("Imi.Project.Api.Core.Entities.Genre", "Genre")
                        .WithMany("MovieGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Imi.Project.Api.Core.Entities.Movie", "Movie")
                        .WithMany("MovieGenres")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.MovieLentout", b =>
                {
                    b.HasOne("Imi.Project.Api.Core.Entities.LentOut", "LentOut")
                        .WithMany("MovieLentouts")
                        .HasForeignKey("LentOutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Imi.Project.Api.Core.Entities.Movie", "Movie")
                        .WithMany("MovieLentouts")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}