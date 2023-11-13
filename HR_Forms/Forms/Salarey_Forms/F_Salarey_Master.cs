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
    public partial class F_Salarey_Master : F_Master_Inhertanz
    {
        public F_Salarey_Master()
        {
            InitializeComponent();
        }
        ClsCommander<T_Salary_Master> cmdSalMaster = new ClsCommander<T_Salary_Master>();
        ClsCommander<T_Employee_Map> cmdEmpMap = new ClsCommander<T_Employee_Map>();


        T_Salary_Master TF_Sal_Master;
        Boolean Is_Double_Click = false;
        public override void Get_Data(string status_mess)
        {
            if (TF_Sal_Master != null)
            {
                try
                {
                    clear_data(this.Controls);
                    Is_Double_Click = false;
                    cmdSalMaster = new ClsCommander<T_Salary_Master>();

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
                    TF_Sal_Master = new T_Salary_Master();
                    Fill_Entitey();
                    cmdSalMaster.Insert_Data(TF_Sal_Master);
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
                    if (Validate_Data() && gv.RowCount > 0 && TF_Sal_Master != null)
                    {
                        Fill_Entitey();
                        cmdSalMaster.Update_Data(TF_Sal_Master);
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
                                cmdSalMaster.Delet_Data(TF_Sal_Master);

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
                if (ex.InnerException.InnerException.ToString().Contains("Fk_Emp_Month"))
                    C_Master.Warning_Massege_Box("العنصر مرتبط مع راتب شهري لا يمكن حذفه");
               else
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
            number_of_errores += Emp_Sal_IdTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += Emp_Sal_NameTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += Emp_Sal_SalaryTextEdit.is_text_valid() ? 0 : 1;
            if (Emp_Mp_IdSearchLookUpEdit.EditValue == null)
            {
                number_of_errores += 1;
                Emp_Mp_IdSearchLookUpEdit.ErrorText = "هذا الحقل مطلوب";
            }

            return (number_of_errores == 0);
        }

        public void Fill_Controls()
        {
            Emp_Sal_IdTextEdit.Text = TF_Sal_Master.Emp_Sal_Id.ToString();
            Emp_Sal_NameTextEdit.Text = TF_Sal_Master.Emp_Sal_Name;
            Emp_Sal_SalaryTextEdit.Text = TF_Sal_Master.Emp_Sal_Salary.ToString();
            Emp_Sal_StateCheckEdit.Checked = Convert.ToBoolean(TF_Sal_Master.Emp_Sal_State);
            Emp_Sal_NoteMemoEdit.Text = TF_Sal_Master.Emp_Sal_Note;
            Emp_Mp_IdSearchLookUpEdit.EditValue = TF_Sal_Master.Emp_Mp_Id;

        }
        public void Fill_Entitey()
        {
            TF_Sal_Master.Emp_Sal_Id = Convert.ToInt64(Emp_Sal_IdTextEdit.Text);
            TF_Sal_Master.Emp_Sal_Name = Emp_Sal_NameTextEdit.Text;
            TF_Sal_Master.Emp_Sal_Salary = Convert.ToDecimal(Emp_Sal_SalaryTextEdit.Text);
            TF_Sal_Master.Emp_Sal_State = Convert.ToBoolean(Emp_Sal_StateCheckEdit.CheckState);
            TF_Sal_Master.Emp_Sal_Note = Emp_Sal_NoteMemoEdit.Text;
            TF_Sal_Master.Emp_Mp_Id = Convert.ToUInt64(Emp_Mp_IdSearchLookUpEdit.EditValue);

        }
        private void Fill_Graid()
        {
            gc.DataSource = (from s_master in cmdSalMaster.Get_All()
                             select new
                             {
                                 id = s_master.Emp_Sal_Id,
                                 name = s_master.Emp_Sal_Name,
                                 salarey = s_master.Emp_Sal_Salary,
                                 mp_id = s_master.Emp_Mp_Id,
                                level = s_master.T_Employee_Map.Emp_Mp_Level 
                             }).OrderBy(l_id => l_id.id).ToList();

            gv.Columns[0].Caption = "الرقم";
            gv.Columns[1].Caption = "الاسم";
            gv.Columns[2].Caption = "الراتب";
            gv.Columns[3].Caption = "رقم الدرجة";
            gv.Columns[4].Caption = "الدرجة";


            gv.BestFitColumns();
        }
        public void GetEmp_Data()
        {
            var Emp_List = (from Emp_mp in cmdEmpMap.Get_All()
                            select new
                            {
                                id = Emp_mp.Emp_Mp_Id,
                                clas=Emp_mp.Emp_Mp_Class,
                                leveal = Emp_mp.Emp_Mp_Level ,
                            }).OrderBy(id => id.id);
            if (Emp_List != null && Emp_List.Count() > 0)
            {
                Emp_Mp_IdSearchLookUpEdit.slkp_iniatalize_data(Emp_List, "leveal", "id");
                Emp_Mp_IdSearchLookUpEdit.Properties.View.Columns[0].Caption = "الرقم";
                Emp_Mp_IdSearchLookUpEdit.Properties.View.Columns[1].Caption = "الفئة ";
                Emp_Mp_IdSearchLookUpEdit.Properties.View.Columns[1].Caption = "الدرجة ";

            }
        }
        private void Set_Auto_Id()
        {
            var max_id = cmdSalMaster.Get_All().Where(c_id => c_id.Emp_Sal_Id == cmdSalMaster.Get_All().Max(max => max.Emp_Mp_Id)).FirstOrDefault();
            Emp_Sal_IdTextEdit.Text = max_id == null ? "1" : (max_id.Emp_Sal_Id + 1).ToString();
            // Emp_Mp_CodeTextEdit.Text = Emp_Mp_IdTextEdit.Text;
        }
        private void Get_Row_ID(int Row_Id)
        {
            long id;
            if (Row_Id != 0)
            {
                id = Convert.ToInt64(gv.GetRowCellValue(Row_Id, gv.Columns[0]));
                TF_Sal_Master = cmdSalMaster.Get_By(c_id => c_id.Emp_Sal_Id == id).FirstOrDefault();
            }
            else
            {
                id = Convert.ToInt64(gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns[0]));
                TF_Sal_Master = cmdSalMaster.Get_By(c_id => c_id.Emp_Sal_Id == id).FirstOrDefault();
            }
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            Is_Double_Click = true;
            gv.SelectRow(gv.FocusedRowHandle);

            Get_Row_ID(0);
            if (TF_Sal_Master != null)
                Fill_Controls();
        }

        private void gv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete && gv.RowCount > 0)
                Delete_Data();
        }


        private void Emp_Mp_IdSearchLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != string.Empty)
            {
                long e_id = Convert.ToInt64(e.Value);
                var mp_data = cmdEmpMap.Get_By(x => x.Emp_Mp_Id==e_id).FirstOrDefault();
                e.DisplayText = mp_data.Emp_Mp_Class;
                Emp_Sal_NameTextEdit.Text =" راتب " +mp_data.Emp_Mp_Class + " " + mp_data.Emp_Mp_Level;
                Emp_Sal_SalaryTextEdit.Text = mp_data.Emp_Mp_Salary.ToString();

            }
            else
                e.DisplayText = "";
        }
    }
}
