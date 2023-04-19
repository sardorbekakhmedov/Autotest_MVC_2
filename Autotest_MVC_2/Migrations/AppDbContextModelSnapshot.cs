﻿// <auto-generated />
using System;
using Autotest_MVC_2.DataDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Autotest_MVC_2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Auto_test.Library.Models.Tickets.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"), 1L, 1);

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentQuestionIndex")
                        .HasColumnType("int");

                    b.Property<int>("QuestionsCount")
                        .HasColumnType("int");

                    b.Property<int>("StarQuestionIndex")
                        .HasColumnType("int");

                    b.Property<int>("TicketIndex")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TicketId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Auto_test.Library.Models.Tickets.TicketQuestionAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ChoiceIndex")
                        .HasColumnType("int");

                    b.Property<int>("CorrectAnswerIndex")
                        .HasColumnType("int");

                    b.Property<int>("QuestionIndex")
                        .HasColumnType("int");

                    b.Property<int?>("TicketId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.ToTable("TicketQuestionAnswers");
                });

            modelBuilder.Entity("Auto_test.Library.Models.UserModels.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CurrentTicketIndex")
                        .HasColumnType("int");

                    b.Property<int?>("CurrentTicketTicketId")
                        .HasColumnType("int");

                    b.Property<int>("ExamCurrentTicketIndex")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsCompletedTicketCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsExam")
                        .HasColumnType("bit");

                    b.Property<int>("TotalCorrectAnswerCount")
                        .HasColumnType("int");

                    b.Property<string>("UserEmailOrPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("CurrentTicketTicketId");

                    b.ToTable("AllUsers");
                });

            modelBuilder.Entity("Auto_test.Library.Models.Tickets.Ticket", b =>
                {
                    b.HasOne("Auto_test.Library.Models.UserModels.User", null)
                        .WithMany("UserTickets")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Auto_test.Library.Models.Tickets.TicketQuestionAnswer", b =>
                {
                    b.HasOne("Auto_test.Library.Models.Tickets.Ticket", null)
                        .WithMany("TicketAnswers")
                        .HasForeignKey("TicketId");
                });

            modelBuilder.Entity("Auto_test.Library.Models.UserModels.User", b =>
                {
                    b.HasOne("Auto_test.Library.Models.Tickets.Ticket", "CurrentTicket")
                        .WithMany()
                        .HasForeignKey("CurrentTicketTicketId");

                    b.Navigation("CurrentTicket");
                });

            modelBuilder.Entity("Auto_test.Library.Models.Tickets.Ticket", b =>
                {
                    b.Navigation("TicketAnswers");
                });

            modelBuilder.Entity("Auto_test.Library.Models.UserModels.User", b =>
                {
                    b.Navigation("UserTickets");
                });
#pragma warning restore 612, 618
        }
    }
}
