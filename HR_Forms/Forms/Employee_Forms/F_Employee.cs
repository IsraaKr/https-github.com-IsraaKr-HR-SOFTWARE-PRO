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
using HR_DataBase;

namespace HR_Forms.Forms.Employee_Forms
{
    public partial class F_Employee : F_Master_Inhertanz
    {
        public F_Employee()
        {
            InitializeComponent();
        }

        ClsCommander<T_Emploee> cmdEmploeey = new ClsCommander<T_Emploee>();
        ClsCommander<T_Employee_State> cmdEmpState = new ClsCommander<T_Employee_State> ();
        ClsCommander<T_Employee_Map> cmdEmpMap = new ClsCommander<T_Employee_Map>();
        ClsCommander<T_Employee_File> cmdEmpFile = new ClsCommander<T_Employee_File>();

        T_Emploee TF_Emploee;
        Boolean Is_Double_Click = false;
        string Base64file;
        long emp_id;

        #region override
        public override void Get_Data(string status_mess)
        {
            if (TF_Emploee != null)
            {
                try
                {
                    clear_data(this.Controls);
                    Is_Double_Click = false;
                    cmdEmploeey = new ClsCommander<T_Emploee>();
                    cmdEmpState = new ClsCommander<T_Employee_State>();
                    cmdEmpMap = new ClsCommander<T_Employee_Map>();
                    Fill_Grid();
                    base.Get_Data(status_mess);

                    GetEmp_Map_Data();
                    GetEmp_State_Data();
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
                    TF_Emploee = new T_Emploee();
                    Fill_Entitey();
                    cmdEmploeey.Insert_Data(TF_Emploee);
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
                    if (Validate_Data() && gv.RowCount > 0 && TF_Emploee != null)
                    {
                        Fill_Entitey();
                        cmdEmploeey.Update_Data(TF_Emploee);
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
                                cmdEmploeey.Delet_Data(TF_Emploee);

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
        public override bool Validate_Data()
        {
            int number_of_errores = 0;
            number_of_errores += Emp_F_NameTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += Emp_IdTextEdit.is_text_valid() ? 0 : 1;

            return (number_of_errores == 0);
           
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

        #endregion

        #region methodes
        private void Set_Auto_Id()
        {
            var Max_id = cmdEmploeey.Get_All().Where(l_id => l_id.Emp_Id ==cmdEmploeey.Get_All().Max(Max => Max.Emp_Id)).FirstOrDefault();
            Emp_IdTextEdit.Text = Max_id == null ? "1" : (Max_id.Emp_Id+1).ToString();
            Emp_CodeTextEdit.Text = Emp_IdTextEdit.Text;
        }
        public void Fill_Controls()
        {
            Emp_IdTextEdit.Text = TF_Emploee.Emp_Id.ToString();
            emp_id = Convert.ToInt64(Emp_IdTextEdit.Text);

            Emp_CodeTextEdit.Text = TF_Emploee.Emp_Code;
            Emp_F_NameTextEdit.Text = TF_Emploee.Emp_F_Name;
            Emp_L_NameTextEdit.Text = TF_Emploee.Emp_L_Name;
            Emp_Nation_numTextEdit.Text = TF_Emploee.Emp_Nation_num;
            Emp_B_DateDateEdit.DateTime =Convert.ToDateTime( TF_Emploee.Emp_B_Date);
            Emp_AgeTextEdit.Text = TF_Emploee.Emp_Age.ToString();
            Emp_GenderTextEdit.SelectedIndex = Convert.ToInt32( TF_Emploee.Emp_Gender);
            Emp_AddressTextEdit.Text = TF_Emploee.Emp_Address;
            Emp_PhoneTextEdit.Text = TF_Emploee.Emp_Phone;
            Emp_MobileTextEdit.Text = TF_Emploee.Emp_Mobile;
            //   Emp_MaritialComboBoxEdit.SelectedIndex=Convert.ToInt32( TF_Emploee.Emp_Maritial);
             Emp_MaritialComboBoxEdit.Text= TF_Emploee.Emp_Maritial;
            Emp_StateCheckEdit.Checked =Convert.ToBoolean( TF_Emploee.Emp_State);
            Emp_NoteTextEdit.Text = TF_Emploee.Emp_Note;

            Emp_St_IdSearchLookUpEdit.EditValue = TF_Emploee.Emp_St_Id;
            Emp_Mp_IdSearchLookUpEdit.EditValue = TF_Emploee.Emp_Mp_Id;

            //show image 
            var emp_image = cmdEmpFile.Get_By(x => x.Emp_Id==emp_id && x.Emp_F_Type== "صورة شخصية" && x.Emp_F_State == true).ToList();
            if (emp_image.FirstOrDefault() != null)
 
            pic_photo.Image = from_bytes_toImage(emp_image.FirstOrDefault().Emp_F_Path );
        }
        public void Fill_Entitey()
        {
            TF_Emploee.Emp_Id  = Convert.ToInt64( Emp_IdTextEdit.Text)  ;
            TF_Emploee.Emp_Code= Emp_CodeTextEdit.Text  ;
            TF_Emploee.Emp_F_Name= Emp_F_NameTextEdit.Text  ;
            TF_Emploee.Emp_L_Name=  Emp_L_NameTextEdit.Text ;
            TF_Emploee.Emp_Nation_num= Emp_Nation_numTextEdit.Text  ;
            TF_Emploee.Emp_B_Date =  Convert.ToDateTime(Emp_B_DateDateEdit.DateTime.ToString("yyyy/MM/dd"));
            TF_Emploee.Emp_Age= Convert.ToInt32( Emp_AgeTextEdit.Text) ;
            TF_Emploee.Emp_Gender  = Convert.ToInt32(Emp_GenderTextEdit.SelectedIndex);
            TF_Emploee.Emp_Address= Emp_AddressTextEdit.Text ;
            TF_Emploee.Emp_Phone= Emp_PhoneTextEdit.Text ;
            TF_Emploee.Emp_Mobile= Emp_MobileTextEdit.Text ;
            //   Emp_MaritialComboBoxEdit.SelectedIndex=Convert.ToInt32( TF_Emploee.Emp_Maritial);
            TF_Emploee.Emp_Maritial= Emp_MaritialComboBoxEdit.Text ;
            TF_Emploee.Emp_State = Convert.ToBoolean(Emp_StateCheckEdit.CheckState);
            TF_Emploee.Emp_Note= Emp_NoteTextEdit.Text ;

            TF_Emploee.Emp_St_Id= Convert.ToInt64(Emp_St_IdSearchLookUpEdit.EditValue) ;
            TF_Emploee.Emp_Mp_Id= Convert.ToInt64(Emp_Mp_IdSearchLookUpEdit.EditValue );
        }
        private void Fill_Grid()
        {

            gc.DataSource = (from emp in cmdEmploeey.Get_All()
                             join emp_st in cmdEmpState.Get_All() 
                             on emp.Emp_St_Id equals emp_st.Emp_St_Id into jointable 
                             from x in jointable .DefaultIfEmpty()//اذا ما كتبنا هاد السطر بكون اينر جوين و نحنا بدنا نعمل رايت جوين
                             select new
                             {
                                 id = emp.Emp_Id,
                                 name = emp.Emp_F_Name + " " + emp.Emp_L_Name,
                                 nation_id = emp.Emp_Nation_num,
                                 mobile = emp.Emp_Mobile + " / " + emp.Emp_Phone,
                                 state = emp.Emp_State,
                                 states_name=x==null ? " " : x.Emp_St_Name
                             }).OrderBy(l_id =>l_id.id).ToList() ;

            gv.Columns[0].Caption = "الرقم";
            gv.Columns[1].Caption = "الاسم";
            gv.Columns[2].Caption = "الرقم الوطني";
            gv.Columns[3].Caption = "الهاتف";
            gv.Columns[4].Caption = "فعال";
            gv.Columns[5].Caption = "حالة العمل";

            gv.BestFitColumns();
         
        }
        private void Get_Row_ID(int Row_Id)
        {
            long id;
            if (Row_Id != 0)
            {
                id = Convert.ToInt64(gv.GetRowCellValue(Row_Id, gv.Columns[0]));
                TF_Emploee = cmdEmploeey.Get_By(c_id => c_id.Emp_Id == id).FirstOrDefault();
            }
            else
            {
                id = Convert.ToInt64(gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns[0]));
                TF_Emploee = cmdEmploeey.Get_By(c_id => c_id.Emp_Id == id).FirstOrDefault();
            }
        }
        public void GetEmp_State_Data()
        {
            var EmpState_List = (from Emp_S in cmdEmpState.Get_All().Where(es => es.Emp_St_State == true)
                                 select new
                                 { 
                                 es_id =Emp_S.Emp_St_Id,
                                 es_name =Emp_S.Emp_St_Name
                                 }).OrderBy(id => id.es_id);
            if (EmpState_List != null && EmpState_List.Count() > 0)
            {
                Emp_St_IdSearchLookUpEdit.slkp_iniatalize_data(EmpState_List, "es_name", "es_id");
                Emp_St_IdSearchLookUpEdit.Properties.View.Columns[0].Caption = "الرقم";
                Emp_St_IdSearchLookUpEdit.Properties.View.Columns[1].Caption = "اسم الحالة";

            }

        }
        public void GetEmp_Map_Data()
        {
            var EmpMap_List = (from Emp_m in cmdEmpMap.Get_All()
                                 select new
                                 {
                                     em_id = Emp_m.Emp_Mp_Id,
                                     em_class = Emp_m.Emp_Mp_Class,
                                     em_level = Emp_m.Emp_Mp_Level
                                 }).OrderBy(id => id.em_id);
            if (EmpMap_List != null && EmpMap_List.Count() > 0)
            {
                Emp_Mp_IdSearchLookUpEdit.slkp_iniatalize_data(EmpMap_List, "em_class", "em_id");
                Emp_Mp_IdSearchLookUpEdit.Properties.View.Columns[0].Caption = "الرقم";
                Emp_Mp_IdSearchLookUpEdit.Properties.View.Columns[1].Caption = "الفئة ";
                Emp_Mp_IdSearchLookUpEdit.Properties.View.Columns[2].Caption = " الدرجة";
            }
        }
      
        #endregion

        #region event
        private void gv_DoubleClick(object sender, EventArgs e)
        {
            Is_Double_Click = true;
            gv.SelectRow(gv.FocusedRowHandle);

            Get_Row_ID(0);
            if (TF_Emploee != null)
                Fill_Controls();
        }
        private void Emp_B_DateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            Emp_AgeTextEdit.Text = (DateTime.Now.Year - Emp_B_DateDateEdit.DateTime.Year).ToString();
        }
        private void btn_load_pic_Click(object sender, EventArgs e)
        {
            chose_image();

        }      
        private void btn_save_pic_Click(object sender, EventArgs e)
        {
            long e_id = Convert.ToInt64(Emp_IdTextEdit.Text);
            TF_Emploee = cmdEmploeey.Get_By(c_id => c_id.Emp_Id == e_id).FirstOrDefault();
            if (TF_Emploee != null)
            {
                T_Employee_File e_files = new T_Employee_File();
                e_files = cmdEmpFile.Get_By(id => id.Emp_Id == e_id && id.Emp_F_Type == "صورة شخصية" && id.Emp_F_State == true).FirstOrDefault();
                if (e_files != null)
                {
                    e_files.Emp_F_Path = Base64file;
                    cmdEmpFile.Update_Data(e_files);
                }
                else
                {
                    e_files = new T_Employee_File();
                    e_files.Emp_Id = e_id;
                    e_files.Emp_F_Name = "صورة شخصية";
                    e_files.Emp_F_Type = "صورة شخصية";
                    e_files.Emp_F_State = true;
                    e_files.Emp_F_Path = Base64file;
                    cmdEmpFile.Insert_Data(e_files);
                }
                C_Master.Warning_Massege_Box("تم حفظ الصورة");
            }
        }
        //لعرض النص في السيرش لوك اب ايديت عند الدبل كليك
        private void Emp_Mp_IdSearchLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != string.Empty)
            {
                long m_id = Convert.ToInt64(e.Value);
                e.DisplayText = cmdEmpMap.Get_By(id => id.Emp_Mp_Id == m_id).FirstOrDefault().Emp_Mp_Class;
            }
            else
                e.DisplayText = "";

        }
        private void Emp_St_IdSearchLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != string.Empty)
            {
                long s_id = Convert.ToInt64(e.Value);
                e.DisplayText = cmdEmpState.Get_By(id => id.Emp_St_Id == s_id).FirstOrDefault().Emp_St_Name;
            }
            else
                e.DisplayText = "";

        }
        private void gv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete && gv.RowCount > 0)
                Delete_Data();
        }


        #endregion

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
            if (path != null)
            {
                byte[] bytes = Convert.FromBase64String(path);
                Image im;
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    im = Image.FromStream(ms);
                }

                return im;
            }
            return null;
        }


        #endregion

        private void btn_files_Click(object sender, EventArgs e)
        {
            F_Emp_Files f;
            if (TF_Emploee !=null)
                 f = new F_Emp_Files(TF_Emploee.Emp_Id);
                      
            else
                f = new F_Emp_Files();
            f.ShowDialog();

        }

        private void btn_certificate_Click(object sender, EventArgs e)
        {
            F_Emp_Certificate f;
            if (TF_Emploee != null)
                f = new F_Emp_Certificate(TF_Emploee.Emp_Id);
            else
                f = new F_Emp_Certificate();
            f.ShowDialog();
        }

            private void btn_experiance_Click(object sender, EventArgs e)
        {
            F_Emp_Experians f;
            if (TF_Emploee != null)
                f = new F_Emp_Experians(TF_Emploee.Emp_Id);
            else
                f = new F_Emp_Experians();
            f.ShowDialog();
        }

        private void btn_social_Click(object sender, EventArgs e)
        {
            F_Emp_Social f;
            if (TF_Emploee != null)
                f = new F_Emp_Social(TF_Emploee.Emp_Id);
            else
                f = new F_Emp_Social();
            f.ShowDialog();
        }
    }
}
