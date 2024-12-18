﻿// <auto-generated />
using System;
using MS3_LMS.LMSDbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MS3_LMS.Migrations
{
    [DbContext(typeof(LMSContext))]
    [Migration("20241214084737_final")]
    partial class final
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MS3_LMS.Enity.Book.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Book", b =>
                {
                    b.Property<Guid>("Bookid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BookType")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<Guid>("LanguageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<Guid>("PublisherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Bookid");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Genre", b =>
                {
                    b.Property<Guid>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BookGenre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = new Guid("7c1854e2-d122-49dc-b853-1d4ead61a4b7"),
                            BookGenre = "Fiction",
                            Description = "Fictional stories"
                        },
                        new
                        {
                            GenreId = new Guid("1dff11bd-d656-4471-a793-31694a962cc1"),
                            BookGenre = "Non Fiction",
                            Description = "Non-fictional content"
                        },
                        new
                        {
                            GenreId = new Guid("2f1bb645-62f0-4fb0-bed2-e57146c948e5"),
                            BookGenre = "Science Fiction",
                            Description = "Sci-fi stories"
                        },
                        new
                        {
                            GenreId = new Guid("164d21ee-8bb6-4aa6-a3cf-80058d7885a6"),
                            BookGenre = "Mystery",
                            Description = "Mystery novels"
                        },
                        new
                        {
                            GenreId = new Guid("dbfd4f20-96ab-4628-9481-3b02fc10a7a8"),
                            BookGenre = "Thriller",
                            Description = "Thrilling stories"
                        },
                        new
                        {
                            GenreId = new Guid("c0b4d23e-fae4-4fad-856c-02a8a44f1d54"),
                            BookGenre = "Romance Novel",
                            Description = "Romantic tales"
                        },
                        new
                        {
                            GenreId = new Guid("dbdaabed-f2c0-4435-bef3-82c14e1a7782"),
                            BookGenre = "Biography",
                            Description = "Life stories of individuals"
                        },
                        new
                        {
                            GenreId = new Guid("fdbc69da-ae21-4e57-906d-31f04bd5e792"),
                            BookGenre = "Humor",
                            Description = "Funny and comedic stories"
                        },
                        new
                        {
                            GenreId = new Guid("d7ab999e-18ff-416f-a846-f8da908aed8c"),
                            BookGenre = "Fairy Tale",
                            Description = "Fairy tales and folklore"
                        },
                        new
                        {
                            GenreId = new Guid("fa6236e5-299b-4ac7-8304-ac3fdf049253"),
                            BookGenre = "Graphic Novel",
                            Description = "Stories told through illustrations"
                        },
                        new
                        {
                            GenreId = new Guid("05dd32d6-48a4-4c03-b842-f456a83c2c6d"),
                            BookGenre = "True Crime",
                            Description = "Real-life crime stories"
                        },
                        new
                        {
                            GenreId = new Guid("3fd687c2-33f7-4bb0-9091-f5a6cf7fadf6"),
                            BookGenre = "Magical Realism",
                            Description = "Stories blending magic and realism"
                        });
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Image", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Bookid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image1Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Bookid")
                        .IsUnique();

                    b.ToTable("Images");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Language", b =>
                {
                    b.Property<Guid>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeOfLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageId");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            LanguageId = new Guid("8bf20707-3a95-40f6-989e-e1ccced664f8"),
                            TypeOfLanguage = "English"
                        },
                        new
                        {
                            LanguageId = new Guid("ccc5bc29-f3ca-46d7-8ef0-5f919d2609ec"),
                            TypeOfLanguage = "Tamil"
                        },
                        new
                        {
                            LanguageId = new Guid("59387b99-0c67-4545-b035-d3bf427912c6"),
                            TypeOfLanguage = "Singala"
                        });
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Publisher", b =>
                {
                    b.Property<Guid>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Rating", b =>
                {
                    b.Property<Guid>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Bookid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FeedBack")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MemebID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("StarCount")
                        .HasColumnType("int");

                    b.HasKey("RatingId");

                    b.HasIndex("Bookid");

                    b.HasIndex("MemebID");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.BookLend", b =>
                {
                    b.Property<Guid>("LendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ApprovedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Bookid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CollectDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LendDays")
                        .HasColumnType("int");

                    b.Property<Guid>("MemebID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("LendId");

                    b.HasIndex("Bookid");

                    b.HasIndex("MemebID");

                    b.ToTable("BookLends");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.Payment", b =>
                {
                    b.Property<Guid>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("SubId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("SubId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.Restriction", b =>
                {
                    b.Property<Guid>("ResId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsRestricted")
                        .HasColumnType("bit");

                    b.Property<Guid>("MemebID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResId");

                    b.HasIndex("MemebID")
                        .IsUnique();

                    b.ToTable("Restrictions");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.Subscription", b =>
                {
                    b.Property<Guid>("SubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCancel")
                        .HasColumnType("bit");

                    b.Property<Guid>("MemebID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SubType")
                        .HasColumnType("int");

                    b.HasKey("SubId");

                    b.HasIndex("MemebID");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Notification.Notification", b =>
                {
                    b.Property<Guid>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ReceiveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("ViewStatus")
                        .HasColumnType("bit");

                    b.HasKey("NotificationId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Notification.OTP", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("OTPCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("OTPs");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.Member", b =>
                {
                    b.Property<Guid>("MemebID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsVerify")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nic")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserGender")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MemebID");

                    b.HasIndex("Nic")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Members");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.Role", b =>
                {
                    b.Property<Guid>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserAType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleID = new Guid("5288926a-e074-467a-8950-ff28b46a680e"),
                            UserAType = "Member"
                        },
                        new
                        {
                            RoleID = new Guid("a4c03239-1ee4-4d0c-986c-999ed6afc1a4"),
                            UserAType = "Admin"
                        });
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirmEmail")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.UserRole", b =>
                {
                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleID");

                    b.HasIndex("RoleID");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Book", b =>
                {
                    b.HasOne("MS3_LMS.Enity.Book.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MS3_LMS.Enity.Book.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MS3_LMS.Enity.Book.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MS3_LMS.Enity.Book.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");

                    b.Navigation("Language");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Image", b =>
                {
                    b.HasOne("MS3_LMS.Enity.Book.Book", "Book")
                        .WithOne("Image")
                        .HasForeignKey("MS3_LMS.Enity.Book.Image", "Bookid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Rating", b =>
                {
                    b.HasOne("MS3_LMS.Enity.Book.Book", "Book")
                        .WithMany("Ratings")
                        .HasForeignKey("Bookid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MS3_LMS.Enity.User.Member", "Member")
                        .WithMany("Ratings")
                        .HasForeignKey("MemebID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.BookLend", b =>
                {
                    b.HasOne("MS3_LMS.Enity.Book.Book", "Book")
                        .WithMany()
                        .HasForeignKey("Bookid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MS3_LMS.Enity.User.Member", "Member")
                        .WithMany("BookLends")
                        .HasForeignKey("MemebID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.Payment", b =>
                {
                    b.HasOne("MS3_LMS.Enity.Core.Subscription", "Subscription")
                        .WithMany("Payment")
                        .HasForeignKey("SubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.Restriction", b =>
                {
                    b.HasOne("MS3_LMS.Enity.User.Member", "Member")
                        .WithOne("Restriction")
                        .HasForeignKey("MS3_LMS.Enity.Core.Restriction", "MemebID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.Subscription", b =>
                {
                    b.HasOne("MS3_LMS.Enity.User.Member", "Member")
                        .WithMany("Subscriptions")
                        .HasForeignKey("MemebID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Notification.OTP", b =>
                {
                    b.HasOne("MS3_LMS.Enity.User.User", "User")
                        .WithMany("OTPs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.Member", b =>
                {
                    b.HasOne("MS3_LMS.Enity.User.User", "User")
                        .WithOne("Member")
                        .HasForeignKey("MS3_LMS.Enity.User.Member", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.UserRole", b =>
                {
                    b.HasOne("MS3_LMS.Enity.User.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MS3_LMS.Enity.User.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Book", b =>
                {
                    b.Navigation("Image");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Language", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Book.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("MS3_LMS.Enity.Core.Subscription", b =>
                {
                    b.Navigation("Payment");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.Member", b =>
                {
                    b.Navigation("BookLends");

                    b.Navigation("Ratings");

                    b.Navigation("Restriction");

                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("MS3_LMS.Enity.User.User", b =>
                {
                    b.Navigation("Member");

                    b.Navigation("OTPs");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
