//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class T_Employee_Certificate
    {
        public decimal Emp_C_Id { get; set; }
        public string Emp_C_Code { get; set; }
        public string Emp_C_Name { get; set; }
        public string Emp_C_Adress { get; set; }
        public Nullable<System.DateTime> Emp_C_Date { get; set; }
        public Nullable<bool> Emp_C_State { get; set; }
        public string Emp_C_Note { get; set; }
        public Nullable<decimal> Emp_Id { get; set; }
    
        public virtual T_Emploee T_Emploee { get; set; }
    }
}