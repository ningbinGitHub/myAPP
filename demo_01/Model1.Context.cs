﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo_01
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dmmusicteachingEntities : DbContext
    {
        public dmmusicteachingEntities()
            : base("name=dmmusicteachingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<company_achievement> company_achievement { get; set; }
        public virtual DbSet<company_info> company_info { get; set; }
        public virtual DbSet<consumer> consumer { get; set; }
        public virtual DbSet<consumer_apply> consumer_apply { get; set; }
        public virtual DbSet<consumer_demand_record> consumer_demand_record { get; set; }
        public virtual DbSet<consumer_equipment> consumer_equipment { get; set; }
        public virtual DbSet<course> course { get; set; }
        public virtual DbSet<course_arrangement> course_arrangement { get; set; }
        public virtual DbSet<course_classify> course_classify { get; set; }
        public virtual DbSet<course_evaluate> course_evaluate { get; set; }
        public virtual DbSet<course_level_classify> course_level_classify { get; set; }
        public virtual DbSet<course_section> course_section { get; set; }
        public virtual DbSet<lesson> lesson { get; set; }
        public virtual DbSet<mag_module_cate> mag_module_cate { get; set; }
        public virtual DbSet<mag_modules> mag_modules { get; set; }
        public virtual DbSet<mag_role_module_permssion> mag_role_module_permssion { get; set; }
        public virtual DbSet<mag_roles> mag_roles { get; set; }
        public virtual DbSet<mag_user> mag_user { get; set; }
        public virtual DbSet<mag_user_operator_log> mag_user_operator_log { get; set; }
        public virtual DbSet<mag_user_role> mag_user_role { get; set; }
        public virtual DbSet<resources> resources { get; set; }
        public virtual DbSet<resources_images> resources_images { get; set; }
        public virtual DbSet<sys_project_par> sys_project_par { get; set; }
        public virtual DbSet<sys_short_message> sys_short_message { get; set; }
        public virtual DbSet<teacher_audit_process> teacher_audit_process { get; set; }
        public virtual DbSet<teacher_experience> teacher_experience { get; set; }
        public virtual DbSet<teacher_jurisdiction> teacher_jurisdiction { get; set; }
        public virtual DbSet<teacher_level> teacher_level { get; set; }
        public virtual DbSet<teacher_level_operation> teacher_level_operation { get; set; }
        public virtual DbSet<teaching_place> teaching_place { get; set; }
    }
}
