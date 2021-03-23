namespace PIM.ModuloUsuario
{
    partial class frmConsultarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarAluno));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgAluno = new System.Windows.Forms.DataGridView();
            this.btnConsultarAluno = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgAluno);
            this.groupBox1.Controls.Add(this.btnConsultarAluno);
            this.groupBox1.Location = new System.Drawing.Point(36, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 292);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Aluno";
            // 
            // dgAluno
            // 
            this.dgAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAluno.Location = new System.Drawing.Point(52, 38);
            this.dgAluno.Name = "dgAluno";
            this.dgAluno.Size = new System.Drawing.Size(524, 150);
            this.dgAluno.TabIndex = 2;
            // 
            // btnConsultarAluno
            // 
            this.btnConsultarAluno.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarAluno.Image")));
            this.btnConsultarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarAluno.Location = new System.Drawing.Point(475, 231);
            this.btnConsultarAluno.Name = "btnConsultarAluno";
            this.btnConsultarAluno.Size = new System.Drawing.Size(203, 55);
            this.btnConsultarAluno.TabIndex = 1;
            this.btnConsultarAluno.Text = "Consultar Aluno";
            this.btnConsultarAluno.UseVisualStyleBackColor = true;
            this.btnConsultarAluno.Click += new System.EventHandler(this.btnConsultarAluno_Click);
            // 
            // frmConsultarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 376);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultarAluno";
            this.Text = "frmConsultarAluno";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultarAluno;
        private System.Windows.Forms.DataGridView dgAluno;
    }
}