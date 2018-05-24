namespace SA46Team07B_ESNET_Project_v2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.memberFacilityUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilityUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilityManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilityUpdateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberFacilityUpdateToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.cancelBookingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // memberFacilityUpdateToolStripMenuItem
            // 
            this.memberFacilityUpdateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberUpdateToolStripMenuItem,
            this.facilityUpdateToolStripMenuItem});
            this.memberFacilityUpdateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.memberFacilityUpdateToolStripMenuItem.Name = "memberFacilityUpdateToolStripMenuItem";
            this.memberFacilityUpdateToolStripMenuItem.Size = new System.Drawing.Size(413, 36);
            this.memberFacilityUpdateToolStripMenuItem.Text = "Member Creation and Maintainance";
            // 
            // memberUpdateToolStripMenuItem
            // 
            this.memberUpdateToolStripMenuItem.Name = "memberUpdateToolStripMenuItem";
            this.memberUpdateToolStripMenuItem.Size = new System.Drawing.Size(343, 36);
            this.memberUpdateToolStripMenuItem.Text = "Member Management";
            this.memberUpdateToolStripMenuItem.Click += new System.EventHandler(this.memberUpdateToolStripMenuItem_Click);
            // 
            // facilityUpdateToolStripMenuItem
            // 
            this.facilityUpdateToolStripMenuItem.Name = "facilityUpdateToolStripMenuItem";
            this.facilityUpdateToolStripMenuItem.Size = new System.Drawing.Size(343, 36);
            this.facilityUpdateToolStripMenuItem.Text = "Add Member";
            this.facilityUpdateToolStripMenuItem.Click += new System.EventHandler(this.facilityUpdateToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facilityManagementToolStripMenuItem,
            this.facilityUpdateToolStripMenuItem1});
            this.bookingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(394, 36);
            this.bookingToolStripMenuItem.Text = "Facility Creation and Maintainance";
            // 
            // facilityManagementToolStripMenuItem
            // 
            this.facilityManagementToolStripMenuItem.Name = "facilityManagementToolStripMenuItem";
            this.facilityManagementToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.facilityManagementToolStripMenuItem.Text = "Facility Management";
            this.facilityManagementToolStripMenuItem.Click += new System.EventHandler(this.facilityManagementToolStripMenuItem_Click);
            // 
            // facilityUpdateToolStripMenuItem1
            // 
            this.facilityUpdateToolStripMenuItem1.Name = "facilityUpdateToolStripMenuItem1";
            this.facilityUpdateToolStripMenuItem1.Size = new System.Drawing.Size(324, 36);
            this.facilityUpdateToolStripMenuItem1.Text = "Add Facility";
            this.facilityUpdateToolStripMenuItem1.Click += new System.EventHandler(this.facilityUpdateToolStripMenuItem1_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.cancelToolStripMenuItem.Text = "Booking";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
            // 
            // cancelBookingToolStripMenuItem
            // 
            this.cancelBookingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cancelBookingToolStripMenuItem.Name = "cancelBookingToolStripMenuItem";
            this.cancelBookingToolStripMenuItem.Size = new System.Drawing.Size(193, 36);
            this.cancelBookingToolStripMenuItem.Text = "Cancel Booking";
            this.cancelBookingToolStripMenuItem.Click += new System.EventHandler(this.cancelBookingToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1145, 430);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 570);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Welcome to ISS Sport Facility Center";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem memberFacilityUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem memberUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilityUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilityManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilityUpdateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelBookingToolStripMenuItem;
    }
}