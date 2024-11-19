﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetrovGeorgeKt_43_21.Database;

#nullable disable

namespace PetrovGeorgeKt_43_21.Migrations
{
    [DbContext(typeof(TeacherDbContext))]
    [Migration("20241119201055_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetrovGeorgeKt_43_21.Models.Degree", b =>
                {
                    b.Property<int>("DegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("degree_id")
                        .HasComment("Идентификатор записи степени");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DegreeId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_degree_name")
                        .HasComment("Название степени");

                    b.HasKey("DegreeId")
                        .HasName("pk_cd_degree_degree_id");

                    b.ToTable("cd_degree", (string)null);
                });

            modelBuilder.Entity("PetrovGeorgeKt_43_21.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("department_id")
                        .HasComment("Идентификатор записи кафедры");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<int>("HeadId")
                        .HasColumnType("int")
                        .HasColumnName("c_department_head_id")
                        .HasComment("Идентификатор заведущего");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_department_name")
                        .HasComment("Название кафедры");

                    b.HasKey("DepartmentId")
                        .HasName("pk_cd_department_department_id");

                    b.HasIndex(new[] { "HeadId" }, "idx_cd_department_fk_f_head_id");

                    b.ToTable("cd_department", (string)null);
                });

            modelBuilder.Entity("PetrovGeorgeKt_43_21.Models.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("position_id")
                        .HasComment("Идентификатор записи должности");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PositionId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_position_name")
                        .HasComment("Название должности");

                    b.HasKey("PositionId")
                        .HasName("pk_cd_position_position_id");

                    b.ToTable("cd_position", (string)null);
                });

            modelBuilder.Entity("PetrovGeorgeKt_43_21.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("subject_id")
                        .HasComment("Идентификатор записи дисциплины");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"));

                    b.Property<int>("Hours")
                        .HasColumnType("int")
                        .HasColumnName("c_subject_labhours")
                        .HasComment("Часы");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_subject_name")
                        .HasComment("Название дисциплины");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int")
                        .HasColumnName("c_subject_teacher_id")
                        .HasComment("Идентификатор преподавателя");

                    b.HasKey("SubjectId")
                        .HasName("pk_cd_subject_subject_id");

                    b.HasIndex(new[] { "TeacherId" }, "idx_cd_subject_fk_f_teacher_id");

                    b.ToTable("cd_subject", (string)null);
                });

            modelBuilder.Entity("PetrovGeorgeKt_43_21.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("teacher_id")
                        .HasComment("Идентификатор записи учителя");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<int>("DegreeId")
                        .HasColumnType("int")
                        .HasColumnName("c_teacher_degree_id")
                        .HasComment("Идентификатор степени");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("c_teacher_department_id")
                        .HasComment("Идентификатор кафедры");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("c_teacher_firstname")
                        .HasComment("Имя преподавателя");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("c_teacher_lastname")
                        .HasComment("Фамилия преподавателя");

                    b.Property<string>("Patronymic")
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("c_teacher_patronymic")
                        .HasComment("Отчество преподавателя");

                    b.Property<int>("PositionId")
                        .HasColumnType("int")
                        .HasColumnName("c_teacher_position_id")
                        .HasComment("Идентификатор должности");

                    b.HasKey("TeacherId")
                        .HasName("pk_cd_teacher_teacher_id");

                    b.HasIndex(new[] { "DegreeId" }, "idx_cd_teacher_fk_f_degree_id");

                    b.HasIndex(new[] { "DepartmentId" }, "idx_cd_teacher_fk_f_department_id");

                    b.HasIndex(new[] { "PositionId" }, "idx_cd_teacher_fk_f_position_id");

                    b.ToTable("cd_teacher", (string)null);
                });

            modelBuilder.Entity("PetrovGeorgeKt_43_21.Models.TeachingLoad", b =>
                {
                    b.Property<int>("TeachingLoadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("teachingload_id")
                        .HasComment("Идентификатор нагрузки преподавателя");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeachingLoadId"));

                    b.Property<int>("Hours")
                        .HasColumnType("int")
                        .HasColumnName("c_teachingload_labhours")
                        .HasComment("Часы");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int")
                        .HasColumnName("c_teachingload_subject_id")
                        .HasComment("Идентификатор дисциплины");

                    b.HasKey("TeachingLoadId")
                        .HasName("pk_cd_load_load_id");

                    b.HasIndex("SubjectId")
                        .IsUnique();

                    b.HasIndex(new[] { "SubjectId" }, "idx_cd_load_fk_f_subject_id");

                    b.ToTable("cd_load", (string)null);
                });

            modelBuilder.Entity("PetrovGeorgeKt_43_21.Models.Department", b =>
                {
                    b.HasOne("PetrovGeorgeKt_43_21.Models.Teacher", "Head")
                        .WithMany()
                        .HasForeignKey("HeadId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_f_head_id");

                    b.Navigation("Head");
                });

            modelBuilder.Entity("PetrovGeorgeKt_43_21.Models.Subject", b =>
                {
                    b.HasOne("PetrovGeorgeKt_43_21.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_f_teacher_id");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("PetrovGeorgeKt_43_21.Models.Teacher", b =>
                {
                    b.HasOne("PetrovGeorgeKt_43_21.Models.Degree", "Degree")
                        .WithMany()
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_degree_id");

                    b.HasOne("PetrovGeorgeKt_43_21.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_department_id");

                    b.HasOne("PetrovGeorgeKt_43_21.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_position_id");

                    b.Navigation("Degree");

                    b.Navigation("Department");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("PetrovGeorgeKt_43_21.Models.TeachingLoad", b =>
                {
                    b.HasOne("PetrovGeorgeKt_43_21.Models.Subject", "Subject")
                        .WithOne()
                        .HasForeignKey("PetrovGeorgeKt_43_21.Models.TeachingLoad", "SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_subject_id");

                    b.Navigation("Subject");
                });
#pragma warning restore 612, 618
        }
    }
}