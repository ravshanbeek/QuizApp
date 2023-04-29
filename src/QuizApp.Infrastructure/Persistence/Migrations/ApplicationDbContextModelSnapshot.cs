﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizApp.Infrastructure.Persistence;

#nullable disable

namespace QuizApp.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExamQuestion", b =>
                {
                    b.Property<Guid>("ExamsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QuestionsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ExamsId", "QuestionsId");

                    b.HasIndex("QuestionsId");

                    b.ToTable("ExamQuestion");
                });

            modelBuilder.Entity("QuestionTag", b =>
                {
                    b.Property<Guid>("QuestionsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("QuestionsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("QuestionTag");
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.AttendantAnswer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExamAttendantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ExamAttendantId");

                    b.HasIndex("ExamId");

                    b.HasIndex("OptionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("AttendantAnswers", (string)null);
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.Exam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Duration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndsAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("QuestionCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TesterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TesterId");

                    b.ToTable("Exams", (string)null);
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.ExamAttendant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.ToTable("ExamAttendants", (string)null);
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.OtpCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("OtpCodes", (string)null);
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Questions", (string)null);
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.QuestionOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionOptions", (string)null);
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TesterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TesterId");

                    b.ToTable("Tags", (string)null);
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Phone")
                        .IsUnique();

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("ExamQuestion", b =>
                {
                    b.HasOne("QuizApp.Domain.Entities.Exam", null)
                        .WithMany()
                        .HasForeignKey("ExamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizApp.Domain.Entities.Question", null)
                        .WithMany()
                        .HasForeignKey("QuestionsId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("QuestionTag", b =>
                {
                    b.HasOne("QuizApp.Domain.Entities.Question", null)
                        .WithMany()
                        .HasForeignKey("QuestionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizApp.Domain.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.AttendantAnswer", b =>
                {
                    b.HasOne("QuizApp.Domain.Entities.ExamAttendant", "ExamAttendant")
                        .WithMany("AttendantAnswers")
                        .HasForeignKey("ExamAttendantId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("QuizApp.Domain.Entities.Exam", "Exam")
                        .WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizApp.Domain.Entities.QuestionOption", "Option")
                        .WithMany("AttendantAnswers")
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("QuizApp.Domain.Entities.Question", "Question")
                        .WithMany("AttendantAnswers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("ExamAttendant");

                    b.Navigation("Option");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.Exam", b =>
                {
                    b.HasOne("QuizApp.Domain.Entities.User", "Tester")
                        .WithMany("Exams")
                        .HasForeignKey("TesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tester");
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.ExamAttendant", b =>
                {
                    b.HasOne("QuizApp.Domain.Entities.Exam", "Exam")
                        .WithMany("Attendants")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.OtpCode", b =>
                {
                    b.HasOne("QuizApp.Domain.Entities.User", "User")
                        .WithMany("OtpCodes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.Question", b =>
                {
                    b.HasOne("QuizApp.Domain.Entities.User", "Tester")
                        .WithMany("Questions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tester");
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.QuestionOption", b =>
                {
                    b.HasOne("QuizApp.Domain.Entities.Question", "Question")
                        .WithMany("QuestionOptions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.Tag", b =>
                {
                    b.HasOne("QuizApp.Domain.Entities.User", "User")
                        .WithMany("Tags")
                        .HasForeignKey("TesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.Exam", b =>
                {
                    b.Navigation("Attendants");
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.ExamAttendant", b =>
                {
                    b.Navigation("AttendantAnswers");
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.Question", b =>
                {
                    b.Navigation("AttendantAnswers");

                    b.Navigation("QuestionOptions");
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.QuestionOption", b =>
                {
                    b.Navigation("AttendantAnswers");
                });

            modelBuilder.Entity("QuizApp.Domain.Entities.User", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("OtpCodes");

                    b.Navigation("Questions");

                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
