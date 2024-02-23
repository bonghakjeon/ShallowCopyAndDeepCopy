
namespace ShallowCopyAndDeepCopy
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOrigin = new DevExpress.XtraEditors.SimpleButton();
            this.lblOriginData = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.tboxInt = new DevExpress.XtraEditors.TextEdit();
            this.tboxIntArray = new DevExpress.XtraEditors.TextEdit();
            this.tboxClassNumber = new DevExpress.XtraEditors.TextEdit();
            this.tboxChar = new DevExpress.XtraEditors.TextEdit();
            this.rdoEqual = new System.Windows.Forms.RadioButton();
            this.rdoShallowCopy = new System.Windows.Forms.RadioButton();
            this.rdoDeepCopy = new System.Windows.Forms.RadioButton();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            this.lblOrgData = new DevExpress.XtraEditors.LabelControl();
            this.lblCopyData = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.label8 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxInt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxIntArray.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxClassNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxChar.Properties)).BeginInit();
            this.gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrigin);
            this.groupBox1.Controls.Add(this.lblOriginData);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 52);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origin Data";
            // 
            // btnOrigin
            // 
            this.btnOrigin.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrigin.Appearance.Options.UseForeColor = true;
            this.btnOrigin.Location = new System.Drawing.Point(215, 19);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(60, 25);
            this.btnOrigin.TabIndex = 21;
            this.btnOrigin.Text = "Origin";
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // lblOriginData
            // 
            this.lblOriginData.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.lblOriginData.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOriginData.Appearance.Options.UseBackColor = true;
            this.lblOriginData.Appearance.Options.UseForeColor = true;
            this.lblOriginData.Appearance.Options.UseTextOptions = true;
            this.lblOriginData.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblOriginData.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblOriginData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblOriginData.Location = new System.Drawing.Point(9, 19);
            this.lblOriginData.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblOriginData.Name = "lblOriginData";
            this.lblOriginData.Size = new System.Drawing.Size(200, 25);
            this.lblOriginData.TabIndex = 13;
            this.lblOriginData.Text = "-";
            // 
            // label4
            // 
            this.label4.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Appearance.Options.UseBackColor = true;
            this.label4.Appearance.Options.UseForeColor = true;
            this.label4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.label4.Location = new System.Drawing.Point(28, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "1. Int";
            // 
            // label5
            // 
            this.label5.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Appearance.Options.UseBackColor = true;
            this.label5.Appearance.Options.UseForeColor = true;
            this.label5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.label5.Location = new System.Drawing.Point(145, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "2. Char";
            // 
            // label6
            // 
            this.label6.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Appearance.Options.UseBackColor = true;
            this.label6.Appearance.Options.UseForeColor = true;
            this.label6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label6.Location = new System.Drawing.Point(28, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "3. Int Array";
            // 
            // label7
            // 
            this.label7.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Appearance.Options.UseBackColor = true;
            this.label7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.label7.Location = new System.Drawing.Point(145, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "4. Class Inner Int";
            // 
            // tboxInt
            // 
            this.tboxInt.EditValue = "10";
            this.tboxInt.Location = new System.Drawing.Point(103, 75);
            this.tboxInt.Name = "tboxInt";
            this.tboxInt.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.tboxInt.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tboxInt.Properties.Appearance.Options.UseBackColor = true;
            this.tboxInt.Properties.Appearance.Options.UseForeColor = true;
            this.tboxInt.Size = new System.Drawing.Size(36, 20);
            this.tboxInt.TabIndex = 26;
            // 
            // tboxIntArray
            // 
            this.tboxIntArray.EditValue = "5";
            this.tboxIntArray.Location = new System.Drawing.Point(103, 101);
            this.tboxIntArray.Name = "tboxIntArray";
            this.tboxIntArray.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.tboxIntArray.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tboxIntArray.Properties.Appearance.Options.UseBackColor = true;
            this.tboxIntArray.Properties.Appearance.Options.UseForeColor = true;
            this.tboxIntArray.Size = new System.Drawing.Size(36, 20);
            this.tboxIntArray.TabIndex = 28;
            // 
            // tboxClassNumber
            // 
            this.tboxClassNumber.EditValue = "200";
            this.tboxClassNumber.Location = new System.Drawing.Point(251, 101);
            this.tboxClassNumber.Name = "tboxClassNumber";
            this.tboxClassNumber.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.tboxClassNumber.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tboxClassNumber.Properties.Appearance.Options.UseBackColor = true;
            this.tboxClassNumber.Properties.Appearance.Options.UseForeColor = true;
            this.tboxClassNumber.Size = new System.Drawing.Size(36, 20);
            this.tboxClassNumber.TabIndex = 29;
            // 
            // tboxChar
            // 
            this.tboxChar.EditValue = "A";
            this.tboxChar.Location = new System.Drawing.Point(251, 75);
            this.tboxChar.Name = "tboxChar";
            this.tboxChar.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.tboxChar.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tboxChar.Properties.Appearance.Options.UseBackColor = true;
            this.tboxChar.Properties.Appearance.Options.UseForeColor = true;
            this.tboxChar.Size = new System.Drawing.Size(36, 20);
            this.tboxChar.TabIndex = 27;
            // 
            // rdoEqual
            // 
            this.rdoEqual.BackColor = System.Drawing.SystemColors.Control;
            this.rdoEqual.Checked = true;
            this.rdoEqual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoEqual.Location = new System.Drawing.Point(21, 135);
            this.rdoEqual.Name = "rdoEqual";
            this.rdoEqual.Size = new System.Drawing.Size(55, 18);
            this.rdoEqual.TabIndex = 31;
            this.rdoEqual.TabStop = true;
            this.rdoEqual.Text = "Equal";
            this.rdoEqual.UseVisualStyleBackColor = false;
            // 
            // rdoShallowCopy
            // 
            this.rdoShallowCopy.BackColor = System.Drawing.SystemColors.Control;
            this.rdoShallowCopy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoShallowCopy.Location = new System.Drawing.Point(103, 135);
            this.rdoShallowCopy.Name = "rdoShallowCopy";
            this.rdoShallowCopy.Size = new System.Drawing.Size(97, 18);
            this.rdoShallowCopy.TabIndex = 31;
            this.rdoShallowCopy.TabStop = true;
            this.rdoShallowCopy.Text = "Shallow Copy";
            this.rdoShallowCopy.UseVisualStyleBackColor = false;
            // 
            // rdoDeepCopy
            // 
            this.rdoDeepCopy.BackColor = System.Drawing.SystemColors.Control;
            this.rdoDeepCopy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoDeepCopy.Location = new System.Drawing.Point(213, 135);
            this.rdoDeepCopy.Name = "rdoDeepCopy";
            this.rdoDeepCopy.Size = new System.Drawing.Size(86, 18);
            this.rdoDeepCopy.TabIndex = 33;
            this.rdoDeepCopy.TabStop = true;
            this.rdoDeepCopy.Text = "Deep Copy";
            this.rdoDeepCopy.UseVisualStyleBackColor = false;
            // 
            // gbox
            // 
            this.gbox.BackColor = System.Drawing.SystemColors.Control;
            this.gbox.Controls.Add(this.btnCopy);
            this.gbox.Controls.Add(this.lblOrgData);
            this.gbox.Controls.Add(this.lblCopyData);
            this.gbox.Controls.Add(this.label1);
            this.gbox.Controls.Add(this.label8);
            this.gbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbox.Location = new System.Drawing.Point(12, 163);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(284, 84);
            this.gbox.TabIndex = 21;
            this.gbox.TabStop = false;
            this.gbox.Text = "a = b";
            // 
            // btnCopy
            // 
            this.btnCopy.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCopy.Appearance.Options.UseForeColor = true;
            this.btnCopy.Location = new System.Drawing.Point(215, 19);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(60, 55);
            this.btnCopy.TabIndex = 22;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblOrgData
            // 
            this.lblOrgData.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.lblOrgData.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOrgData.Appearance.Options.UseBackColor = true;
            this.lblOrgData.Appearance.Options.UseForeColor = true;
            this.lblOrgData.Appearance.Options.UseTextOptions = true;
            this.lblOrgData.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblOrgData.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblOrgData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblOrgData.Location = new System.Drawing.Point(48, 49);
            this.lblOrgData.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblOrgData.Name = "lblOrgData";
            this.lblOrgData.Size = new System.Drawing.Size(161, 25);
            this.lblOrgData.TabIndex = 15;
            this.lblOrgData.Text = "-";
            // 
            // lblCopyData
            // 
            this.lblCopyData.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.lblCopyData.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCopyData.Appearance.Options.UseBackColor = true;
            this.lblCopyData.Appearance.Options.UseForeColor = true;
            this.lblCopyData.Appearance.Options.UseTextOptions = true;
            this.lblCopyData.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCopyData.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCopyData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblCopyData.Location = new System.Drawing.Point(48, 19);
            this.lblCopyData.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblCopyData.Name = "lblCopyData";
            this.lblCopyData.Size = new System.Drawing.Size(161, 25);
            this.lblCopyData.TabIndex = 14;
            this.lblCopyData.Text = "-";
            // 
            // label1
            // 
            this.label1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Appearance.Options.UseBackColor = true;
            this.label1.Appearance.Options.UseForeColor = true;
            this.label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Origin";
            // 
            // label8
            // 
            this.label8.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Appearance.Options.UseBackColor = true;
            this.label8.Appearance.Options.UseForeColor = true;
            this.label8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.label8.Location = new System.Drawing.Point(7, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Copy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 262);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.rdoDeepCopy);
            this.Controls.Add(this.rdoShallowCopy);
            this.Controls.Add(this.rdoEqual);
            this.Controls.Add(this.tboxChar);
            this.Controls.Add(this.tboxClassNumber);
            this.Controls.Add(this.tboxIntArray);
            this.Controls.Add(this.tboxInt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tboxInt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxIntArray.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxClassNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxChar.Properties)).EndInit();
            this.gbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl lblOriginData;
        private DevExpress.XtraEditors.SimpleButton btnOrigin;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl label6;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.TextEdit tboxInt;
        private DevExpress.XtraEditors.TextEdit tboxIntArray;
        private DevExpress.XtraEditors.TextEdit tboxClassNumber;
        private DevExpress.XtraEditors.TextEdit tboxChar;
        private System.Windows.Forms.RadioButton rdoEqual;
        private System.Windows.Forms.RadioButton rdoShallowCopy;
        private System.Windows.Forms.RadioButton rdoDeepCopy;
        private System.Windows.Forms.GroupBox gbox;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl label8;
        private DevExpress.XtraEditors.LabelControl lblOrgData;
        private DevExpress.XtraEditors.LabelControl lblCopyData;
        private DevExpress.XtraEditors.SimpleButton btnCopy;
    }
}