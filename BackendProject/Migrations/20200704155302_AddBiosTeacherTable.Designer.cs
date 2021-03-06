// <auto-generated />
using BackendProject.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackendProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200704155302_AddBiosTeacherTable")]
    partial class AddBiosTeacherTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BackendProject.Models.BiosTeacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Facebook");

                    b.Property<string>("Pinterest");

                    b.Property<string>("Twitter");

                    b.Property<string>("Vimeo");

                    b.HasKey("Id");

                    b.ToTable("BiosTeachers");
                });

            modelBuilder.Entity("BackendProject.Models.Skills", b =>
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

            modelBuilder.Entity("BackendProject.Models.Teachers", b =>
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

                    b.Property<string>("Faculity")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<string>("Hobbies")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<string>("SkypeAddress");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("BackendProject.Models.TeacherSkills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SkillsId");

                    b.Property<int>("TeachersId");

                    b.HasKey("Id");

                    b.HasIndex("SkillsId");

                    b.HasIndex("TeachersId");

                    b.ToTable("TeacherSkills");
                });

            modelBuilder.Entity("BackendProject.Models.TeacherSkills", b =>
                {
                    b.HasOne("BackendProject.Models.Skills", "Skill")
                        .WithMany("TeacherSkills")
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BackendProject.Models.Teachers", "Teacher")
                        .WithMany("TeacherSkills")
                        .HasForeignKey("TeachersId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
