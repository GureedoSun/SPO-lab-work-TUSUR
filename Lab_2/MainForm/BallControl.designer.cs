namespace Model_View
{
    partial class BallControl
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
            this.Radius_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Radius_TextBox
            // 
            this.Radius_TextBox.Location = new System.Drawing.Point(0, 16);
            this.Radius_TextBox.Name = "Radius_TextBox";
            this.Radius_TextBox.Size = new System.Drawing.Size(126, 20);
            this.Radius_TextBox.TabIndex = 31;
            this.Radius_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Radius_TextBox_KeyPress_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Радиус";
            // 
            // BallControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Radius_TextBox);
            this.Controls.Add(this.label7);
            this.Name = "BallControll";
            this.Size = new System.Drawing.Size(131, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.TextBox Radius_TextBox;
    }
}
