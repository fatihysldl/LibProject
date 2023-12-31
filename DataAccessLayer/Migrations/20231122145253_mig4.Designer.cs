﻿// <auto-generated />
using DataAccessLayer.concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(context))]
    [Migration("20231122145253_mig4")]
    partial class mig4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.concrete.admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("AdminMail")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("AdminNick")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("AdminId");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("EntityLayer.concrete.book", b =>
                {
                    b.Property<int>("bookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bookId"));

                    b.Property<string>("bookName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("bookStock")
                        .HasColumnType("int");

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("bookId");

                    b.HasIndex("categoryId");

                    b.ToTable("books");
                });

            modelBuilder.Entity("EntityLayer.concrete.bookCategory", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("categoryId"));

                    b.Property<string>("category")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("categoryId");

                    b.ToTable("bookCategories");
                });

            modelBuilder.Entity("EntityLayer.concrete.borrowedBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("bookId")
                        .HasColumnType("int");

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<int>("memberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("bookId");

                    b.HasIndex("categoryId");

                    b.HasIndex("memberId");

                    b.ToTable("borrowedBooks");
                });

            modelBuilder.Entity("EntityLayer.concrete.member", b =>
                {
                    b.Property<int>("memberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("memberId"));

                    b.Property<string>("memberName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("memberPhone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("memberSurname")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("memberId");

                    b.ToTable("members");
                });

            modelBuilder.Entity("EntityLayer.concrete.book", b =>
                {
                    b.HasOne("EntityLayer.concrete.bookCategory", "category")
                        .WithMany()
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("EntityLayer.concrete.borrowedBook", b =>
                {
                    b.HasOne("EntityLayer.concrete.book", "book")
                        .WithMany()
                        .HasForeignKey("bookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.concrete.bookCategory", "category")
                        .WithMany()
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.concrete.member", "member")
                        .WithMany()
                        .HasForeignKey("memberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");

                    b.Navigation("category");

                    b.Navigation("member");
                });
#pragma warning restore 612, 618
        }
    }
}
