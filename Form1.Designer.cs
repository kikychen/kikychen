namespace SA46Team07B_ESNET_Project_v2
{
    partial class booking_form
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
            this.dataGridView_bookStatus = new System.Windows.Forms.DataGridView();
            this.comboBox_select_sport = new System.Windows.Forms.ComboBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.label_date = new System.Windows.Forms.Label();
            this.button_book = new System.Windows.Forms.Button();
            this.button_bookCancel = new System.Windows.Forms.Button();
            this.label_sport = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bookStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_bookStatus
            // 
            this.dataGridView_bookStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bookStatus.Location = new System.Drawing.Point(277, 138);
            this.dataGridView_bookStatus.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView_bookStatus.Name = "dataGridView_bookStatus";
            this.dataGridView_bookStatus.RowTemplate.Height = 28;
            this.dataGridView_bookStatus.Size = new System.Drawing.Size(860, 449);
            this.dataGridView_bookStatus.TabIndex = 0;
            this.dataGridView_bookStatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_bookStatus_CellClick);
            // 
            // comboBox_select_sport
            // 
            this.comboBox_select_sport.FormattingEnabled = true;
            this.comboBox_select_sport.Items.AddRange(new object[] {
            "Badminton",
            "Basketball",
            "Squash",
            "Table Tennis",
            "Gym Equipment 1",
            "Gym Equipment 2",
            "Gym Equipment 3"});
            this.comboBox_select_sport.Location = new System.Drawing.Point(277, 78);
            this.comboBox_select_sport.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBox_select_sport.Name = "comboBox_select_sport";
            this.comboBox_select_sport.Size = new System.Drawing.Size(166, 28);
            this.comboBox_select_sport.TabIndex = 1;
            this.comboBox_select_sport.SelectedIndexChanged += new System.EventHandler(this.comboBox_select_sport_SelectedIndexChanged);
            // 
            // textBox_date
            // 
            this.textBox_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_date.Location = new System.Drawing.Point(974, 78);
            this.textBox_date.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(164, 19);
            this.textBox_date.TabIndex = 2;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(968, 31);
            this.label_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(176, 32);
            this.label_date.TabIndex = 3;
            this.label_date.Text = "Date booked";
            // 
            // button_book
            // 
            this.button_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_book.Location = new System.Drawing.Point(792, 596);
            this.button_book.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_book.Name = "button_book";
            this.button_book.Size = new System.Drawing.Size(135, 49);
            this.button_book.TabIndex = 4;
            this.button_book.Text = "Book";
            this.button_book.UseVisualStyleBackColor = true;
            this.button_book.Click += new System.EventHandler(this.button_book_Click);
            // 
            // button_bookCancel
            // 
            this.button_bookCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bookCancel.Location = new System.Drawing.Point(1002, 596);
            this.button_bookCancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_bookCancel.Name = "button_bookCancel";
            this.button_bookCancel.Size = new System.Drawing.Size(135, 49);
            this.button_bookCancel.TabIndex = 5;
            this.button_bookCancel.Text = "Cancel";
            this.button_bookCancel.UseVisualStyleBackColor = true;
            this.button_bookCancel.Click += new System.EventHandler(this.button_bookCancel_Click);
            // 
            // label_sport
            // 
            this.label_sport.AutoSize = true;
            this.label_sport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sport.Location = new System.Drawing.Point(274, 31);
            this.label_sport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sport.Name = "label_sport";
            this.label_sport.Size = new System.Drawing.Size(170, 32);
            this.label_sport.TabIndex = 6;
            this.label_sport.Text = "Select Sport";
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.Location = new System.Drawing.Point(277, 596);
            this.button_reset.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(198, 49);
            this.button_reset.TabIndex = 7;
            this.button_reset.Text = "List all Sports";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // booking_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 656);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.label_sport);
            this.Controls.Add(this.button_bookCancel);
            this.Controls.Add(this.button_book);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.comboBox_select_sport);
            this.Controls.Add(this.dataGridView_bookStatus);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "booking_form";
            this.Text = "Booking Form";
            this.Load += new System.EventHandler(this.booking_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bookStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_bookStatus;
        private System.Windows.Forms.ComboBox comboBox_select_sport;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Button button_book;
        private System.Windows.Forms.Button button_bookCancel;
        private System.Windows.Forms.Label label_sport;
        private System.Windows.Forms.Button button_reset;
    }
}

