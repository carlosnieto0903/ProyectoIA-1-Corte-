namespace Proyecto.Vista
{
    partial class Insertar
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
            label2 = new Label();
            btnIniciar = new Button();
            cmbSele = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 39);
            label2.Name = "label2";
            label2.Size = new Size(159, 15);
            label2.TabIndex = 1;
            label2.Text = "Maximizador o Minimizador:";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(146, 80);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(100, 31);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "CONTINUAR";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // cmbSele
            // 
            cmbSele.FormattingEnabled = true;
            cmbSele.Items.AddRange(new object[] { "Max", "Min" });
            cmbSele.Location = new Point(216, 36);
            cmbSele.Name = "cmbSele";
            cmbSele.Size = new Size(121, 23);
            cmbSele.TabIndex = 8;
            // 
            // Insertar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 143);
            Controls.Add(cmbSele);
            Controls.Add(btnIniciar);
            Controls.Add(label2);
            Name = "Insertar";
            Text = "Insertar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnIniciar;
        private ComboBox cmbSele;
    }
}