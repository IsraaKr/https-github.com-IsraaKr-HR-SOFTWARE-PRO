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
    
    public partial class T_User_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_User_Type()
        {
            this.T_Users = new HashSet<T_Users>();
        }
    
        public decimal User_T_Id { get; set; }
        public string User_T_Code { get; set; }
        public string User_T_Nane { get; set; }
        public Nullable<bool> User_T_State { get; set; }
        public string User_T_Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Users> T_Users { get; set; }
    }
}
