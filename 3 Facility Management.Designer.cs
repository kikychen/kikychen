namespace SA46Team07B_ESNET_Project_v2
{
    partial class _3_Facility_Management
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.facilityBookingDataSet1 = new SA46Team07B_ESNET_Project_v2.facilityBookingDataSet1();
            this.facilityStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facility_StatusTableAdapter = new SA46Team07B_ESNET_Project_v2.facilityBookingDataSet1TableAdapters.Facility_StatusTableAdapter();
            this.facilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slot910amDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slot1011amDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slot1112pmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slot121pmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slot12pmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slot23pmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slot34pmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slot45pmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slot56pmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slot67pmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slot78pmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slot89pmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityBookingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Badminton",
            "Basketball",
            "Gym Equipment 1",
            "Gym Equipment 2",
            "Gym Equipment 3",
            "Squash",
            "Table Tennis"});
            this.comboBox1.Location = new System.Drawing.Point(341, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 30;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(534, 390);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(92, 44);
            this.delete.TabIndex = 29;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click_1);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(243, 390);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(101, 44);
            this.NewButton.TabIndex = 28;
            this.NewButton.Text = "Add New";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(608, 107);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(103, 44);
            this.SearchButton.TabIndex = 27;
            this.SearchButton.Text = " Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facilityDataGridViewTextBoxColumn,
            this.slot910amDataGridViewTextBoxColumn,
            this.slot1011amDataGridViewTextBoxColumn,
            this.slot1112pmDataGridViewTextBoxColumn,
            this.slot121pmDataGridViewTextBoxColumn,
            this.slot12pmDataGridViewTextBoxColumn,
            this.slot23pmDataGridViewTextBoxColumn,
            this.slot34pmDataGridViewTextBoxColumn,
            this.slot45pmDataGridViewTextBoxColumn,
            this.slot56pmDataGridViewTextBoxColumn,
            this.slot67pmDataGridViewTextBoxColumn,
            this.slot78pmDataGridViewTextBoxColumn,
            this.slot89pmDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facilityStatusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(167, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(544, 167);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(189, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Facility:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 34);
            this.label2.TabIndex = 24;
            this.label2.Text = "Facility Management";
            // 
            // facilityBookingDataSet1
            // 
            this.facilityBookingDataSet1.DataSetName = "facilityBookingDataSet1";
            this.facilityBookingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facilityStatusBindingSource
            // 
            this.facilityStatusBindingSource.DataMember = "Facility Status";
            this.facilityStatusBindingSource.DataSource = this.facilityBookingDataSet1;
            // 
            // facility_StatusTableAdapter
            // 
            this.facility_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // facilityDataGridViewTextBoxColumn
            // 
            this.facilityDataGridViewTextBoxColumn.DataPropertyName = "Facility";
            this.facilityDataGridViewTextBoxColumn.HeaderText = "Facility";
            this.facilityDataGridViewTextBoxColumn.Name = "facilityDataGridViewTextBoxColumn";
            // 
            // slot910amDataGridViewTextBoxColumn
            // 
            this.slot910amDataGridViewTextBoxColumn.DataPropertyName = "Slot 9-10am";
            this.slot910amDataGridViewTextBoxColumn.HeaderText = "Slot 9-10am";
            this.slot910amDataGridViewTextBoxColumn.Name = "slot910amDataGridViewTextBoxColumn";
            // 
            // slot1011amDataGridViewTextBoxColumn
            // 
            this.slot1011amDataGridViewTextBoxColumn.DataPropertyName = "Slot 10-11am";
            this.slot1011amDataGridViewTextBoxColumn.HeaderText = "Slot 10-11am";
            this.slot1011amDataGridViewTextBoxColumn.Name = "slot1011amDataGridViewTextBoxColumn";
            // 
            // slot1112pmDataGridViewTextBoxColumn
            // 
            this.slot1112pmDataGridViewTextBoxColumn.DataPropertyName = "Slot 11-12pm";
            this.slot1112pmDataGridViewTextBoxColumn.HeaderText = "Slot 11-12pm";
            this.slot1112pmDataGridViewTextBoxColumn.Name = "slot1112pmDataGridViewTextBoxColumn";
            // 
            // slot121pmDataGridViewTextBoxColumn
            // 
            this.slot121pmDataGridViewTextBoxColumn.DataPropertyName = "Slot 12-1pm";
            this.slot121pmDataGridViewTextBoxColumn.HeaderText = "Slot 12-1pm";
            this.slot121pmDataGridViewTextBoxColumn.Name = "slot121pmDataGridViewTextBoxColumn";
            // 
            // slot12pmDataGridViewTextBoxColumn
            // 
            this.slot12pmDataGridViewTextBoxColumn.DataPropertyName = "Slot 1-2pm";
            this.slot12pmDataGridViewTextBoxColumn.HeaderText = "Slot 1-2pm";
            this.slot12pmDataGridViewTextBoxColumn.Name = "slot12pmDataGridViewTextBoxColumn";
            // 
            // slot23pmDataGridViewTextBoxColumn
            // 
            this.slot23pmDataGridViewTextBoxColumn.DataPropertyName = "Slot 2-3pm";
            this.slot23pmDataGridViewTextBoxColumn.HeaderText = "Slot 2-3pm";
            this.slot23pmDataGridViewTextBoxColumn.Name = "slot23pmDataGridViewTextBoxColumn";
            // 
            // slot34pmDataGridViewTextBoxColumn
            // 
            this.slot34pmDataGridViewTextBoxColumn.DataPropertyName = "Slot 3-4pm";
            this.slot34pmDataGridViewTextBoxColumn.HeaderText = "Slot 3-4pm";
            this.slot34pmDataGridViewTextBoxColumn.Name = "slot34pmDataGridViewTextBoxColumn";
            // 
            // slot45pmDataGridViewTextBoxColumn
            // 
            this.slot45pmDataGridViewTextBoxColumn.DataPropertyName = "Slot 4-5pm";
            this.slot45pmDataGridViewTextBoxColumn.HeaderText = "Slot 4-5pm";
            this.slot45pmDataGridViewTextBoxColumn.Name = "slot45pmDataGridViewTextBoxColumn";
            // 
            // slot56pmDataGridViewTextBoxColumn
            // 
            this.slot56pmDataGridViewTextBoxColumn.DataPropertyName = "Slot 5-6pm";
            this.slot56pmDataGridViewTextBoxColumn.HeaderText = "Slot 5-6pm";
            this.slot56pmDataGridViewTextBoxColumn.Name = "slot56pmDataGridViewTextBoxColumn";
            // 
            // slot67pmDataGridViewTextBoxColumn
            // 
            this.slot67pmDataGridViewTextBoxColumn.DataPropertyName = "Slot 6-7pm";
            this.slot67pmDataGridViewTextBoxColumn.HeaderText = "Slot 6-7pm";
            this.slot67pmDataGridViewTextBoxColumn.Name = "slot67pmDataGridViewTextBoxColumn";
            // 
            // slot78pmDataGridViewTextBoxColumn
            // 
            this.slot78pmDataGridViewTextBoxColumn.DataPropertyName = "Slot 7-8pm";
            this.slot78pmDataGridViewTextBoxColumn.HeaderText = "Slot 7-8pm";
            this.slot78pmDataGridViewTextBoxColumn.Name = "slot78pmDataGridViewTextBoxColumn";
            // 
            // slot89pmDataGridViewTextBoxColumn
            // 
            this.slot89pmDataGridViewTextBoxColumn.DataPropertyName = "Slot 8-9pm";
            this.slot89pmDataGridViewTextBoxColumn.HeaderText = "Slot 8-9pm";
            this.slot89pmDataGridViewTextBoxColumn.Name = "slot89pmDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // _3_Facility_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 481);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "_3_Facility_Management";
            this.Text = "_3_Facility_Management";
            this.Load += new System.EventHandler(this._3_Facility_Management_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityBookingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityStatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private facilityBookingDataSet1 facilityBookingDataSet1;
        private System.Windows.Forms.BindingSource facilityStatusBindingSource;
        private facilityBookingDataSet1TableAdapters.Facility_StatusTableAdapter facility_StatusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slot910amDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slot1011amDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slot1112pmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slot121pmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slot12pmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slot23pmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slot34pmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slot45pmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slot56pmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slot67pmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slot78pmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slot89pmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}