namespace HibernateFortiSSLVPN
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
            this.components = new System.ComponentModel.Container();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.numericUpDownHibernateTimeout = new System.Windows.Forms.NumericUpDown();
            this.radButtonHibernate = new Telerik.WinControls.UI.RadButton();
            this.timerHibernate = new System.Windows.Forms.Timer(this.components);
            this.radButtonCloseSSLVPN = new Telerik.WinControls.UI.RadButton();
            this.radButtonOpenSSLVPN = new Telerik.WinControls.UI.RadButton();
            this.radLabelSSLServiceStatus = new Telerik.WinControls.UI.RadLabel();
            this.radButtonGetLAN = new Telerik.WinControls.UI.RadButton();
            this.radButtonSetLAN = new Telerik.WinControls.UI.RadButton();
            this.radButtonUnsetLAN = new Telerik.WinControls.UI.RadButton();
            this.radLabelSSLClientStatus = new Telerik.WinControls.UI.RadLabel();
            this.radCheckBoxMuteSound = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHibernateTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonHibernate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCloseSSLVPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonOpenSSLVPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSSLServiceStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonGetLAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSetLAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonUnsetLAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSSLClientStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxMuteSound)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(68, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Timeout (s) :";
            // 
            // numericUpDownHibernateTimeout
            // 
            this.numericUpDownHibernateTimeout.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownHibernateTimeout.Location = new System.Drawing.Point(86, 12);
            this.numericUpDownHibernateTimeout.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownHibernateTimeout.Name = "numericUpDownHibernateTimeout";
            this.numericUpDownHibernateTimeout.ReadOnly = true;
            this.numericUpDownHibernateTimeout.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownHibernateTimeout.TabIndex = 1;
            this.numericUpDownHibernateTimeout.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // radButtonHibernate
            // 
            this.radButtonHibernate.Location = new System.Drawing.Point(141, 12);
            this.radButtonHibernate.Name = "radButtonHibernate";
            this.radButtonHibernate.Size = new System.Drawing.Size(85, 20);
            this.radButtonHibernate.TabIndex = 2;
            this.radButtonHibernate.Text = "&Hibernate";
            this.radButtonHibernate.Click += new System.EventHandler(this.radButtonHibernate_Click);
            // 
            // timerHibernate
            // 
            this.timerHibernate.Interval = 1000;
            this.timerHibernate.Tick += new System.EventHandler(this.timerHibernate_Tick);
            // 
            // radButtonCloseSSLVPN
            // 
            this.radButtonCloseSSLVPN.Location = new System.Drawing.Point(103, 80);
            this.radButtonCloseSSLVPN.Name = "radButtonCloseSSLVPN";
            this.radButtonCloseSSLVPN.Size = new System.Drawing.Size(85, 20);
            this.radButtonCloseSSLVPN.TabIndex = 3;
            this.radButtonCloseSSLVPN.Text = "&Close SSL VPN";
            this.radButtonCloseSSLVPN.Click += new System.EventHandler(this.radButtonCloseSSLVPN_Click);
            // 
            // radButtonOpenSSLVPN
            // 
            this.radButtonOpenSSLVPN.Location = new System.Drawing.Point(12, 80);
            this.radButtonOpenSSLVPN.Name = "radButtonOpenSSLVPN";
            this.radButtonOpenSSLVPN.Size = new System.Drawing.Size(85, 20);
            this.radButtonOpenSSLVPN.TabIndex = 4;
            this.radButtonOpenSSLVPN.Text = "&Open SSL VPN";
            this.radButtonOpenSSLVPN.Click += new System.EventHandler(this.radButtonOpenSSLVPN_Click);
            // 
            // radLabelSSLServiceStatus
            // 
            this.radLabelSSLServiceStatus.Location = new System.Drawing.Point(12, 106);
            this.radLabelSSLServiceStatus.Name = "radLabelSSLServiceStatus";
            this.radLabelSSLServiceStatus.Size = new System.Drawing.Size(94, 18);
            this.radLabelSSLServiceStatus.TabIndex = 5;
            this.radLabelSSLServiceStatus.Text = "SSL Service status";
            // 
            // radButtonGetLAN
            // 
            this.radButtonGetLAN.Location = new System.Drawing.Point(12, 45);
            this.radButtonGetLAN.Name = "radButtonGetLAN";
            this.radButtonGetLAN.Size = new System.Drawing.Size(85, 20);
            this.radButtonGetLAN.TabIndex = 4;
            this.radButtonGetLAN.Text = "&Get LAN";
            this.radButtonGetLAN.Click += new System.EventHandler(this.radButtonGetLAN_Click);
            // 
            // radButtonSetLAN
            // 
            this.radButtonSetLAN.Location = new System.Drawing.Point(103, 45);
            this.radButtonSetLAN.Name = "radButtonSetLAN";
            this.radButtonSetLAN.Size = new System.Drawing.Size(85, 20);
            this.radButtonSetLAN.TabIndex = 5;
            this.radButtonSetLAN.Text = "&Set LAN";
            this.radButtonSetLAN.Click += new System.EventHandler(this.radButtonSetLAN_Click);
            // 
            // radButtonUnsetLAN
            // 
            this.radButtonUnsetLAN.Location = new System.Drawing.Point(194, 45);
            this.radButtonUnsetLAN.Name = "radButtonUnsetLAN";
            this.radButtonUnsetLAN.Size = new System.Drawing.Size(85, 20);
            this.radButtonUnsetLAN.TabIndex = 6;
            this.radButtonUnsetLAN.Text = "&Unset LAN";
            this.radButtonUnsetLAN.Click += new System.EventHandler(this.radButtonUnsetLAN_Click);
            // 
            // radLabelSSLClientStatus
            // 
            this.radLabelSSLClientStatus.Location = new System.Drawing.Point(12, 124);
            this.radLabelSSLClientStatus.Name = "radLabelSSLClientStatus";
            this.radLabelSSLClientStatus.Size = new System.Drawing.Size(117, 18);
            this.radLabelSSLClientStatus.TabIndex = 6;
            this.radLabelSSLClientStatus.Text = "SSL Client not running";
            // 
            // radCheckBoxMuteSound
            // 
            this.radCheckBoxMuteSound.Location = new System.Drawing.Point(232, 12);
            this.radCheckBoxMuteSound.Name = "radCheckBoxMuteSound";
            this.radCheckBoxMuteSound.Size = new System.Drawing.Size(47, 18);
            this.radCheckBoxMuteSound.TabIndex = 7;
            this.radCheckBoxMuteSound.Text = "&Mute";
            this.radCheckBoxMuteSound.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(291, 149);
            this.Controls.Add(this.radCheckBoxMuteSound);
            this.Controls.Add(this.radLabelSSLClientStatus);
            this.Controls.Add(this.radButtonUnsetLAN);
            this.Controls.Add(this.radButtonSetLAN);
            this.Controls.Add(this.radButtonGetLAN);
            this.Controls.Add(this.radLabelSSLServiceStatus);
            this.Controls.Add(this.radButtonOpenSSLVPN);
            this.Controls.Add(this.radButtonCloseSSLVPN);
            this.Controls.Add(this.radButtonHibernate);
            this.Controls.Add(this.numericUpDownHibernateTimeout);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FortiClient SSLVPN / Hibernate";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHibernateTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonHibernate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCloseSSLVPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonOpenSSLVPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSSLServiceStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonGetLAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSetLAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonUnsetLAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSSLClientStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxMuteSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.NumericUpDown numericUpDownHibernateTimeout;
        private Telerik.WinControls.UI.RadButton radButtonHibernate;
        private System.Windows.Forms.Timer timerHibernate;
        private Telerik.WinControls.UI.RadButton radButtonCloseSSLVPN;
        private Telerik.WinControls.UI.RadButton radButtonOpenSSLVPN;
        private Telerik.WinControls.UI.RadLabel radLabelSSLServiceStatus;
        private Telerik.WinControls.UI.RadButton radButtonGetLAN;
        private Telerik.WinControls.UI.RadButton radButtonSetLAN;
        private Telerik.WinControls.UI.RadButton radButtonUnsetLAN;
        private Telerik.WinControls.UI.RadLabel radLabelSSLClientStatus;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxMuteSound;
    }
}

