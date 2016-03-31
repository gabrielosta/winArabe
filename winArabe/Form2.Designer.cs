namespace winArabe
{
    partial class Form2
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
            this.lblPalRaiz = new System.Windows.Forms.Label();
            this.lblPalTexto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.optSustantivo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optAdjetivo = new System.Windows.Forms.RadioButton();
            this.optVerbo = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.optParticula = new System.Windows.Forms.RadioButton();
            this.optPronombre = new System.Windows.Forms.RadioButton();
            this.optOtro = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblPlural = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblUnitario = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPalRaiz
            // 
            this.lblPalRaiz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPalRaiz.AutoSize = true;
            this.lblPalRaiz.BackColor = System.Drawing.Color.Transparent;
            this.lblPalRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalRaiz.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPalRaiz.Location = new System.Drawing.Point(12, 10);
            this.lblPalRaiz.Name = "lblPalRaiz";
            this.lblPalRaiz.Size = new System.Drawing.Size(97, 20);
            this.lblPalRaiz.TabIndex = 15;
            this.lblPalRaiz.Text = "Raíz (فـ ـعـ ـل)";
            this.lblPalRaiz.Click += new System.EventHandler(this.lblPalRaiz_Click);
            // 
            // lblPalTexto
            // 
            this.lblPalTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPalTexto.AutoSize = true;
            this.lblPalTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblPalTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalTexto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPalTexto.Location = new System.Drawing.Point(177, 10);
            this.lblPalTexto.Name = "lblPalTexto";
            this.lblPalTexto.Size = new System.Drawing.Size(96, 20);
            this.lblPalTexto.TabIndex = 14;
            this.lblPalTexto.Text = "Palabra / كَلِمَةٌ";
            this.lblPalTexto.Click += new System.EventHandler(this.lblPalTexto_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(181, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(167, 40);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(87, 40);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // optSustantivo
            // 
            this.optSustantivo.AutoSize = true;
            this.optSustantivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSustantivo.ForeColor = System.Drawing.Color.Black;
            this.optSustantivo.Location = new System.Drawing.Point(17, 19);
            this.optSustantivo.Name = "optSustantivo";
            this.optSustantivo.Size = new System.Drawing.Size(85, 17);
            this.optSustantivo.TabIndex = 18;
            this.optSustantivo.TabStop = true;
            this.optSustantivo.Text = "Sustantivo";
            this.optSustantivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optOtro);
            this.groupBox1.Controls.Add(this.optPronombre);
            this.groupBox1.Controls.Add(this.optVerbo);
            this.groupBox1.Controls.Add(this.optParticula);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.optAdjetivo);
            this.groupBox1.Controls.Add(this.optSustantivo);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 187);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Palabra";
            // 
            // optAdjetivo
            // 
            this.optAdjetivo.AutoSize = true;
            this.optAdjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAdjetivo.ForeColor = System.Drawing.Color.Blue;
            this.optAdjetivo.Location = new System.Drawing.Point(17, 66);
            this.optAdjetivo.Name = "optAdjetivo";
            this.optAdjetivo.Size = new System.Drawing.Size(71, 17);
            this.optAdjetivo.TabIndex = 19;
            this.optAdjetivo.TabStop = true;
            this.optAdjetivo.Text = "Adjetivo";
            this.optAdjetivo.UseVisualStyleBackColor = true;
            // 
            // optVerbo
            // 
            this.optVerbo.AutoSize = true;
            this.optVerbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optVerbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.optVerbo.Location = new System.Drawing.Point(17, 89);
            this.optVerbo.Name = "optVerbo";
            this.optVerbo.Size = new System.Drawing.Size(58, 17);
            this.optVerbo.TabIndex = 20;
            this.optVerbo.TabStop = true;
            this.optVerbo.Text = "Verbo";
            this.optVerbo.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButton4.Location = new System.Drawing.Point(17, 112);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(75, 17);
            this.radioButton4.TabIndex = 21;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Adverbio";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // optParticula
            // 
            this.optParticula.AutoSize = true;
            this.optParticula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optParticula.ForeColor = System.Drawing.Color.Red;
            this.optParticula.Location = new System.Drawing.Point(17, 135);
            this.optParticula.Name = "optParticula";
            this.optParticula.Size = new System.Drawing.Size(91, 17);
            this.optParticula.TabIndex = 22;
            this.optParticula.TabStop = true;
            this.optParticula.Text = "Preposición";
            this.optParticula.UseVisualStyleBackColor = true;
            // 
            // optPronombre
            // 
            this.optPronombre.AutoSize = true;
            this.optPronombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optPronombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.optPronombre.Location = new System.Drawing.Point(17, 43);
            this.optPronombre.Name = "optPronombre";
            this.optPronombre.Size = new System.Drawing.Size(85, 17);
            this.optPronombre.TabIndex = 23;
            this.optPronombre.TabStop = true;
            this.optPronombre.Text = "Pronombre";
            this.optPronombre.UseVisualStyleBackColor = true;
            // 
            // optOtro
            // 
            this.optOtro.AutoSize = true;
            this.optOtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optOtro.ForeColor = System.Drawing.Color.Gray;
            this.optOtro.Location = new System.Drawing.Point(17, 158);
            this.optOtro.Name = "optOtro";
            this.optOtro.Size = new System.Drawing.Size(49, 17);
            this.optOtro.TabIndex = 24;
            this.optOtro.TabStop = true;
            this.optOtro.Text = "Otro";
            this.optOtro.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(181, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(167, 40);
            this.textBox3.TabIndex = 20;
            // 
            // lblPlural
            // 
            this.lblPlural.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlural.AutoSize = true;
            this.lblPlural.BackColor = System.Drawing.Color.Transparent;
            this.lblPlural.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlural.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlural.Location = new System.Drawing.Point(177, 152);
            this.lblPlural.Name = "lblPlural";
            this.lblPlural.Size = new System.Drawing.Size(80, 20);
            this.lblPlural.TabIndex = 21;
            this.lblPlural.Text = "Plural / جَمْعٌ";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(181, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(167, 40);
            this.textBox4.TabIndex = 22;
            // 
            // lblUnitario
            // 
            this.lblUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitario.AutoSize = true;
            this.lblUnitario.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUnitario.Location = new System.Drawing.Point(177, 83);
            this.lblUnitario.Name = "lblUnitario";
            this.lblUnitario.Size = new System.Drawing.Size(124, 20);
            this.lblUnitario.TabIndex = 23;
            this.lblUnitario.Text = "Nombre Unitario";
            this.lblUnitario.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 278);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblPlural);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPalRaiz);
            this.Controls.Add(this.lblPalTexto);
            this.Controls.Add(this.lblUnitario);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalRaiz;
        private System.Windows.Forms.Label lblPalTexto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton optSustantivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton optVerbo;
        private System.Windows.Forms.RadioButton optAdjetivo;
        private System.Windows.Forms.RadioButton optOtro;
        private System.Windows.Forms.RadioButton optPronombre;
        private System.Windows.Forms.RadioButton optParticula;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblPlural;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblUnitario;
    }
}