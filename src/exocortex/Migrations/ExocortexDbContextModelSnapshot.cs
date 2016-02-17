using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using exocortex.Models;

namespace exocortex.Migrations
{
    [DbContext(typeof(ExocortexDbContext))]
    partial class ExocortexDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("exocortex.Models.exocortex.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<DateTimeOffset?>("DateTime");

                    b.Property<string>("Question");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("exocortex.Models.exocortex.Presentation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset?>("DateTime");

                    b.Property<int>("EntryId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("exocortex.Models.exocortex.Recall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset?>("DateTime");

                    b.Property<int>("EntryId");

                    b.Property<int>("SuccessLevel");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("exocortex.Models.exocortex.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset?>("DateTime");

                    b.Property<int>("EntryId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("exocortex.Models.exocortex.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("exocortex.Models.exocortex.Presentation", b =>
                {
                    b.HasOne("exocortex.Models.exocortex.Entry")
                        .WithMany()
                        .HasForeignKey("EntryId");
                });

            modelBuilder.Entity("exocortex.Models.exocortex.Recall", b =>
                {
                    b.HasOne("exocortex.Models.exocortex.Entry")
                        .WithMany()
                        .HasForeignKey("EntryId");
                });

            modelBuilder.Entity("exocortex.Models.exocortex.Request", b =>
                {
                    b.HasOne("exocortex.Models.exocortex.Entry")
                        .WithMany()
                        .HasForeignKey("EntryId");
                });
        }
    }
}
