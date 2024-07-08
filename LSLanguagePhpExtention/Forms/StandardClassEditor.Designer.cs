namespace LSLanguagePhpExtention.Forms
{
    partial class StandardClassEditor
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
            this.pnl_standard_code = new System.Windows.Forms.Panel();
            this.rtb_stdclass = new System.Windows.Forms.RichTextBox();
            this.lbl_std_class = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtb_translation = new System.Windows.Forms.RichTextBox();
            this.lbl_translation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_standard_code.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_standard_code
            // 
            this.pnl_standard_code.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_standard_code.Controls.Add(this.rtb_stdclass);
            this.pnl_standard_code.Controls.Add(this.lbl_std_class);
            this.pnl_standard_code.Location = new System.Drawing.Point(0, 50);
            this.pnl_standard_code.Name = "pnl_standard_code";
            this.pnl_standard_code.Size = new System.Drawing.Size(802, 291);
            this.pnl_standard_code.TabIndex = 1;
            // 
            // rtb_stdclass
            // 
            this.rtb_stdclass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.rtb_stdclass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtb_stdclass.ForeColor = System.Drawing.Color.White;
            this.rtb_stdclass.Location = new System.Drawing.Point(15, 35);
            this.rtb_stdclass.Name = "rtb_stdclass";
            this.rtb_stdclass.Size = new System.Drawing.Size(773, 243);
            this.rtb_stdclass.TabIndex = 1;
            this.rtb_stdclass.Text = "";
            // 
            // lbl_std_class
            // 
            this.lbl_std_class.AutoSize = true;
            this.lbl_std_class.ForeColor = System.Drawing.Color.White;
            this.lbl_std_class.Location = new System.Drawing.Point(12, 9);
            this.lbl_std_class.Name = "lbl_std_class";
            this.lbl_std_class.Size = new System.Drawing.Size(456, 13);
            this.lbl_std_class.TabIndex = 0;
            this.lbl_std_class.Text = "Standard Class : (Variables : {langKey} = default language name, {translations} =" +
    " translated dict)";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rtb_translation);
            this.panel1.Controls.Add(this.lbl_translation);
            this.panel1.Location = new System.Drawing.Point(0, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 100);
            this.panel1.TabIndex = 2;
            // 
            // rtb_translation
            // 
            this.rtb_translation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.rtb_translation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.rtb_translation.ForeColor = System.Drawing.Color.White;
            this.rtb_translation.Location = new System.Drawing.Point(15, 29);
            this.rtb_translation.Name = "rtb_translation";
            this.rtb_translation.Size = new System.Drawing.Size(773, 53);
            this.rtb_translation.TabIndex = 2;
            this.rtb_translation.Text = "";
            // 
            // lbl_translation
            // 
            this.lbl_translation.AutoSize = true;
            this.lbl_translation.ForeColor = System.Drawing.Color.White;
            this.lbl_translation.Location = new System.Drawing.Point(12, 13);
            this.lbl_translation.Name = "lbl_translation";
            this.lbl_translation.Size = new System.Drawing.Size(486, 13);
            this.lbl_translation.TabIndex = 1;
            this.lbl_translation.Text = "Standard for translating dictionary to text :  (Variables: {dictKey} translation " +
    "key, {dictValue} translation)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(713, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StandardClassEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_standard_code);
            this.Name = "StandardClassEditor";
            this.Load += new System.EventHandler(this.StandardClassEditor_Load);
            this.pnl_standard_code.ResumeLayout(false);
            this.pnl_standard_code.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_standard_code;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtb_stdclass;
        private System.Windows.Forms.Label lbl_std_class;
        private System.Windows.Forms.Label lbl_translation;
        private System.Windows.Forms.RichTextBox rtb_translation;
        private System.Windows.Forms.Button button1;
    }
}