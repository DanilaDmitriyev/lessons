
namespace MyHomeForm
{
    partial class Form1
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
            this.priceBox = new System.Windows.Forms.TextBox();
            this.vatBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.SystemColors.Info;
            this.priceBox.Location = new System.Drawing.Point(40, 28);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 26);
            this.priceBox.TabIndex = 0;
            // 
            // vatBox
            // 
            this.vatBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.vatBox.Location = new System.Drawing.Point(177, 28);
            this.vatBox.Name = "vatBox";
            this.vatBox.Size = new System.Drawing.Size(100, 26);
            this.vatBox.TabIndex = 1;
            this.vatBox.Text = "20";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(306, 31);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(232, 35);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "Рассчитать";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(568, 31);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(100, 26);
            this.resultBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(40, 108);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(276, 56);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(40, 227);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(276, 56);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 331);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.vatBox);
            this.Controls.Add(this.priceBox);
            this.MinimumSize = new System.Drawing.Size(738, 387);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox vatBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
    }
}

