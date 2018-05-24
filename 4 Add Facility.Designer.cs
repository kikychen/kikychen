namespace SA46Team07B_ESNET_Project_v2
{
    partial class _4_Add_Facility
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
            this.submit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.slot1 = new System.Windows.Forms.Label();
            this.MIDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(384, 479);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(89, 38);
            this.submit.TabIndex = 38;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "avaliable",
            "booked"});
            this.comboBox1.Location = new System.Drawing.Point(384, 316);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 37;
            // 
            // slot1
            // 
            this.slot1.AutoSize = true;
            this.slot1.Location = new System.Drawing.Point(222, 316);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(75, 20);
            this.slot1.TabIndex = 36;
            this.slot1.Text = "SlotTime:";
            // 
            // MIDTextBox
            // 
            this.MIDTextBox.Location = new System.Drawing.Point(384, 207);
            this.MIDTextBox.Name = "MIDTextBox";
            this.MIDTextBox.Size = new System.Drawing.Size(296, 26);
            this.MIDTextBox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Facility Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 33;
            this.label1.Text = "New Facility";
            // 
            // _4_Add_Facility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 581);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.slot1);
            this.Controls.Add(this.MIDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "_4_Add_Facility";
            this.Text = "_4_Add_Facility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label slot1;
        private System.Windows.Forms.TextBox MIDTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}