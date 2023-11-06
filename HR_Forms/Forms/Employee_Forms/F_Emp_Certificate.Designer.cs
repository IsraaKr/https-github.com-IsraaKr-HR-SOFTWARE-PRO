namespace HR_Forms.Forms.Employee_Forms
{
    partial class F_Emp_Certificate
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
            this.Emp_C_IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Emp_C_NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Emp_C_AdressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Emp_C_DateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.Emp_C_StateCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.Emp_C_NoteMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Emp_IdSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForEmp_C_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_C_Name = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_C_Adress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_C_Date = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_C_Note = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_C_State = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_Id = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_C_IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_C_NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_C_AdressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_C_DateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_C_DateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_C_StateCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_C_NoteMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_IdSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_C_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_C_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_C_Adress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_C_Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_C_Note)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_C_State)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gc);
            this.dataLayoutControl1.Controls.Add(this.Emp_C_IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_C_NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_C_AdressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_C_DateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_C_StateCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_C_NoteMemoEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_IdSearchLookUpEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 24);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(800, 401);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gc
            // 
            this.gc.Location = new System.Drawing.Point(12, 12);
            this.gc.MainView = this.gv;
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(495, 377);
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
            // Emp_C_IdTextEdit
            // 
            this.Emp_C_IdTextEdit.Location = new System.Drawing.Point(621, 69);
            this.Emp_C_IdTextEdit.Name = "Emp_C_IdTextEdit";
            this.Emp_C_IdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Emp_C_IdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Emp_C_IdTextEdit.Properties.Mask.EditMask = "G";
            this.Emp_C_IdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Emp_C_IdTextEdit.Properties.ReadOnly = true;
            this.Emp_C_IdTextEdit.Size = new System.Drawing.Size(86, 20);
            this.Emp_C_IdTextEdit.StyleController = this.dataLayoutControl1;
            this.Emp_C_IdTextEdit.TabIndex = 4;
            // 
            // Emp_C_NameTextEdit
            // 
            this.Emp_C_NameTextEdit.Location = new System.Drawing.Point(523, 93);
            this.Emp_C_NameTextEdit.Name = "Emp_C_NameTextEdit";
            this.Emp_C_NameTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Emp_C_NameTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Character;
            this.Emp_C_NameTextEdit.Size = new System.Drawing.Size(184, 20);
            this.Emp_C_NameTextEdit.StyleController = this.dataLayoutControl1;
            this.Emp_C_NameTextEdit.TabIndex = 5;
            // 
            // Emp_C_AdressTextEdit
            // 
            this.Emp_C_AdressTextEdit.Location = new System.Drawing.Point(523, 117);
            this.Emp_C_AdressTextEdit.Name = "Emp_C_AdressTextEdit";
            this.Emp_C_AdressTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Emp_C_AdressTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Character;
            this.Emp_C_AdressTextEdit.Size = new System.Drawing.Size(184, 20);
            this.Emp_C_AdressTextEdit.StyleController = this.dataLayoutControl1;
            this.Emp_C_AdressTextEdit.TabIndex = 6;
            // 
            // Emp_C_DateDateEdit
            // 
            this.Emp_C_DateDateEdit.EditValue = null;
            this.Emp_C_DateDateEdit.Location = new System.Drawing.Point(523, 141);
            this.Emp_C_DateDateEdit.Name = "Emp_C_DateDateEdit";
            this.Emp_C_DateDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Emp_C_DateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Emp_C_DateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Emp_C_DateDateEdit.Size = new System.Drawing.Size(184, 20);
            this.Emp_C_DateDateEdit.StyleController = this.dataLayoutControl1;
            this.Emp_C_DateDateEdit.TabIndex = 7;
            // 
            // Emp_C_StateCheckEdit
            // 
            this.Emp_C_StateCheckEdit.Location = new System.Drawing.Point(523, 69);
            this.Emp_C_StateCheckEdit.Name = "Emp_C_StateCheckEdit";
            this.Emp_C_StateCheckEdit.Properties.Caption = "حالة الشهادة";
            this.Emp_C_StateCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.Emp_C_StateCheckEdit.Size = new System.Drawing.Size(94, 20);
            this.Emp_C_StateCheckEdit.StyleController = this.dataLayoutControl1;
            this.Emp_C_StateCheckEdit.TabIndex = 8;
            // 
            // Emp_C_NoteMemoEdit
            // 
            this.Emp_C_NoteMemoEdit.Location = new System.Drawing.Point(523, 181);
            this.Emp_C_NoteMemoEdit.Name = "Emp_C_NoteMemoEdit";
            this.Emp_C_NoteMemoEdit.Size = new System.Drawing.Size(253, 196);
            this.Emp_C_NoteMemoEdit.StyleController = this.dataLayoutControl1;
            this.Emp_C_NoteMemoEdit.TabIndex = 9;
            // 
            // Emp_IdSearchLookUpEdit
            // 
            this.Emp_IdSearchLookUpEdit.Location = new System.Drawing.Point(523, 45);
            this.Emp_IdSearchLookUpEdit.Name = "Emp_IdSearchLookUpEdit";
            this.Emp_IdSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Emp_IdSearchLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Emp_IdSearchLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Emp_IdSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Emp_IdSearchLookUpEdit.Properties.NullText = "";
            this.Emp_IdSearchLookUpEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.Emp_IdSearchLookUpEdit.Size = new System.Drawing.Size(184, 20);
            this.Emp_IdSearchLookUpEdit.StyleController = this.dataLayoutControl1;
            this.Emp_IdSearchLookUpEdit.TabIndex = 10;
            this.Emp_IdSearchLookUpEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.Emp_IdSearchLookUpEdit_CustomDisplayText);
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
            this.Root.Size = new System.Drawing.Size(800, 401);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(780, 381);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(499, 381);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Options.UseTextOptions = true;
            this.layoutControlGroup2.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForEmp_C_Id,
            this.ItemForEmp_C_Name,
            this.ItemForEmp_C_Adress,
            this.ItemForEmp_C_Date,
            this.ItemForEmp_C_Note,
            this.ItemForEmp_C_State,
            this.ItemForEmp_Id});
            this.layoutControlGroup2.Location = new System.Drawing.Point(499, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsPrint.AppearanceItem.Options.UseTextOptions = true;
            this.layoutControlGroup2.OptionsPrint.AppearanceItem.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlGroup2.OptionsPrint.AppearanceItemControl.Options.UseTextOptions = true;
            this.layoutControlGroup2.OptionsPrint.AppearanceItemControl.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlGroup2.Size = new System.Drawing.Size(281, 381);
            this.layoutControlGroup2.Text = "بيانات الشهادة";
            // 
            // ItemForEmp_C_Id
            // 
            this.ItemForEmp_C_Id.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmp_C_Id.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForEmp_C_Id.Control = this.Emp_C_IdTextEdit;
            this.ItemForEmp_C_Id.Location = new System.Drawing.Point(98, 24);
            this.ItemForEmp_C_Id.Name = "ItemForEmp_C_Id";
            this.ItemForEmp_C_Id.Size = new System.Drawing.Size(159, 24);
            this.ItemForEmp_C_Id.Text = "الرقم";
            this.ItemForEmp_C_Id.TextSize = new System.Drawing.Size(66, 13);
            // 
            // ItemForEmp_C_Name
            // 
            this.ItemForEmp_C_Name.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmp_C_Name.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForEmp_C_Name.Control = this.Emp_C_NameTextEdit;
            this.ItemForEmp_C_Name.Location = new System.Drawing.Point(0, 48);
            this.ItemForEmp_C_Name.Name = "ItemForEmp_C_Name";
            this.ItemForEmp_C_Name.Size = new System.Drawing.Size(257, 24);
            this.ItemForEmp_C_Name.Text = "اسم الشهادة";
            this.ItemForEmp_C_Name.TextSize = new System.Drawing.Size(66, 13);
            // 
            // ItemForEmp_C_Adress
            // 
            this.ItemForEmp_C_Adress.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmp_C_Adress.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForEmp_C_Adress.Control = this.Emp_C_AdressTextEdit;
            this.ItemForEmp_C_Adress.Location = new System.Drawing.Point(0, 72);
            this.ItemForEmp_C_Adress.Name = "ItemForEmp_C_Adress";
            this.ItemForEmp_C_Adress.Size = new System.Drawing.Size(257, 24);
            this.ItemForEmp_C_Adress.Text = "عنوان الشهادة";
            this.ItemForEmp_C_Adress.TextSize = new System.Drawing.Size(66, 13);
            // 
            // ItemForEmp_C_Date
            // 
            this.ItemForEmp_C_Date.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmp_C_Date.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForEmp_C_Date.Control = this.Emp_C_DateDateEdit;
            this.ItemForEmp_C_Date.Location = new System.Drawing.Point(0, 96);
            this.ItemForEmp_C_Date.Name = "ItemForEmp_C_Date";
            this.ItemForEmp_C_Date.Size = new System.Drawing.Size(257, 24);
            this.ItemForEmp_C_Date.Text = "تاريخ الشهادة";
            this.ItemForEmp_C_Date.TextSize = new System.Drawing.Size(66, 13);
            // 
            // ItemForEmp_C_Note
            // 
            this.ItemForEmp_C_Note.Control = this.Emp_C_NoteMemoEdit;
            this.ItemForEmp_C_Note.Location = new System.Drawing.Point(0, 120);
            this.ItemForEmp_C_Note.Name = "ItemForEmp_C_Note";
            this.ItemForEmp_C_Note.Size = new System.Drawing.Size(257, 216);
            this.ItemForEmp_C_Note.StartNewLine = true;
            this.ItemForEmp_C_Note.Text = "الملاحظات";
            this.ItemForEmp_C_Note.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForEmp_C_Note.TextSize = new System.Drawing.Size(66, 13);
            // 
            // ItemForEmp_C_State
            // 
            this.ItemForEmp_C_State.Control = this.Emp_C_StateCheckEdit;
            this.ItemForEmp_C_State.Location = new System.Drawing.Point(0, 24);
            this.ItemForEmp_C_State.Name = "ItemForEmp_C_State";
            this.ItemForEmp_C_State.Size = new System.Drawing.Size(98, 24);
            this.ItemForEmp_C_State.Text = "Emp_C_State";
            this.ItemForEmp_C_State.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForEmp_C_State.TextVisible = false;
            // 
            // ItemForEmp_Id
            // 
            this.ItemForEmp_Id.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmp_Id.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemForEmp_Id.Control = this.Emp_IdSearchLookUpEdit;
            this.ItemForEmp_Id.Location = new System.Drawing.Point(0, 0);
            this.ItemForEmp_Id.Name = "ItemForEmp_Id";
            this.ItemForEmp_Id.Size = new System.Drawing.Size(257, 24);
            this.ItemForEmp_Id.Text = "الموظف";
            this.ItemForEmp_Id.TextSize = new System.Drawing.Size(66, 13);
            // 
            // F_Emp_Certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "F_Emp_Certificate";
            this.Text = "F_Emp_Certificate";
            this.Controls.SetChildIndex(this.dataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_C_IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_C_NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_C_AdressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_C_DateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_C_DateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_C_StateCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_C_NoteMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_IdSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_C_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_C_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_C_Adress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_C_Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_C_Note)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_C_State)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit Emp_C_IdTextEdit;
        private DevExpress.XtraEditors.TextEdit Emp_C_NameTextEdit;
        private DevExpress.XtraEditors.TextEdit Emp_C_AdressTextEdit;
        private DevExpress.XtraEditors.DateEdit Emp_C_DateDateEdit;
        private DevExpress.XtraEditors.CheckEdit Emp_C_StateCheckEdit;
        private DevExpress.XtraEditors.MemoEdit Emp_C_NoteMemoEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit Emp_IdSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_C_Id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_C_Name;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_C_Adress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_C_Date;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_C_Note;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_C_State;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_Id;
        private DevExpress.XtraGrid.GridControl gc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}