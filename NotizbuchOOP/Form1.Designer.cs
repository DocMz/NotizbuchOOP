namespace NotizbuchOOP
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Notizen = new System.Windows.Forms.ListBox();
            this.cb_ListenAuswahl = new System.Windows.Forms.ComboBox();
            this.lbl_ComboBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Notizen
            // 
            this.lb_Notizen.FormattingEnabled = true;
            this.lb_Notizen.Location = new System.Drawing.Point(12, 78);
            this.lb_Notizen.Name = "lb_Notizen";
            this.lb_Notizen.Size = new System.Drawing.Size(214, 212);
            this.lb_Notizen.TabIndex = 0;
            // 
            // cb_ListenAuswahl
            // 
            this.cb_ListenAuswahl.FormattingEnabled = true;
            this.cb_ListenAuswahl.Location = new System.Drawing.Point(12, 25);
            this.cb_ListenAuswahl.Name = "cb_ListenAuswahl";
            this.cb_ListenAuswahl.Size = new System.Drawing.Size(214, 21);
            this.cb_ListenAuswahl.TabIndex = 2;
            // 
            // lbl_ComboBox
            // 
            this.lbl_ComboBox.AutoSize = true;
            this.lbl_ComboBox.Location = new System.Drawing.Point(13, 6);
            this.lbl_ComboBox.Name = "lbl_ComboBox";
            this.lbl_ComboBox.Size = new System.Drawing.Size(64, 13);
            this.lbl_ComboBox.TabIndex = 4;
            this.lbl_ComboBox.Text = "Notizbücher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Notizen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ComboBox);
            this.Controls.Add(this.cb_ListenAuswahl);
            this.Controls.Add(this.lb_Notizen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Notizen;
        private System.Windows.Forms.ComboBox cb_ListenAuswahl;
        private System.Windows.Forms.Label lbl_ComboBox;
        private System.Windows.Forms.Label label1;
    }
}

