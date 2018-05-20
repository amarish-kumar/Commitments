﻿// <auto-generated />
using System;
using Commitments.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Commitments.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180520133558_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview2-30571")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Commitments.Core.Entities.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BehaviourId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<DateTime>("PerformedOn");

                    b.Property<int>("ProfileId");

                    b.HasKey("ActivityId");

                    b.HasIndex("BehaviourId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Commitments.Core.Entities.Behaviour", b =>
                {
                    b.Property<int>("BehaviourId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BehaviourTypeId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("Name");

                    b.Property<int?>("ProfileId");

                    b.Property<string>("Slug");

                    b.HasKey("BehaviourId");

                    b.HasIndex("BehaviourTypeId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Behaviours");
                });

            modelBuilder.Entity("Commitments.Core.Entities.BehaviourType", b =>
                {
                    b.Property<int>("BehaviourTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("BehaviourTypeId");

                    b.ToTable("BehaviourTypes");
                });

            modelBuilder.Entity("Commitments.Core.Entities.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("CardId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Commitments.Core.Entities.Commitment", b =>
                {
                    b.Property<int>("CommitmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BehaviourId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<int>("ProfileId");

                    b.HasKey("CommitmentId");

                    b.HasIndex("BehaviourId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Commitment");
                });

            modelBuilder.Entity("Commitments.Core.Entities.CommitmentFrequency", b =>
                {
                    b.Property<int>("CommitmentFrequencyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CommitmentId");

                    b.Property<int>("FrequencyId");

                    b.HasKey("CommitmentFrequencyId");

                    b.HasIndex("CommitmentId");

                    b.HasIndex("FrequencyId");

                    b.ToTable("CommitmentFrequency");
                });

            modelBuilder.Entity("Commitments.Core.Entities.CommitmentPreCondition", b =>
                {
                    b.Property<int>("CommitmentPreConditionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CommitmentId");

                    b.Property<string>("Name");

                    b.HasKey("CommitmentPreConditionId");

                    b.HasIndex("CommitmentId");

                    b.ToTable("CommitmentPreCondition");
                });

            modelBuilder.Entity("Commitments.Core.Entities.Dashboard", b =>
                {
                    b.Property<int>("DashboardId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("Name");

                    b.Property<int>("ProfileId");

                    b.HasKey("DashboardId");

                    b.ToTable("Dashboards");
                });

            modelBuilder.Entity("Commitments.Core.Entities.DashboardCard", b =>
                {
                    b.Property<int>("DashboardCardId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CardId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("DashboardId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("Options");

                    b.HasKey("DashboardCardId");

                    b.HasIndex("CardId");

                    b.HasIndex("DashboardId");

                    b.ToTable("DashboardCards");
                });

            modelBuilder.Entity("Commitments.Core.Entities.DigitalAsset", b =>
                {
                    b.Property<int>("DigitalAssetId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("DigitalAssetId");

                    b.ToTable("DigitalAssets");
                });

            modelBuilder.Entity("Commitments.Core.Entities.Frequency", b =>
                {
                    b.Property<int>("FrequencyId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("Frequency");

                    b.Property<int>("FrequencyTypeId");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsDesirable");

                    b.Property<DateTime>("LastModifiedOn");

                    b.HasKey("FrequencyId");

                    b.HasIndex("FrequencyTypeId");

                    b.ToTable("Frequencies");
                });

            modelBuilder.Entity("Commitments.Core.Entities.FrequencyType", b =>
                {
                    b.Property<int>("FrequencyTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("FrequencyTypeId");

                    b.ToTable("FrequencyTypes");
                });

            modelBuilder.Entity("Commitments.Core.Entities.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("Slug");

                    b.Property<string>("Title");

                    b.HasKey("NoteId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("Commitments.Core.Entities.NoteTag", b =>
                {
                    b.Property<int>("NoteTagId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<int>("NoteId");

                    b.Property<int>("TagId");

                    b.HasKey("NoteTagId");

                    b.HasIndex("NoteId");

                    b.HasIndex("TagId");

                    b.ToTable("NoteTag");
                });

            modelBuilder.Entity("Commitments.Core.Entities.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("Name");

                    b.Property<int>("UserId");

                    b.HasKey("ProfileId");

                    b.HasIndex("UserId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Commitments.Core.Entities.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("Name");

                    b.Property<string>("Slug");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Commitments.Core.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("Password");

                    b.Property<byte[]>("Salt");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Commitments.Core.Entities.Activity", b =>
                {
                    b.HasOne("Commitments.Core.Entities.Behaviour", "Behaviour")
                        .WithMany()
                        .HasForeignKey("BehaviourId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Commitments.Core.Entities.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Commitments.Core.Entities.Behaviour", b =>
                {
                    b.HasOne("Commitments.Core.Entities.BehaviourType", "BehaviourType")
                        .WithMany("Behaviours")
                        .HasForeignKey("BehaviourTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Commitments.Core.Entities.Profile")
                        .WithMany("Commitments")
                        .HasForeignKey("ProfileId");
                });

            modelBuilder.Entity("Commitments.Core.Entities.Commitment", b =>
                {
                    b.HasOne("Commitments.Core.Entities.Behaviour", "Behaviour")
                        .WithMany()
                        .HasForeignKey("BehaviourId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Commitments.Core.Entities.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Commitments.Core.Entities.CommitmentFrequency", b =>
                {
                    b.HasOne("Commitments.Core.Entities.Commitment", "Commitment")
                        .WithMany("CommitmentFrequencies")
                        .HasForeignKey("CommitmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Commitments.Core.Entities.Frequency", "Frequency")
                        .WithMany("CommitmentFrequencies")
                        .HasForeignKey("FrequencyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Commitments.Core.Entities.CommitmentPreCondition", b =>
                {
                    b.HasOne("Commitments.Core.Entities.Commitment", "Commitment")
                        .WithMany("CommitmentPreConditions")
                        .HasForeignKey("CommitmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Commitments.Core.Entities.DashboardCard", b =>
                {
                    b.HasOne("Commitments.Core.Entities.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Commitments.Core.Entities.Dashboard", "Dashboard")
                        .WithMany("DashboardCards")
                        .HasForeignKey("DashboardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Commitments.Core.Entities.Frequency", b =>
                {
                    b.HasOne("Commitments.Core.Entities.FrequencyType", "FrequencyType")
                        .WithMany()
                        .HasForeignKey("FrequencyTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Commitments.Core.Entities.NoteTag", b =>
                {
                    b.HasOne("Commitments.Core.Entities.Note", "Note")
                        .WithMany("NoteTags")
                        .HasForeignKey("NoteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Commitments.Core.Entities.Tag", "Tag")
                        .WithMany("NoteTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Commitments.Core.Entities.Profile", b =>
                {
                    b.HasOne("Commitments.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
