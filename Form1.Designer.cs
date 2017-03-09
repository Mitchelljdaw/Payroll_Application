namespace Proj_12
{
    partial class FrmFluffElectronics
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
            this.MnuExt = new System.Windows.Forms.MenuStrip();
            this.MnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSubExt = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSubAbt = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtNetPay = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblNetPay = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.MnuExt.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuExt
            // 
            this.MnuExt.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MnuExt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMain});
            this.MnuExt.Location = new System.Drawing.Point(0, 0);
            this.MnuExt.Name = "MnuExt";
            this.MnuExt.Size = new System.Drawing.Size(476, 40);
            this.MnuExt.TabIndex = 0;
            this.MnuExt.Text = "Menu";
            // 
            // MnuMain
            // 
            this.MnuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSubExt,
            this.MnuSubAbt});
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(64, 36);
            this.MnuMain.Text = "Exit";
            // 
            // MnuSubExt
            // 
            this.MnuSubExt.Name = "MnuSubExt";
            this.MnuSubExt.Size = new System.Drawing.Size(269, 38);
            this.MnuSubExt.Text = "Exit";
            this.MnuSubExt.Click += new System.EventHandler(this.MnuSubExt_Click);
            // 
            // MnuSubAbt
            // 
            this.MnuSubAbt.Name = "MnuSubAbt";
            this.MnuSubAbt.Size = new System.Drawing.Size(269, 38);
            this.MnuSubAbt.Text = "About";
            this.MnuSubAbt.Click += new System.EventHandler(this.MnuSubAbt_Click);
            // 
            // TxtName
            // 
            this.TxtName.Enabled = false;
            this.TxtName.Location = new System.Drawing.Point(125, 84);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(259, 31);
            this.TxtName.TabIndex = 2;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Enabled = false;
            this.TxtAddress.Location = new System.Drawing.Point(125, 189);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(259, 31);
            this.TxtAddress.TabIndex = 3;
            // 
            // TxtNetPay
            // 
            this.TxtNetPay.Enabled = false;
            this.TxtNetPay.Location = new System.Drawing.Point(193, 257);
            this.TxtNetPay.Name = "TxtNetPay";
            this.TxtNetPay.Size = new System.Drawing.Size(191, 31);
            this.TxtNetPay.TabIndex = 4;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(35, 90);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(74, 25);
            this.LblName.TabIndex = 5;
            this.LblName.Text = "Name:";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(12, 195);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(97, 25);
            this.LblAddress.TabIndex = 6;
            this.LblAddress.Text = "Address:";
            // 
            // LblNetPay
            // 
            this.LblNetPay.AutoSize = true;
            this.LblNetPay.Location = new System.Drawing.Point(80, 263);
            this.LblNetPay.Name = "LblNetPay";
            this.LblNetPay.Size = new System.Drawing.Size(94, 25);
            this.LblNetPay.TabIndex = 7;
            this.LblNetPay.Text = "Net Pay:";
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(193, 335);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 47);
            this.BtnNext.TabIndex = 8;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(125, 135);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(259, 31);
            this.TxtId.TabIndex = 9;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(71, 141);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(38, 25);
            this.LblId.TabIndex = 10;
            this.LblId.Text = "ID:";
            // 
            // FrmFluffElectronics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 409);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.LblNetPay);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtNetPay);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.MnuExt);
            this.MainMenuStrip = this.MnuExt;
            this.Name = "FrmFluffElectronics";
            this.Text = "Fluff Electronics";
            this.Load += new System.EventHandler(this.FrmFluffElectronics_Load);
            this.MnuExt.ResumeLayout(false);
            this.MnuExt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuExt;
        private System.Windows.Forms.ToolStripMenuItem MnuMain;
        private System.Windows.Forms.ToolStripMenuItem MnuSubExt;
        private System.Windows.Forms.ToolStripMenuItem MnuSubAbt;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtNetPay;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblNetPay;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblId;
    }
}

