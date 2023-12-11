using HR_DataBase;
using HR_Forms.Forms.Lists_Forms;
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
    public partial class F_Attend : F_Master_Inhertanz
    {
        public F_Attend()
        {
            InitializeComponent();
        }
        ClsCommander<T_Attend> cmdAtt = new ClsCommander<T_Attend>();
        ClsCommander<T_Emploee> cmdEmploeey = new ClsCommander<T_Emploee>();
        ClsCommander<T_Attend_Day> cmdAttDay = new ClsCommander<T_Attend_Day>();

        T_Attend TF_Att;
      //  Boolean Is_Double_Click = false;
        public override void Get_Data(string status_mess)
        {
            if (TF_Att != null)
            {
                try
                {
                    clear_data(this.Controls);
                  //  Is_Double_Click = false;
                    cmdAtt = new ClsCommander<T_Attend>();
                    Gride_Data(Emp_IdTextEdit.Text);
                   // Fill_Graid(); 

                    base.Get_Data(status_mess);
                }
                catch (Exception ex)
                {
                    Get_Data(ex.InnerException.InnerException.ToString() + "/" + ex.Message);
                }
            }
        }
        private void Gride_Data( string s_emp_name)
        {
            dataGridView1.Rows.Clear();
            cmdAtt = new ClsCommander<T_Attend>();
            //اذا اليوم موجود مسبقا و عامل عليه حضور
            var data_list = (from att_day in cmdAtt.Get_All().Where(
                               d => d.T_Emploee.Emp_State == true
                            && d.T_Emploee.Emp_St_Id == 1
                            && Convert.ToDateTime(d.Emp_Att_Date).ToString("dd/MM/yyyy") == Emp_Att_DateDateEdit.DateTime.ToString("dd/MM/yyyy")
                            && (d.T_Emploee.Emp_F_Name + " " + d.T_Emploee.Emp_L_Name).Contains(Emp_IdTextEdit.Text))
                             select new
                             {
                                 emp_id = att_day.Emp_Id,
                                 emp_name = att_day.T_Emploee.Emp_F_Name + " " + att_day.T_Emploee.Emp_L_Name,
                                 date = att_day.Emp_Att_Date,
                                 hours = att_day.Emp_Att_Houer,
                                 state = att_day.Emp_Att_State,
                                 note = att_day.Emp_Att_Note
                             }).OrderBy(c=>c.emp_name).ToList();
            if (data_list.Count > 0)
            {
                foreach (var item in data_list)
                {
                    dataGridView1.Rows.Add(item.emp_id,
                                           item.emp_name,
                                           Convert.ToDateTime(item.date).ToString("dd/MM/yyyy"),
                                           item.hours,
                                          item.state,
                                          item.note);

                    lbl_day_states.BackColor = Color.Green;
                }

            }
            else//اذال اليوم مو اخذ عليه حضور و انصاف
            {
                var data_Null_list =(from emp_list in cmdEmploeey.Get_All().Where(
                    d=>d.Emp_State==true 
                    && d.Emp_St_Id==1
                    && (d.Emp_F_Name + " " + d.Emp_L_Name).Contains(Emp_IdTextEdit.Text))
                      join att_day in cmdAtt.Get_All().Where(a=>Convert.ToDateTime(a.Emp_Att_Date).ToString("dd/MM/yyyy") == Emp_Att_DateDateEdit.DateTime.ToString("dd/MM/yyyy"))
                       on emp_list.Emp_Id equals att_day.Emp_Id into list
                       from att in list .DefaultIfEmpty()
                       select new
                       {
                           emp_id = emp_list.Emp_Id,
                           emp_name = emp_list.Emp_F_Name + " " + emp_list.Emp_L_Name,
                           date = att == null ? Emp_Att_DateDateEdit.DateTime : att.Emp_Att_Date,
                           hours = att == null ? 8 : att.Emp_Att_Houer,
                           state = att==null ? true : att.Emp_Att_State,
                           note = att ==null ? " " :att.Emp_Att_Note
                       }).OrderBy(c => c.emp_name).ToList();
                foreach (var item in data_Null_list)
                {
                    dataGridView1.Rows.Add(item.emp_id,
                                           item.emp_name,
                                           Convert.ToDateTime(item.date).ToString("dd/MM/yyyy"),
                                           item.hours,
                                           item.state,
                                           item.note);

                    lbl_day_states.BackColor = Color.OrangeRed;
                }
            }

        }
      

        public override void Insert_Data()
        {
            try
            {
                if (Validate_Data())
                {
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        TF_Att = new T_Attend();
                        TF_Att.Emp_Att_Code = item.Cells[0].Value.ToString() +
                                          Emp_Att_DateDateEdit.DateTime.Day.ToString("00") +
                                           Emp_Att_DateDateEdit.DateTime.Month.ToString("00") +
                                            Emp_Att_DateDateEdit.DateTime.Year.ToString();
                        TF_Att.Emp_Att_Date = Convert.ToDateTime(Emp_Att_DateDateEdit.DateTime.ToString("yyyy/MM/dd"));
                        TF_Att.Emp_Att_Houer = Convert.ToInt32(item.Cells[3].Value);
                        TF_Att.Emp_Att_State = Convert.ToBoolean(item.Cells[4].Value);
                        TF_Att.Emp_Att_Note = item.Cells[2].Value.ToString();
                        TF_Att.Emp_Id= Convert.ToInt64(item.Cells[0].Value);
                        TF_Att.Emp_Att_D_Id = Convert.ToInt64(Emp_Att_D_IdSearchLookUpEdit.EditValue);
                        cmdAtt.Insert_Data(TF_Att);
                       
                    }
                    C_Master.Warning_Massege_Box("تم حفظ سجل الحضور لهذا اليوم ");
                    base.Insert_Data();
                    Get_Data("i");
                }           

            }
            catch (Exception ex)
            {
                cmdAtt.Detached_Data(TF_Att);
                if (ex.InnerException.InnerException.ToString().Contains("Emp_Attend_Day_Index"))
                {
                    C_Master.Warning_Massege_Box("هذا السجل تم حفظه مسبقا يمكنك التعديل ");
                    return;
                }
                Get_Data(ex.InnerException.InnerException.ToString() + "\n " + ex.Message);
            }
        }
        public override void Update_Data()
        {
            try
            {
                //if (Is_Double_Click)
                //{
                    if (Validate_Data() && gv.RowCount > 0 && TF_Att != null)
                    {
                        if (Validate_Data())
                        {
                            foreach (DataGridViewRow item in dataGridView1.Rows)
                            {
                                TF_Att = new T_Attend();
                                TF_Att = cmdAtt.Get_All().Where(x => x.Emp_Id == Convert.ToInt64(item.Cells[0].Value) &&
                                                          x.Emp_Att_Date == Convert.ToDateTime(item.Cells[2].Value)).FirstOrDefault();
                                TF_Att.Emp_Att_Code = item.Cells[0].Value.ToString() +
                                                  Emp_Att_DateDateEdit.DateTime.Day.ToString("00") +
                                                   Emp_Att_DateDateEdit.DateTime.Month.ToString("00") +
                                                    Emp_Att_DateDateEdit.DateTime.Year.ToString();
                                TF_Att.Emp_Att_Date = Convert.ToDateTime(Emp_Att_DateDateEdit.DateTime.ToString("yyyy/MM/dd"));
                                TF_Att.Emp_Att_Houer = Convert.ToInt32(item.Cells[2].Value);
                                TF_Att.Emp_Att_State = Convert.ToBoolean(item.Cells[3].Value);
                                TF_Att.Emp_Att_Note = item.Cells[2].Value.ToString();
                                TF_Att.Emp_Id = Convert.ToInt64(item.Cells[5].Value);
                                TF_Att.Emp_Att_D_Id = Convert.ToInt64(Emp_Att_D_IdSearchLookUpEdit.EditValue);
                                cmdAtt.Update_Data(TF_Att);

                            }
                            C_Master.Warning_Massege_Box("تم تعديل سجل الحضور لهذا اليوم ");
                            base.Update_Data();
                            Get_Data("u");
                        }
                    }
                    //else
                    //    C_Master.Warning_Massege_Box("الرجاء اختيار عنصر لتعديله");

               // }
            }
            catch (Exception ex)
            {
                cmdAtt.Detached_Data(TF_Att);
                Get_Data(ex.InnerException.InnerException.ToString() + "\n " + ex.Message);
            }


        }
        public override void Delete_Data()
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    TF_Att = new T_Attend();
                    TF_Att = cmdAtt.Get_All().Where(x => x.Emp_Id == Convert.ToInt64(item.Cells[0].Value) &&
                                              x.Emp_Att_Date == Convert.ToDateTime(item.Cells[2].Value)).FirstOrDefault();
                }
                C_Master.Warning_Massege_Box("تم حذف سجل الحضور لهذا اليوم ");
                Get_Data("d");
                //if (Is_Double_Click)
                //{
                //if (C_Master.Qustion_Massege_Box(C_Master.mas_del) == DialogResult.Yes)
                //{
                //    if (gv.RowCount > 0)
                //    {
                //        foreach (int row_id in gv.GetSelectedRows())
                //        {
                //           // Get_Row_ID(row_id);
                //            cmdAtt.Delet_Data(TF_Att);

                //        }
                //        base.Delete_Data();
                //        Get_Data("d");
                //    }
                //}
                //    else
                //        C_Master.Warning_Massege_Box("الرجاء اختيار عنصر من الجدول لحذفه");
                //}
            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString() + "\n " + ex.Message);
            }
        }


        public override void clear_data(Control.ControlCollection s_controls)
        {
            base.clear_data(s_controls);
            Set_Auto_Id();

            Emp_Att_DateDateEdit.DateTime = DateTime.Now;
            Att_day_list();
            Gride_Data(Emp_IdTextEdit.Text);
            lbl_day_states.BackColor = Color.White;
        }
        public override void Print_Data()
        {
            base.Print_Data();
        }

        public override bool Validate_Data()
        {
            int number_of_errores = 0;
         //   number_of_errores += Emp_Att_IdTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += Name_DayTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += Emp_IdTextEdit.is_text_valid() ? 0 : 1;
            if (Emp_Att_DateDateEdit.EditValue == null)
            {
                number_of_errores += 1;
              Emp_Att_DateDateEdit.ErrorText = "هذا الحقل مطلوب";
            }
            if (Emp_Att_D_IdSearchLookUpEdit.EditValue == null)
            {
                number_of_errores += 1;
                Emp_Att_D_IdSearchLookUpEdit.ErrorText = "هذا الحقل مطلوب";
            }
            return (number_of_errores == 0);
        }
    
       
       
        private void Set_Auto_Id()
        {
            var max_id = cmdAtt.Get_All().Where(c_id => c_id.Emp_Att_Id == cmdAtt.Get_All().Max(max => max.Emp_Att_Id)).FirstOrDefault();
        //   Emp_Att_IdTextEdit.Text = max_id == null ? "1" : (max_id.Emp_Att_Id + 1).ToString();
            // Emp_Mp_CodeTextEdit.Text = Emp_Mp_IdTextEdit.Text;
        }
        //private void Get_Row_ID(int Row_Id)
        //{
        //    long id;
        //    if (Row_Id != 0)
        //    {
        //        id = Convert.ToInt64(gv.GetRowCellValue(Row_Id, gv.Columns[0]));
        //        TF_Att = cmdAtt.Get_By(c_id => c_id.Emp_Att_Id == id).FirstOrDefault();
        //    }
        //    else
        //    {
        //        id = Convert.ToInt64(gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns[0]));
        //        TF_Att = cmdAtt.Get_By(c_id => c_id.Emp_Att_Id == id).FirstOrDefault();
        //    }
        //}
        public void Att_day_list()
        {
            cmdAttDay = new ClsCommander<T_Attend_Day>(); 
            var Emp_List = (from Emp in cmdAttDay.Get_All().Where(es => es.Emp_Att_D_State == true)
                            select new
                            {
                                id = Emp.Emp_Att_D_Id,
                                name = Emp.Emp_Att_D_Day,
                                date = Emp.Emp_Att_D_Date
                            }).OrderBy(id => id.id);
            if (Emp_List != null && Emp_List.Count() > 0)
            {
                Emp_Att_D_IdSearchLookUpEdit.slkp_iniatalize_data(Emp_List, "name", "id");
                Emp_Att_D_IdSearchLookUpEdit.Properties.View.Columns[0].Caption = "الرقم";
                Emp_Att_D_IdSearchLookUpEdit.Properties.View.Columns[1].Caption = "الاسم ";
                Emp_Att_D_IdSearchLookUpEdit.Properties.View.Columns[2].Caption = "التاريخ ";
            }

            var dayList = cmdAttDay.Get_All().Where(d => Convert.ToDateTime(d.Emp_Att_D_Date).ToString("dd/MM/yyyy") == Emp_Att_DateDateEdit.DateTime.ToString("dd/MM/yyyy")).FirstOrDefault();
            Emp_Att_D_IdSearchLookUpEdit.EditValue = dayList == null ? 0 : dayList.Emp_Att_D_Id ;
        }
        //private void gv_DoubleClick(object sender, EventArgs e)
        //{
        //    Is_Double_Click = true;
        //    gv.SelectRow(gv.FocusedRowHandle);

        //    Get_Row_ID(0);
        //    if (TF_Att != null)
        //        Fill_Controls();
        //}

        //private void gv_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.Delete && gv.RowCount > 0)
        //        Delete_Data();
        //}

        private void Emp_Att_D_IdSearchLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != string.Empty && Convert.ToInt64(e.Value)!=0)
            {
                long e_id = Convert.ToInt64(e.Value);
              var   days_list = cmdAttDay.Get_By(id => id.Emp_Att_D_Id == e_id).FirstOrDefault();
                DateTime date1 = Convert.ToDateTime(days_list.Emp_Att_D_Date);
                e.DisplayText = date1.ToString("dd/MM/yyyy");
                Name_DayTextEdit.Text = days_list.Emp_Att_D_Day;
            }
            else
                e.DisplayText = "";
            Name_DayTextEdit.Text = "";
        }

        private void Emp_Att_DateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Att_day_list();
                Gride_Data(Emp_IdTextEdit.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_add_day_Click(object sender, EventArgs e)
        {
            try
            {
                F_Attend_Day f = new F_Attend_Day();
                f.ShowDialog();
                Att_day_list();
            }
            catch (Exception ex)
            {

                Get_Data(ex.InnerException.InnerException.ToString() + "/" + ex.Message);
            }

        }

        private void Emp_IdSearchLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            Gride_Data(Emp_IdTextEdit.Text);
        }

        private void btn_emp_add_Click(object sender, EventArgs e)
        {
            F_Emp_List f = new F_Emp_List();
            f.ShowDialog();
            Emp_IdTextEdit.Text = f.Emploee.Emp_F_Name + " " + f.Emploee.Emp_L_Name;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==4 & e.RowIndex ==dataGridView1.CurrentRow.Index)
            {
                if (Convert.ToBoolean(dataGridView1.CurrentRow.Cells[4].Value)==true)
                {
                    dataGridView1.CurrentRow.Cells[4].Value = false;
                    dataGridView1.CurrentRow.Cells[3].Value = 0;

                }
             

            }
        }
    }
}
