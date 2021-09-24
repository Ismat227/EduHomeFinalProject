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
    [Migration("20200705065755_RelationTeacherAndSkill")]
    partial class RelationTeacherAndSkill
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.HasIndex("SkillId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("BackendProject.Models.Teacher", b =>
                {
                    b.HasOne("BackendProject.Models.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
