namespace NotizbuchOOP
{
    partial class ArtikelAdd
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
            this.cb_artikel = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tb_anzahl = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tb_preis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_artikel
            // 
            this.cb_artikel.FormattingEnabled = true;
            this.cb_artikel.Location = new System.Drawing.Point(12, 12);
            this.cb_artikel.Name = "cb_artikel";
            this.cb_artikel.Size = new System.Drawing.Size(224, 21);
            this.cb_artikel.TabIndex = 0;
            this.cb_artikel.SelectedIndexChanged += new System.EventHandler(this.cb_artikel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anzahl";
            // 
            // tb_anzahl
            // 
            this.tb_anzahl.Location = new System.Drawing.Point(13, 53);
            this.tb_anzahl.Name = "tb_anzahl";
            this.tb_anzahl.Size = new System.Drawing.Size(106, 20);
            this.tb_anzahl.TabIndex = 2;
            this.tb_anzahl.TextChanged += new System.EventHandler(this.tb_anzahl_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tb_preis
            // 
            this.tb_preis.Location = new System.Drawing.Point(125, 53);
            this.tb_preis.Name = "tb_preis";
            this.tb_preis.ReadOnly = true;
            this.tb_preis.Size = new System.Drawing.Size(111, 20);
            this.tb_preis.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preis";
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(12, 76);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(224, 23);
            this.b_add.TabIndex = 6;
            this.b_add.Text = "Hinzufügen";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // ArtikelAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 111);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_preis);
            this.Controls.Add(this.tb_anzahl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_artikel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArtikelAdd";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Artikel hinzufügen";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_artikel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_anzahl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tb_preis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_add;
    }
}