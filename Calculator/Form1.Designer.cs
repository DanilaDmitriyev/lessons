namespace Calculator
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.number1 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.Label();
            this.action = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.NumericUpDown();
            this.actionBox = new System.Windows.Forms.ComboBox();
            this.Result = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.elementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.number1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.number2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.action, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.actionBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Result, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 324);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number1.Location = new System.Drawing.Point(14, 10);
            this.number1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(103, 39);
            this.number1.TabIndex = 0;
            this.number1.Text = "Число 1";
            this.number1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // number2
            // 
            this.number2.AutoSize = true;
            this.number2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number2.Location = new System.Drawing.Point(14, 49);
            this.number2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(103, 39);
            this.number2.TabIndex = 1;
            this.number2.Text = "Число 2";
            this.number2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // action
            // 
            this.action.AutoSize = true;
            this.action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.action.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.action.Location = new System.Drawing.Point(14, 88);
            this.action.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(103, 42);
            this.action.TabIndex = 2;
            this.action.Text = "Действие";
            this.action.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.elementsBindingSource, "Element1", true));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(125, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 29);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.elementsBindingSource, "Element2", true));
            this.textBox2.DecimalPlaces = 3;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(125, 54);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(433, 29);
            this.textBox2.TabIndex = 4;
            // 
            // actionBox
            // 
            this.actionBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.elementsBindingSource, "Operation", true));
            this.actionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actionBox.FormattingEnabled = true;
            this.actionBox.Location = new System.Drawing.Point(125, 93);
            this.actionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(433, 32);
            this.actionBox.TabIndex = 5;
            this.actionBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.actionBox_Format);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Dock = System.Windows.Forms.DockStyle.Top;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(14, 166);
            this.Result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(103, 24);
            this.Result.TabIndex = 6;
            this.Result.Text = "Результат";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.elementsBindingSource, "Result", true));
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(124, 164);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(435, 29);
            this.textBox3.TabIndex = 7;
            // 
            // elementsBindingSource
            // 
            this.elementsBindingSource.DataSource = typeof(Calculator.Elements);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(572, 324);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.Label number2;
        private System.Windows.Forms.Label action;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown textBox2;
        private System.Windows.Forms.ComboBox actionBox;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource elementsBindingSource;
    }
}

