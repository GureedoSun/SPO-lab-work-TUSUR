namespace Model_View
{
    partial class ParallelepipedContrlol
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
            this.CSide_TextBox = new System.Windows.Forms.TextBox();
            this.BSide_TextBox = new System.Windows.Forms.TextBox();
            this.ASide_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CSide_TextBox
            // 
            this.CSide_TextBox.Location = new System.Drawing.Point(0, 95);
            this.CSide_TextBox.Name = "CSide_TextBox";
            this.CSide_TextBox.Size = new System.Drawing.Size(126, 20);
            this.CSide_TextBox.TabIndex = 28;
            this.CSide_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CSide_TextBox_KeyPress_1);
            // 
            // BSide_TextBox
            // 
            this.BSide_TextBox.Location = new System.Drawing.Point(0, 56);
            this.BSide_TextBox.Name = "BSide_TextBox";
            this.BSide_TextBox.Size = new System.Drawing.Size(126, 20);
            this.BSide_TextBox.TabIndex = 27;
            this.BSide_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BSide_TextBox_KeyPress_1);
            // 
            // ASide_TextBox
            // 
            this.ASide_TextBox.Location = new System.Drawing.Point(0, 17);
            this.ASide_TextBox.Name = "ASide_TextBox";
            this.ASide_TextBox.Size = new System.Drawing.Size(126, 20);
            this.ASide_TextBox.TabIndex = 26;
            this.ASide_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ASide_TextBox_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Сторона А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Сторона В";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Сторона С";
            // 
            // ParallelepipedContrloll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CSide_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BSide_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ASide_TextBox);
            this.Name = "ParallelepipedContrloll";
            this.Size = new System.Drawing.Size(133, 118);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox CSide_TextBox;
        protected System.Windows.Forms.TextBox BSide_TextBox;
        protected System.Windows.Forms.TextBox ASide_TextBox;
    }
}
