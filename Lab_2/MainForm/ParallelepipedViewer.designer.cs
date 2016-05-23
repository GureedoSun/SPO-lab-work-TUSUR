namespace Model_View
{
    partial class ParallelepipedViewer
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
            this.CSide_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BSide_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ASide_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CSide_TextBox
            // 
            this.CSide_TextBox.Enabled = false;
            this.CSide_TextBox.Location = new System.Drawing.Point(3, 98);
            this.CSide_TextBox.Name = "CSide_TextBox";
            this.CSide_TextBox.ReadOnly = true;
            this.CSide_TextBox.Size = new System.Drawing.Size(126, 20);
            this.CSide_TextBox.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Сторона С";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Сторона В";
            // 
            // BSide_TextBox
            // 
            this.BSide_TextBox.Enabled = false;
            this.BSide_TextBox.Location = new System.Drawing.Point(3, 59);
            this.BSide_TextBox.Name = "BSide_TextBox";
            this.BSide_TextBox.ReadOnly = true;
            this.BSide_TextBox.Size = new System.Drawing.Size(126, 20);
            this.BSide_TextBox.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Сторона А";
            // 
            // ASide_TextBox
            // 
            this.ASide_TextBox.Enabled = false;
            this.ASide_TextBox.Location = new System.Drawing.Point(3, 20);
            this.ASide_TextBox.Name = "ASide_TextBox";
            this.ASide_TextBox.ReadOnly = true;
            this.ASide_TextBox.Size = new System.Drawing.Size(126, 20);
            this.ASide_TextBox.TabIndex = 32;
            // 
            // ParallelepipedViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CSide_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BSide_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ASide_TextBox);
            this.Name = "ParallelepipedViewer";
            this.Size = new System.Drawing.Size(134, 124);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox CSide_TextBox;
        protected System.Windows.Forms.TextBox BSide_TextBox;
        protected System.Windows.Forms.TextBox ASide_TextBox;
    }
}
