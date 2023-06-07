namespace WebCam
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            GroupBoxImagen = new GroupBox();
            panel1 = new Panel();
            BtnImagen = new Button();
            pictureBox = new PictureBox();
            GroupBoxImagen.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxImagen
            // 
            GroupBoxImagen.Controls.Add(panel1);
            GroupBoxImagen.Controls.Add(pictureBox);
            GroupBoxImagen.Dock = DockStyle.Fill;
            GroupBoxImagen.Location = new Point(5, 5);
            GroupBoxImagen.Margin = new Padding(3, 3, 3, 6);
            GroupBoxImagen.Name = "GroupBoxImagen";
            GroupBoxImagen.Padding = new Padding(5);
            GroupBoxImagen.Size = new Size(744, 663);
            GroupBoxImagen.TabIndex = 1;
            GroupBoxImagen.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 92, 140);
            panel1.Controls.Add(BtnImagen);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(5, 591);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 67);
            panel1.TabIndex = 5;
            // 
            // BtnImagen
            // 
            BtnImagen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            BtnImagen.BackgroundImage = Properties.Resources.icono_camara;
            BtnImagen.BackgroundImageLayout = ImageLayout.Stretch;
            BtnImagen.Cursor = Cursors.Hand;
            BtnImagen.Location = new Point(316, 3);
            BtnImagen.Name = "BtnImagen";
            BtnImagen.Size = new Size(103, 61);
            BtnImagen.TabIndex = 3;
            BtnImagen.UseVisualStyleBackColor = true;
            BtnImagen.Click += BtnImagen_Click;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.Location = new Point(5, 21);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(734, 564);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 673);
            Controls.Add(GroupBoxImagen);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Capturando imagen";
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            GroupBoxImagen.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxImagen;
        private PictureBox pictureBox;
        private Panel panel1;
        private Button BtnImagen;
    }
}