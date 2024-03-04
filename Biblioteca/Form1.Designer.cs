namespace Biblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbPrecio = new TextBox();
            cbDescuento = new ComboBox();
            cbArea = new ComboBox();
            btnCalcular = new Button();
            btnTerminar = new Button();
            rtbRegistros = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Size = new Size(552, 59);
            label1.TabIndex = 0;
            label1.Text = "MUSEO DEL DESIERTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 84);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "DESCUENTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 84);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "AREA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(593, 84);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 4;
            label5.Text = "PRECIO";
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(673, 81);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(148, 23);
            tbPrecio.TabIndex = 7;
            // 
            // cbDescuento
            // 
            cbDescuento.FormattingEnabled = true;
            cbDescuento.Location = new Point(141, 81);
            cbDescuento.Name = "cbDescuento";
            cbDescuento.Size = new Size(136, 23);
            cbDescuento.TabIndex = 9;
            // 
            // cbArea
            // 
            cbArea.FormattingEnabled = true;
            cbArea.Location = new Point(408, 81);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(136, 23);
            cbArea.TabIndex = 10;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(305, 126);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(81, 30);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnTerminar
            // 
            btnTerminar.Location = new Point(508, 128);
            btnTerminar.Name = "btnTerminar";
            btnTerminar.Size = new Size(101, 28);
            btnTerminar.TabIndex = 12;
            btnTerminar.Text = "TERMINAR";
            btnTerminar.UseVisualStyleBackColor = true;
            btnTerminar.Click += btnTerminar_Click;
            // 
            // rtbRegistros
            // 
            rtbRegistros.Location = new Point(272, 162);
            rtbRegistros.Name = "rtbRegistros";
            rtbRegistros.Size = new Size(337, 215);
            rtbRegistros.TabIndex = 13;
            rtbRegistros.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 450);
            Controls.Add(rtbRegistros);
            Controls.Add(btnTerminar);
            Controls.Add(btnCalcular);
            Controls.Add(cbArea);
            Controls.Add(cbDescuento);
            Controls.Add(tbPrecio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sistema de registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbPrecio;
        private ComboBox cbDescuento;
        private ComboBox cbArea;
        private Button btnCalcular;
        private Button btnTerminar;
        private RichTextBox rtbRegistros;
    }
}
