namespace RegularExpressions
{
    partial class frmRegularExpressions
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLanguages = new System.Windows.Forms.TextBox();
            this.txtAlphabets = new System.Windows.Forms.TextBox();
            this.txtAlphabet = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.btnAddAlphabet = new System.Windows.Forms.Button();
            this.btnAddLanguage = new System.Windows.Forms.Button();
            this.comboLanguageA = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioPower = new System.Windows.Forms.RadioButton();
            this.radioUnion = new System.Windows.Forms.RadioButton();
            this.radioIntersect = new System.Windows.Forms.RadioButton();
            this.radioConcat = new System.Windows.Forms.RadioButton();
            this.radioComplement = new System.Windows.Forms.RadioButton();
            this.radioSimetricDifference = new System.Windows.Forms.RadioButton();
            this.radioDifference = new System.Windows.Forms.RadioButton();
            this.radioPositiveClosure = new System.Windows.Forms.RadioButton();
            this.radioKleeneClosure = new System.Windows.Forms.RadioButton();
            this.comboLanguageB = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.comboAlphabets = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.numericPower = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPower)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtResult.Location = new System.Drawing.Point(12, 210);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(341, 54);
            this.txtResult.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAlphabets);
            this.groupBox1.Enabled = false;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.groupBox1.Location = new System.Drawing.Point(359, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alfabetos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLanguages);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.groupBox2.Location = new System.Drawing.Point(545, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 237);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lenguajes";
            // 
            // txtLanguages
            // 
            this.txtLanguages.BackColor = System.Drawing.Color.White;
            this.txtLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLanguages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtLanguages.Location = new System.Drawing.Point(3, 16);
            this.txtLanguages.Multiline = true;
            this.txtLanguages.Name = "txtLanguages";
            this.txtLanguages.ReadOnly = true;
            this.txtLanguages.Size = new System.Drawing.Size(211, 218);
            this.txtLanguages.TabIndex = 3;
            // 
            // txtAlphabets
            // 
            this.txtAlphabets.BackColor = System.Drawing.Color.White;
            this.txtAlphabets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAlphabets.Enabled = false;
            this.txtAlphabets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAlphabets.Location = new System.Drawing.Point(3, 16);
            this.txtAlphabets.Multiline = true;
            this.txtAlphabets.Name = "txtAlphabets";
            this.txtAlphabets.ReadOnly = true;
            this.txtAlphabets.Size = new System.Drawing.Size(174, 218);
            this.txtAlphabets.TabIndex = 1;
            this.txtAlphabets.Text = "COMING SOON";
            this.txtAlphabets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlphabet
            // 
            this.txtAlphabet.Enabled = false;
            this.txtAlphabet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAlphabet.Location = new System.Drawing.Point(12, 30);
            this.txtAlphabet.Name = "txtAlphabet";
            this.txtAlphabet.Size = new System.Drawing.Size(260, 20);
            this.txtAlphabet.TabIndex = 3;
            this.txtAlphabet.Text = "Alfabeto (COMING SOON)";
            this.txtAlphabet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAlphabet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtAlphabet_MouseDown);
            this.txtAlphabet.MouseLeave += new System.EventHandler(this.txtAlphabet_MouseLeave);
            // 
            // txtLanguage
            // 
            this.txtLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLanguage.Location = new System.Drawing.Point(109, 56);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(163, 20);
            this.txtLanguage.TabIndex = 0;
            this.txtLanguage.Text = "Lenguaje";
            this.txtLanguage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLanguage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtLanguage_MouseDown);
            this.txtLanguage.MouseLeave += new System.EventHandler(this.txtLanguage_MouseLeave);
            // 
            // btnAddAlphabet
            // 
            this.btnAddAlphabet.BackColor = System.Drawing.Color.DimGray;
            this.btnAddAlphabet.Enabled = false;
            this.btnAddAlphabet.FlatAppearance.BorderSize = 0;
            this.btnAddAlphabet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAlphabet.ForeColor = System.Drawing.Color.White;
            this.btnAddAlphabet.Location = new System.Drawing.Point(278, 27);
            this.btnAddAlphabet.Name = "btnAddAlphabet";
            this.btnAddAlphabet.Size = new System.Drawing.Size(75, 23);
            this.btnAddAlphabet.TabIndex = 2;
            this.btnAddAlphabet.Text = "Agregar";
            this.btnAddAlphabet.UseVisualStyleBackColor = false;
            this.btnAddAlphabet.Click += new System.EventHandler(this.btnAddAlphabet_Click);
            // 
            // btnAddLanguage
            // 
            this.btnAddLanguage.BackColor = System.Drawing.Color.DimGray;
            this.btnAddLanguage.FlatAppearance.BorderSize = 0;
            this.btnAddLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLanguage.ForeColor = System.Drawing.Color.White;
            this.btnAddLanguage.Location = new System.Drawing.Point(278, 53);
            this.btnAddLanguage.Name = "btnAddLanguage";
            this.btnAddLanguage.Size = new System.Drawing.Size(75, 23);
            this.btnAddLanguage.TabIndex = 1;
            this.btnAddLanguage.Text = "Agregar";
            this.btnAddLanguage.UseVisualStyleBackColor = false;
            this.btnAddLanguage.Click += new System.EventHandler(this.btnAddLanguage_Click);
            // 
            // comboLanguageA
            // 
            this.comboLanguageA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguageA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLanguageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboLanguageA.FormattingEnabled = true;
            this.comboLanguageA.Location = new System.Drawing.Point(12, 183);
            this.comboLanguageA.Name = "comboLanguageA";
            this.comboLanguageA.Size = new System.Drawing.Size(91, 21);
            this.comboLanguageA.Sorted = true;
            this.comboLanguageA.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericPower);
            this.groupBox3.Controls.Add(this.radioPositiveClosure);
            this.groupBox3.Controls.Add(this.radioKleeneClosure);
            this.groupBox3.Controls.Add(this.radioComplement);
            this.groupBox3.Controls.Add(this.radioSimetricDifference);
            this.groupBox3.Controls.Add(this.radioDifference);
            this.groupBox3.Controls.Add(this.radioConcat);
            this.groupBox3.Controls.Add(this.radioIntersect);
            this.groupBox3.Controls.Add(this.radioUnion);
            this.groupBox3.Controls.Add(this.radioPower);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 95);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones";
            // 
            // radioPower
            // 
            this.radioPower.AutoSize = true;
            this.radioPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.radioPower.Location = new System.Drawing.Point(202, 19);
            this.radioPower.Name = "radioPower";
            this.radioPower.Size = new System.Drawing.Size(67, 17);
            this.radioPower.TabIndex = 18;
            this.radioPower.TabStop = true;
            this.radioPower.Text = "Potencia";
            this.radioPower.UseVisualStyleBackColor = true;
            this.radioPower.CheckedChanged += new System.EventHandler(this.radioPower_CheckedChanged);
            // 
            // radioUnion
            // 
            this.radioUnion.AutoSize = true;
            this.radioUnion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.radioUnion.Location = new System.Drawing.Point(6, 19);
            this.radioUnion.Name = "radioUnion";
            this.radioUnion.Size = new System.Drawing.Size(53, 17);
            this.radioUnion.TabIndex = 19;
            this.radioUnion.TabStop = true;
            this.radioUnion.Text = "Union";
            this.radioUnion.UseVisualStyleBackColor = true;
            this.radioUnion.CheckedChanged += new System.EventHandler(this.radioUnion_CheckedChanged);
            // 
            // radioIntersect
            // 
            this.radioIntersect.AutoSize = true;
            this.radioIntersect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.radioIntersect.Location = new System.Drawing.Point(6, 42);
            this.radioIntersect.Name = "radioIntersect";
            this.radioIntersect.Size = new System.Drawing.Size(83, 17);
            this.radioIntersect.TabIndex = 20;
            this.radioIntersect.TabStop = true;
            this.radioIntersect.Text = "Interseccion";
            this.radioIntersect.UseVisualStyleBackColor = true;
            this.radioIntersect.CheckedChanged += new System.EventHandler(this.radioIntersect_CheckedChanged);
            // 
            // radioConcat
            // 
            this.radioConcat.AutoSize = true;
            this.radioConcat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.radioConcat.Location = new System.Drawing.Point(6, 65);
            this.radioConcat.Name = "radioConcat";
            this.radioConcat.Size = new System.Drawing.Size(97, 17);
            this.radioConcat.TabIndex = 21;
            this.radioConcat.TabStop = true;
            this.radioConcat.Text = "Concatenacion";
            this.radioConcat.UseVisualStyleBackColor = true;
            this.radioConcat.CheckedChanged += new System.EventHandler(this.radioConcat_CheckedChanged);
            // 
            // radioComplement
            // 
            this.radioComplement.AutoSize = true;
            this.radioComplement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.radioComplement.Location = new System.Drawing.Point(107, 65);
            this.radioComplement.Name = "radioComplement";
            this.radioComplement.Size = new System.Drawing.Size(89, 17);
            this.radioComplement.TabIndex = 24;
            this.radioComplement.TabStop = true;
            this.radioComplement.Text = "Complemento";
            this.radioComplement.UseVisualStyleBackColor = true;
            this.radioComplement.CheckedChanged += new System.EventHandler(this.radioComplement_CheckedChanged);
            // 
            // radioSimetricDifference
            // 
            this.radioSimetricDifference.AutoSize = true;
            this.radioSimetricDifference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.radioSimetricDifference.Location = new System.Drawing.Point(107, 42);
            this.radioSimetricDifference.Name = "radioSimetricDifference";
            this.radioSimetricDifference.Size = new System.Drawing.Size(87, 17);
            this.radioSimetricDifference.TabIndex = 23;
            this.radioSimetricDifference.TabStop = true;
            this.radioSimetricDifference.Text = "Dif. Simetrica";
            this.radioSimetricDifference.UseVisualStyleBackColor = true;
            this.radioSimetricDifference.CheckedChanged += new System.EventHandler(this.radioSimetricDifference_CheckedChanged);
            // 
            // radioDifference
            // 
            this.radioDifference.AutoSize = true;
            this.radioDifference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.radioDifference.Location = new System.Drawing.Point(107, 19);
            this.radioDifference.Name = "radioDifference";
            this.radioDifference.Size = new System.Drawing.Size(73, 17);
            this.radioDifference.TabIndex = 22;
            this.radioDifference.TabStop = true;
            this.radioDifference.Text = "Diferencia";
            this.radioDifference.UseVisualStyleBackColor = true;
            this.radioDifference.CheckedChanged += new System.EventHandler(this.radioDifference_CheckedChanged);
            // 
            // radioPositiveClosure
            // 
            this.radioPositiveClosure.AutoSize = true;
            this.radioPositiveClosure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.radioPositiveClosure.Location = new System.Drawing.Point(202, 65);
            this.radioPositiveClosure.Name = "radioPositiveClosure";
            this.radioPositiveClosure.Size = new System.Drawing.Size(111, 17);
            this.radioPositiveClosure.TabIndex = 26;
            this.radioPositiveClosure.TabStop = true;
            this.radioPositiveClosure.Text = "Cerradura Positiva";
            this.radioPositiveClosure.UseVisualStyleBackColor = true;
            this.radioPositiveClosure.CheckedChanged += new System.EventHandler(this.radioPositiveClosure_CheckedChanged);
            // 
            // radioKleeneClosure
            // 
            this.radioKleeneClosure.AutoSize = true;
            this.radioKleeneClosure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.radioKleeneClosure.Location = new System.Drawing.Point(202, 42);
            this.radioKleeneClosure.Name = "radioKleeneClosure";
            this.radioKleeneClosure.Size = new System.Drawing.Size(107, 17);
            this.radioKleeneClosure.TabIndex = 25;
            this.radioKleeneClosure.TabStop = true;
            this.radioKleeneClosure.Text = "Cerradura Kleene";
            this.radioKleeneClosure.UseVisualStyleBackColor = true;
            this.radioKleeneClosure.CheckedChanged += new System.EventHandler(this.radioKleeneClosure_CheckedChanged);
            // 
            // comboLanguageB
            // 
            this.comboLanguageB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguageB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLanguageB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboLanguageB.FormattingEnabled = true;
            this.comboLanguageB.Location = new System.Drawing.Point(109, 183);
            this.comboLanguageB.Name = "comboLanguageB";
            this.comboLanguageB.Size = new System.Drawing.Size(97, 21);
            this.comboLanguageB.Sorted = true;
            this.comboLanguageB.TabIndex = 18;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.DimGray;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(212, 181);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(141, 23);
            this.btnAccept.TabIndex = 19;
            this.btnAccept.Text = "Operar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // comboAlphabets
            // 
            this.comboAlphabets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlphabets.Enabled = false;
            this.comboAlphabets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAlphabets.FormattingEnabled = true;
            this.comboAlphabets.Location = new System.Drawing.Point(12, 55);
            this.comboAlphabets.Name = "comboAlphabets";
            this.comboAlphabets.Size = new System.Drawing.Size(91, 21);
            this.comboAlphabets.Sorted = true;
            this.comboAlphabets.TabIndex = 20;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLbl});
            this.statusStrip.Location = new System.Drawing.Point(0, 272);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(774, 22);
            this.statusStrip.TabIndex = 21;
            // 
            // statLbl
            // 
            this.statLbl.ForeColor = System.Drawing.Color.White;
            this.statLbl.Name = "statLbl";
            this.statLbl.Size = new System.Drawing.Size(759, 17);
            this.statLbl.Spring = true;
            this.statLbl.Text = "Initiated!";
            // 
            // numericPower
            // 
            this.numericPower.Enabled = false;
            this.numericPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.numericPower.Location = new System.Drawing.Point(266, 19);
            this.numericPower.Name = "numericPower";
            this.numericPower.Size = new System.Drawing.Size(43, 20);
            this.numericPower.TabIndex = 27;
            this.numericPower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 24);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(773, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 248);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 248);
            this.panel3.TabIndex = 24;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Location = new System.Drawing.Point(739, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 24);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimize.Location = new System.Drawing.Point(704, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 24);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "__";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // frmRegularExpressions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 294);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.comboAlphabets);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.comboLanguageB);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.comboLanguageA);
            this.Controls.Add(this.btnAddLanguage);
            this.Controls.Add(this.btnAddAlphabet);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.txtAlphabet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegularExpressions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmRegularExpressions_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegularExpressions_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmRegularExpressions_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPower)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAlphabets;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLanguages;
        private System.Windows.Forms.TextBox txtAlphabet;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Button btnAddAlphabet;
        private System.Windows.Forms.Button btnAddLanguage;
        private System.Windows.Forms.ComboBox comboLanguageA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioPositiveClosure;
        private System.Windows.Forms.RadioButton radioKleeneClosure;
        private System.Windows.Forms.RadioButton radioComplement;
        private System.Windows.Forms.RadioButton radioSimetricDifference;
        private System.Windows.Forms.RadioButton radioDifference;
        private System.Windows.Forms.RadioButton radioConcat;
        private System.Windows.Forms.RadioButton radioIntersect;
        private System.Windows.Forms.RadioButton radioUnion;
        private System.Windows.Forms.RadioButton radioPower;
        private System.Windows.Forms.ComboBox comboLanguageB;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox comboAlphabets;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statLbl;
        private System.Windows.Forms.NumericUpDown numericPower;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
    }
}

