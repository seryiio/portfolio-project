
namespace CapaPresentacion
{
    partial class FormECartera
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
            this.PnlFrmECartera = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValorME_ME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValorMN_ME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValorMN_MN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValorME_MN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlFrmECartera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlFrmECartera
            // 
            this.PnlFrmECartera.Controls.Add(this.label2);
            this.PnlFrmECartera.Controls.Add(this.label1);
            this.PnlFrmECartera.Controls.Add(this.dataGridView2);
            this.PnlFrmECartera.Controls.Add(this.dataGridView1);
            this.PnlFrmECartera.Location = new System.Drawing.Point(0, 0);
            this.PnlFrmECartera.Name = "PnlFrmECartera";
            this.PnlFrmECartera.Size = new System.Drawing.Size(1072, 643);
            this.PnlFrmECartera.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmValor,
            this.clmEmisor,
            this.clmValorMN_MN,
            this.clmValorME_MN});
            this.dataGridView1.Location = new System.Drawing.Point(302, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.clmValorME_ME,
            this.clmValorMN_ME});
            this.dataGridView2.Location = new System.Drawing.Point(302, 367);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(443, 218);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Moneda Nacional";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Emisor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // clmValorME_ME
            // 
            this.clmValorME_ME.HeaderText = "Valorizado ME";
            this.clmValorME_ME.Name = "clmValorME_ME";
            this.clmValorME_ME.ReadOnly = true;
            // 
            // clmValorMN_ME
            // 
            this.clmValorMN_ME.HeaderText = "Valorizado MN";
            this.clmValorMN_ME.Name = "clmValorMN_ME";
            this.clmValorMN_ME.ReadOnly = true;
            // 
            // clmValor
            // 
            this.clmValor.HeaderText = "Valor";
            this.clmValor.Name = "clmValor";
            this.clmValor.ReadOnly = true;
            // 
            // clmEmisor
            // 
            this.clmEmisor.HeaderText = "Emisor";
            this.clmEmisor.Name = "clmEmisor";
            this.clmEmisor.ReadOnly = true;
            // 
            // clmValorMN_MN
            // 
            this.clmValorMN_MN.HeaderText = "Valorizado MN";
            this.clmValorMN_MN.Name = "clmValorMN_MN";
            this.clmValorMN_MN.ReadOnly = true;
            // 
            // clmValorME_MN
            // 
            this.clmValorME_MN.HeaderText = "Valorizado ME";
            this.clmValorME_MN.Name = "clmValorME_MN";
            this.clmValorME_MN.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Moneda Extranjera";
            // 
            // FormECartera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 643);
            this.Controls.Add(this.PnlFrmECartera);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormECartera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormECartera";
            this.PnlFrmECartera.ResumeLayout(false);
            this.PnlFrmECartera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFrmECartera;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorME_ME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorMN_ME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorMN_MN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorME_MN;
    }
}