namespace Click
{
    partial class ClickBetterForm
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
            this.gb_BindSettings = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ShiftClickKey = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BindClickShift = new System.Windows.Forms.Button();
            this.lbl_ClickBind = new System.Windows.Forms.Label();
            this.lbl_TextBind = new System.Windows.Forms.Label();
            this.btn_RecordClickBind = new System.Windows.Forms.Button();
            this.gb_MouseSettings = new System.Windows.Forms.GroupBox();
            this.cb_FastClick = new System.Windows.Forms.CheckBox();
            this.gb_BindSettings.SuspendLayout();
            this.gb_MouseSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_BindSettings
            // 
            this.gb_BindSettings.Controls.Add(this.label3);
            this.gb_BindSettings.Controls.Add(this.label1);
            this.gb_BindSettings.Controls.Add(this.lbl_ShiftClickKey);
            this.gb_BindSettings.Controls.Add(this.label2);
            this.gb_BindSettings.Controls.Add(this.btn_BindClickShift);
            this.gb_BindSettings.Controls.Add(this.lbl_ClickBind);
            this.gb_BindSettings.Controls.Add(this.lbl_TextBind);
            this.gb_BindSettings.Controls.Add(this.btn_RecordClickBind);
            this.gb_BindSettings.Location = new System.Drawing.Point(12, 12);
            this.gb_BindSettings.Name = "gb_BindSettings";
            this.gb_BindSettings.Size = new System.Drawing.Size(260, 84);
            this.gb_BindSettings.TabIndex = 0;
            this.gb_BindSettings.TabStop = false;
            this.gb_BindSettings.Text = "Bind Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Click + Shift";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click";
            // 
            // lbl_ShiftClickKey
            // 
            this.lbl_ShiftClickKey.AutoSize = true;
            this.lbl_ShiftClickKey.Location = new System.Drawing.Point(184, 53);
            this.lbl_ShiftClickKey.Name = "lbl_ShiftClickKey";
            this.lbl_ShiftClickKey.Size = new System.Drawing.Size(35, 13);
            this.lbl_ShiftClickKey.TabIndex = 5;
            this.lbl_ShiftClickKey.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key:";
            // 
            // btn_BindClickShift
            // 
            this.btn_BindClickShift.Location = new System.Drawing.Point(69, 48);
            this.btn_BindClickShift.Name = "btn_BindClickShift";
            this.btn_BindClickShift.Size = new System.Drawing.Size(75, 23);
            this.btn_BindClickShift.TabIndex = 3;
            this.btn_BindClickShift.Text = "Set Bind";
            this.btn_BindClickShift.UseVisualStyleBackColor = true;
            this.btn_BindClickShift.Click += new System.EventHandler(this.btn_BindClickShift_Click);
            // 
            // lbl_ClickBind
            // 
            this.lbl_ClickBind.AutoSize = true;
            this.lbl_ClickBind.Location = new System.Drawing.Point(184, 24);
            this.lbl_ClickBind.Name = "lbl_ClickBind";
            this.lbl_ClickBind.Size = new System.Drawing.Size(35, 13);
            this.lbl_ClickBind.TabIndex = 2;
            this.lbl_ClickBind.Text = "label1";
            // 
            // lbl_TextBind
            // 
            this.lbl_TextBind.AutoSize = true;
            this.lbl_TextBind.Location = new System.Drawing.Point(150, 24);
            this.lbl_TextBind.Name = "lbl_TextBind";
            this.lbl_TextBind.Size = new System.Drawing.Size(28, 13);
            this.lbl_TextBind.TabIndex = 1;
            this.lbl_TextBind.Text = "Key:";
            // 
            // btn_RecordClickBind
            // 
            this.btn_RecordClickBind.Location = new System.Drawing.Point(69, 19);
            this.btn_RecordClickBind.Name = "btn_RecordClickBind";
            this.btn_RecordClickBind.Size = new System.Drawing.Size(75, 23);
            this.btn_RecordClickBind.TabIndex = 0;
            this.btn_RecordClickBind.Text = "Set Bind";
            this.btn_RecordClickBind.UseVisualStyleBackColor = true;
            this.btn_RecordClickBind.Click += new System.EventHandler(this.btn_RecordClickBind_Click);
            // 
            // gb_MouseSettings
            // 
            this.gb_MouseSettings.Controls.Add(this.cb_FastClick);
            this.gb_MouseSettings.Location = new System.Drawing.Point(12, 102);
            this.gb_MouseSettings.Name = "gb_MouseSettings";
            this.gb_MouseSettings.Size = new System.Drawing.Size(260, 92);
            this.gb_MouseSettings.TabIndex = 1;
            this.gb_MouseSettings.TabStop = false;
            this.gb_MouseSettings.Text = "Mouse Settings";
            // 
            // cb_FastClick
            // 
            this.cb_FastClick.AutoSize = true;
            this.cb_FastClick.Location = new System.Drawing.Point(7, 20);
            this.cb_FastClick.Name = "cb_FastClick";
            this.cb_FastClick.Size = new System.Drawing.Size(72, 17);
            this.cb_FastClick.TabIndex = 0;
            this.cb_FastClick.Text = "Fast Click";
            this.cb_FastClick.UseVisualStyleBackColor = true;
            // 
            // ClickBetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.gb_MouseSettings);
            this.Controls.Add(this.gb_BindSettings);
            this.Name = "ClickBetterForm";
            this.Text = "ClickBetterForm";
            this.gb_BindSettings.ResumeLayout(false);
            this.gb_BindSettings.PerformLayout();
            this.gb_MouseSettings.ResumeLayout(false);
            this.gb_MouseSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_BindSettings;
        private System.Windows.Forms.Label lbl_ClickBind;
        private System.Windows.Forms.Label lbl_TextBind;
        private System.Windows.Forms.Button btn_RecordClickBind;
        private System.Windows.Forms.Label lbl_ShiftClickKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BindClickShift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_MouseSettings;
        private System.Windows.Forms.CheckBox cb_FastClick;
    }
}