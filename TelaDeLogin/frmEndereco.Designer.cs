namespace TelaDeLogin
{
    partial class frmEndereco
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbRua = new System.Windows.Forms.TextBox();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.txbCid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(99, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Qual seu endereço?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(56, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 27);
            this.label3.TabIndex = 37;
            this.label3.Text = "<";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbRua
            // 
            this.txbRua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbRua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbRua.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbRua.ForeColor = System.Drawing.Color.LightBlue;
            this.txbRua.Location = new System.Drawing.Point(65, 161);
            this.txbRua.Multiline = true;
            this.txbRua.Name = "txbRua";
            this.txbRua.Size = new System.Drawing.Size(216, 28);
            this.txbRua.TabIndex = 43;
            this.txbRua.Text = "Rua / Avenida";
            // 
            // txbNum
            // 
            this.txbNum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNum.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNum.ForeColor = System.Drawing.Color.LightBlue;
            this.txbNum.Location = new System.Drawing.Point(65, 220);
            this.txbNum.Multiline = true;
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(216, 28);
            this.txbNum.TabIndex = 44;
            this.txbNum.Text = "Número";
            // 
            // txbBairro
            // 
            this.txbBairro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBairro.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbBairro.ForeColor = System.Drawing.Color.LightBlue;
            this.txbBairro.Location = new System.Drawing.Point(65, 282);
            this.txbBairro.Multiline = true;
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(216, 28);
            this.txbBairro.TabIndex = 45;
            this.txbBairro.Text = "Bairro";
            // 
            // txbCid
            // 
            this.txbCid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbCid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCid.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCid.ForeColor = System.Drawing.Color.LightBlue;
            this.txbCid.Location = new System.Drawing.Point(65, 349);
            this.txbCid.Multiline = true;
            this.txbCid.Name = "txbCid";
            this.txbCid.Size = new System.Drawing.Size(216, 28);
            this.txbCid.TabIndex = 46;
            this.txbCid.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(239, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 27);
            this.label2.TabIndex = 47;
            this.label2.Text = "->";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 27);
            this.label1.TabIndex = 48;
            this.label1.Text = "4.";
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSair.ForeColor = System.Drawing.Color.Red;
            this.lblSair.Location = new System.Drawing.Point(154, 528);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(31, 17);
            this.lblSair.TabIndex = 49;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // frmEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 554);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbCid);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.txbRua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEndereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEndereco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label label3;
        private TextBox txbRua;
        private TextBox txbNum;
        private TextBox txbBairro;
        private TextBox txbCid;
        private Label label2;
        private Label label1;
        private Label lblSair;
    }
}