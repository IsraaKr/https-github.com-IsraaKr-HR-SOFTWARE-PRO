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
    
    public partial class T_Salary_Master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Salary_Master()
        {
            this.T_Salarey_Month = new HashSet<T_Salarey_Month>();
        }
    
        public decimal Emp_Sal_Id { get; set; }
        public string Emp_Sal_Code { get; set; }
        public string Emp_Sal_Name { get; set; }
        public Nullable<decimal> Emp_Sal_Salary { get; set; }
        public Nullable<bool> Emp_Sal_State { get; set; }
        public string Emp_Sal_Note { get; set; }
        public Nullable<decimal> Emp_Mp_Id { get; set; }
    
        public virtual T_Employee_Map T_Employee_Map { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Salarey_Month> T_Salarey_Month { get; set; }
    }
}