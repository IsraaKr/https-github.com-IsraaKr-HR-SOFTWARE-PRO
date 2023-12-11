using HR_DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Forms.Forms.Attend_Forms
{
    public partial class F_Attend_Day :F_Master_Inhertanz
    {
        public F_Attend_Day()
        {
            InitializeComponent();
        }
        ClsCommander<T_Attend_Day> cmdAttDay = new ClsCommander<T_Attend_Day>();
        ClsCommander<T_Attend_Month> cmdAttMonth = new ClsCommander<T_Attend_Month>();


        T_Attend_Day TF_Att_Day;
        Boolean Is_Double_Click = false;
        public override void Get_Data(string status_mess)
        {
            if (TF_Att_Day != null)
            {
                try
                {
                    clear_data(this.Controls);
                    Is_Double_Click = false;
                    cmdAttDay = new ClsCommander<T_Attend_Day>();

                    Fill_Graid();
                    load_day_data();
                    GetAtt_Month_Data();
                    base.Get_Data(status_mess);

                }
                catch (Exception ex)
                {
                    Get_Data(ex.InnerException.InnerException.ToString() + "/" + ex.Message);
                }
            }
        }

        private void load_day_data()
        {
            Emp_Att_D_CodeTextEdit.Text = Emp_Att_D_IdTextEdit.Text + " "
                + Emp_Att_D_DateDateEdit.DateTime.Day.ToString("00") +
                  Emp_Att_D_DateDateEdit.DateTime.Month.ToString("00")+
            Emp_Att_D_DateDateEdit.DateTime.Year.ToString("00");

            Emp_Att_D_DayTextEdit.Text = Emp_Att_D_DateDateEdit.DateTime.ToString("ddddd" , new CultureInfo("ar-BH"));
        }

        public override void Insert_Data()
        {
            try
            {
                if (Validate_Data())
                {
                    TF_Att_Day = new T_Attend_Day();
                    Fill_Entitey();
                    cmdAttDay.Insert_Data(TF_Att_Day);
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
                    if (Validate_Data() && gv.RowCount > 0 && TF_Att_Day != null)
                    {
                        Fill_Entitey();
                        cmdAttDay.Update_Data(TF_Att_Day);
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
                                cmdAttDay.Delet_Data(TF_Att_Day);

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
            number_of_errores += Emp_Att_D_IdTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += Emp_Att_D_DayTextEdit.is_text_valid() ? 0 : 1;
            if (Emp_Att_M_IdSearchLookUpEdit.EditValue == null)
            {
                number_of_errores += 1;
               Emp_Att_M_IdSearchLookUpEdit.ErrorText = "هذا الحقل مطلوب";
            }

            return (number_of_errores == 0);
        }

        public void Fill_Controls()
        {
            Emp_Att_D_IdTextEdit.Text = TF_Att_Day.Emp_Att_D_Id.ToString();
            Emp_Att_D_CodeTextEdit.Text = TF_Att_Day.Emp_Att_D_Code;
            Emp_Att_D_DateDateEdit.DateTime = Convert.ToDateTime(TF_Att_Day.Emp_Att_D_Date);
            Emp_Att_D_DayTextEdit.Text = TF_Att_Day.Emp_Att_D_Day;
            Emp_Att_D_StateCheckEdit.Checked = Convert.ToBoolean(TF_Att_Day.Emp_Att_D_State);
            Emp_Att_D_NoteMemoEdit.Text = TF_Att_Day.Emp_Att_D_Note;
           Emp_Att_M_IdSearchLookUpEdit.EditValue = TF_Att_Day.Emp_Att_M_Id;

        }
        public void Fill_Entitey()
        {
            TF_Att_Day.Emp_Att_D_Id = Convert.ToInt64(Emp_Att_D_IdTextEdit.Text);
            TF_Att_Day.Emp_Att_D_Code = Emp_Att_D_CodeTextEdit.Text;
            TF_Att_Day.Emp_Att_D_Date = Convert.ToDateTime(Emp_Att_D_DateDateEdit.DateTime.ToString("yyyy/MM/dd"));
            TF_Att_Day.Emp_Att_D_Day = Emp_Att_D_DayTextEdit.Text;
            TF_Att_Day.Emp_Att_D_State = Convert.ToBoolean(Emp_Att_D_StateCheckEdit.CheckState);
            TF_Att_Day.Emp_Att_D_Note = Emp_Att_D_NoteMemoEdit.Text;
            TF_Att_Day.Emp_Att_M_Id = Convert.ToUInt64(Emp_Att_M_IdSearchLookUpEdit.EditValue);

        }
        private void Fill_Graid()
        {
            gc.DataSource = (from e_exp in cmdAttDay.Get_All()
                             select new
                             {
                                 id = e_exp.Emp_Att_D_Id,                               
                                 date = e_exp.Emp_Att_D_Date,
                                 day = e_exp.Emp_Att_D_Day,
                                 emp_id = e_exp.Emp_Att_M_Id,
                                 emp_name = e_exp.T_Attend_Month.Emp_Att_M_Month_Name 
                             }).OrderBy(l_id => l_id.id).ToList();

            gv.Columns[0].Caption = "الرقم";
            gv.Columns[1].Caption = "التاريخ";
            gv.Columns[2].Caption = "اليوم";
            gv.Columns[3].Caption = "رقم الشهر";
            gv.Columns[4].Caption = "اسم الشهر ";
  

            gv.BestFitColumns();
        }
        public void GetAtt_Month_Data()
        {
            var Emp_List = (from Emp in cmdAttMonth.Get_All().Where(es => es.Emp_Att_M_State == true)
                            select new
                            {
                                id = Emp.Emp_Att_M_Id,
                                name = Emp.Emp_Att_M_Month_Name ,
                                date = Emp.Emp_Att_M_Date
                            }).OrderBy(id => id.id);
            if (Emp_List != null && Emp_List.Count() > 0)
            {
               Emp_Att_M_IdSearchLookUpEdit.slkp_iniatalize_data(Emp_List, "name", "id");
                Emp_Att_M_IdSearchLookUpEdit.Properties.View.Columns[0].Caption = "الرقم";
                Emp_Att_M_IdSearchLookUpEdit.Properties.View.Columns[1].Caption = "الاسم ";
                Emp_Att_M_IdSearchLookUpEdit.Properties.View.Columns[2].Caption = "التاريخ ";
            }
        }
        private void Set_Auto_Id()
        {
            var max_id = cmdAttDay.Get_All().Where(c_id => c_id.Emp_Att_D_Id == cmdAttDay.Get_All().Max(max => max.Emp_Att_D_Id)).FirstOrDefault();
            Emp_Att_D_IdTextEdit.Text = max_id == null ? "1" : (max_id.Emp_Att_D_Id + 1).ToString();
            // Emp_Mp_CodeTextEdit.Text = Emp_Mp_IdTextEdit.Text;
        }
        private void Get_Row_ID(int Row_Id)
        {
            long id;
            if (Row_Id != 0)
            {
                id = Convert.ToInt64(gv.GetRowCellValue(Row_Id, gv.Columns[0]));
                TF_Att_Day = cmdAttDay.Get_By(c_id => c_id.Emp_Att_D_Id == id).FirstOrDefault();
            }
            else
            {
                id = Convert.ToInt64(gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns[0]));
                TF_Att_Day = cmdAttDay.Get_By(c_id => c_id.Emp_Att_D_Id == id).FirstOrDefault();
            }
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            Is_Double_Click = true;
            gv.SelectRow(gv.FocusedRowHandle);

            Get_Row_ID(0);
            if (TF_Att_Day != null)
                Fill_Controls();
        }

        private void gv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete && gv.RowCount > 0)
                Delete_Data();
        }


        private void Emp_Att_IdSearchLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != string.Empty)
            {
                long e_id = Convert.ToInt64(e.Value);
                DateTime date1 = Convert.ToDateTime(cmdAttMonth.Get_By(id => id.Emp_Att_M_Id == e_id).FirstOrDefault().Emp_Att_M_Date);
                e.DisplayText =date1.ToString("MM/yyyy") ;
            
            }
            else
                e.DisplayText = "";
        }

        private void Emp_Att_D_DateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            load_day_data();
        }

        private void btn_add_month_Click(object sender, EventArgs e)
        {
            try
            {
                F_Attend_Month f = new F_Attend_Month();
                f.ShowDialog();
                Get_Data("");
            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString());
            }
        }
    }
}
