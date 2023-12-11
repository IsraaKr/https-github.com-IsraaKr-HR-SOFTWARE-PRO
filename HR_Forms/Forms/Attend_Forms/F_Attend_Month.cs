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

namespace HR_Forms.Forms.Attend_Forms
{
    public partial class F_Attend_Month : F_Master_Inhertanz
    {
        public F_Attend_Month()
        {
            InitializeComponent();
        }
        ClsCommander<T_Attend_Month> cmdAttMonth = new ClsCommander<T_Attend_Month>();


        T_Attend_Month TF_Att_Month;
        Boolean Is_Double_Click = false;
        public override void Get_Data(string status_mess)
        {
            clear_data(this.Controls);
            load_month_data();
            if (TF_Att_Month != null)
            {
                try
                {
                   
                    Is_Double_Click = false;
                    cmdAttMonth = new ClsCommander<T_Attend_Month>();

                    Fill_Graid();
                             
                    base.Get_Data(status_mess);
                }
                catch (Exception ex)
                {
                    Get_Data(ex.InnerException.InnerException.ToString() + "/" + ex.Message);
                }
            }
        }

        private void load_month_data()
        {
           Emp_Att_M_CodeTextEdit.Text = Emp_Att_M_IdTextEdit.Text + " "
                + Emp_Att_M_DateDateEdit.DateTime.Month.ToString("00") +
               Emp_Att_M_DateDateEdit.DateTime.Year.ToString();

           Emp_Att_M_Month_NameTextEdit.Text = Emp_Att_M_DateDateEdit.DateTime.ToString("MMM");
           Emp_Att_M_Month_NumTextEdit.Text = Emp_Att_M_DateDateEdit.DateTime.ToString("MM");
           Emp_Att_M_Month_NameTextEdit.Text = Emp_Att_M_DateDateEdit.DateTime.ToString("MMM");
           Emp_Att_M_Day_CountTextEdit.Text = (DateTime.DaysInMonth(Emp_Att_M_DateDateEdit.DateTime.Year, Emp_Att_M_DateDateEdit.DateTime.Month) * 8).ToString();
        }

        public override void Insert_Data()
        {
            try
            {
                if (Validate_Data())
                {
                    TF_Att_Month = new T_Attend_Month();
                    Fill_Entitey();
                    cmdAttMonth.Insert_Data(TF_Att_Month);
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
                    if (Validate_Data() && gv.RowCount > 0 && TF_Att_Month != null)
                    {
                        Fill_Entitey();
                        cmdAttMonth.Update_Data(TF_Att_Month);
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
                                cmdAttMonth.Delet_Data(TF_Att_Month);

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
            number_of_errores += Emp_Att_M_IdTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += Emp_Att_M_CodeTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += Emp_Att_M_Month_NameTextEdit.is_text_valid() ? 0 : 1;


            return (number_of_errores == 0);
        }

        public void Fill_Controls()
        {
           Emp_Att_M_IdTextEdit.Text = TF_Att_Month.Emp_Att_M_Id.ToString();
           Emp_Att_M_CodeTextEdit.Text = TF_Att_Month.Emp_Att_M_Code;
           Emp_Att_M_DateDateEdit.DateTime = Convert.ToDateTime(TF_Att_Month.Emp_Att_M_Date);
           Emp_Att_M_Month_NumTextEdit.Text = TF_Att_Month.Emp_Att_M_Month_Num.ToString();
           Emp_Att_M_Day_CountTextEdit.Text = TF_Att_Month.Emp_Att_M_Day_Count.ToString();
           Emp_Att_M_Month_NameTextEdit.Text = TF_Att_Month.Emp_Att_M_Month_Name;
           Emp_Att_M_StateCheckEdit.Checked = Convert.ToBoolean(TF_Att_Month.Emp_Att_M_State);
           Emp_Att_M_NoteMemoEdit.Text = TF_Att_Month.Emp_Att_M_Note;

        }
        public void Fill_Entitey()
        {
            TF_Att_Month.Emp_Att_M_Id = Convert.ToInt64(Emp_Att_M_IdTextEdit.Text);
            TF_Att_Month.Emp_Att_M_Code = Emp_Att_M_CodeTextEdit.Text;
            TF_Att_Month.Emp_Att_M_Date = Convert.ToDateTime(Emp_Att_M_DateDateEdit.DateTime.ToString("yyyy/MM/dd"));
            TF_Att_Month.Emp_Att_M_Month_Num = Convert.ToInt64(Emp_Att_M_Month_NumTextEdit.Text);
            TF_Att_Month.Emp_Att_M_Day_Count = Convert.ToInt32(Emp_Att_M_Day_CountTextEdit.Text);
            TF_Att_Month.Emp_Att_M_Month_Name = Emp_Att_M_Month_NameTextEdit.Text;
            TF_Att_Month.Emp_Att_M_State = Convert.ToBoolean(Emp_Att_M_StateCheckEdit.CheckState);
            TF_Att_Month.Emp_Att_M_Note = Emp_Att_M_NoteMemoEdit.Text;

        }
        private void Fill_Graid()
        {
            gc.DataSource = (from att_Mo in cmdAttMonth.Get_All()
                             select new
                             {
                                 id = att_Mo.Emp_Att_M_Id,
                                 date = att_Mo.Emp_Att_M_Date,
                                 name = att_Mo.Emp_Att_M_Month_Name,
                                 num = att_Mo.Emp_Att_M_Month_Num,
                             }).OrderBy(l_id => l_id.id).ToList();

            gv.Columns[0].Caption = "الرقم";
            gv.Columns[1].Caption = "التاريخ";
            gv.Columns[2].Caption = "اسم الشهر";
            gv.Columns[3].Caption = "رقم الشهر";


            gv.BestFitColumns();
        }
        private void Set_Auto_Id()
        {
            var max_id = cmdAttMonth.Get_All().Where(c_id => c_id.Emp_Att_M_Id == cmdAttMonth.Get_All().Max(max => max.Emp_Att_M_Id)).FirstOrDefault();
           Emp_Att_M_IdTextEdit.Text = max_id == null ? "1" : (max_id.Emp_Att_M_Id + 1).ToString();
            // Emp_Mp_CodeTextEdit.Text = Emp_Mp_IdTextEdit.Text;
        }
        private void Get_Row_ID(int Row_Id)
        {
            long id;
            if (Row_Id != 0)
            {
                id = Convert.ToInt64(gv.GetRowCellValue(Row_Id, gv.Columns[0]));
                TF_Att_Month = cmdAttMonth.Get_By(c_id => c_id.Emp_Att_M_Id == id).FirstOrDefault();
            }
            else
            {
                id = Convert.ToInt64(gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns[0]));
                TF_Att_Month = cmdAttMonth.Get_By(c_id => c_id.Emp_Att_M_Id == id).FirstOrDefault();
            }
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            Is_Double_Click = true;
            gv.SelectRow(gv.FocusedRowHandle);

            Get_Row_ID(0);
            if (TF_Att_Month != null)
                Fill_Controls();
        }

        private void gv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete && gv.RowCount > 0)
                Delete_Data();
        }

        private void Emp_Att_DateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            load_month_data();
        }

        private void Emp_Att_IdTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
