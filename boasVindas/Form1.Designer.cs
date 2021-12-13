namespace boasVindas
{
    partial class frmAula01
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
            this.btnBoasVindas = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBoasVindas
            // 
            this.btnBoasVindas.Location = new System.Drawing.Point(335, 119);
            this.btnBoasVindas.Name = "btnBoasVindas";
            this.btnBoasVindas.Size = new System.Drawing.Size(112, 34);
            this.btnBoasVindas.TabIndex = 0;
            this.btnBoasVindas.Text = "Clique Aqui";
            this.btnBoasVindas.UseVisualStyleBackColor = true;
            this.btnBoasVindas.Click += new System.EventHandler(this.btnBoasVindas_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(335, 206);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 25);
            this.lblMensagem.TabIndex = 1;
            this.lblMensagem.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(162, 25);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Digite o seu nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(30, 69);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(707, 31);
            this.txtNome.TabIndex = 3;
            // 
            // frmAula01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 427);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnBoasVindas);
            this.Name = "frmAula01";
            this.Text = "Aula01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBoasVindas;
        private Label lblMensagem;
        private Label lblNome;
        private TextBox txtNome;
    }
}