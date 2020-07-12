namespace VfioUsbClient.UI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.lblServerIp = new System.Windows.Forms.Label();
            this.tbServerIp = new System.Windows.Forms.TextBox();
            this.btnProfileEditor = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.cbStartMinimized = new System.Windows.Forms.CheckBox();
            this.lblLGPath = new System.Windows.Forms.Label();
            this.tbLGPath = new System.Windows.Forms.TextBox();
            this.btnLGBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServerIp
            // 
            this.lblServerIp.AutoSize = true;
            this.lblServerIp.Location = new System.Drawing.Point(6, 8);
            this.lblServerIp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServerIp.Name = "lblServerIp";
            this.lblServerIp.Size = new System.Drawing.Size(54, 13);
            this.lblServerIp.TabIndex = 0;
            this.lblServerIp.Text = "Server IP:";
            // 
            // tbServerIp
            // 
            this.tbServerIp.Location = new System.Drawing.Point(62, 5);
            this.tbServerIp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbServerIp.Name = "tbServerIp";
            this.tbServerIp.Size = new System.Drawing.Size(226, 20);
            this.tbServerIp.TabIndex = 1;
            // 
            // btnProfileEditor
            // 
            this.btnProfileEditor.Location = new System.Drawing.Point(9, 81);
            this.btnProfileEditor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfileEditor.Name = "btnProfileEditor";
            this.btnProfileEditor.Size = new System.Drawing.Size(85, 25);
            this.btnProfileEditor.TabIndex = 2;
            this.btnProfileEditor.Text = "Profile Editor";
            this.btnProfileEditor.UseVisualStyleBackColor = true;
            this.btnProfileEditor.Click += new System.EventHandler(this.btnProfileEditor_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(9, 129);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(212, 131);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 4;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // cbStartMinimized
            // 
            this.cbStartMinimized.AutoSize = true;
            this.cbStartMinimized.Location = new System.Drawing.Point(9, 59);
            this.cbStartMinimized.Name = "cbStartMinimized";
            this.cbStartMinimized.Size = new System.Drawing.Size(96, 17);
            this.cbStartMinimized.TabIndex = 5;
            this.cbStartMinimized.Text = "Start minimized";
            this.cbStartMinimized.UseVisualStyleBackColor = true;
            // 
            // lblLGPath
            // 
            this.lblLGPath.AutoSize = true;
            this.lblLGPath.Location = new System.Drawing.Point(6, 33);
            this.lblLGPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLGPath.Name = "lblLGPath";
            this.lblLGPath.Size = new System.Drawing.Size(102, 13);
            this.lblLGPath.TabIndex = 6;
            this.lblLGPath.Text = "Looking Glass Path:";
            // 
            // tbLGPath
            // 
            this.tbLGPath.Location = new System.Drawing.Point(111, 33);
            this.tbLGPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLGPath.Name = "tbLGPath";
            this.tbLGPath.ReadOnly = true;
            this.tbLGPath.Size = new System.Drawing.Size(123, 20);
            this.tbLGPath.TabIndex = 7;
            // 
            // btnLGBrowse
            // 
            this.btnLGBrowse.Location = new System.Drawing.Point(237, 33);
            this.btnLGBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLGBrowse.Name = "btnLGBrowse";
            this.btnLGBrowse.Size = new System.Drawing.Size(50, 20);
            this.btnLGBrowse.TabIndex = 8;
            this.btnLGBrowse.Text = "Browse";
            this.btnLGBrowse.UseVisualStyleBackColor = true;
            this.btnLGBrowse.Click += new System.EventHandler(this.btnLGBrowse_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 161);
            this.Controls.Add(this.btnLGBrowse);
            this.Controls.Add(this.tbLGPath);
            this.Controls.Add(this.lblLGPath);
            this.Controls.Add(this.cbStartMinimized);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnProfileEditor);
            this.Controls.Add(this.tbServerIp);
            this.Controls.Add(this.lblServerIp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerIp;
        private System.Windows.Forms.TextBox tbServerIp;
        private System.Windows.Forms.Button btnProfileEditor;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.CheckBox cbStartMinimized;
        private System.Windows.Forms.Label lblLGPath;
        private System.Windows.Forms.TextBox tbLGPath;
        private System.Windows.Forms.Button btnLGBrowse;
    }
}