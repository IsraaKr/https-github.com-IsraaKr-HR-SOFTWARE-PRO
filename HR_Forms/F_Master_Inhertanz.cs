﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Forms
{
    public partial class F_Master_Inhertanz : Form
    {
        public F_Master_Inhertanz()
        {
            InitializeComponent();
        }


        public void change_states_message(string status_mess)
        {
            bar_states.Caption = "...";
            bar_states.ItemAppearance.Normal.BackColor = F_Master_Inhertanz.DefaultBackColor;
            if (status_mess == "")
            {
                return;
            }
            else if (status_mess == "i")
            {
                bar_states.Caption = "             تم الإدخال بنجاح              ";
                bar_states.ItemAppearance.Normal.BackColor = Color.DarkSeaGreen;
                clear_data(this.Controls);
            }
            else if (status_mess == "u")
            {
                bar_states.Caption = "             تم التعديل بنجاح              ";
                bar_states.ItemAppearance.Normal.BackColor = Color.Khaki;
                clear_data(this.Controls);
            }
            else if (status_mess == "d")
            {
                bar_states.Caption = "             تم الحذف بنجاح              ";
                bar_states.ItemAppearance.Normal.BackColor = Color.IndianRed;
                clear_data(this.Controls);
            }
            else
            {
                MessageBox.Show(status_mess);
                bar_states.Caption = "            فشل الإجراء             ";
                bar_states.ItemAppearance.Normal.BackColor = Color.Maroon;
                bar_states.ItemAppearance.Normal.ForeColor = Color.White;
            }

        }
        //فيرتشول من اجل اعمله اوفر رايدينغ عند الوراثة و 
        // البراميتر من نوع الداتا بيس انتتي
        public virtual void Get_Data(string status_mess)
        {
            change_states_message(status_mess);
        }
        public virtual bool Validate_Data()
        {
            return true;
        }
        //الادخال
        public virtual void Insert_Data()
        {
            timer_states_bar.Enabled = true;

        }
        //التعديل
        public virtual void Update_Data()
        {
            timer_states_bar.Enabled = true;

        }
        public virtual void Print_Data()
        {
           

        }
        //الحذف
        public virtual void Delete_Data()
        {
            timer_states_bar.Enabled = true;

        }

        public virtual void Clear_Data(Control.ControlCollection Controls)
        {
            Action<Control.ControlCollection> func = null;
        func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = null;
                    else if (control is DateEdit)
                        (control as DateEdit).DateTime = DateTime.Now;
                    else if (control is TimeSpanEdit)
                        (control as TimeSpanEdit).EditValue = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
                    else if (control is TimeEdit)
                        (control as TimeEdit).Time = DateTime.Now;
                    else if (control is SearchLookUpEdit)
                    {
                        (control as SearchLookUpEdit).Text = "";
                        (control as SearchLookUpEdit).EditValue = null;
                    }
                    else if (control is LookUpEdit)
                    {
                        control.Text = null;
                        (control as LookUpEdit).EditValue = null;
                    }
                    else if (control is PictureEdit)
    (control as PictureEdit).Image = null;

else
    func(control.Controls);
            };
func(Controls);

        }


        //لتفريغ الحقول و لتغير جملة الستاتس
public virtual void clear_data(Control.ControlCollection s_controls)
        {    //كود لتفريغ كل محتوى الكونترولات
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control c in controls)
                    if (c is TextBox)
                        (c as TextBox).Text  =string.Empty ;
                    else if (c is DateEdit)
                        (c as DateEdit).DateTime = DateTime.Now;
                    else if (c is TimeSpanEdit)
                        (c as TimeSpanEdit).EditValue = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
                    else if (c is SearchLookUpEdit)
                    {
                        (c as SearchLookUpEdit).Text = "";
                        (c as SearchLookUpEdit).EditValue = null;
                    }
                    else if (c is LookUpEdit)
                    {
                        c.Text = null;
                        (c as LookUpEdit).EditValue = null;
                    }
                    else if (c is PictureEdit)
                        (c as PictureEdit).Image = null;
                    //else if (c is DateTimePicker)
                    //    (c as DateTimePicker).Value = DateTime.Now;
                    //else if (c is System.Windows.Forms.ComboBox)
                    //    (c as System.Windows.Forms.ComboBox).SelectedIndex = -1;
                    //else if (c is TimeEdit)
                    //    (c as TimeEdit).Time = DateTime.Now;
                    else
                        func(c.Controls);
            };
            func(s_controls);
        }



        private void barr_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Insert_Data();
            timer_states_bar.Enabled = true;
        }

        private void bar_edite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Update_Data();
            timer_states_bar.Enabled = true;
        }

        private void bar_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            Delete_Data();
            timer_states_bar.Enabled = true;
        }

        private void bar_clear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear_data(this.Controls);
            Get_Data("");
            timer_states_bar.Enabled = true;
        }

        private void timer_states_bar_Tick(object sender, EventArgs e)
        {
            change_states_message("");
            timer_states_bar.Enabled = false;
        }

        private void F_Master_Inhertanz_Load(object sender, EventArgs e)
        {
            Get_Data("");
        }

        private void bar_print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Print_Data();
        }
    }
}
