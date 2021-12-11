
namespace kursach.Forms
{
    partial class tech
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btLoad1 = new System.Windows.Forms.Button();
            this.btPrepods = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Colvo,
            this.Cena,
            this.Summ});
            this.dataGridView2.Location = new System.Drawing.Point(16, 117);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(904, 357);
            this.dataGridView2.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Название";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Colvo
            // 
            this.Colvo.HeaderText = "Количество";
            this.Colvo.MinimumWidth = 6;
            this.Colvo.Name = "Colvo";
            this.Colvo.Width = 125;
            // 
            // Cena
            // 
            this.Cena.HeaderText = "Цена за единицу";
            this.Cena.MinimumWidth = 6;
            this.Cena.Name = "Cena";
            this.Cena.Width = 125;
            // 
            // Summ
            // 
            this.Summ.HeaderText = "Общая стоимость";
            this.Summ.MinimumWidth = 6;
            this.Summ.Name = "Summ";
            this.Summ.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(156, 498);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(171, 41);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(333, 58);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Заказать";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(113, 59);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(179, 22);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btLoad1
            // 
            this.btLoad1.Location = new System.Drawing.Point(16, 498);
            this.btLoad1.Margin = new System.Windows.Forms.Padding(4);
            this.btLoad1.Name = "btLoad1";
            this.btLoad1.Size = new System.Drawing.Size(100, 41);
            this.btLoad1.TabIndex = 5;
            this.btLoad1.Text = "Обновить";
            this.btLoad1.UseVisualStyleBackColor = true;
            this.btLoad1.Click += new System.EventHandler(this.btLoad1_Click);
            // 
            // btPrepods
            // 
            this.btPrepods.Location = new System.Drawing.Point(820, 55);
            this.btPrepods.Margin = new System.Windows.Forms.Padding(4);
            this.btPrepods.Name = "btPrepods";
            this.btPrepods.Size = new System.Drawing.Size(100, 28);
            this.btPrepods.TabIndex = 6;
            this.btPrepods.Text = "Учителя";
            this.btPrepods.UseVisualStyleBackColor = true;
            this.btPrepods.Click += new System.EventHandler(this.btPrepods_Click);
            // 
            // tech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 554);
            this.Controls.Add(this.btPrepods);
            this.Controls.Add(this.btLoad1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tech";
            this.Text = "tech";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btLoad1;
        private System.Windows.Forms.Button btPrepods;
    }
}