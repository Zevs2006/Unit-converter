namespace Unit_converter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxFromUnit;
        private System.Windows.Forms.ComboBox comboBoxToUnit;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnConvert;

        /// <summary>
        /// Освобождение ресурсов.
        /// </summary>
        /// <param name="disposing">Истинно, если управляемые ресурсы нужно освободить; иначе ложно.</param>
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
        /// Требуемый метод для поддержки конструктора - не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxFromUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxToUnit = new System.Windows.Forms.ComboBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Длина",
            "Вес",
            "Объем"});
            this.comboBoxCategory.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCategory.TabIndex = 0;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);

            // 
            // comboBoxFromUnit
            // 
            this.comboBoxFromUnit.FormattingEnabled = true;
            this.comboBoxFromUnit.Location = new System.Drawing.Point(12, 50);
            this.comboBoxFromUnit.Name = "comboBoxFromUnit";
            this.comboBoxFromUnit.Size = new System.Drawing.Size(200, 21);
            this.comboBoxFromUnit.TabIndex = 1;

            // 
            // comboBoxToUnit
            // 
            this.comboBoxToUnit.FormattingEnabled = true;
            this.comboBoxToUnit.Location = new System.Drawing.Point(12, 90);
            this.comboBoxToUnit.Name = "comboBoxToUnit";
            this.comboBoxToUnit.Size = new System.Drawing.Size(200, 21);
            this.comboBoxToUnit.TabIndex = 2;

            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 130);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(200, 20);
            this.textBoxInput.TabIndex = 3;

            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 180);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(66, 13);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Результат:";

            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 220);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(200, 30);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Конвертировать";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 270);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.comboBoxToUnit);
            this.Controls.Add(this.comboBoxFromUnit);
            this.Controls.Add(this.comboBoxCategory);
            this.Name = "Form1";
            this.Text = "Конвертер единиц";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
