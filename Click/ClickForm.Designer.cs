namespace Click
{
    partial class clickForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_rebind = new System.Windows.Forms.Button();
            this.lbl_btn = new System.Windows.Forms.Label();
            this.lbl_text = new System.Windows.Forms.Label();
            this.cb_Shift = new System.Windows.Forms.CheckBox();
            this.cb_Alt = new System.Windows.Forms.CheckBox();
            this.cb_Ctrl = new System.Windows.Forms.CheckBox();
            this.nud_Clicks = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Record = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.lbl_Clicks = new System.Windows.Forms.Label();
            this.btn_Bind_Recording = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Recording_Start = new System.Windows.Forms.Label();
            this.cb_FastClick = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Clicks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_rebind
            // 
            this.btn_rebind.Location = new System.Drawing.Point(6, 19);
            this.btn_rebind.Name = "btn_rebind";
            this.btn_rebind.Size = new System.Drawing.Size(75, 23);
            this.btn_rebind.TabIndex = 2;
            this.btn_rebind.Text = "Rebind click";
            this.btn_rebind.UseVisualStyleBackColor = true;
            this.btn_rebind.Click += new System.EventHandler(this.btn_rebind_Click);
            // 
            // lbl_btn
            // 
            this.lbl_btn.AutoSize = true;
            this.lbl_btn.Location = new System.Drawing.Point(120, 24);
            this.lbl_btn.Name = "lbl_btn";
            this.lbl_btn.Size = new System.Drawing.Size(35, 13);
            this.lbl_btn.TabIndex = 3;
            this.lbl_btn.Text = "label1";
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(87, 24);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(28, 13);
            this.lbl_text.TabIndex = 4;
            this.lbl_text.Text = "Key:";
            // 
            // cb_Shift
            // 
            this.cb_Shift.AutoSize = true;
            this.cb_Shift.Location = new System.Drawing.Point(6, 48);
            this.cb_Shift.Name = "cb_Shift";
            this.cb_Shift.Size = new System.Drawing.Size(47, 17);
            this.cb_Shift.TabIndex = 5;
            this.cb_Shift.Text = "Shift";
            this.cb_Shift.UseVisualStyleBackColor = true;
            // 
            // cb_Alt
            // 
            this.cb_Alt.AutoSize = true;
            this.cb_Alt.Location = new System.Drawing.Point(6, 71);
            this.cb_Alt.Name = "cb_Alt";
            this.cb_Alt.Size = new System.Drawing.Size(38, 17);
            this.cb_Alt.TabIndex = 6;
            this.cb_Alt.Text = "Alt";
            this.cb_Alt.UseVisualStyleBackColor = true;
            // 
            // cb_Ctrl
            // 
            this.cb_Ctrl.AutoSize = true;
            this.cb_Ctrl.Location = new System.Drawing.Point(6, 94);
            this.cb_Ctrl.Name = "cb_Ctrl";
            this.cb_Ctrl.Size = new System.Drawing.Size(41, 17);
            this.cb_Ctrl.TabIndex = 7;
            this.cb_Ctrl.Text = "Ctrl";
            this.cb_Ctrl.UseVisualStyleBackColor = true;
            // 
            // nud_Clicks
            // 
            this.nud_Clicks.Location = new System.Drawing.Point(280, 82);
            this.nud_Clicks.Name = "nud_Clicks";
            this.nud_Clicks.Size = new System.Drawing.Size(80, 20);
            this.nud_Clicks.TabIndex = 8;
            this.nud_Clicks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Clicks";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(280, 108);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Delay";
            // 
            // btn_Record
            // 
            this.btn_Record.Location = new System.Drawing.Point(12, 155);
            this.btn_Record.Name = "btn_Record";
            this.btn_Record.Size = new System.Drawing.Size(96, 22);
            this.btn_Record.TabIndex = 12;
            this.btn_Record.Text = "Record Mouse";
            this.btn_Record.UseVisualStyleBackColor = true;
            this.btn_Record.Click += new System.EventHandler(this.btn_Record_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(12, 183);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(96, 22);
            this.btn_Play.TabIndex = 13;
            this.btn_Play.Text = "Play Recording";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // lbl_Clicks
            // 
            this.lbl_Clicks.AutoSize = true;
            this.lbl_Clicks.Location = new System.Drawing.Point(154, 160);
            this.lbl_Clicks.Name = "lbl_Clicks";
            this.lbl_Clicks.Size = new System.Drawing.Size(13, 13);
            this.lbl_Clicks.TabIndex = 14;
            this.lbl_Clicks.Text = "0";
            // 
            // btn_Bind_Recording
            // 
            this.btn_Bind_Recording.Location = new System.Drawing.Point(12, 211);
            this.btn_Bind_Recording.Name = "btn_Bind_Recording";
            this.btn_Bind_Recording.Size = new System.Drawing.Size(96, 23);
            this.btn_Bind_Recording.TabIndex = 15;
            this.btn_Bind_Recording.Text = "Bind recording";
            this.btn_Bind_Recording.UseVisualStyleBackColor = true;
            this.btn_Bind_Recording.Click += new System.EventHandler(this.btn_Bind_Recording_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Clicks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Key:";
            // 
            // lbl_Recording_Start
            // 
            this.lbl_Recording_Start.AutoSize = true;
            this.lbl_Recording_Start.Location = new System.Drawing.Point(147, 216);
            this.lbl_Recording_Start.Name = "lbl_Recording_Start";
            this.lbl_Recording_Start.Size = new System.Drawing.Size(35, 13);
            this.lbl_Recording_Start.TabIndex = 17;
            this.lbl_Recording_Start.Text = "label1";
            // 
            // cb_FastClick
            // 
            this.cb_FastClick.AutoSize = true;
            this.cb_FastClick.Location = new System.Drawing.Point(6, 117);
            this.cb_FastClick.Name = "cb_FastClick";
            this.cb_FastClick.Size = new System.Drawing.Size(72, 17);
            this.cb_FastClick.TabIndex = 19;
            this.cb_FastClick.Text = "Fast Click";
            this.cb_FastClick.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_rebind);
            this.groupBox1.Controls.Add(this.cb_FastClick);
            this.groupBox1.Controls.Add(this.lbl_btn);
            this.groupBox1.Controls.Add(this.lbl_text);
            this.groupBox1.Controls.Add(this.cb_Shift);
            this.groupBox1.Controls.Add(this.cb_Alt);
            this.groupBox1.Controls.Add(this.cb_Ctrl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nud_Clicks);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 137);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keyboard Click Settings";
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // clickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 327);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Recording_Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Bind_Recording);
            this.Controls.Add(this.lbl_Clicks);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.btn_Record);
            this.KeyPreview = true;
            this.Name = "clickForm";
            this.Text = "Clicker";
            this.Load += new System.EventHandler(this.cb_FastClick_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClickForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Clicks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_rebind;
        private System.Windows.Forms.Label lbl_btn;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.CheckBox cb_Shift;
        private System.Windows.Forms.CheckBox cb_Alt;
        private System.Windows.Forms.CheckBox cb_Ctrl;
        private System.Windows.Forms.NumericUpDown nud_Clicks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Record;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Label lbl_Clicks;
        private System.Windows.Forms.Button btn_Bind_Recording;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Recording_Start;
        private System.Windows.Forms.CheckBox cb_FastClick;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

