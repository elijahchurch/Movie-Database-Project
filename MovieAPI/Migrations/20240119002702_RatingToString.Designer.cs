﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApi.Models;

#nullable disable

namespace MovieApi.Migrations
{
    [DbContext(typeof(MovieApiContext))]
    [Migration("20240119002702_RatingToString")]
    partial class RatingToString
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MovieApi.Models.CoverPhoto", b =>
                {
                    b.Property<int>("CoverPhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("longtext");

                    b.HasKey("CoverPhotoId");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.ToTable("CoverPhotos");
                });

            modelBuilder.Entity("MovieApi.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Date")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("OverView")
                        .HasColumnType("longtext");

                    b.Property<string>("Rating")
                        .HasColumnType("longtext");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieApi.Models.Poster", b =>
                {
                    b.Property<int>("PosterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("longtext");

                    b.HasKey("PosterId");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.ToTable("Posters");
                });

            modelBuilder.Entity("MovieApi.Models.CoverPhoto", b =>
                {
                    b.HasOne("MovieApi.Models.Movie", "Movie")
                        .WithOne("CoverPhoto")
                        .HasForeignKey("MovieApi.Models.CoverPhoto", "MovieId");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieApi.Models.Poster", b =>
                {
                    b.HasOne("MovieApi.Models.Movie", "Movie")
                        .WithOne("Poster")
                        .HasForeignKey("MovieApi.Models.Poster", "MovieId");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieApi.Models.Movie", b =>
                {
                    b.Navigation("CoverPhoto");

                    b.Navigation("Poster");
                });
#pragma warning restore 612, 618
        }
    }
}
