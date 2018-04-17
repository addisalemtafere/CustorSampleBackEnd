﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RecipesFinal.Data.Context;
using System;

namespace RecipesFinal.Migrations
{
    [DbContext(typeof(RecipeDatacontext))]
    [Migration("20180412072226_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RecipesFinal.Data.Model.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Sex");

                    b.HasKey("CustomerId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("RecipesFinal.Data.Model.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Amount");

                    b.Property<string>("Name");

                    b.Property<int?>("RecipeId");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("RecipesFinal.Data.Model.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ImagePath");

                    b.Property<string>("Name");

                    b.HasKey("RecipeId");

                    b.ToTable("recipes");
                });

            modelBuilder.Entity("RecipesFinal.Data.Model.Ingredient", b =>
                {
                    b.HasOne("RecipesFinal.Data.Model.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId");
                });
#pragma warning restore 612, 618
        }
    }
}
