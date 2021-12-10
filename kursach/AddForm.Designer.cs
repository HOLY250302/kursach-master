namespace kursach
{
    partial class AddForm
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
            this.tbSumm = new System.Windows.Forms.TextBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbCol = new System.Windows.Forms.TextBox();
            this.tbNazv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSumm
            // 
            this.tbSumm.Location = new System.Drawing.Point(182, 219);
            this.tbSumm.Name = "tbSumm";
            this.tbSumm.Size = new System.Drawing.Size(132, 20);
            this.tbSumm.TabIndex = 1;
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(182, 173);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(132, 20);
            this.tbCena.TabIndex = 2;
            // 
            // tbCol
            // 
            this.tbCol.Location = new System.Drawing.Point(182, 127);
            this.tbCol.Name = "tbCol";
            this.tbCol.Size = new System.Drawing.Size(132, 20);
            this.tbCol.TabIndex = 3;
            // 
            // tbNazv
            // 
            this.tbNazv.Location = new System.Drawing.Point(182, 78);
            this.tbNazv.Name = "tbNazv";
            this.tbNazv.Size = new System.Drawing.Size(132, 20);
            this.tbNazv.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена за единицу";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Общая стоимость";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(79, 286);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(187, 23);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 366);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNazv);
            this.Controls.Add(this.tbCol);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.tbSumm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSumm;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbCol;
        private System.Windows.Forms.TextBox tbNazv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAdd;
    }
}