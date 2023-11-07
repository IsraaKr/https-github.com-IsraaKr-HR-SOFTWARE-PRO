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
    public partial class F_Emp_Certificate : F_Master_Inhertanz
    {
        public F_Emp_Certificate()
        {
            InitializeComponent();
        }
        public F_Emp_Certificate(decimal emp_id)
        {
            InitializeComponent();
            Get_Data("");
            Emp_IdSearchLookUpEdit.EditValue = emp_id;
            gv.FindFilterText = Emp_IdSearchLookUpEdit.Text;
        }
        ClsCommander<T_Employee_Certificate> cmdEmpCertificate = new ClsCommander<T_Employee_Certificate>();
        ClsCommander<T_Emploee> cmdEmploeey = new ClsCommander<T_Emploee>();

     
        T_Employee_Certificate TF_Emp_Certificate;
        Boolean Is_Double_Click = false;
        public override void Get_Data(string status_mess)
        {
            if (TF_Emp_Certificate != null)
            {
                try
                {
                    clear_data(this.Controls);
                    Is_Double_Click = false;
                    cmdEmpCertificate = new ClsCommander<T_Employee_Certificate>();

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
                    TF_Emp_Certificate = new T_Employee_Certificate();
                    Fill_Entitey();
                    cmdEmpCertificate.Insert_Data(TF_Emp_Certificate);
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
                    if (Validate_Data() && gv.RowCount > 0 && TF_Emp_Certificate != null)
                    {
                        Fill_Entitey();
                        cmdEmpCertificate.Update_Data(TF_Emp_Certificate);
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
                                cmdEmpCertificate.Delet_Data(TF_Emp_Certificate);

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
            number_of_errores += Emp_C_IdTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += Emp_C_NameTextEdit.is_text_valid() ? 0 : 1;
            if (Emp_IdSearchLookUpEdit.EditValue == null)
            {
                number_of_errores += 1;
                Emp_IdSearchLookUpEdit.ErrorText = "هذا الحقل مطلوب";
            }

            return (number_of_errores == 0);
        }

        public void Fill_Controls()
        {
            Emp_C_IdTextEdit.Text = TF_Emp_Certificate.Emp_C_Id.ToString();
            Emp_C_NameTextEdit.Text= TF_Emp_Certificate.Emp_C_Name;
            Emp_C_AdressTextEdit.Text = TF_Emp_Certificate.Emp_C_Adress;
            Emp_C_DateDateEdit.DateTime = Convert.ToDateTime(TF_Emp_Certificate.Emp_C_Date);
            Emp_C_StateCheckEdit.Checked = Convert.ToBoolean(TF_Emp_Certificate.Emp_C_State);
            Emp_C_NoteMemoEdit.Text= TF_Emp_Certificate.Emp_C_Note;
           Emp_IdSearchLookUpEdit.EditValue = TF_Emp_Certificate.Emp_Id;

        }
        public void Fill_Entitey()
        {
            TF_Emp_Certificate.Emp_C_Id= Convert.ToInt64( Emp_C_IdTextEdit.Text) ;
            TF_Emp_Certificate.Emp_C_Name = Emp_C_NameTextEdit.Text;
            TF_Emp_Certificate.Emp_C_Adress = Emp_C_AdressTextEdit.Text;
            TF_Emp_Certificate.Emp_C_Date = Convert.ToDateTime(Emp_C_DateDateEdit.DateTime.ToString("yyyy/MM/dd"));
            TF_Emp_Certificate.Emp_C_State= Convert.ToBoolean(Emp_C_StateCheckEdit.CheckState );
            TF_Emp_Certificate.Emp_C_Note = Emp_C_NoteMemoEdit.Text;
            TF_Emp_Certificate.Emp_Id  =Convert.ToUInt64( Emp_IdSearchLookUpEdit.EditValue);

        }
        private void Fill_Graid()
        {
            gc.DataSource = (from e_cert in cmdEmpCertificate.Get_All()
                             select new
                             {
                                 id = e_cert.Emp_C_Id,
                                 name = e_cert.Emp_C_Name,
                                 date = e_cert.Emp_C_Date,
                                 emp_id = e_cert.Emp_Id,
                                 emp_name = e_cert.T_Emploee.Emp_F_Name + " " + e_cert.T_Emploee.Emp_L_Name
                             }).OrderBy(l_id => l_id.id).ToList();

            gv.Columns[0].Caption = "الرقم";
            gv.Columns[1].Caption = "الاسم";
            gv.Columns[2].Caption = "التاريخ";
            gv.Columns[3].Caption = "رقم الموظف";
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
        private void Set_Auto_Id()
        {
            var max_id = cmdEmpCertificate.Get_All().Where(c_id => c_id.Emp_C_Id == cmdEmpCertificate.Get_All().Max(max => max.Emp_C_Id)).FirstOrDefault();
            Emp_C_IdTextEdit.Text = max_id == null ? "1" : (max_id.Emp_C_Id + 1).ToString();
           // Emp_Mp_CodeTextEdit.Text = Emp_Mp_IdTextEdit.Text;
        }
        private void Get_Row_ID(int Row_Id)
        {
            long id;
            if (Row_Id != 0)
            {
                id = Convert.ToInt64(gv.GetRowCellValue(Row_Id, gv.Columns[0]));
                TF_Emp_Certificate = cmdEmpCertificate.Get_By(c_id => c_id.Emp_C_Id == id).FirstOrDefault();
            }
            else
            {
                id = Convert.ToInt64(gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns[0]));
                TF_Emp_Certificate = cmdEmpCertificate.Get_By(c_id => c_id.Emp_C_Id == id).FirstOrDefault();
            }
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            Is_Double_Click = true;
            gv.SelectRow(gv.FocusedRowHandle);

            Get_Row_ID(0);
            if (TF_Emp_Certificate != null)
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
