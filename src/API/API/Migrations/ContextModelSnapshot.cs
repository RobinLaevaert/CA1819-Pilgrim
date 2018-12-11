﻿// <auto-generated />
using System;
using DataLinkLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLinkLayer.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer");

                    b.Property<string>("CrypticClue");

                    b.Property<string>("Description");

                    b.Property<string>("Hint1");

                    b.Property<string>("Hint2");

                    b.Property<double?>("Lat");

                    b.Property<double?>("Long");

                    b.Property<string>("Naam");

                    b.Property<int?>("PilgrimageID");

                    b.HasKey("ID");

                    b.HasIndex("PilgrimageID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DataLinkLayer.Models.Pilgrimage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("StartTime");

                    b.Property<int>("Time");

                    b.HasKey("ID");

                    b.ToTable("Pilgrimages");
                });

            modelBuilder.Entity("DataLinkLayer.Models.Profile", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("DateCreated");

                    b.Property<long>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("NickName");

                    b.Property<byte[]>("ProfilePicture");

                    b.Property<string>("base64");

                    b.Property<string>("fireBaseID");

                    b.HasKey("ID");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("DataLinkLayer.Models.Location", b =>
                {
                    b.HasOne("DataLinkLayer.Models.Pilgrimage")
                        .WithMany("Locations")
                        .HasForeignKey("PilgrimageID");
                });
#pragma warning restore 612, 618
        }
    }
}
