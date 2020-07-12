namespace VfioUsbClient
{
    partial class ProfileEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileEditor));
            this.lblProfile = new System.Windows.Forms.Label();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.lblDevices = new System.Windows.Forms.Label();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.btnRemoveDevice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(12, 18);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(57, 20);
            this.lblProfile.TabIndex = 0;
            this.lblProfile.Text = "Profile:";
            // 
            // cbProfile
            // 
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(75, 15);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(254, 28);
            this.cbProfile.TabIndex = 1;
            this.cbProfile.SelectedIndexChanged += new System.EventHandler(this.cbProfile_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(336, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(448, 14);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 34);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbDevices
            // 
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.ItemHeight = 20;
            this.lbDevices.Location = new System.Drawing.Point(16, 83);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(538, 204);
            this.lbDevices.TabIndex = 4;
            // 
            // lblDevices
            // 
            this.lblDevices.AutoSize = true;
            this.lblDevices.Location = new System.Drawing.Point(12, 60);
            this.lblDevices.Name = "lblDevices";
            this.lblDevices.Size = new System.Drawing.Size(69, 20);
            this.lblDevices.TabIndex = 5;
            this.lblDevices.Text = "Devices:";
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Location = new System.Drawing.Point(16, 295);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(132, 32);
            this.btnAddDevice.TabIndex = 6;
            this.btnAddDevice.Text = "Add Device";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // btnRemoveDevice
            // 
            this.btnRemoveDevice.Location = new System.Drawing.Point(422, 295);
            this.btnRemoveDevice.Name = "btnRemoveDevice";
            this.btnRemoveDevice.Size = new System.Drawing.Size(132, 34);
            this.btnRemoveDevice.TabIndex = 7;
            this.btnRemoveDevice.Text = "Remove Device";
            this.btnRemoveDevice.UseVisualStyleBackColor = true;
            this.btnRemoveDevice.Click += new System.EventHandler(this.btnRemoveDevice_Click);
            // 
            // ProfileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 348);
            this.Controls.Add(this.btnRemoveDevice);
            this.Controls.Add(this.btnAddDevice);
            this.Controls.Add(this.lblDevices);
            this.Controls.Add(this.lbDevices);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbProfile);
            this.Controls.Add(this.lblProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile Editor";
            this.Load += new System.EventHandler(this.ProfileEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbDevices;
        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Button btnRemoveDevice;
    }
}