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
            this.confDgv = new System.Windows.Forms.DataGridView();
            this.showDgv = new System.Windows.Forms.DataGridView();
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
            this.dataGridView1.Location = new System.Drawing.Point(52, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(648, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Linen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учёныеToolStripMenuItem,
            this.конференцииToolStripMenuItem,
            this.выступленияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // учёныеToolStripMenuItem
            // 
            this.учёныеToolStripMenuItem.Name = "учёныеToolStripMenuItem";
            this.учёныеToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.учёныеToolStripMenuItem.Text = "Учёные";
            this.учёныеToolStripMenuItem.Click += new System.EventHandler(this.учёныеToolStripMenuItem_Click);
            // 
            // конференцииToolStripMenuItem
            // 
            this.конференцииToolStripMenuItem.Name = "конференцииToolStripMenuItem";
            this.конференцииToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.конференцииToolStripMenuItem.Text = "Конференции";
            this.конференцииToolStripMenuItem.Click += new System.EventHandler(this.конференцииToolStripMenuItem_Click);
            // 
            // выступленияToolStripMenuItem
            // 
            this.выступленияToolStripMenuItem.Name = "выступленияToolStripMenuItem";
            this.выступленияToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.выступленияToolStripMenuItem.Text = "Выступления";
            this.выступленияToolStripMenuItem.Click += new System.EventHandler(this.выступленияToolStripMenuItem_Click);
            // 
            // confDgv
            // 
            this.confDgv.BackgroundColor = System.Drawing.Color.SeaShell;
            this.confDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.confDgv.Location = new System.Drawing.Point(52, 52);
            this.confDgv.Name = "confDgv";
            this.confDgv.RowHeadersWidth = 62;
            this.confDgv.Size = new System.Drawing.Size(648, 337);
            this.confDgv.TabIndex = 2;
            // 
            // showDgv
            // 
            this.showDgv.BackgroundColor = System.Drawing.Color.SeaShell;
            this.showDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDgv.Location = new System.Drawing.Point(52, 52);
            this.showDgv.Name = "showDgv";
            this.showDgv.Size = new System.Drawing.Size(648, 337);
            this.showDgv.TabIndex = 3;
            // 
            // Scientist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(747, 415);
            this.Controls.Add(this.showDgv);
            this.Controls.Add(this.confDgv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Scientist";
            this.Text = "Scientist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem учёныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конференцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выступленияToolStripMenuItem;
        private System.Windows.Forms.DataGridView confDgv;
        private System.Windows.Forms.DataGridView showDgv;
    }
}

