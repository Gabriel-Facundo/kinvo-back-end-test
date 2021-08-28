﻿// <auto-generated />
using System;
using Aliquota.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aliquota.Domain.Migrations
{
    [DbContext(typeof(AliquotaDomainContext))]
    partial class AliquotaDomainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Aliquota.Domain.Models.Investment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DayOfInvestment");

                    b.Property<double>("InitialAmount");

                    b.Property<string>("InvestorName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Investment");
                });
#pragma warning restore 612, 618
        }
    }
}
