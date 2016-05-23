namespace Model_View
{
    partial class PiramidControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.S_TextBox = new System.Windows.Forms.TextBox();
            this.H_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // S_TextBox
            // 
            this.S_TextBox.Location = new System.Drawing.Point(3, 17);
            this.S_TextBox.Name = "S_TextBox";
            this.S_TextBox.Size = new System.Drawing.Size(126, 20);
            this.S_TextBox.TabIndex = 30;
            this.S_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.S_TextBox_KeyPress_1);
            // 
            // H_TextBox
            // 
            this.H_TextBox.Location = new System.Drawing.Point(3, 56);
            this.H_TextBox.Name = "H_TextBox";
            this.H_TextBox.Size = new System.Drawing.Size(126, 20);
            this.H_TextBox.TabIndex = 29;
            this.H_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.H_TextBox_KeyPress_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Площадь основания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Высота";
            // 
            // PiramidControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.S_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.H_TextBox);
            this.Name = "PiramidControll";
            this.Size = new System.Drawing.Size(142, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox S_TextBox;
        protected System.Windows.Forms.TextBox H_TextBox;
    }
}
