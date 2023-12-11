using HR_DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Forms.Forms.Lists_Forms
{
    public partial class F_Emp_List : F_Master_List
    {
        public F_Emp_List()
        {
            InitializeComponent();
            Title("قائمة الموظفين");
            Get_Data();
        }
        ClsCommander<T_Emploee> cmdEmploeey = new ClsCommander<T_Emploee>();
        ClsCommander<T_Employee_State> cmdEmp_State = new ClsCommander<T_Employee_State>();
     public   T_Emploee Emploee;

        public override void Title(string s_title)
        {
            base.Title(s_title);
        }
        public override void Get_Data()
        {
            cmdEmploeey = new ClsCommander<T_Emploee>();
            cmdEmp_State = new ClsCommander<T_Employee_State>();

            gc.DataSource = (from emp in cmdEmploeey.Get_All()
                             join emp_Sta in cmdEmp_State.Get_All()
                             on emp.Emp_St_Id equals emp_Sta.Emp_St_Id into jointable 
                             from estates in jointable .DefaultIfEmpty()
                            select new
                            { 
                                id = emp.Emp_Id,
                                name =emp.Emp_F_Name +" " +emp.Emp_L_Name,
                                nation =emp.Emp_Nation_num,
                                mobile =emp.Emp_Mobile + " / " + emp.Emp_Phone,
                                stat =emp.Emp_State,
                                s_name =estates ==null ? " " : estates.Emp_St_Name                            
                            }).OrderBy (c=>c.id).ToList();

            gv.Columns[0].Caption = "رقم الموظف";
            gv.Columns[1].Caption = "الاسم";
            gv.Columns[2].Caption = "الرقم الوطني ";
            gv.Columns[3].Caption = "رقم الهاتف ";
            gv.Columns[4].Caption = "الحالة ";
            gv.Columns[5].Caption = "حالة العمل ";

            gv.BestFitColumns();
            base.Get_Data();
        }
        public override void gc_DoubleClick(object sender, EventArgs e)
        {
            Emploee = new T_Emploee();
            Emploee = cmdEmploeey.Get_All().Where(x => x.Emp_Id == 
                      Convert.ToInt64(gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns[0]))).FirstOrDefault();
            if (Emploee != null)
            {
                this.Close();
            }
            base.gc_DoubleClick(sender, e);
        }

    }
}
