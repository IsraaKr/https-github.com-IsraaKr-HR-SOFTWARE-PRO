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

namespace HR_Forms.Forms.Salarey_Forms
{
    public partial class F_Salarey_Month : F_Master_Inhertanz
    {
        public F_Salarey_Month()
        {
            InitializeComponent();
        }
        ClsCommander<T_Salarey_Month> cmdSalMonth = new ClsCommander<T_Salarey_Month>();
        ClsCommander<T_Salary_Master> cmdSalMaster= new ClsCommander<T_Salary_Master>();
        ClsCommander<T_Emploee> cmdEmploeey = new ClsCommander<T_Emploee>();

        T_Salarey_Month TF_Sal_Month;
        Boolean Is_Double_Click = false;
        public override void Get_Data(string status_mess)
        {
            if (TF_Sal_Month != null)
            {
                try
                {
                    clear_data(this.Controls);
                    Is_Double_Click = false;
                    cmdSalMonth = new ClsCommander<T_Salarey_Month>();

                    Fill_Graid();

                    GetEmp_Data();
                    GetSal_Master_Data();
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
                   TF_Sal_Month = new T_Salarey_Month();
                    Fill_Entitey();
                    cmdSalMonth.Insert_Data(TF_Sal_Month);
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
                    if (Validate_Data() && gv.RowCount > 0 && TF_Sal_Month != null)
                    {
                        Fill_Entitey();
                        cmdSalMonth.Update_Data(TF_Sal_Month);
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
                                cmdSalMonth.Delet_Data(TF_Sal_Month);

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
            number_of_errores += Emp_Mnth_Sal_IdTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += Emp_Mnth_Sal_NameTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += Emp_Mnth_Sal_SalaryTextEdit.is_text_valid() ? 0 : 1;
            if (Emp_Sal_IdSearchLookUpEdit.EditValue == null)
            {
                number_of_errores += 1;
               Emp_Sal_IdSearchLookUpEdit.ErrorText = "هذا الحقل مطلوب";
            }
            if (Emp_IdSearchLookUpEdit.EditValue == null)
            {
                number_of_errores += 1;
                Emp_IdSearchLookUpEdit.ErrorText = "هذا الحقل مطلوب";
            }

            return (number_of_errores == 0);
        }

        public void Fill_Controls()
        {
            Emp_Mnth_Sal_IdTextEdit.Text = TF_Sal_Month.Emp_Mnth_Sal_Id.ToString();
            Emp_Mnth_Sal_NameTextEdit.Text = TF_Sal_Month.Emp_Mnth_Sal_Name;
            Emp_Mnth_Sal_DateDateEdit.DateTime = Convert.ToDateTime(TF_Sal_Month.Emp_Mnth_Sal_Date);

            Emp_Mnth_Sal_SalaryTextEdit.Text = TF_Sal_Month.Emp_Mnth_Sal_Salary.ToString();
            Emp_Mnth_Sal_BonasTextEdit.Text = TF_Sal_Month.Emp_Mnth_Sal_Bonas.ToString();
            Emp_Mnth_Sal_MinoseTextEdit.Text = TF_Sal_Month.Emp_Mnth_Sal_Minose.ToString();
            Emp_Mnth_Sal_SS_MinousTextEdit.Text = TF_Sal_Month.Emp_Mnth_Sal_SS_Minous.ToString();
            Emp_Mnth_Sal_TotalTextEdit.Text = TF_Sal_Month.Emp_Mnth_Sal_Total.ToString();

            Emp_Mnth_Sal_StateCheckEdit.Checked = Convert.ToBoolean(TF_Sal_Month.Emp_Mnth_Sal_State);
            Emp_Mnth_Sal_NoteMemoEdit.Text = TF_Sal_Month.Emp_Mnth_Sal_Note;

           Emp_Sal_IdSearchLookUpEdit.EditValue = TF_Sal_Month.Emp_Sal_Id;
            Emp_IdSearchLookUpEdit.EditValue = TF_Sal_Month.Emp_Id;

        }
        public void Fill_Entitey()
        {
            TF_Sal_Month.Emp_Mnth_Sal_Id = Convert.ToInt64(Emp_Mnth_Sal_IdTextEdit.Text);
            TF_Sal_Month.Emp_Mnth_Sal_Name = Emp_Mnth_Sal_NameTextEdit.Text;
            TF_Sal_Month.Emp_Mnth_Sal_Date = Convert.ToDateTime(Emp_Mnth_Sal_DateDateEdit.DateTime.ToString("yyyy/MM/dd"));
            TF_Sal_Month.Emp_Mnth_Sal_Salary = Convert.ToDecimal(Emp_Mnth_Sal_SalaryTextEdit.Text);
            TF_Sal_Month.Emp_Mnth_Sal_Bonas = Convert.ToDecimal(Emp_Mnth_Sal_BonasTextEdit.Text);
            TF_Sal_Month.Emp_Mnth_Sal_Minose = Convert.ToDecimal(Emp_Mnth_Sal_MinoseTextEdit.Text);
            TF_Sal_Month.Emp_Mnth_Sal_SS_Minous = Convert.ToDecimal(Emp_Mnth_Sal_SS_MinousTextEdit.Text);
            TF_Sal_Month.Emp_Mnth_Sal_Total = Convert.ToDecimal(Emp_Mnth_Sal_TotalTextEdit.Text);
            TF_Sal_Month.Emp_Mnth_Sal_State = Convert.ToBoolean(Emp_Mnth_Sal_StateCheckEdit.CheckState);
            TF_Sal_Month.Emp_Mnth_Sal_Note = Emp_Mnth_Sal_NoteMemoEdit.Text;
            TF_Sal_Month.Emp_Sal_Id = Convert.ToUInt64(Emp_Sal_IdSearchLookUpEdit.EditValue);
            TF_Sal_Month.Emp_Id = Convert.ToUInt64(Emp_IdSearchLookUpEdit.EditValue);

        }
        private void Fill_Graid()
        {
            gc.DataSource = (from s_month in cmdSalMonth.Get_All()
                             select new
                             {
                                 id = s_month.Emp_Mnth_Sal_Id,
                                 name = s_month.Emp_Mnth_Sal_Name,
                                 date = s_month.Emp_Mnth_Sal_Date,
                                 salarey = s_month.Emp_Mnth_Sal_Salary,
                                 total = s_month.Emp_Mnth_Sal_Total,
                                 emp_id = s_month.Emp_Id,
                                 emp_name = s_month.T_Emploee.Emp_F_Name + " " + s_month.T_Emploee.Emp_L_Name

                             }).OrderBy(l_id => l_id.id).ToList();

            gv.Columns[0].Caption = "الرقم";
            gv.Columns[1].Caption = "الاسم";
            gv.Columns[2].Caption = "التاريخ";
            gv.Columns[3].Caption = "الراتب ";
            gv.Columns[4].Caption = "الصافي";
            gv.Columns[5].Caption = "رقم الموظف";
            gv.Columns[4].Caption = "اسم الموظف";

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
        public void GetSal_Master_Data()
        {
            var Emp_List = (from Emp in cmdSalMaster.Get_All()
                            select new
                            {
                                id = Emp.Emp_Sal_Id,
                                name = Emp.Emp_Sal_Name 
                            }).OrderBy(id => id.id);
            if (Emp_List != null && Emp_List.Count() > 0)
            {
                Emp_Sal_IdSearchLookUpEdit.slkp_iniatalize_data(Emp_List, "name", "id");
                Emp_Sal_IdSearchLookUpEdit.Properties.View.Columns[0].Caption = "الرقم";
                Emp_Sal_IdSearchLookUpEdit.Properties.View.Columns[1].Caption = "الاسم ";
            }

        }
        private void Set_Auto_Id()
        {
            var max_id = cmdSalMonth.Get_All().Where(c_id => c_id.Emp_Mnth_Sal_Id == cmdSalMonth.Get_All().Max(max => max.Emp_Mnth_Sal_Id)).FirstOrDefault();
            Emp_Mnth_Sal_IdTextEdit.Text = max_id == null ? "1" : (max_id.Emp_Mnth_Sal_Id + 1).ToString();
            // Emp_Mp_CodeTextEdit.Text = Emp_Mp_IdTextEdit.Text;
        }
        private void Get_Row_ID(int Row_Id)
        {
            long id;
            if (Row_Id != 0)
            {
                id = Convert.ToInt64(gv.GetRowCellValue(Row_Id, gv.Columns[0]));
                TF_Sal_Month = cmdSalMonth.Get_By(c_id => c_id.Emp_Mnth_Sal_Id == id).FirstOrDefault();
            }
            else
            {
                id = Convert.ToInt64(gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns[0]));
                TF_Sal_Month = cmdSalMonth.Get_By(c_id => c_id.Emp_Mnth_Sal_Id == id).FirstOrDefault();
            }
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            Is_Double_Click = true;
            gv.SelectRow(gv.FocusedRowHandle);

            Get_Row_ID(0);
            if (TF_Sal_Month != null)
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



        private void Emp_Sal_IdSearchLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != string.Empty)
            {
                //long e_id = Convert.ToInt64(e.Value);
                //var mp_data = cmdEmpMap.Get_By(x => x.Emp_Mp_Id == e_id).FirstOrDefault();
                //e.DisplayText = mp_data.Emp_Mp_Class;
                //Emp_Sal_NameTextEdit.Text = " راتب " + mp_data.Emp_Mp_Class + " " + mp_data.Emp_Mp_Level;
                //Emp_Sal_SalaryTextEdit.Text = mp_data.Emp_Mp_Salary.ToString();

            }
            else
                e.DisplayText = "";
        }
    }
}
