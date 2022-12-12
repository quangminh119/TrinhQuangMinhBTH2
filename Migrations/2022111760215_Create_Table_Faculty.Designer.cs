using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrinhQuangMinhBTH2.Data;

#nullable disable

namespace TrinhQuangMinhBTH2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221117160215_Create_Table_Faculty")]
    partial class Create_Table_Faculty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("TranBaVuBTH2.Models.Customer", b =>
            {
                b.Property<string>("CustomerID")
                    .HasColumnType("TEXT");

                b.Property<string>("CustomerAddress")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("CustomerName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("CustomerPhone")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("CustomerID");

                b.ToTable("Customers");
            });

            modelBuilder.Entity("TranBaVuBTH2.Models.Employee", b =>
            {
                b.Property<string>("EmployeeID")
                    .HasColumnType("TEXT");

                b.Property<string>("EmployeeAddress")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("EmployeeEmail")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("EmployeeName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("EmployeePhone")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("EmployeeID");

                b.ToTable("Employees");
            });

            modelBuilder.Entity("TranBaVuBTH2.Models.Faculty", b =>
            {
                b.Property<string>("FacultyID")
                    .HasColumnType("TEXT");

                b.Property<string>("FacultyName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("FacultyID");

                b.ToTable("Faculties");
            });

            modelBuilder.Entity("TranBaVuBTH2.Models.Person", b =>
            {
                b.Property<string>("PersonID")
                    .HasColumnType("TEXT");

                b.Property<string>("Height")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("PersonName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Weight")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("PersonID");

                b.ToTable("People");
            });

            modelBuilder.Entity("TranBaVuBTH2.Models.Student", b =>
            {
                b.Property<string>("StudentID")
                    .HasColumnType("TEXT");

                b.Property<string>("FacultyID")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("StudentName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("StudentID");

                b.HasIndex("FacultyID");

                b.ToTable("Students");
            });

            modelBuilder.Entity("TranBaVuBTH2.Models.Student", b =>
            {
                b.HasOne("TranBaVuBTH2.Models.Faculty", "Faculty")
                    .WithMany()
                    .HasForeignKey("FacultyID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Faculty");
            });

        }
    }
}