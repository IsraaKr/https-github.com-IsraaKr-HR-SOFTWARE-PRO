namespace HR_Forms.Forms.Lists_Forms
{
    partial class F_Emp_Att_Salarey_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Emp_Att_Salarey_List));
            this.Mont_searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataLayoutControl2 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btn_salarey = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.txt_emp_name = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mont_searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).BeginInit();
            this.dataLayoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_emp_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tiltle
            // 
            this.lbl_tiltle.Size = new System.Drawing.Size(776, 48);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataLayoutControl2);
            this.groupControl1.Size = new System.Drawing.Size(776, 97);
            this.groupControl1.Text = "بيانات الدوام الشهري";
            // 
            // Mont_searchLookUpEdit1
            // 
            this.Mont_searchLookUpEdit1.Location = new System.Drawing.Point(12, 12);
            this.Mont_searchLookUpEdit1.Name = "Mont_searchLookUpEdit1";
            this.Mont_searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Mont_searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.Mont_searchLookUpEdit1.Size = new System.Drawing.Size(515, 20);
            this.Mont_searchLookUpEdit1.StyleController = this.dataLayoutControl2;
            this.Mont_searchLookUpEdit1.TabIndex = 0;
            this.Mont_searchLookUpEdit1.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.Mont_searchLookUpEdit1_CustomDisplayText);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // dataLayoutControl2
            // 
            this.dataLayoutControl2.Controls.Add(this.btn_salarey);
            this.dataLayoutControl2.Controls.Add(this.btn_delete);
            this.dataLayoutControl2.Controls.Add(this.btn_print);
            this.dataLayoutControl2.Controls.Add(this.btn_clear);
            this.dataLayoutControl2.Controls.Add(this.txt_emp_name);
            this.dataLayoutControl2.Controls.Add(this.Mont_searchLookUpEdit1);
            this.dataLayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl2.Location = new System.Drawing.Point(2, 23);
            this.dataLayoutControl2.Name = "dataLayoutControl2";
            this.dataLayoutControl2.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl2.Root = this.Root;
            this.dataLayoutControl2.Size = new System.Drawing.Size(772, 72);
            this.dataLayoutControl2.TabIndex = 1;
            this.dataLayoutControl2.Text = "dataLayoutControl2";
            // 
            // btn_salarey
            // 
            this.btn_salarey.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_salarey.ImageOptions.Image")));
            this.btn_salarey.Location = new System.Drawing.Point(594, 38);
            this.btn_salarey.Name = "btn_salarey";
            this.btn_salarey.Size = new System.Drawing.Size(166, 22);
            this.btn_salarey.StyleController = this.dataLayoutControl2;
            this.btn_salarey.TabIndex = 8;
            this.btn_salarey.Text = "احتساب رواتب الشهر";
            this.btn_salarey.Click += new System.EventHandler(this.btn_salarey_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.Location = new System.Drawing.Point(710, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(50, 22);
            this.btn_delete.StyleController = this.dataLayoutControl2;
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "حذف";
            // 
            // btn_print
            // 
            this.btn_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.ImageOptions.Image")));
            this.btn_print.Location = new System.Drawing.Point(594, 12);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(55, 22);
            this.btn_print.StyleController = this.dataLayoutControl2;
            this.btn_print.TabIndex = 6;
            this.btn_print.Text = "طباعة";
            // 
            // btn_clear
            // 
            this.btn_clear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.ImageOptions.Image")));
            this.btn_clear.Location = new System.Drawing.Point(653, 12);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(53, 22);
            this.btn_clear.StyleController = this.dataLayoutControl2;
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "مسح";
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.Location = new System.Drawing.Point(12, 38);
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.Size = new System.Drawing.Size(515, 20);
            this.txt_emp_name.StyleController = this.dataLayoutControl2;
            this.txt_emp_name.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(772, 72);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Mont_searchLookUpEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(582, 26);
            this.layoutControlItem1.Text = "قائمة الشهور";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_emp_name;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(582, 26);
            this.layoutControlItem2.Text = "اسم الموظف";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_clear;
            this.layoutControlItem3.Location = new System.Drawing.Point(641, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(57, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_print;
            this.layoutControlItem4.Location = new System.Drawing.Point(582, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(59, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btn_salarey;
            this.layoutControlItem6.Location = new System.Drawing.Point(582, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(170, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btn_delete;
            this.layoutControlItem5.Location = new System.Drawing.Point(698, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(54, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // F_Emp_Att_Salarey_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "F_Emp_Att_Salarey_List";
            this.Text = "ساعات عمل الموظفين و احتساب الرواتب";
            this.Load += new System.EventHandler(this.F_Emp_Att_Salarey_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Mont_searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).EndInit();
            this.dataLayoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_emp_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit Mont_searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txt_emp_name;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btn_salarey;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_clear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}