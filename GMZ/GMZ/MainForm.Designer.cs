
namespace GMZ
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_cmd_file = new System.Windows.Forms.ToolStripMenuItem();
            this.m_cmd_components = new System.Windows.Forms.ToolStripMenuItem();
            this.m_cmd_product = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_cmd_file,
            this.m_cmd_components,
            this.m_cmd_product});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_cmd_file
            // 
            this.m_cmd_file.Name = "m_cmd_file";
            this.m_cmd_file.Size = new System.Drawing.Size(48, 22);
            this.m_cmd_file.Text = "Файл";
            // 
            // m_cmd_components
            // 
            this.m_cmd_components.Name = "m_cmd_components";
            this.m_cmd_components.Size = new System.Drawing.Size(90, 22);
            this.m_cmd_components.Text = "Компоненты";
            this.m_cmd_components.Click += new System.EventHandler(this.ItemComponents_Click);
            // 
            // m_cmd_product
            // 
            this.m_cmd_product.Name = "m_cmd_product";
            this.m_cmd_product.Size = new System.Drawing.Size(65, 22);
            this.m_cmd_product.Text = "Продукт";
            this.m_cmd_product.Click += new System.EventHandler(this.m_cmd_product_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(339, 339);
            this.Name = "MainForm";
            this.Text = "ГМЗ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_cmd_file;
        private System.Windows.Forms.ToolStripMenuItem m_cmd_components;
        private System.Windows.Forms.ToolStripMenuItem m_cmd_product;
    }
}

