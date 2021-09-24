﻿// <auto-generated />
using BackendProject.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackendProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200705162945_UpdateBlog")]
    partial class UpdateBlog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BackendProject.Models.Bio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Facebook");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Pinterest");

                    b.Property<string>("Site");

                    b.Property<string>("Twitter");

                    b.Property<string>("Vimeo");

                    b.HasKey("Id");

                    b.ToTable("Bios");
                });

            modelBuilder.Entity("BackendProject.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName");

                    b.Property<string>("BlogBody");

                    b.Property<string>("Date");

                    b.Property<string>("Explain");

                    b.Property<string>("Image");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("BackendProject.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Description");

                    b.Property<string>("Image")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("BackendProject.Models.CourseContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About");

                    b.Property<string>("Certification");

                    b.Property<int>("CourseId");

                    b.Property<string>("HowToApply");

                    b.HasKey("Id");

                    b.HasIndex("CourseId")
                        .IsUnique();

                    b.ToTable("CourseContents");
                });

            modelBuilder.Entity("BackendProject.Models.CourseFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Assement")
                        .IsRequired();

                    b.Property<string>("ClassDuration")
                        .IsRequired();

                    b.Property<decimal>("CourseFee");

                    b.Property<int>("CourseId");

                    b.Property<string>("Duration")
                        .IsRequired();

                    b.Property<string>("Language")
                        .IsRequired();

                    b.Property<string>("Sarts")
                        .IsRequired();

                    b.Property<string>("SkillLevel");

                    b.Property<int>("StudentCount");

                    b.HasKey("Id");

                    b.HasIndex("CourseId")
                        .IsUnique();

                    b.ToTable("CourseFeatures");
                });

            modelBuilder.Entity("BackendProject.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Communication");

                    b.Property<int>("Design");

                    b.Property<int>("Development");

                    b.Property<int>("Innovation");

                    b.Property<int>("Language");

                    b.Property<int>("TeamLeader");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("BackendProject.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Facebook")
                        .IsRequired();

                    b.Property<string>("Faculity")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<string>("Hobbies")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Pinterest")
                        .IsRequired();

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<int>("SkillId");

                    b.Property<string>("SkypeAddress");

                    b.Property<string>("Twitter")
                        .IsRequired();

                    b.Property<string>("Vimeo")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("SkillId")
                        .IsUnique();

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("BackendProject.Models.CourseContent", b =>
                {
                    b.HasOne("BackendProject.Models.Course", "Course")
                        .WithOne("CourseContent")
                        .HasForeignKey("BackendProject.Models.CourseContent", "CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BackendProject.Models.CourseFeature", b =>
                {
                    b.HasOne("BackendProject.Models.Course", "Course")
                        .WithOne("CourseFeature")
                        .HasForeignKey("BackendProject.Models.CourseFeature", "CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BackendProject.Models.Teacher", b =>
                {
                    b.HasOne("BackendProject.Models.Skill", "Skill")
                        .WithOne("Teacher")
                        .HasForeignKey("BackendProject.Models.Teacher", "SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
