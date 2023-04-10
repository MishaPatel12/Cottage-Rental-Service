namespace Latin_Translator
{
    partial class Latin_Translator1
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
            this.quid_pro_quobutton = new System.Windows.Forms.Button();
            this.exempli_gratisbutton = new System.Windows.Forms.Button();
            this.ille_estbutton = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.English_Translatorlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quid_pro_quobutton
            // 
            this.quid_pro_quobutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quid_pro_quobutton.Location = new System.Drawing.Point(68, 258);
            this.quid_pro_quobutton.Name = "quid_pro_quobutton";
            this.quid_pro_quobutton.Size = new System.Drawing.Size(134, 42);
            this.quid_pro_quobutton.TabIndex = 0;
            this.quid_pro_quobutton.Text = "quid pro quo";
            this.quid_pro_quobutton.UseVisualStyleBackColor = false;
            this.quid_pro_quobutton.Click += new System.EventHandler(this.quid_pro_quobutton_Click);
            // 
            // exempli_gratisbutton
            // 
            this.exempli_gratisbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exempli_gratisbutton.Location = new System.Drawing.Point(240, 258);
            this.exempli_gratisbutton.Name = "exempli_gratisbutton";
            this.exempli_gratisbutton.Size = new System.Drawing.Size(155, 42);
            this.exempli_gratisbutton.TabIndex = 1;
            this.exempli_gratisbutton.Text = "exempli gratis";
            this.exempli_gratisbutton.UseVisualStyleBackColor = false;
            this.exempli_gratisbutton.Click += new System.EventHandler(this.exempli_gratisbutton_Click);
            // 
            // ille_estbutton
            // 
            this.ille_estbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ille_estbutton.Location = new System.Drawing.Point(443, 258);
            this.ille_estbutton.Name = "ille_estbutton";
            this.ille_estbutton.Size = new System.Drawing.Size(148, 42);
            this.ille_estbutton.TabIndex = 2;
            this.ille_estbutton.Text = "ille est";
            this.ille_estbutton.UseVisualStyleBackColor = false;
            this.ille_estbutton.Click += new System.EventHandler(this.ille_estbutton_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(644, 258);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(119, 42);
            this.Exit_button.TabIndex = 3;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(644, 153);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(119, 42);
            this.Clear_button.TabIndex = 4;
            this.Clear_button.Text = "Clear Text";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutput.Location = new System.Drawing.Point(295, 153);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(218, 42);
            this.labelOutput.TabIndex = 5;
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // English_Translatorlabel
            // 
            this.English_Translatorlabel.AutoSize = true;
            this.English_Translatorlabel.Location = new System.Drawing.Point(66, 153);
            this.English_Translatorlabel.Name = "English_Translatorlabel";
            this.English_Translatorlabel.Size = new System.Drawing.Size(136, 20);
            this.English_Translatorlabel.TabIndex = 6;
            this.English_Translatorlabel.Text = "English Translator";
            this.English_Translatorlabel.Click += new System.EventHandler(this.English_Translatorlabel_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(215, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Click on the to show the meaning of the word in latin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Latin_Translator1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.English_Translatorlabel);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.ille_estbutton);
            this.Controls.Add(this.exempli_gratisbutton);
            this.Controls.Add(this.quid_pro_quobutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Latin_Translator1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quid_pro_quobutton;
        private System.Windows.Forms.Button exempli_gratisbutton;
        private System.Windows.Forms.Button ille_estbutton;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label English_Translatorlabel;
        private System.Windows.Forms.Label label3;
    }
}

