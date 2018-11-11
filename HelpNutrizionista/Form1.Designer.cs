namespace HelpNutrizionista
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbAlimenti1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdibile = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCalcola = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCalorie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProteine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrassi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaturi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotCal = new System.Windows.Forms.TextBox();
            this.txtTotProt = new System.Windows.Forms.TextBox();
            this.txtTotGras = new System.Windows.Forms.TextBox();
            this.txtTotSat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtColest = new System.Windows.Forms.TextBox();
            this.txtTotCol = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCarb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtZuc = new System.Windows.Forms.TextBox();
            this.txtTotCarb = new System.Windows.Forms.TextBox();
            this.txtTotZuc = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAlimenti1
            // 
            this.cbAlimenti1.FormattingEnabled = true;
            this.cbAlimenti1.Location = new System.Drawing.Point(12, 372);
            this.cbAlimenti1.Name = "cbAlimenti1";
            this.cbAlimenti1.Size = new System.Drawing.Size(400, 21);
            this.cbAlimenti1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(434, 373);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qtà (g)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edibile (g)";
            // 
            // txtEdibile
            // 
            this.txtEdibile.Location = new System.Drawing.Point(490, 373);
            this.txtEdibile.Name = "txtEdibile";
            this.txtEdibile.ReadOnly = true;
            this.txtEdibile.Size = new System.Drawing.Size(40, 20);
            this.txtEdibile.TabIndex = 4;
            this.txtEdibile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(89, 405);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(59, 28);
            this.btnAggiungi.TabIndex = 6;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1010, 264);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrizione";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qantità (g)";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Parte Edibile (g)";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kcal";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Proteine (g)";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 72;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Grassi (g)";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 63;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Di cui Saturi (g)";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 90;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Colesterolo (mg)";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 90;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Carboidrati (g)";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader10.Width = 79;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Zuccheri (g)";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 81;
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(12, 405);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(59, 28);
            this.btnCalcola.TabIndex = 8;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kcal";
            // 
            // txtCalorie
            // 
            this.txtCalorie.Location = new System.Drawing.Point(553, 373);
            this.txtCalorie.Name = "txtCalorie";
            this.txtCalorie.ReadOnly = true;
            this.txtCalorie.Size = new System.Drawing.Size(40, 20);
            this.txtCalorie.TabIndex = 9;
            this.txtCalorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Prot. (g)";
            // 
            // txtProteine
            // 
            this.txtProteine.Location = new System.Drawing.Point(616, 373);
            this.txtProteine.Name = "txtProteine";
            this.txtProteine.ReadOnly = true;
            this.txtProteine.Size = new System.Drawing.Size(40, 20);
            this.txtProteine.TabIndex = 11;
            this.txtProteine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(676, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Lipidi (g)";
            // 
            // txtGrassi
            // 
            this.txtGrassi.Location = new System.Drawing.Point(679, 373);
            this.txtGrassi.Name = "txtGrassi";
            this.txtGrassi.ReadOnly = true;
            this.txtGrassi.Size = new System.Drawing.Size(40, 20);
            this.txtGrassi.TabIndex = 13;
            this.txtGrassi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(738, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Saturi (g)";
            // 
            // txtSaturi
            // 
            this.txtSaturi.Location = new System.Drawing.Point(742, 373);
            this.txtSaturi.Name = "txtSaturi";
            this.txtSaturi.ReadOnly = true;
            this.txtSaturi.Size = new System.Drawing.Size(40, 20);
            this.txtSaturi.TabIndex = 15;
            this.txtSaturi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "TOTALE:";
            // 
            // txtTotCal
            // 
            this.txtTotCal.Location = new System.Drawing.Point(474, 302);
            this.txtTotCal.Name = "txtTotCal";
            this.txtTotCal.ReadOnly = true;
            this.txtTotCal.Size = new System.Drawing.Size(50, 20);
            this.txtTotCal.TabIndex = 18;
            this.txtTotCal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotProt
            // 
            this.txtTotProt.Location = new System.Drawing.Point(532, 302);
            this.txtTotProt.Name = "txtTotProt";
            this.txtTotProt.ReadOnly = true;
            this.txtTotProt.Size = new System.Drawing.Size(66, 20);
            this.txtTotProt.TabIndex = 19;
            this.txtTotProt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotGras
            // 
            this.txtTotGras.Location = new System.Drawing.Point(604, 302);
            this.txtTotGras.Name = "txtTotGras";
            this.txtTotGras.ReadOnly = true;
            this.txtTotGras.Size = new System.Drawing.Size(58, 20);
            this.txtTotGras.TabIndex = 20;
            this.txtTotGras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotSat
            // 
            this.txtTotSat.Location = new System.Drawing.Point(668, 302);
            this.txtTotSat.Name = "txtTotSat";
            this.txtTotSat.ReadOnly = true;
            this.txtTotSat.Size = new System.Drawing.Size(83, 20);
            this.txtTotSat.TabIndex = 21;
            this.txtTotSat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(796, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Colest. (mg)";
            // 
            // txtColest
            // 
            this.txtColest.Location = new System.Drawing.Point(805, 373);
            this.txtColest.Name = "txtColest";
            this.txtColest.ReadOnly = true;
            this.txtColest.Size = new System.Drawing.Size(40, 20);
            this.txtColest.TabIndex = 22;
            this.txtColest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotCol
            // 
            this.txtTotCol.Location = new System.Drawing.Point(757, 302);
            this.txtTotCol.Name = "txtTotCol";
            this.txtTotCol.ReadOnly = true;
            this.txtTotCol.Size = new System.Drawing.Size(84, 20);
            this.txtTotCol.TabIndex = 24;
            this.txtTotCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(865, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Carb. (g)";
            // 
            // txtCarb
            // 
            this.txtCarb.Location = new System.Drawing.Point(868, 373);
            this.txtCarb.Name = "txtCarb";
            this.txtCarb.ReadOnly = true;
            this.txtCarb.Size = new System.Drawing.Size(40, 20);
            this.txtCarb.TabIndex = 25;
            this.txtCarb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(919, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Zuccheri. (g)";
            // 
            // txtZuc
            // 
            this.txtZuc.Location = new System.Drawing.Point(931, 373);
            this.txtZuc.Name = "txtZuc";
            this.txtZuc.ReadOnly = true;
            this.txtZuc.Size = new System.Drawing.Size(40, 20);
            this.txtZuc.TabIndex = 27;
            this.txtZuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotCarb
            // 
            this.txtTotCarb.Location = new System.Drawing.Point(847, 302);
            this.txtTotCarb.Name = "txtTotCarb";
            this.txtTotCarb.ReadOnly = true;
            this.txtTotCarb.Size = new System.Drawing.Size(72, 20);
            this.txtTotCarb.TabIndex = 29;
            this.txtTotCarb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotZuc
            // 
            this.txtTotZuc.Location = new System.Drawing.Point(925, 302);
            this.txtTotZuc.Name = "txtTotZuc";
            this.txtTotZuc.ReadOnly = true;
            this.txtTotZuc.Size = new System.Drawing.Size(78, 20);
            this.txtTotZuc.TabIndex = 30;
            this.txtTotZuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(963, 405);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(59, 28);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "Stampa";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(888, 405);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(59, 28);
            this.btnSalva.TabIndex = 32;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 446);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtTotZuc);
            this.Controls.Add(this.txtTotCarb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtZuc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCarb);
            this.Controls.Add(this.txtTotCol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtColest);
            this.Controls.Add(this.txtTotSat);
            this.Controls.Add(this.txtTotGras);
            this.Controls.Add(this.txtTotProt);
            this.Controls.Add(this.txtTotCal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSaturi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGrassi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProteine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCalorie);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEdibile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbAlimenti1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aiuto Nutrizionista";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAlimenti1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdibile;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCalorie;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProteine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrassi;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSaturi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotCal;
        private System.Windows.Forms.TextBox txtTotProt;
        private System.Windows.Forms.TextBox txtTotGras;
        private System.Windows.Forms.TextBox txtTotSat;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtColest;
        private System.Windows.Forms.TextBox txtTotCol;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCarb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtZuc;
        private System.Windows.Forms.TextBox txtTotCarb;
        private System.Windows.Forms.TextBox txtTotZuc;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

