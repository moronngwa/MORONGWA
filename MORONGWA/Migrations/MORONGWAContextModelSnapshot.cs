﻿// <auto-generated />
using MORONGWA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MORONGWA.Migrations
{
    [DbContext(typeof(MORONGWAContext))]
    partial class MORONGWAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MORONGWA.Models.Courses", b =>
                {
                    b.Property<long>("CoursesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CoursesId"));

                    b.Property<string>("CoursesDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoursesName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoursesId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("MORONGWA.Models.Facilitators", b =>
                {
                    b.Property<long>("FacilitatorsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("FacilitatorsId"));

                    b.Property<string>("FacilitatorsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacilitatorsSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacilitatorsId");

                    b.ToTable("Facilitators");
                });

            modelBuilder.Entity("MORONGWA.Models.Learners", b =>
                {
                    b.Property<long>("LearnersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("LearnersId"));

                    b.Property<long>("LearnersIdentityNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("LearnersName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearnersSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LearnersId");

                    b.ToTable("Learners");
                });
#pragma warning restore 612, 618
        }
    }
}
