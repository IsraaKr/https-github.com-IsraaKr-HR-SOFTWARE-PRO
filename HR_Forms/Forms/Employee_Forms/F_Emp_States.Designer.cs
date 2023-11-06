namespace HR_Forms.Forms.Employee_Forms
{
    partial class F_Emp_States
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gc = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Emp_St_IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Emp_St_CodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Emp_St_NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Emp_St_StateCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.Company_IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Emp_St_NoteTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForEmp_St_Code = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_St_Name = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_St_State = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_St_Note = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCompany_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_St_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_St_IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_St_CodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_St_NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_St_StateCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Company_IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_St_NoteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_St_Code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_St_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_St_State)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_St_Note)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompany_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_St_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gc);
            this.dataLayoutControl1.Controls.Add(this.Emp_St_IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_St_CodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_St_NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_St_StateCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.Company_IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_St_NoteTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 24);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.DrawItemBorders = true;
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(800, 279);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gc
            // 
            this.gc.Location = new System.Drawing.Point(24, 24);
            this.gc.MainView = this.gv;
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(431, 231);
            this.gc.TabIndex = 10;
            this.gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gv.Appearance.EvenRow.Options.UseBackColor = true;
            this.gv.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv.Appearance.HeaderPanel.Options.UseFont = true;
            this.gv.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gv.Appearance.Row.Options.UseTextOptions = true;
            this.gv.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gv.GridControl = this.gc;
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.Editable = false;
            this.gv.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gv.OptionsSelection.MultiSelect = true;
            this.gv.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv.OptionsView.EnableAppearanceEvenRow = true;
            this.gv.OptionsView.ShowAutoFilterRow = true;
            this.gv.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gv_SelectionChanged);
            this.gv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gv_KeyDown);
            this.gv.DoubleClick += new System.EventHandler(this.gv_DoubleClick);
            // 
            // Emp_St_IdTextEdit
            // 
            this.Emp_St_IdTextEdit.Location = new System.Drawing.Point(609, 45);
            this.Emp_St_IdTextEdit.Name = "Emp_St_IdTextEdit";
            this.Emp_St_IdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Emp_St_IdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Emp_St_IdTextEdit.Properties.Mask.EditMask = "G";
            this.Emp_St_IdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Emp_St_IdTextEdit.Properties.ReadOnly = true;
            this.Emp_St_IdTextEdit.Size = new System.Drawing.Size(110, 20);
            this.Emp_St_IdTextEdit.StyleController = this.dataLayoutControl1;
            this.Emp_St_IdTextEdit.TabIndex = 4;
            // 
            // Emp_St_CodeTextEdit
            // 
            this.Emp_St_CodeTextEdit.Location = new System.Drawing.Point(609, 69);
            this.Emp_St_CodeTextEdit.Name = "Emp_St_CodeTextEdit";
            this.Emp_St_CodeTextEdit.Properties.ReadOnly = true;
            this.Emp_St_CodeTextEdit.Size = new System.Drawing.Size(110, 20);
            this.Emp_St_CodeTextEdit.StyleController = this.dataLayoutControl1;
            this.Emp_St_CodeTextEdit.TabIndex = 5;
            // 
            // Emp_St_NameTextEdit
            // 
            this.Emp_St_NameTextEdit.Location = new System.Drawing.Point(483, 93);
            this.Emp_St_NameTextEdit.Name = "Emp_St_NameTextEdit";
            this.Emp_St_NameTextEdit.Size = new System.Drawing.Size(236, 20);
            this.Emp_St_NameTextEdit.StyleController = this.dataLayoutControl1;
            this.Emp_St_NameTextEdit.TabIndex = 6;
            // 
            // Emp_St_StateCheckEdit
            // 
            this.Emp_St_StateCheckEdit.Location = new System.Drawing.Point(483, 45);
            this.Emp_St_StateCheckEdit.Name = "Emp_St_StateCheckEdit";
            this.Emp_St_StateCheckEdit.Properties.Caption = "فعال";
            this.Emp_St_StateCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.Emp_St_StateCheckEdit.Size = new System.Drawing.Size(122, 20);
            this.Emp_St_StateCheckEdit.StyleController = this.dataLayoutControl1;
            this.Emp_St_StateCheckEdit.TabIndex = 7;
            // 
            // Company_IdTextEdit
            // 
            this.Company_IdTextEdit.Location = new System.Drawing.Point(483, 235);
            this.Company_IdTextEdit.Name = "Company_IdTextEdit";
            this.Company_IdTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Company_IdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Company_IdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Company_IdTextEdit.Properties.Mask.EditMask = "G";
            this.Company_IdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Company_IdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Company_IdTextEdit.Size = new System.Drawing.Size(236, 20);
            this.Company_IdTextEdit.StyleController = this.dataLayoutControl1;
            this.Company_IdTextEdit.TabIndex = 9;
            // 
            // Emp_St_NoteTextEdit
            // 
            this.Emp_St_NoteTextEdit.Location = new System.Drawing.Point(483, 117);
            this.Emp_St_NoteTextEdit.Name = "Emp_St_NoteTextEdit";
            this.Emp_St_NoteTextEdit.Size = new System.Drawing.Size(236, 114);
            this.Emp_St_NoteTextEdit.StyleController = this.dataLayoutControl1;
            this.Emp_St_NoteTextEdit.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 279);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(780, 259);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForEmp_St_Code,
            this.ItemForEmp_St_Name,
            this.ItemForEmp_St_State,
            this.ItemForEmp_St_Note,
            this.ItemForCompany_Id,
            this.ItemForEmp_St_Id});
            this.layoutControlGroup2.Location = new System.Drawing.Point(459, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(321, 259);
            this.layoutControlGroup2.Text = "بيانات حالة الموظف";
            // 
            // ItemForEmp_St_Code
            // 
            this.ItemForEmp_St_Code.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmp_St_Code.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForEmp_St_Code.Control = this.Emp_St_CodeTextEdit;
            this.ItemForEmp_St_Code.Location = new System.Drawing.Point(126, 24);
            this.ItemForEmp_St_Code.Name = "ItemForEmp_St_Code";
            this.ItemForEmp_St_Code.Size = new System.Drawing.Size(171, 24);
            this.ItemForEmp_St_Code.Text = "كود الحالة";
            this.ItemForEmp_St_Code.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForEmp_St_Name
            // 
            this.ItemForEmp_St_Name.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmp_St_Name.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForEmp_St_Name.Control = this.Emp_St_NameTextEdit;
            this.ItemForEmp_St_Name.Location = new System.Drawing.Point(0, 48);
            this.ItemForEmp_St_Name.Name = "ItemForEmp_St_Name";
            this.ItemForEmp_St_Name.Size = new System.Drawing.Size(297, 24);
            this.ItemForEmp_St_Name.Text = "اسم الحالة";
            this.ItemForEmp_St_Name.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForEmp_St_State
            // 
            this.ItemForEmp_St_State.Control = this.Emp_St_StateCheckEdit;
            this.ItemForEmp_St_State.Location = new System.Drawing.Point(0, 0);
            this.ItemForEmp_St_State.Name = "ItemForEmp_St_State";
            this.ItemForEmp_St_State.Size = new System.Drawing.Size(126, 48);
            this.ItemForEmp_St_State.Text = "Emp_St_State";
            this.ItemForEmp_St_State.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForEmp_St_State.TextVisible = false;
            // 
            // ItemForEmp_St_Note
            // 
            this.ItemForEmp_St_Note.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmp_St_Note.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForEmp_St_Note.Control = this.Emp_St_NoteTextEdit;
            this.ItemForEmp_St_Note.Location = new System.Drawing.Point(0, 72);
            this.ItemForEmp_St_Note.Name = "ItemForEmp_St_Note";
            this.ItemForEmp_St_Note.Size = new System.Drawing.Size(297, 118);
            this.ItemForEmp_St_Note.Text = "الملاحظات";
            this.ItemForEmp_St_Note.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForCompany_Id
            // 
            this.ItemForCompany_Id.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForCompany_Id.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForCompany_Id.Control = this.Company_IdTextEdit;
            this.ItemForCompany_Id.Location = new System.Drawing.Point(0, 190);
            this.ItemForCompany_Id.Name = "ItemForCompany_Id";
            this.ItemForCompany_Id.Size = new System.Drawing.Size(297, 24);
            this.ItemForCompany_Id.Text = "رقم الشركة";
            this.ItemForCompany_Id.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForEmp_St_Id
            // 
            this.ItemForEmp_St_Id.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmp_St_Id.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForEmp_St_Id.Control = this.Emp_St_IdTextEdit;
            this.ItemForEmp_St_Id.Location = new System.Drawing.Point(126, 0);
            this.ItemForEmp_St_Id.Name = "ItemForEmp_St_Id";
            this.ItemForEmp_St_Id.Size = new System.Drawing.Size(171, 24);
            this.ItemForEmp_St_Id.Text = "رقم الحالة";
            this.ItemForEmp_St_Id.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(459, 259);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(435, 235);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // F_Emp_States
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "F_Emp_States";
            this.Text = "حالة الموظف";
            this.Controls.SetChildIndex(this.dataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_St_IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_St_CodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_St_NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_St_StateCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Company_IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_St_NoteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_St_Code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_St_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_St_State)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_St_Note)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompany_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_St_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
        private DevExpress.XtraEditors.TextEdit Emp_St_IdTextEdit;
        private DevExpress.XtraEditors.TextEdit Emp_St_CodeTextEdit;
        private DevExpress.XtraEditors.TextEdit Emp_St_NameTextEdit;
        private DevExpress.XtraEditors.CheckEdit Emp_St_StateCheckEdit;
        private DevExpress.XtraEditors.TextEdit Company_IdTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_St_Code;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_St_Name;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_St_State;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_St_Note;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompany_Id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_St_Id;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraEditors.MemoEdit Emp_St_NoteTextEdit;
    }
}