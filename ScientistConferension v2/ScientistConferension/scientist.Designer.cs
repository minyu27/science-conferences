namespace ScientistConferension
{
    partial class Scientist
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.учёныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конференцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выступленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confDgv = new System.Windows.Forms.DataGridView();
            this.showDgv = new System.Windows.Forms.DataGridView();
            this.yearBtn = new System.Windows.Forms.Button();
            this.notPublishBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(972, 496);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Linen;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учёныеToolStripMenuItem,
            this.конференцииToolStripMenuItem,
            this.выступленияToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // учёныеToolStripMenuItem
            // 
            this.учёныеToolStripMenuItem.Name = "учёныеToolStripMenuItem";
            this.учёныеToolStripMenuItem.Size = new System.Drawing.Size(89, 32);
            this.учёныеToolStripMenuItem.Text = "Учёные";
            this.учёныеToolStripMenuItem.Click += new System.EventHandler(this.учёныеToolStripMenuItem_Click);
            // 
            // конференцииToolStripMenuItem
            // 
            this.конференцииToolStripMenuItem.Name = "конференцииToolStripMenuItem";
            this.конференцииToolStripMenuItem.Size = new System.Drawing.Size(141, 32);
            this.конференцииToolStripMenuItem.Text = "Конференции";
            this.конференцииToolStripMenuItem.Click += new System.EventHandler(this.конференцииToolStripMenuItem_Click);
            // 
            // выступленияToolStripMenuItem
            // 
            this.выступленияToolStripMenuItem.Name = "выступленияToolStripMenuItem";
            this.выступленияToolStripMenuItem.Size = new System.Drawing.Size(132, 32);
            this.выступленияToolStripMenuItem.Text = "Выступления";
            this.выступленияToolStripMenuItem.Click += new System.EventHandler(this.выступленияToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(97, 32);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // confDgv
            // 
            this.confDgv.BackgroundColor = System.Drawing.Color.SeaShell;
            this.confDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.confDgv.Location = new System.Drawing.Point(18, 54);
            this.confDgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confDgv.Name = "confDgv";
            this.confDgv.RowHeadersWidth = 62;
            this.confDgv.Size = new System.Drawing.Size(972, 496);
            this.confDgv.TabIndex = 2;
            // 
            // showDgv
            // 
            this.showDgv.BackgroundColor = System.Drawing.Color.SeaShell;
            this.showDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDgv.Location = new System.Drawing.Point(18, 54);
            this.showDgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showDgv.Name = "showDgv";
            this.showDgv.ReadOnly = true;
            this.showDgv.RowHeadersWidth = 62;
            this.showDgv.Size = new System.Drawing.Size(972, 496);
            this.showDgv.TabIndex = 3;
            // 
            // yearBtn
            // 
            this.yearBtn.BackColor = System.Drawing.Color.Snow;
            this.yearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearBtn.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearBtn.Location = new System.Drawing.Point(18, 569);
            this.yearBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yearBtn.Name = "yearBtn";
            this.yearBtn.Size = new System.Drawing.Size(153, 88);
            this.yearBtn.TabIndex = 4;
            this.yearBtn.Text = "1999 г.";
            this.yearBtn.UseVisualStyleBackColor = false;
            this.yearBtn.Click += new System.EventHandler(this.yearBtn_Click);
            // 
            // notPublishBtn
            // 
            this.notPublishBtn.BackColor = System.Drawing.Color.Snow;
            this.notPublishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notPublishBtn.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notPublishBtn.Location = new System.Drawing.Point(296, 569);
            this.notPublishBtn.Name = "notPublishBtn";
            this.notPublishBtn.Size = new System.Drawing.Size(153, 88);
            this.notPublishBtn.TabIndex = 5;
            this.notPublishBtn.Text = "не опубл";
            this.notPublishBtn.UseVisualStyleBackColor = false;
            this.notPublishBtn.Click += new System.EventHandler(this.notPublishBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(590, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 88);
            this.button1.TabIndex = 6;
            this.button1.Text = "доктора наук";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(837, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 88);
            this.button2.TabIndex = 7;
            this.button2.Text = "страны";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Scientist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1012, 735);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.notPublishBtn);
            this.Controls.Add(this.yearBtn);
            this.Controls.Add(this.showDgv);
            this.Controls.Add(this.confDgv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Scientist";
            this.Text = "Таблицы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem учёныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конференцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выступленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        public System.Windows.Forms.DataGridView showDgv;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView confDgv;
        private System.Windows.Forms.Button yearBtn;
        private System.Windows.Forms.Button notPublishBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

