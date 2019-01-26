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
            this.components = new System.ComponentModel.Container();
            this.cb_ListenAuswahl = new System.Windows.Forms.ComboBox();
            this.lbl_ComboBox = new System.Windows.Forms.Label();
            this.b_Notizen = new System.Windows.Forms.Button();
            this.b_Einkauf = new System.Windows.Forms.Button();
            this.b_Hausaufgaben = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lb_notizen = new System.Windows.Forms.ListBox();
            this.nud_Prio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.b_Suchen = new System.Windows.Forms.Button();
            this.rtb_inhalt = new System.Windows.Forms.RichTextBox();
            this.tb_titel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b_speichern = new System.Windows.Forms.Button();
            this.tbar_prio = new System.Windows.Forms.TrackBar();
            this.cm_notizen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notizHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notizLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.l_datum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_fach = new System.Windows.Forms.TextBox();
            this.dtp_ablauf = new System.Windows.Forms.DateTimePicker();
            this.sortierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prioritätToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_artAdd = new System.Windows.Forms.Button();
            this.l_artikel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Prio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_prio)).BeginInit();
            this.cm_notizen.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_ListenAuswahl
            // 
            this.cb_ListenAuswahl.FormattingEnabled = true;
            this.cb_ListenAuswahl.Location = new System.Drawing.Point(12, 25);
            this.cb_ListenAuswahl.Name = "cb_ListenAuswahl";
            this.cb_ListenAuswahl.Size = new System.Drawing.Size(222, 21);
            this.cb_ListenAuswahl.TabIndex = 2;
            this.cb_ListenAuswahl.SelectedIndexChanged += new System.EventHandler(this.cb_ListenAuswahl_SelectedIndexChanged);
            // 
            // lbl_ComboBox
            // 
            this.lbl_ComboBox.AutoSize = true;
            this.lbl_ComboBox.Location = new System.Drawing.Point(9, 9);
            this.lbl_ComboBox.Name = "lbl_ComboBox";
            this.lbl_ComboBox.Size = new System.Drawing.Size(64, 13);
            this.lbl_ComboBox.TabIndex = 4;
            this.lbl_ComboBox.Text = "Notizbücher";
            // 
            // b_Notizen
            // 
            this.b_Notizen.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.b_Notizen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.b_Notizen.Location = new System.Drawing.Point(12, 96);
            this.b_Notizen.Name = "b_Notizen";
            this.b_Notizen.Size = new System.Drawing.Size(70, 23);
            this.b_Notizen.TabIndex = 6;
            this.b_Notizen.Text = "Notizen";
            this.b_Notizen.UseVisualStyleBackColor = false;
            this.b_Notizen.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_Einkauf
            // 
            this.b_Einkauf.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.b_Einkauf.Location = new System.Drawing.Point(88, 96);
            this.b_Einkauf.Name = "b_Einkauf";
            this.b_Einkauf.Size = new System.Drawing.Size(70, 23);
            this.b_Einkauf.TabIndex = 7;
            this.b_Einkauf.Text = "Einkauf";
            this.b_Einkauf.UseVisualStyleBackColor = true;
            this.b_Einkauf.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_Hausaufgaben
            // 
            this.b_Hausaufgaben.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.b_Hausaufgaben.Location = new System.Drawing.Point(164, 96);
            this.b_Hausaufgaben.Name = "b_Hausaufgaben";
            this.b_Hausaufgaben.Size = new System.Drawing.Size(70, 23);
            this.b_Hausaufgaben.TabIndex = 8;
            this.b_Hausaufgaben.Text = "Hausaufg.";
            this.b_Hausaufgaben.UseVisualStyleBackColor = true;
            this.b_Hausaufgaben.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Buch hinzufügen";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(127, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Buch entfernen";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lb_notizen
            // 
            this.lb_notizen.FormattingEnabled = true;
            this.lb_notizen.Location = new System.Drawing.Point(240, 25);
            this.lb_notizen.Name = "lb_notizen";
            this.lb_notizen.ScrollAlwaysVisible = true;
            this.lb_notizen.Size = new System.Drawing.Size(252, 121);
            this.lb_notizen.TabIndex = 12;
            this.lb_notizen.SelectedIndexChanged += new System.EventHandler(this.lb_notizen_SelectedIndexChanged);
            // 
            // nud_Prio
            // 
            this.nud_Prio.Location = new System.Drawing.Point(46, 126);
            this.nud_Prio.Name = "nud_Prio";
            this.nud_Prio.ReadOnly = true;
            this.nud_Prio.Size = new System.Drawing.Size(112, 20);
            this.nud_Prio.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filter";
            // 
            // b_Suchen
            // 
            this.b_Suchen.Location = new System.Drawing.Point(164, 125);
            this.b_Suchen.Name = "b_Suchen";
            this.b_Suchen.Size = new System.Drawing.Size(70, 22);
            this.b_Suchen.TabIndex = 15;
            this.b_Suchen.Text = "Suchen";
            this.b_Suchen.UseVisualStyleBackColor = true;
            this.b_Suchen.Click += new System.EventHandler(this.b_Suchen_Click);
            // 
            // rtb_inhalt
            // 
            this.rtb_inhalt.Location = new System.Drawing.Point(240, 208);
            this.rtb_inhalt.Name = "rtb_inhalt";
            this.rtb_inhalt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_inhalt.Size = new System.Drawing.Size(252, 143);
            this.rtb_inhalt.TabIndex = 17;
            this.rtb_inhalt.Text = "";
            // 
            // tb_titel
            // 
            this.tb_titel.Location = new System.Drawing.Point(240, 169);
            this.tb_titel.Name = "tb_titel";
            this.tb_titel.Size = new System.Drawing.Size(251, 20);
            this.tb_titel.TabIndex = 18;
            this.tb_titel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Titel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Inhalt";
            // 
            // b_speichern
            // 
            this.b_speichern.Location = new System.Drawing.Point(14, 327);
            this.b_speichern.Name = "b_speichern";
            this.b_speichern.Size = new System.Drawing.Size(220, 23);
            this.b_speichern.TabIndex = 21;
            this.b_speichern.Text = "Speichern";
            this.b_speichern.UseVisualStyleBackColor = true;
            this.b_speichern.Click += new System.EventHandler(this.b_speichern_click);
            // 
            // tbar_prio
            // 
            this.tbar_prio.LargeChange = 3;
            this.tbar_prio.Location = new System.Drawing.Point(14, 169);
            this.tbar_prio.Maximum = 3;
            this.tbar_prio.Name = "tbar_prio";
            this.tbar_prio.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbar_prio.Size = new System.Drawing.Size(45, 152);
            this.tbar_prio.TabIndex = 22;
            // 
            // cm_notizen
            // 
            this.cm_notizen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notizHinzufügenToolStripMenuItem,
            this.notizLöschenToolStripMenuItem,
            this.sortierenToolStripMenuItem});
            this.cm_notizen.Name = "cm_notizen";
            this.cm_notizen.Size = new System.Drawing.Size(137, 70);
            // 
            // notizHinzufügenToolStripMenuItem
            // 
            this.notizHinzufügenToolStripMenuItem.Name = "notizHinzufügenToolStripMenuItem";
            this.notizHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.notizHinzufügenToolStripMenuItem.Text = "Hinzufügen";
            this.notizHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.notizHinzufügenToolStripMenuItem_Click);
            // 
            // notizLöschenToolStripMenuItem
            // 
            this.notizLöschenToolStripMenuItem.Name = "notizLöschenToolStripMenuItem";
            this.notizLöschenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.notizLöschenToolStripMenuItem.Text = "Löschen";
            this.notizLöschenToolStripMenuItem.Click += new System.EventHandler(this.notizLöschenToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(11, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Priorität";
            // 
            // l_datum
            // 
            this.l_datum.AutoSize = true;
            this.l_datum.Location = new System.Drawing.Point(85, 192);
            this.l_datum.Name = "l_datum";
            this.l_datum.Size = new System.Drawing.Size(48, 13);
            this.l_datum.TabIndex = 25;
            this.l_datum.Text = "Fälligkeit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fach";
            // 
            // tb_fach
            // 
            this.tb_fach.Location = new System.Drawing.Point(88, 169);
            this.tb_fach.Name = "tb_fach";
            this.tb_fach.Size = new System.Drawing.Size(146, 20);
            this.tb_fach.TabIndex = 26;
            // 
            // dtp_ablauf
            // 
            this.dtp_ablauf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ablauf.Location = new System.Drawing.Point(88, 208);
            this.dtp_ablauf.Name = "dtp_ablauf";
            this.dtp_ablauf.Size = new System.Drawing.Size(146, 20);
            this.dtp_ablauf.TabIndex = 28;
            // 
            // sortierenToolStripMenuItem
            // 
            this.sortierenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titelToolStripMenuItem,
            this.datumToolStripMenuItem,
            this.fachToolStripMenuItem,
            this.prioritätToolStripMenuItem});
            this.sortierenToolStripMenuItem.Name = "sortierenToolStripMenuItem";
            this.sortierenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.sortierenToolStripMenuItem.Text = "Sortieren";
            // 
            // titelToolStripMenuItem
            // 
            this.titelToolStripMenuItem.Name = "titelToolStripMenuItem";
            this.titelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.titelToolStripMenuItem.Text = "Titel";
            this.titelToolStripMenuItem.Click += new System.EventHandler(this.titelToolStripMenuItem_Click);
            // 
            // datumToolStripMenuItem
            // 
            this.datumToolStripMenuItem.Name = "datumToolStripMenuItem";
            this.datumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datumToolStripMenuItem.Text = "Datum";
            this.datumToolStripMenuItem.Click += new System.EventHandler(this.datumToolStripMenuItem_Click);
            // 
            // fachToolStripMenuItem
            // 
            this.fachToolStripMenuItem.Name = "fachToolStripMenuItem";
            this.fachToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fachToolStripMenuItem.Text = "Fach";
            this.fachToolStripMenuItem.Click += new System.EventHandler(this.fachToolStripMenuItem_Click);
            // 
            // prioritätToolStripMenuItem
            // 
            this.prioritätToolStripMenuItem.Name = "prioritätToolStripMenuItem";
            this.prioritätToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prioritätToolStripMenuItem.Text = "Priorität";
            this.prioritätToolStripMenuItem.Click += new System.EventHandler(this.prioritätToolStripMenuItem_Click);
            // 
            // b_artAdd
            // 
            this.b_artAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.b_artAdd.Location = new System.Drawing.Point(88, 247);
            this.b_artAdd.Name = "b_artAdd";
            this.b_artAdd.Size = new System.Drawing.Size(146, 23);
            this.b_artAdd.TabIndex = 29;
            this.b_artAdd.Text = "Liste öffnen";
            this.b_artAdd.UseVisualStyleBackColor = true;
            this.b_artAdd.Click += new System.EventHandler(this.b_artAdd_Click);
            // 
            // l_artikel
            // 
            this.l_artikel.AutoSize = true;
            this.l_artikel.Location = new System.Drawing.Point(85, 231);
            this.l_artikel.Name = "l_artikel";
            this.l_artikel.Size = new System.Drawing.Size(36, 13);
            this.l_artikel.TabIndex = 31;
            this.l_artikel.Text = "Artikel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 363);
            this.Controls.Add(this.l_artikel);
            this.Controls.Add(this.b_artAdd);
            this.Controls.Add(this.dtp_ablauf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_fach);
            this.Controls.Add(this.l_datum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbar_prio);
            this.Controls.Add(this.b_speichern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_titel);
            this.Controls.Add(this.rtb_inhalt);
            this.Controls.Add(this.b_Suchen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_Prio);
            this.Controls.Add(this.lb_notizen);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.b_Hausaufgaben);
            this.Controls.Add(this.b_Einkauf);
            this.Controls.Add(this.b_Notizen);
            this.Controls.Add(this.lbl_ComboBox);
            this.Controls.Add(this.cb_ListenAuswahl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Notizbuch";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Prio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_prio)).EndInit();
            this.cm_notizen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_ListenAuswahl;
        private System.Windows.Forms.Label lbl_ComboBox;
        private System.Windows.Forms.Button b_Notizen;
        private System.Windows.Forms.Button b_Einkauf;
        private System.Windows.Forms.Button b_Hausaufgaben;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox lb_notizen;
        private System.Windows.Forms.NumericUpDown nud_Prio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_Suchen;
        private System.Windows.Forms.RichTextBox rtb_inhalt;
        private System.Windows.Forms.TextBox tb_titel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_speichern;
        private System.Windows.Forms.TrackBar tbar_prio;
        private System.Windows.Forms.ContextMenuStrip cm_notizen;
        private System.Windows.Forms.ToolStripMenuItem notizHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notizLöschenToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_datum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_fach;
        private System.Windows.Forms.DateTimePicker dtp_ablauf;
        private System.Windows.Forms.ToolStripMenuItem sortierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prioritätToolStripMenuItem;
        private System.Windows.Forms.Button b_artAdd;
        private System.Windows.Forms.Label l_artikel;
    }
}

