﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizApp.Domain.Entities;

namespace QuizApp.Infrastructure.Persistence.Configurations;
public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder
            .ToTable("Questions");

        builder
            .HasKey(question => question.Id);

        builder
            .Property(question => question.Type)
            .IsRequired(true);

        builder
            .Property(question => question.Level)
            .IsRequired(true);

        builder.Property(question => question.Content)
            .IsRequired(true);

        builder
            .Property(question => question.CreatedAt)
            .IsRequired(true);

        builder
            .HasOne(question => question.Tester)
            .WithMany(user => user.Questions)
            .HasForeignKey(question => question.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
