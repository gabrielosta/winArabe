namespace winArabe
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
         this.listView1 = new System.Windows.Forms.ListView();
         this.Harf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.ismulHarf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.translit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.nombreLetra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.label1 = new System.Windows.Forms.Label();
         this.richTextBox1 = new System.Windows.Forms.RichTextBox();
         this.fontDialog1 = new System.Windows.Forms.FontDialog();
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.btnFuente = new System.Windows.Forms.Button();
         this.chkUsarUnion = new System.Windows.Forms.CheckBox();
         this.chkNrosArabes = new System.Windows.Forms.CheckBox();
         this.chkOcultarBreves = new System.Windows.Forms.CheckBox();
         this.lblPalTexto = new System.Windows.Forms.Label();
         this.lblPalRaiz = new System.Windows.Forms.Label();
         this.btnFrase = new System.Windows.Forms.Button();
         this.btnLimpiar = new System.Windows.Forms.Button();
         this.optLarga1 = new System.Windows.Forms.RadioButton();
         this.optLarga3 = new System.Windows.Forms.RadioButton();
         this.optLarga2 = new System.Windows.Forms.RadioButton();
         this.grpVocalesLargas = new System.Windows.Forms.GroupBox();
         this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
         this.grpVocalesLargas.SuspendLayout();
         this.SuspendLayout();
         // 
         // listView1
         // 
         this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Harf,
            this.ismulHarf,
            this.translit,
            this.nombreLetra});
         this.listView1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
         this.listView1.FullRowSelect = true;
         this.listView1.GridLines = true;
         this.listView1.Location = new System.Drawing.Point(28, 27);
         this.listView1.Name = "listView1";
         this.listView1.Size = new System.Drawing.Size(344, 360);
         this.listView1.TabIndex = 2;
         this.listView1.UseCompatibleStateImageBehavior = false;
         this.listView1.View = System.Windows.Forms.View.Details;
         this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
         // 
         // Harf
         // 
         this.Harf.Text = "الحرف";
         this.Harf.Width = 61;
         // 
         // ismulHarf
         // 
         this.ismulHarf.Text = "اسم الحرف";
         this.ismulHarf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.ismulHarf.Width = 89;
         // 
         // translit
         // 
         this.translit.Text = "Translit.";
         this.translit.Width = 75;
         // 
         // nombreLetra
         // 
         this.nombreLetra.Text = "Nombre";
         this.nombreLetra.Width = 90;
         // 
         // label1
         // 
         this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(396, 256);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(486, 78);
         this.label1.TabIndex = 4;
         this.label1.Text = "label1";
         // 
         // richTextBox1
         // 
         this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.richTextBox1.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
         this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.On;
         this.richTextBox1.Location = new System.Drawing.Point(397, 87);
         this.richTextBox1.Name = "richTextBox1";
         this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
         this.richTextBox1.Size = new System.Drawing.Size(486, 117);
         this.richTextBox1.TabIndex = 5;
         this.richTextBox1.Text = "";
         this.richTextBox1.FontChanged += new System.EventHandler(this.richTextBox1_FontChanged);
         this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
         this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
         // 
         // fontDialog1
         // 
         this.fontDialog1.Color = System.Drawing.SystemColors.ControlText;
         // 
         // comboBox1
         // 
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Location = new System.Drawing.Point(397, 52);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(236, 21);
         this.comboBox1.TabIndex = 6;
         // 
         // btnFuente
         // 
         this.btnFuente.Location = new System.Drawing.Point(643, 52);
         this.btnFuente.Name = "btnFuente";
         this.btnFuente.Size = new System.Drawing.Size(65, 20);
         this.btnFuente.TabIndex = 7;
         this.btnFuente.Text = "&Fuente";
         this.btnFuente.UseVisualStyleBackColor = true;
         this.btnFuente.Click += new System.EventHandler(this.btnFuente_Click);
         // 
         // chkUsarUnion
         // 
         this.chkUsarUnion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.chkUsarUnion.AutoSize = true;
         this.chkUsarUnion.Location = new System.Drawing.Point(772, 221);
         this.chkUsarUnion.Name = "chkUsarUnion";
         this.chkUsarUnion.Size = new System.Drawing.Size(110, 17);
         this.chkUsarUnion.TabIndex = 9;
         this.chkUsarUnion.Text = "Usar unión wasla ";
         this.chkUsarUnion.UseVisualStyleBackColor = true;
         this.chkUsarUnion.CheckedChanged += new System.EventHandler(this.chkUsarUnion_CheckedChanged);
         // 
         // chkNrosArabes
         // 
         this.chkNrosArabes.AutoSize = true;
         this.chkNrosArabes.Location = new System.Drawing.Point(397, 29);
         this.chkNrosArabes.Name = "chkNrosArabes";
         this.chkNrosArabes.Size = new System.Drawing.Size(139, 17);
         this.chkNrosArabes.TabIndex = 10;
         this.chkNrosArabes.Text = "Mostrar números árabes";
         this.chkNrosArabes.UseVisualStyleBackColor = true;
         this.chkNrosArabes.CheckedChanged += new System.EventHandler(this.chkNrosArabes_CheckedChanged);
         // 
         // chkOcultarBreves
         // 
         this.chkOcultarBreves.AutoSize = true;
         this.chkOcultarBreves.Location = new System.Drawing.Point(546, 29);
         this.chkOcultarBreves.Name = "chkOcultarBreves";
         this.chkOcultarBreves.Size = new System.Drawing.Size(135, 17);
         this.chkOcultarBreves.TabIndex = 11;
         this.chkOcultarBreves.Text = "Ocultar vocales breves";
         this.chkOcultarBreves.UseVisualStyleBackColor = true;
         this.chkOcultarBreves.CheckedChanged += new System.EventHandler(this.chkMostrarBreves_CheckedChanged);
         // 
         // lblPalTexto
         // 
         this.lblPalTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.lblPalTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.lblPalTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblPalTexto.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
         this.lblPalTexto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
         this.lblPalTexto.Location = new System.Drawing.Point(496, 345);
         this.lblPalTexto.Name = "lblPalTexto";
         this.lblPalTexto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
         this.lblPalTexto.Size = new System.Drawing.Size(175, 42);
         this.lblPalTexto.TabIndex = 12;
         this.lblPalTexto.Text = "كَلِمَةٌ";
         this.lblPalTexto.Click += new System.EventHandler(this.lblPalTexto_Click);
         // 
         // lblPalRaiz
         // 
         this.lblPalRaiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.lblPalRaiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.lblPalRaiz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblPalRaiz.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
         this.lblPalRaiz.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
         this.lblPalRaiz.Location = new System.Drawing.Point(397, 345);
         this.lblPalRaiz.Name = "lblPalRaiz";
         this.lblPalRaiz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
         this.lblPalRaiz.Size = new System.Drawing.Size(71, 42);
         this.lblPalRaiz.TabIndex = 13;
         this.lblPalRaiz.Text = "فعل";
         // 
         // btnFrase
         // 
         this.btnFrase.Location = new System.Drawing.Point(819, 53);
         this.btnFrase.Name = "btnFrase";
         this.btnFrase.Size = new System.Drawing.Size(63, 20);
         this.btnFrase.TabIndex = 14;
         this.btnFrase.Text = "&Frase";
         this.btnFrase.UseVisualStyleBackColor = true;
         this.btnFrase.Click += new System.EventHandler(this.btnFrase_Click);
         // 
         // btnLimpiar
         // 
         this.btnLimpiar.Location = new System.Drawing.Point(730, 53);
         this.btnLimpiar.Name = "btnLimpiar";
         this.btnLimpiar.Size = new System.Drawing.Size(63, 20);
         this.btnLimpiar.TabIndex = 15;
         this.btnLimpiar.Text = "&Limpiar";
         this.btnLimpiar.UseVisualStyleBackColor = true;
         this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
         // 
         // optLarga1
         // 
         this.optLarga1.AutoSize = true;
         this.optLarga1.Checked = true;
         this.optLarga1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.optLarga1.Location = new System.Drawing.Point(12, 17);
         this.optLarga1.Name = "optLarga1";
         this.optLarga1.Size = new System.Drawing.Size(59, 20);
         this.optLarga1.TabIndex = 16;
         this.optLarga1.TabStop = true;
         this.optLarga1.Text = "a: i: u:";
         this.optLarga1.UseVisualStyleBackColor = true;
         this.optLarga1.CheckedChanged += new System.EventHandler(this.optLarga1_CheckedChanged);
         // 
         // optLarga3
         // 
         this.optLarga3.AutoSize = true;
         this.optLarga3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.optLarga3.Location = new System.Drawing.Point(157, 17);
         this.optLarga3.Name = "optLarga3";
         this.optLarga3.Size = new System.Drawing.Size(50, 20);
         this.optLarga3.TabIndex = 18;
         this.optLarga3.Text = "â î û";
         this.optLarga3.UseVisualStyleBackColor = true;
         this.optLarga3.CheckedChanged += new System.EventHandler(this.optLarga3_CheckedChanged);
         // 
         // optLarga2
         // 
         this.optLarga2.AutoSize = true;
         this.optLarga2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.optLarga2.Location = new System.Drawing.Point(89, 17);
         this.optLarga2.Name = "optLarga2";
         this.optLarga2.Size = new System.Drawing.Size(50, 20);
         this.optLarga2.TabIndex = 19;
         this.optLarga2.Text = "ā ī ū";
         this.optLarga2.UseVisualStyleBackColor = true;
         this.optLarga2.CheckedChanged += new System.EventHandler(this.optRayaSup_CheckedChanged);
         // 
         // grpVocalesLargas
         // 
         this.grpVocalesLargas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.grpVocalesLargas.Controls.Add(this.optLarga2);
         this.grpVocalesLargas.Controls.Add(this.optLarga3);
         this.grpVocalesLargas.Controls.Add(this.optLarga1);
         this.grpVocalesLargas.Location = new System.Drawing.Point(397, 210);
         this.grpVocalesLargas.Name = "grpVocalesLargas";
         this.grpVocalesLargas.Size = new System.Drawing.Size(224, 43);
         this.grpVocalesLargas.TabIndex = 20;
         this.grpVocalesLargas.TabStop = false;
         this.grpVocalesLargas.Text = "Vocales largas";
         // 
         // oleDbDataAdapter1
         // 
         this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
         this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
         this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
         this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(894, 399);
         this.Controls.Add(this.grpVocalesLargas);
         this.Controls.Add(this.btnLimpiar);
         this.Controls.Add(this.btnFrase);
         this.Controls.Add(this.lblPalRaiz);
         this.Controls.Add(this.lblPalTexto);
         this.Controls.Add(this.chkOcultarBreves);
         this.Controls.Add(this.chkNrosArabes);
         this.Controls.Add(this.chkUsarUnion);
         this.Controls.Add(this.btnFuente);
         this.Controls.Add(this.comboBox1);
         this.Controls.Add(this.richTextBox1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.listView1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.grpVocalesLargas.ResumeLayout(false);
         this.grpVocalesLargas.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Harf;
        private System.Windows.Forms.ColumnHeader ismulHarf;
        private System.Windows.Forms.ColumnHeader translit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnFuente;
        private System.Windows.Forms.ColumnHeader nombreLetra;
        private System.Windows.Forms.CheckBox chkUsarUnion;
        private System.Windows.Forms.CheckBox chkNrosArabes;
        private System.Windows.Forms.CheckBox chkOcultarBreves;
        private System.Windows.Forms.Label lblPalTexto;
        private System.Windows.Forms.Label lblPalRaiz;
        private System.Windows.Forms.Button btnFrase;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RadioButton optLarga1;
        private System.Windows.Forms.RadioButton optLarga3;
        private System.Windows.Forms.RadioButton optLarga2;
        private System.Windows.Forms.GroupBox grpVocalesLargas;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
    }
}

