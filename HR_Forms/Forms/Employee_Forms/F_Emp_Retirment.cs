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

namespace HR_Forms.Forms.Employee_Forms
{
    public partial class F_Emp_Retirment : F_Master_Inhertanz
    {
        public F_Emp_Retirment()
        {
            InitializeComponent();
        }
        ClsCommander<T_Employee_Retriment> cmdEmpRetirment = new ClsCommander<T_Employee_Retriment>();
        ClsCommander<T_Emploee> cmdEmploeey = new ClsCommander<T_Emploee>();

    
        T_Employee_Retriment TF_Emp_Retirment;
        Boolean Is_Double_Click = false;
        public override void Get_Data(string status_mess)
        {
            if (TF_Emp_Retirment != null)
            {
                try
                {
                    clear_data(this.Controls);
                    Is_Double_Click = false;
                    cmdEmpRetirment = new ClsCommander<T_Employee_Retriment>();

                    Fill_Graid();

                    GetEmp_Data();
                    base.Get_Data(status_mess);

                }
                catch (Exception ex)
                {
                    Get_Data(ex.InnerException.InnerException.ToString() + "/" + ex.Message);
                }
            }
        }
        public override void Insert_Data()
        {
            try
            {
                if (Validate_Data())
                {
                    TF_Emp_Retirment = new T_Employee_Retriment();
                    Fill_Entitey();
                    cmdEmpRetirment.Insert_Data(TF_Emp_Retirment);
                    base.Insert_Data();
                    Get_Data("i");
                }

            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString());
            }
        }
        public override void Update_Data()
        {
            try
            {
                if (Is_Double_Click)
                {
                    if (Validate_Data() && gv.RowCount > 0 && TF_Emp_Retirment != null)
                    {
                        Fill_Entitey();
                        cmdEmpRetirment.Update_Data(TF_Emp_Retirment);
                        base.Update_Data();
                        Get_Data("u");
                    }
                }
                else
                    C_Master.Warning_Massege_Box("الرجاء اختيار عنصر لتعديله");

            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString());
            }


        }
        public override void Delete_Data()
        {
            try
            {
                if (Is_Double_Click)
                {
                    if (C_Master.Qustion_Massege_Box(C_Master.mas_del) == DialogResult.Yes)
                    {
                        if (gv.RowCount > 0)
                        {
                            foreach (int row_id in gv.GetSelectedRows())
                            {
                                Get_Row_ID(row_id);
                                cmdEmpRetirment.Delet_Data(TF_Emp_Retirment);

                            }
                            base.Delete_Data();
                            Get_Data("d");
                        }
                    }
                    else
                        C_Master.Warning_Massege_Box("الرجاء اختيار عنصر من الجدول لحذفه");
                }
            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString());
            }
        }


        public override void clear_data(Control.ControlCollection s_controls)
        {
            base.clear_data(s_controls);
            Set_Auto_Id();
        }
        public override void Print_Data()
        {
            base.Print_Data();
        }

        public override bool Validate_Data()
        {
            int number_of_errores = 0;
            number_of_errores += Emp_Re_IdTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += Emp_Re_NameTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += Emp_Re_SalaryTextEdit.is_text_valid() ? 0 : 1;
            if (Emp_IdSearchLookUpEdit.EditValue == null)
            {
                number_of_errores += 1;
                Emp_IdSearchLookUpEdit.ErrorText = "هذا الحقل مطلوب";
            }

            return (number_of_errores == 0);
        }

        public void Fill_Controls()
        {
            Emp_Re_IdTextEdit.Text = TF_Emp_Retirment.Emp_Re_Id.ToString();
            Emp_Re_NameTextEdit.Text = TF_Emp_Retirment.Emp_Re_Name;
            Emp_Re_ResoneTextEdit.Text = TF_Emp_Retirment.Emp_Re_Resone;
            Emp_Re_DateDateEdit.DateTime = Convert.ToDateTime(TF_Emp_Retirment.Emp_Re_Date);
            Emp_Re_SalaryTextEdit.Text = TF_Emp_Retirment.Emp_Re_Salary.ToString();
            Emp_Re_StateCheckEdit.Checked = Convert.ToBoolean(TF_Emp_Retirment.Emp_Re_State);
            Emp_Re_NoteMemoEdit.Text = TF_Emp_Retirment.Emp_Re_Note;
            Emp_IdSearchLookUpEdit.EditValue = TF_Emp_Retirment.Emp_Id;

        }
        public void Fill_Entitey()
        {
            TF_Emp_Retirment.Emp_Re_Id = Convert.ToInt64(Emp_Re_IdTextEdit.Text);
            TF_Emp_Retirment.Emp_Re_Name = Emp_Re_NameTextEdit.Text;
            TF_Emp_Retirment.Emp_Re_Resone = Emp_Re_ResoneTextEdit.Text;
            TF_Emp_Retirment.Emp_Re_Date = Convert.ToDateTime(Emp_Re_DateDateEdit.DateTime.ToString("yyyy/MM/dd"));
            TF_Emp_Retirment.Emp_Re_Salary =Convert.ToDecimal( Emp_Re_SalaryTextEdit.Text);
            TF_Emp_Retirment.Emp_Re_State = Convert.ToBoolean(Emp_Re_StateCheckEdit.CheckState);
            TF_Emp_Retirment.Emp_Re_Note = Emp_Re_NoteMemoEdit.Text;
            TF_Emp_Retirment.Emp_Id = Convert.ToUInt64(Emp_IdSearchLookUpEdit.EditValue);

        }
        private void Fill_Graid()
        {
            gc.DataSource = (from e_retire in cmdEmpRetirment.Get_All()
                             select new
                             {
                                 id = e_retire.Emp_Re_Id,
                                 name = e_retire.Emp_Re_Name,
                                 date = e_retire.Emp_Re_Date,
                                 salarey = e_retire.Emp_Re_Salary,
                                 emp_id = e_retire.Emp_Id,
                                 emp_name = e_retire.T_Emploee.Emp_F_Name + " " + e_retire.T_Emploee.Emp_L_Name
                             }).OrderBy(l_id => l_id.id).ToList();

            gv.Columns[0].Caption = "الرقم";
            gv.Columns[1].Caption = "الاسم";
            gv.Columns[2].Caption = "التاريخ";
            gv.Columns[3].Caption = "راتب التقاعد";
            gv.Columns[4].Caption = "رقم الموظف";
            gv.Columns[5].Caption = "اسم الموظف";

            gv.BestFitColumns();
        }
        public void GetEmp_Data()
        {
            var Emp_List = (from Emp in cmdEmploeey.Get_All().Where(es => es.Emp_State == true)
                            select new
                            {
                                id = Emp.Emp_Id,
                                name = Emp.Emp_F_Name + " " + Emp.Emp_L_Name,
                            }).OrderBy(id => id.id);
            if (Emp_List != null && Emp_List.Count() > 0)
            {
                Emp_IdSearchLookUpEdit.slkp_iniatalize_data(Emp_List, "name", "id");
                Emp_IdSearchLookUpEdit.Properties.View.Columns[0].Caption = "الرقم";
                Emp_IdSearchLookUpEdit.Properties.View.Columns[1].Caption = "الاسم ";
            }
        }
        private void Set_Auto_Id()
        {
            var max_id = cmdEmpRetirment.Get_All().Where(c_id => c_id.Emp_Re_Id == cmdEmpRetirment.Get_All().Max(max => max.Emp_Re_Id)).FirstOrDefault();
            Emp_Re_IdTextEdit.Text = max_id == null ? "1" : (max_id.Emp_Re_Id + 1).ToString();
            // Emp_Mp_CodeTextEdit.Text = Emp_Mp_IdTextEdit.Text;
        }
        private void Get_Row_ID(int Row_Id)
        {
            long id;
            if (Row_Id != 0)
            {
                id = Convert.ToInt64(gv.GetRowCellValue(Row_Id, gv.Columns[0]));
                TF_Emp_Retirment = cmdEmpRetirment.Get_By(c_id => c_id.Emp_Re_Id == id).FirstOrDefault();
            }
            else
            {
                id = Convert.ToInt64(gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns[0]));
                TF_Emp_Retirment = cmdEmpRetirment.Get_By(c_id => c_id.Emp_Re_Id == id).FirstOrDefault();
            }
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            Is_Double_Click = true;
            gv.SelectRow(gv.FocusedRowHandle);

            Get_Row_ID(0);
            if (TF_Emp_Retirment != null)
                Fill_Controls();
        }

        private void gv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete && gv.RowCount > 0)
                Delete_Data();
        }

        private void Emp_IdSearchLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != string.Empty)
            {
                long e_id = Convert.ToInt64(e.Value);
                e.DisplayText = cmdEmploeey.Get_By(id => id.Emp_Id == e_id).FirstOrDefault().Emp_F_Name;
            }
            else
                e.DisplayText = "";
        }

    
    }
}
