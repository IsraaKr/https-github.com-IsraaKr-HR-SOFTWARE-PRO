﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR_DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SMART_HR_DB_2023Entities : DbContext
    {
        public SMART_HR_DB_2023Entities()
            : base("name=SMART_HR_DB_2023Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<T_Attend_Day> T_Attend_Day { get; set; }
        public virtual DbSet<T_Attend_Month> T_Attend_Month { get; set; }
        public virtual DbSet<T_Companey> T_Companey { get; set; }
        public virtual DbSet<T_Customer> T_Customer { get; set; }
        public virtual DbSet<T_Customer_Bill> T_Customer_Bill { get; set; }
        public virtual DbSet<T_Customer_Companey> T_Customer_Companey { get; set; }
        public virtual DbSet<T_Customer_Contract> T_Customer_Contract { get; set; }
        public virtual DbSet<T_Customer_Invoice> T_Customer_Invoice { get; set; }
        public virtual DbSet<T_Emploee> T_Emploee { get; set; }
        public virtual DbSet<T_Employee_Certificate> T_Employee_Certificate { get; set; }
        public virtual DbSet<T_Employee_Experiance> T_Employee_Experiance { get; set; }
        public virtual DbSet<T_Employee_File> T_Employee_File { get; set; }
        public virtual DbSet<T_Employee_Map> T_Employee_Map { get; set; }
        public virtual DbSet<T_Employee_Retriment> T_Employee_Retriment { get; set; }
        public virtual DbSet<T_Employee_State> T_Employee_State { get; set; }
        public virtual DbSet<T_Salarey_Month> T_Salarey_Month { get; set; }
        public virtual DbSet<T_Salary_Master> T_Salary_Master { get; set; }
        public virtual DbSet<T_User_Type> T_User_Type { get; set; }
        public virtual DbSet<T_Users> T_Users { get; set; }
        public virtual DbSet<T_Employee_Social> T_Employee_Social { get; set; }
        public virtual DbSet<T_Attend> T_Attend { get; set; }
        public virtual DbSet<V_Emp_Month_Atend_Salarey> V_Emp_Month_Atend_Salarey { get; set; }
    }
}
