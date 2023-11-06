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
    public partial class F_Emp_Map : F_Master_Inhertanz
    {
        public F_Emp_Map()
        {
            InitializeComponent();
        }

        ClsCommander<T_Employee_Map> cmd_Emp_Map = new ClsCommander<T_Employee_Map>();
        T_Employee_Map TF_Emp_Map;
        Boolean Is_Double_Click = false;

        public override void Get_Data(string status_mess)
        {
            try
            {
                clear_data(this.Controls);
                Is_Double_Click = false;
                cmd_Emp_Map = new ClsCommander<T_Employee_Map>();
                TF_Emp_Map = cmd_Emp_Map.Get_All().FirstOrDefault();
                Fill_Graid();

                base.Get_Data(status_mess);

            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString() +"/" +ex.Message);
            }
        }
        public override void Insert_Data()
        {
            try
            {
                if (Validate_Data())
                {
                    TF_Emp_Map = new T_Employee_Map();
                    Fill_Entitey();
                    cmd_Emp_Map.Insert_Data(TF_Emp_Map);
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
                    if (Validate_Data() && gv.RowCount>0 && TF_Emp_Map!=null)
                    {
                        Fill_Entitey();
                        cmd_Emp_Map.Update_Data(TF_Emp_Map);
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
                                cmd_Emp_Map.Delet_Data(TF_Emp_Map);

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
            Emp_Mp_LevelTextEdit.Text = "0";
            Emp_Mp_BonasTextEdit.Text = "0";
            Emp_Mp_BlusTextEdit.Text = "0";
            Emp_Mp_YearTextEdit.Text = "0";
            Emp_Mp_SalaryTextEdit.Text = "0";
            Emp_Mp_Single_BonsTextEdit.Text = "0";
            Emp_Mp_Marrid_BonsTextEdit.Text = "0";
            Set_Auto_Id();

        }
        public override bool Validate_Data()
        {
            int number_of_errores = 0;
            number_of_errores += Emp_Mp_IdTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += Emp_Mp_ClassTextEdit.is_text_valid() ? 0 : 1;

            return (number_of_errores==0) ;
        }
        public override void Print_Data()
        {
            base.Print_Data();
        }
        private void Set_Auto_Id()
        {
            var max_id = cmd_Emp_Map.Get_All().Where(c_id => c_id.Emp_Mp_Id==cmd_Emp_Map.Get_All().Max(max=> max.Emp_Mp_Id)).FirstOrDefault();
            Emp_Mp_IdTextEdit.Text = max_id == null ? "1" : (max_id.Emp_Mp_Id + 1).ToString();
            Emp_Mp_CodeTextEdit.Text = Emp_Mp_IdTextEdit.Text;
        }
        public void Fill_Controls()
        {

            Emp_Mp_IdTextEdit.Text = TF_Emp_Map.Emp_Mp_Id.ToString();
            Emp_Mp_CodeTextEdit.Text = TF_Emp_Map.Emp_Mp_Code ;
            Emp_Mp_ClassTextEdit.Text = TF_Emp_Map.Emp_Mp_Class;
            Emp_Mp_LevelTextEdit.Text = TF_Emp_Map.Emp_Mp_Level;
            Emp_Mp_BonasTextEdit.Text = TF_Emp_Map.Emp_Mp_Bonas.ToString(); ;
            Emp_Mp_BlusTextEdit.Text = TF_Emp_Map.Emp_Mp_Blus.ToString(); ;
            Emp_Mp_YearTextEdit.Text = TF_Emp_Map.Emp_Mp_Year.ToString(); ;
            Emp_Mp_SalaryTextEdit.Text = TF_Emp_Map.Emp_Mp_Salary.ToString(); ;
            Emp_Mp_Single_BonsTextEdit.Text = TF_Emp_Map.Emp_Mp_Single_Bons.ToString(); ;
            Emp_Mp_Marrid_BonsTextEdit.Text = TF_Emp_Map.Emp_Mp_Marrid_Bons.ToString(); ;


        }
        public void Fill_Entitey()
        {
           TF_Emp_Map.Emp_Mp_Id =Convert.ToInt64( Emp_Mp_IdTextEdit.Text) ;
             TF_Emp_Map.Emp_Mp_Code = Emp_Mp_CodeTextEdit.Text ;
             TF_Emp_Map.Emp_Mp_Class = Emp_Mp_ClassTextEdit.Text ;
            TF_Emp_Map.Emp_Mp_Level = Emp_Mp_LevelTextEdit.Text ;
           TF_Emp_Map.Emp_Mp_Bonas =Convert.ToDecimal( Emp_Mp_BonasTextEdit.Text ) ;
           TF_Emp_Map.Emp_Mp_Blus = Convert.ToDecimal(Emp_Mp_BlusTextEdit.Text ) ;
          TF_Emp_Map.Emp_Mp_Year = Convert.ToDecimal(Emp_Mp_YearTextEdit.Text ) ;
           TF_Emp_Map.Emp_Mp_Salary = Convert.ToDecimal(Emp_Mp_SalaryTextEdit.Text ) ;
            TF_Emp_Map.Emp_Mp_Single_Bons = Convert.ToDecimal(Emp_Mp_Single_BonsTextEdit.Text );
             TF_Emp_Map.Emp_Mp_Marrid_Bons = Convert.ToDecimal(Emp_Mp_Marrid_BonsTextEdit.Text ) ;
            TF_Emp_Map.Company_Id = 1;
        }
        private void Fill_Graid()
        {
            cmd_Emp_Map = new ClsCommander<T_Employee_Map>();
            gc.DataSource = cmd_Emp_Map.Get_All().ToList();

            gv.Columns[0].Caption = "الرقم";
            gv.Columns[1].Visible = false;
            gv.Columns[2].Caption = "الفئة";
            gv.Columns[3].Caption = "الدرجة";
            gv.Columns[4].Caption = "العلاوات الشهرية";
            gv.Columns[5].Caption = "المكافئات ";
            gv.Columns[6].Caption = "الراتب السنوي";
            gv.Columns[7].Caption = "الراتب الشهري";
            gv.Columns[8].Caption = "علاوة الأعزب";
            gv.Columns[9].Caption = "علاوة المتزوج";
            gv.Columns[10].Visible = false;
            gv.Columns[11].Visible = false;
            gv.Columns[12].Visible = false;
            gv.Columns[13].Visible = false;

            gv.BestFitColumns();

        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            Is_Double_Click = true;
            gv.SelectRow(gv.FocusedRowHandle);

            Get_Row_ID(0);
            if (TF_Emp_Map != null)
                Fill_Controls();


        }

        private void Get_Row_ID(int Row_Id)
        {
            long id;
            if (Row_Id!=0)
            {
                 id = Convert.ToInt64(gv.GetRowCellValue(Row_Id, gv.Columns[0]));
                TF_Emp_Map = cmd_Emp_Map.Get_By(c_id => c_id.Emp_Mp_Id == id).FirstOrDefault();

            }
            else
            
           {
                id = Convert.ToInt64(gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns[0]));
                TF_Emp_Map = cmd_Emp_Map.Get_By(c_id => c_id.Emp_Mp_Id == id).FirstOrDefault();

            }
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

        private void Emp_Mp_BonasTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Emp_Mp_YearTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Emp_Mp_Single_BonsTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Emp_Mp_Marrid_BonsTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
