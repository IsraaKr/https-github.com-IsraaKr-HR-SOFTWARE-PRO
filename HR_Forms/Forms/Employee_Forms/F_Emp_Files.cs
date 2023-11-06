using HR_DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Forms.Forms.Employee_Forms
{
    public partial class F_Emp_Files : F_Master_Inhertanz
    {
        public F_Emp_Files()
        {
            InitializeComponent();
        }

        ClsCommander<T_Employee_File> cmdEmpFile = new ClsCommander<T_Employee_File>();
        ClsCommander<T_Emploee> cmdEmploeey = new ClsCommander<T_Emploee>();

        string Base64file;
        T_Employee_File TF_Emp_File;
        Boolean Is_Double_Click = false;
        public override void Get_Data(string status_mess)
        {
            try
            {
                clear_data(this.Controls);
                Is_Double_Click = false;
                cmdEmpFile = new ClsCommander<T_Employee_File>();

               Fill_Graid();

               GetEmp_Data();
                base.Get_Data(status_mess);

            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString() + "/" + ex.Message);
            }

        }
        public override void Insert_Data()
        {
            try
            {
                if (Validate_Data() )
                {
                    TF_Emp_File = new T_Employee_File();
                    Fill_Entitey();
                    cmdEmpFile.Insert_Data(TF_Emp_File);
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
                    if (Validate_Data() && gv.RowCount > 0 && TF_Emp_File != null)
                    {
                        Fill_Entitey();
                        cmdEmpFile.Update_Data(TF_Emp_File);
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
                                cmdEmpFile.Delet_Data(TF_Emp_File);

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
        }
        public override void Print_Data()
        {
            base.Print_Data();
        }

        public override bool Validate_Data()
        {
            int number_of_errores = 0;
            number_of_errores += Emp_F_NameTextEdit.is_text_valid() ? 0 : 1;
            if (Emp_Id_SearchLookUpEdit.EditValue == null)
            {
                number_of_errores += 1;
               Emp_Id_SearchLookUpEdit.ErrorText = "هذا الحقل مطلوب";
            }
            if (pic_photo.Image == null)
            {
                number_of_errores += 1;
                pic_photo.ErrorText = "الرجاء اختيار صورة";
            }

            return (number_of_errores == 0);
        }

        public void Fill_Controls()
        {
            Emp_F_NameTextEdit.Text = TF_Emp_File.Emp_F_Name;
            Emp_F_TypeTextEdit.Text = TF_Emp_File.Emp_F_Type;
      
            Emp_F_NoteTextEdit.Text = TF_Emp_File.Emp_F_Note;
            Emp_F_StateCheckEdit.Checked = Convert.ToBoolean(TF_Emp_File.Emp_F_State);

            Emp_Id_SearchLookUpEdit.EditValue = TF_Emp_File.Emp_Id;

            //show image 
            if (TF_Emp_File.Emp_F_Path != string.Empty)

                pic_photo.Image = from_bytes_toImage(TF_Emp_File.Emp_F_Path);

            Base64file = TF_Emp_File.Emp_F_Path;

        }
        public void Fill_Entitey()
        {
            TF_Emp_File.Emp_F_Name  = Emp_F_NameTextEdit.Text  ;
            TF_Emp_File.Emp_F_Type = Emp_F_TypeTextEdit.Text  ;
            TF_Emp_File.Emp_F_Path = Base64file;
            TF_Emp_File.Emp_F_Note =  Emp_F_NoteTextEdit.Text ;
            TF_Emp_File.Emp_F_State = Convert.ToBoolean(Emp_F_StateCheckEdit.CheckState) ;

            TF_Emp_File.Emp_Id =Convert.ToUInt64( Emp_Id_SearchLookUpEdit.EditValue) ;

        }
        private void Fill_Graid()
        {
            gc.DataSource = (from e_file in cmdEmpFile.Get_All()
                            select new
                             {
                                 id = e_file.Emp_F_Id,
                                 name = e_file.Emp_F_Name ,
                                 type = e_file.Emp_F_Type,                                                       
                                 emp_id =e_file.Emp_Id,
                                emp_name = e_file.T_Emploee.Emp_F_Name + " " + e_file.T_Emploee.Emp_L_Name
                            }).OrderBy(l_id => l_id.id).ToList();

            gv.Columns[0].Caption = "الرقم";
            gv.Columns[1].Caption = "الاسم";
            gv.Columns[2].Caption = "النوع";
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
            if (Emp_List != null && Emp_List.Count()>0)
            {
                Emp_Id_SearchLookUpEdit.slkp_iniatalize_data(Emp_List, "name", "id");
                Emp_Id_SearchLookUpEdit.Properties.View.Columns[0].Caption = "الرقم";
                Emp_Id_SearchLookUpEdit.Properties.View.Columns[1].Caption = "الاسم ";
            }
        }
        private void Emp_Id_SearchLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != string.Empty)
            {
                long e_id = Convert.ToInt64(e.Value);
                e.DisplayText = cmdEmploeey.Get_By(id => id.Emp_Id == e_id).FirstOrDefault().Emp_F_Name ;
            }
            else
                e.DisplayText = "";
        }

        #region Image
        private void chose_image()
        {
            //open file dialog
            OpenFileDialog open = new OpenFileDialog();
            //image filter
            open.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.bmp;*.png) |*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                from_image_toBytes(open);
            }
        }
        private void from_image_toBytes(OpenFileDialog open)
        {
            pic_photo.Image = new Bitmap(open.FileName);
            pic_photo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            string file_path = open.FileName;
            byte[] bytes = File.ReadAllBytes(open.FileName);
            Base64file = Convert.ToBase64String(bytes);
        }
        public Image from_bytes_toImage(string path)
        {
            byte[] bytes = Convert.FromBase64String(path);
            Image im;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                im = Image.FromStream(ms);
            }

            return im;
        }

        #endregion

        private void btn_load_pic_Click(object sender, EventArgs e)
        {
            chose_image();
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            Is_Double_Click = true;
            gv.SelectRow(gv.FocusedRowHandle);

            Get_Row_ID(0);
            if (TF_Emp_File != null)
                Fill_Controls();
        }
        private void Get_Row_ID(int Row_Id)
        {
            long id;
            if (Row_Id != 0)
            {
                id = Convert.ToInt64(gv.GetRowCellValue(Row_Id, gv.Columns[0]));
                TF_Emp_File = cmdEmpFile.Get_By(c_id => c_id.Emp_F_Id == id).FirstOrDefault();
            }
            else
            {
                id = Convert.ToInt64(gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns[0]));
                TF_Emp_File = cmdEmpFile.Get_By(c_id => c_id.Emp_F_Id == id).FirstOrDefault();
            }
        }

        private void gv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete && gv.RowCount > 0)
                Delete_Data();
        }
    }
}
