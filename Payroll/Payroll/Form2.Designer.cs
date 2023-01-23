namespace Payroll
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtE = new System.Windows.Forms.ToolStripButton();
            this.txtPayroll = new System.Windows.Forms.ToolStripButton();
            this.txtUsers = new System.Windows.Forms.ToolStripButton();
            this.txtLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtE,
            this.txtPayroll,
            this.txtUsers,
            this.txtLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtE
            // 
            this.txtE.Enabled = false;
            this.txtE.Image = ((System.Drawing.Image)(resources.GetObject("txtE.Image")));
            this.txtE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(68, 35);
            this.txtE.Text = "Employees";
            this.txtE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.txtE.Click += new System.EventHandler(this.txtE_Click);
            // 
            // txtPayroll
            // 
            this.txtPayroll.Enabled = false;
            this.txtPayroll.Image = ((System.Drawing.Image)(resources.GetObject("txtPayroll.Image")));
            this.txtPayroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtPayroll.Name = "txtPayroll";
            this.txtPayroll.Size = new System.Drawing.Size(47, 35);
            this.txtPayroll.Text = "Payroll";
            this.txtPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.txtPayroll.Click += new System.EventHandler(this.txtPayroll_Click);
            // 
            // txtUsers
            // 
            this.txtUsers.Enabled = false;
            this.txtUsers.Image = ((System.Drawing.Image)(resources.GetObject("txtUsers.Image")));
            this.txtUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(39, 35);
            this.txtUsers.Text = "Users";
            this.txtUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.txtUsers.Click += new System.EventHandler(this.txtUsers_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Image = ((System.Drawing.Image)(resources.GetObject("txtLogin.Image")));
            this.txtLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(41, 35);
            this.txtLogin.Text = "Login";
            this.txtLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.txtLogin.Click += new System.EventHandler(this.txtLogin_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form2";
            this.Text = "Welcome";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton txtE;
        private ToolStripButton txtPayroll;
        private ToolStripButton txtUsers;
        private ToolStripButton txtLogin;
    }
}