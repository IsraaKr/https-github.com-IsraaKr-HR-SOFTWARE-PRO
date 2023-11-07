namespace HR_Forms.Forms.Salarey_Forms
{
    partial class F_Salarey_Master
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
            this.Emp_Sal_IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Emp_Sal_NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Emp_Sal_SalaryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Emp_Sal_StateCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.Emp_Sal_NoteMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Emp_Mp_IdSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForEmp_Sal_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_Sal_Name = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_Sal_Salary = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_Sal_State = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_Sal_Note = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_Mp_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Sal_IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Sal_NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Sal_SalaryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Sal_StateCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Sal_NoteMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Mp_IdSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Sal_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Sal_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Sal_Salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Sal_State)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Sal_Note)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Mp_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gc);
            this.dataLayoutControl1.Controls.Add(this.Emp_Sal_IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_Sal_NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_Sal_SalaryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_Sal_StateCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_Sal_NoteMemoEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_Mp_IdSearchLookUpEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 24);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(800, 404);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gc
            // 
            this.gc.Location = new System.Drawing.Point(12, 12);
            this.gc.MainView = this.gv;
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(491, 380);
            this.gc.TabIndex = 22;
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
            this.gv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gv_KeyDown);
            this.gv.DoubleClick += new System.EventHandler(this.gv_DoubleClick);
            // 
            // Emp_Sal_IdTextEdit
            // 
            this.Emp_Sal_IdTextEdit.Location = new System.Drawing.Point(519, 69);
            this.Emp_Sal_IdTextEdit.Name = "Emp_Sal_IdTextEdit";
            this.Emp_Sal_IdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Emp_Sal_IdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Emp_Sal_IdTextEdit.Properties.Mask.EditMask = "G";
            this.Emp_Sal_IdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Emp_Sal_IdTextEdit.Properties.ReadOnly = true;
            this.Emp_Sal_IdTextEdit.Size = new System.Drawing.Size(66, 20);
            this.Emp_Sal_IdTextEdit.StyleController = this.dataLayoutControl1;
            this.Emp_Sal_IdTextEdit.TabIndex = 4;
            // 
            // Emp_Sal_NameTextEdit
            // 
            this.Emp_Sal_NameTextEdit.Location = new System.Drawing.Point(519, 93);
            this.Emp_Sal_NameTextEdit.Name = "Emp_Sal_NameTextEdit";
            this.Emp_Sal_NameTextEdit.Size = new System.Drawing.Size(194, 20);
            this.Emp_Sal_NameTextEdit.StyleController = this.dataLayoutControl1;
            this.Emp_Sal_NameTextEdit.TabIndex = 5;
            // 
            // Emp_Sal_SalaryTextEdit
            // 
            this.Emp_Sal_SalaryTextEdit.Location = new System.Drawing.Point(519, 117);
            this.Emp_Sal_SalaryTextEdit.Name = "Emp_Sal_SalaryTextEdit";
            this.Emp_Sal_SalaryTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Emp_Sal_SalaryTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Emp_Sal_SalaryTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Emp_Sal_SalaryTextEdit.Properties.Mask.EditMask = "G";
            this.Emp_Sal_SalaryTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Emp_Sal_SalaryTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Emp_Sal_SalaryTextEdit.Size = new System.Drawing.Size(194, 20);
            this.Emp_Sal_SalaryTextEdit.StyleController = this.dataLayoutControl1;
            this.Emp_Sal_SalaryTextEdit.TabIndex = 6;
            // 
            // Emp_Sal_StateCheckEdit
            // 
            this.Emp_Sal_StateCheckEdit.EditValue = true;
            this.Emp_Sal_StateCheckEdit.Location = new System.Drawing.Point(652, 69);
            this.Emp_Sal_StateCheckEdit.Name = "Emp_Sal_StateCheckEdit";
            this.Emp_Sal_StateCheckEdit.Properties.Caption = "حالة الراتب";
            this.Emp_Sal_StateCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.Emp_Sal_StateCheckEdit.Size = new System.Drawing.Size(124, 20);
            this.Emp_Sal_StateCheckEdit.StyleController = this.dataLayoutControl1;
            this.Emp_Sal_StateCheckEdit.TabIndex = 7;
            // 
            // Emp_Sal_NoteMemoEdit
            // 
            this.Emp_Sal_NoteMemoEdit.Location = new System.Drawing.Point(519, 157);
            this.Emp_Sal_NoteMemoEdit.Name = "Emp_Sal_NoteMemoEdit";
            this.Emp_Sal_NoteMemoEdit.Size = new System.Drawing.Size(257, 223);
            this.Emp_Sal_NoteMemoEdit.StyleController = this.dataLayoutControl1;
            this.Emp_Sal_NoteMemoEdit.TabIndex = 8;
            // 
            // Emp_Mp_IdSearchLookUpEdit
            // 
            this.Emp_Mp_IdSearchLookUpEdit.Location = new System.Drawing.Point(519, 45);
            this.Emp_Mp_IdSearchLookUpEdit.Name = "Emp_Mp_IdSearchLookUpEdit";
            this.Emp_Mp_IdSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Emp_Mp_IdSearchLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Emp_Mp_IdSearchLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Emp_Mp_IdSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Emp_Mp_IdSearchLookUpEdit.Properties.NullText = "";
            this.Emp_Mp_IdSearchLookUpEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.Emp_Mp_IdSearchLookUpEdit.Size = new System.Drawing.Size(194, 20);
            this.Emp_Mp_IdSearchLookUpEdit.StyleController = this.dataLayoutControl1;
            this.Emp_Mp_IdSearchLookUpEdit.TabIndex = 9;
            this.Emp_Mp_IdSearchLookUpEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.Emp_Mp_IdSearchLookUpEdit_CustomDisplayText);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 404);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(780, 384);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForEmp_Sal_Id,
            this.ItemForEmp_Sal_Name,
            this.ItemForEmp_Sal_Salary,
            this.ItemForEmp_Sal_State,
            this.ItemForEmp_Sal_Note,
            this.ItemForEmp_Mp_Id});
            this.layoutControlGroup2.Location = new System.Drawing.Point(495, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(285, 384);
            this.layoutControlGroup2.Text = "بيانات الراتب";
            // 
            // ItemForEmp_Sal_Id
            // 
            this.ItemForEmp_Sal_Id.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmp_Sal_Id.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForEmp_Sal_Id.Control = this.Emp_Sal_IdTextEdit;
            this.ItemForEmp_Sal_Id.Location = new System.Drawing.Point(0, 24);
            this.ItemForEmp_Sal_Id.Name = "ItemForEmp_Sal_Id";
            this.ItemForEmp_Sal_Id.Size = new System.Drawing.Size(133, 24);
            this.ItemForEmp_Sal_Id.Text = "الرقم";
            this.ItemForEmp_Sal_Id.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForEmp_Sal_Name
            // 
            this.ItemForEmp_Sal_Name.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmp_Sal_Name.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForEmp_Sal_Name.Control = this.Emp_Sal_NameTextEdit;
            this.ItemForEmp_Sal_Name.Location = new System.Drawing.Point(0, 48);
            this.ItemForEmp_Sal_Name.Name = "ItemForEmp_Sal_Name";
            this.ItemForEmp_Sal_Name.Size = new System.Drawing.Size(261, 24);
            this.ItemForEmp_Sal_Name.Text = "اسم الراتب";
            this.ItemForEmp_Sal_Name.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForEmp_Sal_Salary
            // 
            this.ItemForEmp_Sal_Salary.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmp_Sal_Salary.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForEmp_Sal_Salary.Control = this.Emp_Sal_SalaryTextEdit;
            this.ItemForEmp_Sal_Salary.Location = new System.Drawing.Point(0, 72);
            this.ItemForEmp_Sal_Salary.Name = "ItemForEmp_Sal_Salary";
            this.ItemForEmp_Sal_Salary.Size = new System.Drawing.Size(261, 24);
            this.ItemForEmp_Sal_Salary.Text = "الراتب";
            this.ItemForEmp_Sal_Salary.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForEmp_Sal_State
            // 
            this.ItemForEmp_Sal_State.Control = this.Emp_Sal_StateCheckEdit;
            this.ItemForEmp_Sal_State.Location = new System.Drawing.Point(133, 24);
            this.ItemForEmp_Sal_State.Name = "ItemForEmp_Sal_State";
            this.ItemForEmp_Sal_State.Size = new System.Drawing.Size(128, 24);
            this.ItemForEmp_Sal_State.Text = "Emp_Sal_State";
            this.ItemForEmp_Sal_State.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForEmp_Sal_State.TextVisible = false;
            // 
            // ItemForEmp_Sal_Note
            // 
            this.ItemForEmp_Sal_Note.Control = this.Emp_Sal_NoteMemoEdit;
            this.ItemForEmp_Sal_Note.Location = new System.Drawing.Point(0, 96);
            this.ItemForEmp_Sal_Note.Name = "ItemForEmp_Sal_Note";
            this.ItemForEmp_Sal_Note.Size = new System.Drawing.Size(261, 243);
            this.ItemForEmp_Sal_Note.StartNewLine = true;
            this.ItemForEmp_Sal_Note.Text = "الملاحظات";
            this.ItemForEmp_Sal_Note.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForEmp_Sal_Note.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForEmp_Mp_Id
            // 
            this.ItemForEmp_Mp_Id.Control = this.Emp_Mp_IdSearchLookUpEdit;
            this.ItemForEmp_Mp_Id.Location = new System.Drawing.Point(0, 0);
            this.ItemForEmp_Mp_Id.Name = "ItemForEmp_Mp_Id";
            this.ItemForEmp_Mp_Id.Size = new System.Drawing.Size(261, 24);
            this.ItemForEmp_Mp_Id.Text = "درجة الموظف";
            this.ItemForEmp_Mp_Id.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(495, 384);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // F_Salarey_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "F_Salarey_Master";
            this.Text = "F_Salarey_Master";
            this.Controls.SetChildIndex(this.dataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Sal_IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Sal_NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Sal_SalaryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Sal_StateCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Sal_NoteMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Mp_IdSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Sal_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Sal_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Sal_Salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Sal_State)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Sal_Note)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Mp_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit Emp_Sal_IdTextEdit;
        private DevExpress.XtraEditors.TextEdit Emp_Sal_NameTextEdit;
        private DevExpress.XtraEditors.TextEdit Emp_Sal_SalaryTextEdit;
        private DevExpress.XtraEditors.CheckEdit Emp_Sal_StateCheckEdit;
        private DevExpress.XtraEditors.MemoEdit Emp_Sal_NoteMemoEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit Emp_Mp_IdSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_Mp_Id;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_Sal_Id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_Sal_Name;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_Sal_Salary;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_Sal_State;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_Sal_Note;
        private DevExpress.XtraGrid.GridControl gc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}