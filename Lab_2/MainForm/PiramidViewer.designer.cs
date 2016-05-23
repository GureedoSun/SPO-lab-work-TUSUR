namespace Model_View
{
    partial class PiramidViewer
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.S_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.H_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // S_TextBox
            // 
            this.S_TextBox.Enabled = false;
            this.S_TextBox.Location = new System.Drawing.Point(2, 16);
            this.S_TextBox.Name = "S_TextBox";
            this.S_TextBox.ReadOnly = true;
            this.S_TextBox.Size = new System.Drawing.Size(126, 20);
            this.S_TextBox.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Высота";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Площадь основания";
            // 
            // H_TextBox
            // 
            this.H_TextBox.Enabled = false;
            this.H_TextBox.Location = new System.Drawing.Point(3, 54);
            this.H_TextBox.Name = "H_TextBox";
            this.H_TextBox.ReadOnly = true;
            this.H_TextBox.Size = new System.Drawing.Size(126, 20);
            this.H_TextBox.TabIndex = 33;
            // 
            // PiramidViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.S_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.H_TextBox);
            this.Name = "PiramidViewer";
            this.Size = new System.Drawing.Size(132, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox S_TextBox;
        protected System.Windows.Forms.TextBox H_TextBox;
    }
}
