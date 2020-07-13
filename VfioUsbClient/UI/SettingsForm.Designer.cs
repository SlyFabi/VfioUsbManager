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
            this.cbSwitchInput = new System.Windows.Forms.CheckBox();
            this.lblVmInput = new System.Windows.Forms.Label();
            this.lblLinuxInputId = new System.Windows.Forms.Label();
            this.tbVmInputId = new System.Windows.Forms.TextBox();
            this.tbLinuxInputId = new System.Windows.Forms.TextBox();
            this.lblDisplayId = new System.Windows.Forms.Label();
            this.tbDisplayId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblServerIp
            // 
            this.lblServerIp.AutoSize = true;
            this.lblServerIp.Location = new System.Drawing.Point(9, 12);
            this.lblServerIp.Name = "lblServerIp";
            this.lblServerIp.Size = new System.Drawing.Size(78, 20);
            this.lblServerIp.TabIndex = 0;
            this.lblServerIp.Text = "Server IP:";
            // 
            // tbServerIp
            // 
            this.tbServerIp.Location = new System.Drawing.Point(93, 8);
            this.tbServerIp.Name = "tbServerIp";
            this.tbServerIp.Size = new System.Drawing.Size(337, 26);
            this.tbServerIp.TabIndex = 1;
            // 
            // btnProfileEditor
            // 
            this.btnProfileEditor.Location = new System.Drawing.Point(15, 262);
            this.btnProfileEditor.Name = "btnProfileEditor";
            this.btnProfileEditor.Size = new System.Drawing.Size(128, 38);
            this.btnProfileEditor.TabIndex = 2;
            this.btnProfileEditor.Text = "Profile Editor";
            this.btnProfileEditor.UseVisualStyleBackColor = true;
            this.btnProfileEditor.Click += new System.EventHandler(this.btnProfileEditor_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(15, 317);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 35);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(319, 321);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(112, 35);
            this.btnAbort.TabIndex = 4;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // cbStartMinimized
            // 
            this.cbStartMinimized.AutoSize = true;
            this.cbStartMinimized.Location = new System.Drawing.Point(15, 228);
            this.cbStartMinimized.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStartMinimized.Name = "cbStartMinimized";
            this.cbStartMinimized.Size = new System.Drawing.Size(144, 24);
            this.cbStartMinimized.TabIndex = 5;
            this.cbStartMinimized.Text = "Start minimized";
            this.cbStartMinimized.UseVisualStyleBackColor = true;
            // 
            // lblLGPath
            // 
            this.lblLGPath.AutoSize = true;
            this.lblLGPath.Location = new System.Drawing.Point(9, 51);
            this.lblLGPath.Name = "lblLGPath";
            this.lblLGPath.Size = new System.Drawing.Size(151, 20);
            this.lblLGPath.TabIndex = 6;
            this.lblLGPath.Text = "Looking Glass Path:";
            // 
            // tbLGPath
            // 
            this.tbLGPath.Location = new System.Drawing.Point(166, 51);
            this.tbLGPath.Name = "tbLGPath";
            this.tbLGPath.ReadOnly = true;
            this.tbLGPath.Size = new System.Drawing.Size(182, 26);
            this.tbLGPath.TabIndex = 7;
            // 
            // btnLGBrowse
            // 
            this.btnLGBrowse.Location = new System.Drawing.Point(356, 51);
            this.btnLGBrowse.Name = "btnLGBrowse";
            this.btnLGBrowse.Size = new System.Drawing.Size(75, 31);
            this.btnLGBrowse.TabIndex = 8;
            this.btnLGBrowse.Text = "Browse";
            this.btnLGBrowse.UseVisualStyleBackColor = true;
            this.btnLGBrowse.Click += new System.EventHandler(this.btnLGBrowse_Click);
            // 
            // cbSwitchInput
            // 
            this.cbSwitchInput.AutoSize = true;
            this.cbSwitchInput.Location = new System.Drawing.Point(13, 84);
            this.cbSwitchInput.Name = "cbSwitchInput";
            this.cbSwitchInput.Size = new System.Drawing.Size(266, 24);
            this.cbSwitchInput.TabIndex = 9;
            this.cbSwitchInput.Text = "Switch display input on start/stop";
            this.cbSwitchInput.UseVisualStyleBackColor = true;
            this.cbSwitchInput.CheckedChanged += new System.EventHandler(this.cbSwitchInput_CheckedChanged);
            // 
            // lblVmInput
            // 
            this.lblVmInput.AutoSize = true;
            this.lblVmInput.Location = new System.Drawing.Point(13, 149);
            this.lblVmInput.Name = "lblVmInput";
            this.lblVmInput.Size = new System.Drawing.Size(99, 20);
            this.lblVmInput.TabIndex = 10;
            this.lblVmInput.Text = "VM Input ID:";
            // 
            // lblLinuxInputId
            // 
            this.lblLinuxInputId.AutoSize = true;
            this.lblLinuxInputId.Location = new System.Drawing.Point(11, 181);
            this.lblLinuxInputId.Name = "lblLinuxInputId";
            this.lblLinuxInputId.Size = new System.Drawing.Size(112, 20);
            this.lblLinuxInputId.TabIndex = 11;
            this.lblLinuxInputId.Text = "Linux Input ID:";
            // 
            // tbVmInputId
            // 
            this.tbVmInputId.Location = new System.Drawing.Point(130, 146);
            this.tbVmInputId.Name = "tbVmInputId";
            this.tbVmInputId.Size = new System.Drawing.Size(100, 26);
            this.tbVmInputId.TabIndex = 12;
            // 
            // tbLinuxInputId
            // 
            this.tbLinuxInputId.Location = new System.Drawing.Point(130, 181);
            this.tbLinuxInputId.Name = "tbLinuxInputId";
            this.tbLinuxInputId.Size = new System.Drawing.Size(100, 26);
            this.tbLinuxInputId.TabIndex = 13;
            // 
            // lblDisplayId
            // 
            this.lblDisplayId.AutoSize = true;
            this.lblDisplayId.Location = new System.Drawing.Point(13, 117);
            this.lblDisplayId.Name = "lblDisplayId";
            this.lblDisplayId.Size = new System.Drawing.Size(85, 20);
            this.lblDisplayId.TabIndex = 14;
            this.lblDisplayId.Text = "Display ID:";
            // 
            // tbDisplayId
            // 
            this.tbDisplayId.Location = new System.Drawing.Point(130, 114);
            this.tbDisplayId.Name = "tbDisplayId";
            this.tbDisplayId.Size = new System.Drawing.Size(100, 26);
            this.tbDisplayId.TabIndex = 15;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 368);
            this.Controls.Add(this.tbDisplayId);
            this.Controls.Add(this.lblDisplayId);
            this.Controls.Add(this.tbLinuxInputId);
            this.Controls.Add(this.tbVmInputId);
            this.Controls.Add(this.lblLinuxInputId);
            this.Controls.Add(this.lblVmInput);
            this.Controls.Add(this.cbSwitchInput);
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
        private System.Windows.Forms.CheckBox cbSwitchInput;
        private System.Windows.Forms.Label lblVmInput;
        private System.Windows.Forms.Label lblLinuxInputId;
        private System.Windows.Forms.TextBox tbVmInputId;
        private System.Windows.Forms.TextBox tbLinuxInputId;
        private System.Windows.Forms.Label lblDisplayId;
        private System.Windows.Forms.TextBox tbDisplayId;
    }
}