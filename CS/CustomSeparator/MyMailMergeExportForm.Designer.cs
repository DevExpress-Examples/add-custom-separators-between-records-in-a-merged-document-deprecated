namespace CustomSeparator {
    partial class MyMailMergeExportForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbSeparator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Location = new System.Drawing.Point(33, 250);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton2.Location = new System.Drawing.Point(114, 250);
            // 
            // radioGroupMode
            // 
            this.radioGroupMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupMode.Properties.Appearance.Options.UseBackColor = true;
            // 
            // spinEditCount
            // 
            this.spinEditCount.Properties.Mask.EditMask = "n0";
            // 
            // spinEditFrom
            // 
            this.spinEditFrom.Properties.Mask.EditMask = "n0";
            // 
            // icbSeparator
            // 
            this.icbSeparator.Enabled = false;
            this.icbSeparator.Visible = false;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(14, 168);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "HTML"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Rich text")});
            this.radioGroup1.Size = new System.Drawing.Size(181, 65);
            this.radioGroup1.TabIndex = 10;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(114, 172);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 11;
            this.simpleButton3.Text = "Edit...";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(114, 201);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 12;
            this.simpleButton4.Text = "Edit...";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // MyMailMergeExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(208, 283);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.radioGroup1);
            this.Name = "MyMailMergeExportForm";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.simpleButton1, 0);
            this.Controls.SetChildIndex(this.simpleButton2, 0);
            this.Controls.SetChildIndex(this.radioGroupMode, 0);
            this.Controls.SetChildIndex(this.icbSeparator, 0);
            this.Controls.SetChildIndex(this.lblSeparator, 0);
            this.Controls.SetChildIndex(this.radioGroup1, 0);
            this.Controls.SetChildIndex(this.simpleButton3, 0);
            this.Controls.SetChildIndex(this.simpleButton4, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbSeparator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}