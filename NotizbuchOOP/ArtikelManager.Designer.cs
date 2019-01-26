namespace NotizbuchOOP
{
    partial class ArtikelManager
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
            this.lb_artikel = new System.Windows.Forms.ListBox();
            this.tb_Bezeichnung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_Preis = new System.Windows.Forms.NumericUpDown();
            this.b_save = new System.Windows.Forms.Button();
            this.cm_artikel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Preis)).BeginInit();
            this.cm_artikel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_artikel
            // 
            this.lb_artikel.FormattingEnabled = true;
            this.lb_artikel.Location = new System.Drawing.Point(12, 12);
            this.lb_artikel.Name = "lb_artikel";
            this.lb_artikel.Size = new System.Drawing.Size(146, 108);
            this.lb_artikel.TabIndex = 0;
            this.lb_artikel.SelectedIndexChanged += new System.EventHandler(this.lb_artikel_SelectedIndexChanged);
            // 
            // tb_Bezeichnung
            // 
            this.tb_Bezeichnung.Location = new System.Drawing.Point(164, 28);
            this.tb_Bezeichnung.Name = "tb_Bezeichnung";
            this.tb_Bezeichnung.Size = new System.Drawing.Size(162, 20);
            this.tb_Bezeichnung.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Artikelbezeichnung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Preis";
            // 
            // nud_Preis
            // 
            this.nud_Preis.Location = new System.Drawing.Point(164, 68);
            this.nud_Preis.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_Preis.Name = "nud_Preis";
            this.nud_Preis.Size = new System.Drawing.Size(162, 20);
            this.nud_Preis.TabIndex = 14;
            this.nud_Preis.ThousandsSeparator = true;
            // 
            // b_save
            // 
            this.b_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.b_save.Location = new System.Drawing.Point(164, 97);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(162, 23);
            this.b_save.TabIndex = 15;
            this.b_save.Text = "Speichern";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // cm_artikel
            // 
            this.cm_artikel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem,
            this.entfernenToolStripMenuItem});
            this.cm_artikel.Name = "cm_artikel";
            this.cm_artikel.Size = new System.Drawing.Size(181, 70);
            // 
            // hinzufügenToolStripMenuItem
            // 
            this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
            this.hinzufügenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hinzufügenToolStripMenuItem.Text = "Hinzufügen";
            this.hinzufügenToolStripMenuItem.Click += new System.EventHandler(this.hinzufügenToolStripMenuItem_Click);
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entfernenToolStripMenuItem.Text = "Entfernen";
            this.entfernenToolStripMenuItem.Click += new System.EventHandler(this.entfernenToolStripMenuItem_Click);
            // 
            // ArtikelManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 132);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.nud_Preis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Bezeichnung);
            this.Controls.Add(this.lb_artikel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArtikelManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ArtikelManager";
            this.Load += new System.EventHandler(this.ArtikelManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Preis)).EndInit();
            this.cm_artikel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_artikel;
        private System.Windows.Forms.TextBox tb_Bezeichnung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_Preis;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.ContextMenuStrip cm_artikel;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
    }
}