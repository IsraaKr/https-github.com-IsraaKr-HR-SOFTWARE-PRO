namespace HR_Forms.Forms.Attend_Forms
{
    partial class F_Attend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Attend));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btn_add_day = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_day_states = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C_Emp_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Emp_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Work_Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Att_State = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.C_Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gc = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Name_DayTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Emp_Att_DateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.Emp_Att_D_IdSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Emp_IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForEmp_Att_Code = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_Att_Date = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_Att_D_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_emp_add = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name_DayTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Att_DateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Att_DateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Att_D_IdSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Att_Code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Att_Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Att_D_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btn_emp_add);
            this.dataLayoutControl1.Controls.Add(this.btn_add_day);
            this.dataLayoutControl1.Controls.Add(this.lbl_day_states);
            this.dataLayoutControl1.Controls.Add(this.dataGridView1);
            this.dataLayoutControl1.Controls.Add(this.gc);
            this.dataLayoutControl1.Controls.Add(this.Name_DayTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_Att_DateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_Att_D_IdSearchLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_IdTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 24);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(800, 404);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btn_add_day
            // 
            this.btn_add_day.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_day.ImageOptions.Image")));
            this.btn_add_day.Location = new System.Drawing.Point(414, 69);
            this.btn_add_day.Name = "btn_add_day";
            this.btn_add_day.Size = new System.Drawing.Size(22, 22);
            this.btn_add_day.StyleController = this.dataLayoutControl1;
            this.btn_add_day.TabIndex = 28;
            this.btn_add_day.Click += new System.EventHandler(this.btn_add_day_Click);
            // 
            // lbl_day_states
            // 
            this.lbl_day_states.Location = new System.Drawing.Point(24, 45);
            this.lbl_day_states.Name = "lbl_day_states";
            this.lbl_day_states.Size = new System.Drawing.Size(20, 20);
            this.lbl_day_states.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Emp_Num,
            this.C_Emp_Name,
            this.C_Date,
            this.C_Work_Hours,
            this.C_Att_State,
            this.C_Notes});
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(672, 285);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // C_Emp_Num
            // 
            this.C_Emp_Num.HeaderText = "رقم الموظف";
            this.C_Emp_Num.Name = "C_Emp_Num";
            this.C_Emp_Num.ReadOnly = true;
            // 
            // C_Emp_Name
            // 
            this.C_Emp_Name.HeaderText = "اسم الموظف";
            this.C_Emp_Name.Name = "C_Emp_Name";
            this.C_Emp_Name.ReadOnly = true;
            // 
            // C_Date
            // 
            this.C_Date.HeaderText = "تاريخ اليوم";
            this.C_Date.Name = "C_Date";
            this.C_Date.ReadOnly = true;
            // 
            // C_Work_Hours
            // 
            this.C_Work_Hours.HeaderText = "ساعات العمل";
            this.C_Work_Hours.Name = "C_Work_Hours";
            // 
            // C_Att_State
            // 
            this.C_Att_State.HeaderText = "حالة الحضور";
            this.C_Att_State.Name = "C_Att_State";
            this.C_Att_State.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.C_Att_State.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // C_Notes
            // 
            this.C_Notes.HeaderText = "ملاحظات";
            this.C_Notes.Name = "C_Notes";
            // 
            // gc
            // 
            this.gc.Location = new System.Drawing.Point(688, 107);
            this.gc.MainView = this.gv;
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(100, 285);
            this.gc.TabIndex = 25;
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
            // 
            // Name_DayTextEdit
            // 
            this.Name_DayTextEdit.Location = new System.Drawing.Point(48, 45);
            this.Name_DayTextEdit.Name = "Name_DayTextEdit";
            this.Name_DayTextEdit.Size = new System.Drawing.Size(283, 20);
            this.Name_DayTextEdit.StyleController = this.dataLayoutControl1;
            this.Name_DayTextEdit.TabIndex = 5;
            // 
            // Emp_Att_DateDateEdit
            // 
            this.Emp_Att_DateDateEdit.EditValue = null;
            this.Emp_Att_DateDateEdit.Location = new System.Drawing.Point(414, 45);
            this.Emp_Att_DateDateEdit.Name = "Emp_Att_DateDateEdit";
            this.Emp_Att_DateDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Emp_Att_DateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Emp_Att_DateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Emp_Att_DateDateEdit.Size = new System.Drawing.Size(283, 20);
            this.Emp_Att_DateDateEdit.StyleController = this.dataLayoutControl1;
            this.Emp_Att_DateDateEdit.TabIndex = 6;
            this.Emp_Att_DateDateEdit.EditValueChanged += new System.EventHandler(this.Emp_Att_DateDateEdit_EditValueChanged);
            // 
            // Emp_Att_D_IdSearchLookUpEdit
            // 
            this.Emp_Att_D_IdSearchLookUpEdit.Location = new System.Drawing.Point(440, 69);
            this.Emp_Att_D_IdSearchLookUpEdit.Name = "Emp_Att_D_IdSearchLookUpEdit";
            this.Emp_Att_D_IdSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Emp_Att_D_IdSearchLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Emp_Att_D_IdSearchLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Emp_Att_D_IdSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Emp_Att_D_IdSearchLookUpEdit.Properties.NullText = "";
            this.Emp_Att_D_IdSearchLookUpEdit.Properties.PopupView = this.gridView1;
            this.Emp_Att_D_IdSearchLookUpEdit.Size = new System.Drawing.Size(257, 20);
            this.Emp_Att_D_IdSearchLookUpEdit.StyleController = this.dataLayoutControl1;
            this.Emp_Att_D_IdSearchLookUpEdit.TabIndex = 11;
            this.Emp_Att_D_IdSearchLookUpEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.Emp_Att_D_IdSearchLookUpEdit_CustomDisplayText);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Emp_IdTextEdit
            // 
            this.Emp_IdTextEdit.Location = new System.Drawing.Point(50, 69);
            this.Emp_IdTextEdit.Name = "Emp_IdTextEdit";
            this.Emp_IdTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Emp_IdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Emp_IdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Emp_IdTextEdit.Size = new System.Drawing.Size(281, 20);
            this.Emp_IdTextEdit.StyleController = this.dataLayoutControl1;
            this.Emp_IdTextEdit.TabIndex = 10;
            this.Emp_IdTextEdit.EditValueChanged += new System.EventHandler(this.Emp_IdSearchLookUpEdit_EditValueChanged);
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
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(780, 384);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForEmp_Att_Date,
            this.ItemForEmp_Att_D_Id,
            this.layoutControlItem4,
            this.ItemForEmp_Att_Code,
            this.layoutControlItem3,
            this.ItemForEmp_Id,
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(780, 95);
            this.layoutControlGroup2.Text = "تسجيل ساعات العمل اليومي";
            // 
            // ItemForEmp_Att_Code
            // 
            this.ItemForEmp_Att_Code.Control = this.Name_DayTextEdit;
            this.ItemForEmp_Att_Code.Location = new System.Drawing.Point(24, 0);
            this.ItemForEmp_Att_Code.Name = "ItemForEmp_Att_Code";
            this.ItemForEmp_Att_Code.Size = new System.Drawing.Size(366, 24);
            this.ItemForEmp_Att_Code.Text = "اسم اليوم";
            this.ItemForEmp_Att_Code.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForEmp_Att_Date
            // 
            this.ItemForEmp_Att_Date.Control = this.Emp_Att_DateDateEdit;
            this.ItemForEmp_Att_Date.Location = new System.Drawing.Point(390, 0);
            this.ItemForEmp_Att_Date.Name = "ItemForEmp_Att_Date";
            this.ItemForEmp_Att_Date.Size = new System.Drawing.Size(366, 24);
            this.ItemForEmp_Att_Date.Text = "التاريخ";
            this.ItemForEmp_Att_Date.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForEmp_Id
            // 
            this.ItemForEmp_Id.Control = this.Emp_IdTextEdit;
            this.ItemForEmp_Id.Location = new System.Drawing.Point(26, 24);
            this.ItemForEmp_Id.Name = "ItemForEmp_Id";
            this.ItemForEmp_Id.Size = new System.Drawing.Size(364, 26);
            this.ItemForEmp_Id.Text = "الموظف";
            this.ItemForEmp_Id.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForEmp_Att_D_Id
            // 
            this.ItemForEmp_Att_D_Id.Control = this.Emp_Att_D_IdSearchLookUpEdit;
            this.ItemForEmp_Att_D_Id.Location = new System.Drawing.Point(416, 24);
            this.ItemForEmp_Att_D_Id.Name = "ItemForEmp_Att_D_Id";
            this.ItemForEmp_Att_D_Id.Size = new System.Drawing.Size(340, 26);
            this.ItemForEmp_Att_D_Id.Text = "قائمة أيام الداوام";
            this.ItemForEmp_Att_D_Id.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lbl_day_states;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(24, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(24, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(24, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_add_day;
            this.layoutControlItem4.Location = new System.Drawing.Point(390, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(26, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(26, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dataGridView1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 95);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(676, 289);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gc;
            this.layoutControlItem1.Location = new System.Drawing.Point(676, 95);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(104, 289);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btn_emp_add
            // 
            this.btn_emp_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_emp_add.Location = new System.Drawing.Point(24, 69);
            this.btn_emp_add.Name = "btn_emp_add";
            this.btn_emp_add.Size = new System.Drawing.Size(22, 22);
            this.btn_emp_add.StyleController = this.dataLayoutControl1;
            this.btn_emp_add.TabIndex = 29;
            this.btn_emp_add.Click += new System.EventHandler(this.btn_emp_add_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btn_emp_add;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(26, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // F_Attend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataLayoutControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "F_Attend";
            this.Text = "تسجيل ساعات العمل اليومي";
            this.Controls.SetChildIndex(this.dataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name_DayTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Att_DateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Att_DateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_Att_D_IdSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Att_Code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Att_Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Att_D_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit Name_DayTextEdit;
        private DevExpress.XtraEditors.DateEdit Emp_Att_DateDateEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit Emp_Att_D_IdSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_Att_Code;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_Att_Date;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_Id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_Att_D_Id;
        private DevExpress.XtraGrid.GridControl gc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Emp_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Emp_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Work_Hours;
        private System.Windows.Forms.DataGridViewCheckBoxColumn C_Att_State;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Notes;
        private System.Windows.Forms.Label lbl_day_states;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit Emp_IdTextEdit;
        private DevExpress.XtraEditors.SimpleButton btn_add_day;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btn_emp_add;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}