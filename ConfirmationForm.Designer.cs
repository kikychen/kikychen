namespace SA46Team07B_ESNET_Project_v2
{
    partial class ConfirmationForm
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
            this.button_confirm = new System.Windows.Forms.Button();
            this.label_confirmation = new System.Windows.Forms.Label();
            this.button_confirmCancel = new System.Windows.Forms.Button();
            this.label_memberInfo = new System.Windows.Forms.Label();
            this.button_member = new System.Windows.Forms.Button();
            this.label_date = new System.Windows.Forms.Label();
            this.label_sport = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_sport = new System.Windows.Forms.TextBox();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.textBox_memberID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_confirm
            // 
            this.button_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirm.Location = new System.Drawing.Point(703, 505);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(135, 49);
            this.button_confirm.TabIndex = 0;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // label_confirmation
            // 
            this.label_confirmation.AutoSize = true;
            this.label_confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_confirmation.Location = new System.Drawing.Point(77, 43);
            this.label_confirmation.Name = "label_confirmation";
            this.label_confirmation.Size = new System.Drawing.Size(418, 29);
            this.label_confirmation.TabIndex = 1;
            this.label_confirmation.Text = "Below is the summary of your booking";
            // 
            // button_confirmCancel
            // 
            this.button_confirmCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirmCancel.Location = new System.Drawing.Point(871, 505);
            this.button_confirmCancel.Name = "button_confirmCancel";
            this.button_confirmCancel.Size = new System.Drawing.Size(135, 49);
            this.button_confirmCancel.TabIndex = 2;
            this.button_confirmCancel.Text = "Cancel";
            this.button_confirmCancel.UseVisualStyleBackColor = true;
            this.button_confirmCancel.Click += new System.EventHandler(this.button_confirmCancel_Click);
            // 
            // label_memberInfo
            // 
            this.label_memberInfo.AutoSize = true;
            this.label_memberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_memberInfo.Location = new System.Drawing.Point(77, 396);
            this.label_memberInfo.Name = "label_memberInfo";
            this.label_memberInfo.Size = new System.Drawing.Size(320, 29);
            this.label_memberInfo.TabIndex = 3;
            this.label_memberInfo.Text = "Please enter your memberID";
            // 
            // button_member
            // 
            this.button_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_member.Location = new System.Drawing.Point(575, 396);
            this.button_member.Name = "button_member";
            this.button_member.Size = new System.Drawing.Size(75, 32);
            this.button_member.TabIndex = 4;
            this.button_member.Text = "...";
            this.button_member.UseVisualStyleBackColor = true;
            this.button_member.Click += new System.EventHandler(this.button_member_Click);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(78, 179);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(53, 25);
            this.label_date.TabIndex = 5;
            this.label_date.Text = "Date";
            // 
            // label_sport
            // 
            this.label_sport.AutoSize = true;
            this.label_sport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sport.Location = new System.Drawing.Point(75, 120);
            this.label_sport.Name = "label_sport";
            this.label_sport.Size = new System.Drawing.Size(59, 25);
            this.label_sport.TabIndex = 6;
            this.label_sport.Text = "Sport";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(78, 239);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(56, 25);
            this.label_time.TabIndex = 7;
            this.label_time.Text = "Time";
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(186, 178);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(142, 26);
            this.textBox_date.TabIndex = 8;
            // 
            // textBox_sport
            // 
            this.textBox_sport.Location = new System.Drawing.Point(186, 119);
            this.textBox_sport.Name = "textBox_sport";
            this.textBox_sport.Size = new System.Drawing.Size(142, 26);
            this.textBox_sport.TabIndex = 9;
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(186, 238);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(142, 26);
            this.textBox_time.TabIndex = 10;
            // 
            // textBox_memberID
            // 
            this.textBox_memberID.Location = new System.Drawing.Point(403, 399);
            this.textBox_memberID.Name = "textBox_memberID";
            this.textBox_memberID.Size = new System.Drawing.Size(142, 26);
            this.textBox_memberID.TabIndex = 11;
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 562);
            this.Controls.Add(this.textBox_memberID);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.textBox_sport);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_sport);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.button_member);
            this.Controls.Add(this.label_memberInfo);
            this.Controls.Add(this.button_confirmCancel);
            this.Controls.Add(this.label_confirmation);
            this.Controls.Add(this.button_confirm);
            this.Name = "ConfirmationForm";
            this.Text = "ConfirmationForm";
            this.Load += new System.EventHandler(this.ConfirmationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Label label_confirmation;
        private System.Windows.Forms.Button button_confirmCancel;
        private System.Windows.Forms.Label label_memberInfo;
        private System.Windows.Forms.Button button_member;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_sport;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_sport;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.TextBox textBox_memberID;
    }
}