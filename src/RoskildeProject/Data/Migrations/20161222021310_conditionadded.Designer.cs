﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RoskildeProject.Data;

namespace RoskildeProject.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20161222021310_conditionadded")]
    partial class conditionadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RoskildeProject.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("address");

                    b.Property<DateTime>("created_at");

                    b.Property<string>("fName");

                    b.Property<string>("lName");

                    b.Property<int>("postal");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("RoskildeProject.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("RoskildeProject.Models.Comment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("authorId");

                    b.Property<string>("commentText");

                    b.Property<DateTime>("created_at");

                    b.Property<int?>("itemid");

                    b.HasKey("id");

                    b.HasIndex("authorId");

                    b.HasIndex("itemid");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("RoskildeProject.Models.Condition", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("conditions");
                });

            modelBuilder.Entity("RoskildeProject.Models.DeliveryMethod", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("itemid");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.HasIndex("itemid");

                    b.ToTable("deliveryMethods");
                });

            modelBuilder.Entity("RoskildeProject.Models.Item", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("categoryid");

                    b.Property<int?>("conditionid");

                    b.Property<DateTime>("created_at");

                    b.Property<string>("creatorId");

                    b.Property<string>("description");

                    b.Property<double>("price");

                    b.Property<string>("title");

                    b.HasKey("id");

                    b.HasIndex("categoryid");

                    b.HasIndex("conditionid");

                    b.HasIndex("creatorId");

                    b.ToTable("items");
                });

            modelBuilder.Entity("RoskildeProject.Models.Picture", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("imagePath");

                    b.Property<int?>("itemid");

                    b.Property<string>("ownerId");

                    b.HasKey("id");

                    b.HasIndex("itemid");

                    b.HasIndex("ownerId");

                    b.ToTable("pictures");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RoskildeProject.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RoskildeProject.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RoskildeProject.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RoskildeProject.Models.Comment", b =>
                {
                    b.HasOne("RoskildeProject.Models.ApplicationUser", "author")
                        .WithMany()
                        .HasForeignKey("authorId");

                    b.HasOne("RoskildeProject.Models.Item", "item")
                        .WithMany("comments")
                        .HasForeignKey("itemid");
                });

            modelBuilder.Entity("RoskildeProject.Models.DeliveryMethod", b =>
                {
                    b.HasOne("RoskildeProject.Models.Item", "item")
                        .WithMany("deliveryMethods")
                        .HasForeignKey("itemid");
                });

            modelBuilder.Entity("RoskildeProject.Models.Item", b =>
                {
                    b.HasOne("RoskildeProject.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryid");

                    b.HasOne("RoskildeProject.Models.Condition", "condition")
                        .WithMany()
                        .HasForeignKey("conditionid");

                    b.HasOne("RoskildeProject.Models.ApplicationUser", "creator")
                        .WithMany()
                        .HasForeignKey("creatorId");
                });

            modelBuilder.Entity("RoskildeProject.Models.Picture", b =>
                {
                    b.HasOne("RoskildeProject.Models.Item", "item")
                        .WithMany("pictures")
                        .HasForeignKey("itemid");

                    b.HasOne("RoskildeProject.Models.ApplicationUser", "owner")
                        .WithMany()
                        .HasForeignKey("ownerId");
                });
        }
    }
}
