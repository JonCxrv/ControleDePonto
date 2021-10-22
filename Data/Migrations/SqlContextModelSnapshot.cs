﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(SqlContext))]
    partial class SqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Collaborator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Active")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Active");

                    b.Property<string>("Assignment")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Assignment");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(14)")
                        .HasColumnName("CPF");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Email");

                    b.Property<string>("HiringType")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Hiring Type");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Phone");

                    b.Property<string>("Vacations")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Vacations");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Collaborator");
                });

            modelBuilder.Entity("Domain.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("CNPJ");

                    b.Property<string>("CorporateName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("CorporateName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("Project")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Project");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Domain.Entities.Dashboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Balance")
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Balance");

                    b.Property<int>("CollaboratorId")
                        .HasColumnType("int");

                    b.Property<int>("Workload")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Workload");

                    b.HasKey("Id");

                    b.HasIndex("CollaboratorId");

                    b.ToTable("Dashboard");
                });

            modelBuilder.Entity("Domain.Entities.HappyFriday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CollaboratorId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("HappyFridayDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CollaboratorId");

                    b.HasIndex("CompanyId");

                    b.ToTable("HappyFridays");
                });

            modelBuilder.Entity("Domain.Entities.Schedules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CollaboratorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Departure Time");

                    b.Property<DateTime>("Entry")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Entry Time");

                    b.Property<DateTime>("LunchTime")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Lunch Time");

                    b.Property<DateTime>("ReturnLunchTime")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Lunch Return Time");

                    b.Property<double>("WorkedHours")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CollaboratorId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Domain.Entities.Collaborator", b =>
                {
                    b.HasOne("Domain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Domain.Entities.Dashboard", b =>
                {
                    b.HasOne("Domain.Entities.Collaborator", "Collaborator")
                        .WithMany()
                        .HasForeignKey("CollaboratorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collaborator");
                });

            modelBuilder.Entity("Domain.Entities.HappyFriday", b =>
                {
                    b.HasOne("Domain.Entities.Collaborator", "Collaborator")
                        .WithMany()
                        .HasForeignKey("CollaboratorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collaborator");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Domain.Entities.Schedules", b =>
                {
                    b.HasOne("Domain.Entities.Collaborator", "Collaborator")
                        .WithMany()
                        .HasForeignKey("CollaboratorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collaborator");
                });
#pragma warning restore 612, 618
        }
    }
}
