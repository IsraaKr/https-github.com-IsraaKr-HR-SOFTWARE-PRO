using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HR_DataBase;

namespace HR_Forms.Forms.Employee_Forms
{
    public partial class F_Emp_States : F_Master_Inhertanz
    {
        public F_Emp_States()
        {
            InitializeComponent();
        }

        ClsCommander<T_Employee_State> cmdEmpState =new ClsCommander<T_Employee_State>();
        T_Employee_State TF_Emp_State;
        Boolean Is_Double_Click = false;

        public override void Get_Data(string status_mess)
        {
            try
            {
                clear_data(this.Controls);
                Is_Double_Click = false;
                //cmdEmpState = new ClsCommander<T_Employee_State>();
                TF_Emp_State = cmdEmpState.Get_All().FirstOrDefault();
                Fill_Graid();   

                base.Get_Data(status_mess);
            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString());
            }
           
        }

        private void Set_Auto_Id()
        {
            var Max_Id = cmdEmpState.Get_All().Where(c_id => c_id.Emp_St_Id == cmdEmpState.Get_All().Max(max => max.Emp_St_Id)).FirstOrDefault();
            Emp_St_IdTextEdit.Text = Max_Id == null ? "1" : (Max_Id.Emp_St_Id + 1).ToString();

            Emp_St_CodeTextEdit.Text = Emp_St_IdTextEdit.Text;

        }

        public override bool Validate_Data()
        {
            int number_of_errores = 0;

    //        number_of_errores += lkp_state.is_editevalue_valid() ? 0 : 1;
 
            number_of_errores += Emp_St_NameTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += Emp_St_IdTextEdit.is_text_valid() ? 0 : 1;
            return (number_of_errores == 0);

        }
        public override void Insert_Data()
        {
            try
            {
                if (Validate_Data())
                {
                    TF_Emp_State = new T_Employee_State();
                    //if (TF_Emp_State != null)
                        Fill_Entitey();
                    cmdEmpState.Insert_Data(TF_Emp_State);
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
                    if (Validate_Data() && gv.RowCount > 0)
                    {
                        long id = Convert.ToInt64(Emp_St_IdTextEdit.Text);
                        TF_Emp_State = cmdEmpState.Get_By(c_id => c_id.Emp_St_Id == id).FirstOrDefault();
                        if (TF_Emp_State != null)
                            Fill_Entitey();
                        base.Update_Data();
                        Get_Data("u");
                    }
                }
                else
                    C_Master.Warning_Massege_Box("يجب اختيار عنصر من الجدول لتعديله");
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
                    if (C_Master.Qustion_Massege_Box("هل أنت متأكد أنك تريد الحذف") == DialogResult.Yes)
                    {
                        if (gv.RowCount > 0)
                            foreach (int row_id in gv.GetSelectedRows())
                            {
                                long id = Convert.ToInt64(gv.GetRowCellValue(row_id, gv.Columns["id"]));
                                TF_Emp_State = cmdEmpState.Get_By(c_id => c_id.Emp_St_Id == id).FirstOrDefault();
                                cmdEmpState.Delet_Data(TF_Emp_State);
                            }
                        base.Delete_Data();
                        Get_Data("d");

                    }
                }
                else
                    C_Master.Warning_Massege_Box(" يجب اختيار عنصر من الجدول لحذفه");
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
        public void Fill_Controls()
        {
            Emp_St_IdTextEdit.Text = TF_Emp_State.Emp_St_Id.ToString();
            Emp_St_CodeTextEdit.Text = TF_Emp_State.Emp_St_Code;
            Emp_St_NameTextEdit.Text = TF_Emp_State.Emp_St_Name;
            Emp_St_StateCheckEdit.Checked =Convert.ToBoolean( TF_Emp_State.Emp_St_State);
            Emp_St_NoteTextEdit.Text = TF_Emp_State.Emp_St_Note;
        }
        public void Fill_Entitey()
        {
            TF_Emp_State.Emp_St_Id = Convert.ToInt64(Emp_St_IdTextEdit.Text);

            TF_Emp_State.Emp_St_Code = Emp_St_IdTextEdit.Text .Trim();
             TF_Emp_State.Emp_St_Name = Emp_St_NameTextEdit.Text.Trim();
            TF_Emp_State.Emp_St_State = Convert.ToBoolean(Emp_St_StateCheckEdit.CheckState) ;
           TF_Emp_State.Emp_St_Note = Emp_St_NoteTextEdit.Text.Trim();
            TF_Emp_State.Company_Id = 1;

        }
        private void Fill_Graid()
        {
            gc.DataSource = (from Emp_s in cmdEmpState.Get_All()
                             select new
                             {
                                 id = Emp_s.Emp_St_Id,
                                 name = Emp_s.Emp_St_Name,
                                 state = Emp_s.Emp_St_State
                             }).OrderBy(c_id => c_id.id).ToList();

            gv.Columns["id"].Caption = "الرقم";
            gv.Columns["name"].Caption = "اسم الحالة";
            gv.Columns["state"].Caption = "الحالة";

            gv.BestFitColumns();
        }
        private void gv_DoubleClick(object sender, EventArgs e)
        {
            Is_Double_Click = true;
            gv.SelectRow(gv.FocusedRowHandle);
            long id = Convert.ToInt64(gv.GetRowCellValue(gv.FocusedRowHandle,gv.Columns["id"]));
            TF_Emp_State = cmdEmpState.Get_By(c_id => c_id.Emp_St_Id == id).FirstOrDefault();

            Fill_Controls();
        }
        private void gv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete && gv.RowCount > 0)
                Delete_Data();  
        }

        private void gv_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            Is_Double_Click = true;
        }
    }
}
