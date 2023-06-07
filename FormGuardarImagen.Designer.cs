namespace WebCam
{
    partial class FormGuardarImagen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuardarImagen));
            BtnSalir = new Button();
            BtnAceptar = new Button();
            BtSalir = new Button();
            BtAceptar = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            pictureBox = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSalir.Location = new Point(894, 14);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(97, 48);
            BtnSalir.TabIndex = 1;
            BtnSalir.Text = "SALIR";
            BtnSalir.UseVisualStyleBackColor = true;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAceptar.Location = new Point(781, 14);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(97, 48);
            BtnAceptar.TabIndex = 2;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // BtSalir
            // 
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Dock = DockStyle.Right;
            BtSalir.Location = new Point(519, 7);
            BtSalir.Name = "BtSalir";
            BtSalir.Padding = new Padding(3);
            BtSalir.Size = new Size(119, 42);
            BtSalir.TabIndex = 3;
            BtSalir.Text = "SALIR";
            BtSalir.UseVisualStyleBackColor = true;
            BtSalir.Click += BtSalir_Click;
            // 
            // BtAceptar
            // 
            BtAceptar.Anchor = AnchorStyles.Right;
            BtAceptar.Cursor = Cursors.Hand;
            BtAceptar.Location = new Point(394, 6);
            BtAceptar.Margin = new Padding(3, 3, 9, 3);
            BtAceptar.Name = "BtAceptar";
            BtAceptar.Size = new Size(117, 44);
            BtAceptar.TabIndex = 5;
            BtAceptar.Text = "Guardar imagen";
            BtAceptar.UseVisualStyleBackColor = true;
            BtAceptar.Click += BtAceptar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 92, 140);
            panel1.Controls.Add(BtAceptar);
            panel1.Controls.Add(BtSalir);
            panel1.Controls.Add(BtnAceptar);
            panel1.Controls.Add(BtnSalir);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(5, 494);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(7);
            panel1.Size = new Size(645, 56);
            panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(645, 489);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(3, 19);
            pictureBox.Margin = new Padding(8);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(639, 467);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            // 
            // FormGuardarImagen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 555);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGuardarImagen";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guardar imagen";
            Load += FormGuardarImagen_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSalir;
        private Button BtnAceptar;
        private Button BtSalir;
        private Button BtAceptar;
        private Panel panel1;
        private GroupBox groupBox1;
        private PictureBox pictureBox;
    }
}