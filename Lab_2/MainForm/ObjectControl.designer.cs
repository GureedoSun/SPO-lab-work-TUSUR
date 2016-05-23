namespace Model_View
{
    partial class ObjectControl
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.piramidControl = new Model_View.PiramidControl();
            this.parallelepipedContrlol = new Model_View.ParallelepipedContrlol();
            this.ballControl = new Model_View.BallControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.parallelepiped_RadioButton = new System.Windows.Forms.RadioButton();
            this.piramid_RadioButton = new System.Windows.Forms.RadioButton();
            this.spere_RadioButton = new System.Windows.Forms.RadioButton();
            this.piramideBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piramideBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.piramidControl);
            this.groupBox3.Controls.Add(this.parallelepipedContrlol);
            this.groupBox3.Controls.Add(this.ballControl);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 161);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // piramidControl
            // 
            this.piramidControl.BackColor = System.Drawing.Color.Transparent;
            this.piramidControl.ForeColor = System.Drawing.Color.Black;
            this.piramidControl.Location = new System.Drawing.Point(6, 57);
            this.piramidControl.Name = "piramidControl";
            this.piramidControl.Size = new System.Drawing.Size(133, 89);
            this.piramidControl.TabIndex = 15;
            this.piramidControl.Visible = false;
            // 
            // parallelepipedContrlol
            // 
            this.parallelepipedContrlol.BackColor = System.Drawing.Color.Transparent;
            this.parallelepipedContrlol.ForeColor = System.Drawing.Color.Black;
            this.parallelepipedContrlol.Location = new System.Drawing.Point(151, 19);
            this.parallelepipedContrlol.Name = "parallelepipedContrlol";
            this.parallelepipedContrlol.Size = new System.Drawing.Size(133, 127);
            this.parallelepipedContrlol.TabIndex = 14;
            this.parallelepipedContrlol.Visible = false;
            // 
            // ballControl
            // 
            this.ballControl.BackColor = System.Drawing.Color.Transparent;
            this.ballControl.ForeColor = System.Drawing.Color.Black;
            this.ballControl.Location = new System.Drawing.Point(6, 19);
            this.ballControl.Name = "ballControl";
            this.ballControl.Size = new System.Drawing.Size(131, 41);
            this.ballControl.TabIndex = 13;
            this.ballControl.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.parallelepiped_RadioButton);
            this.groupBox1.Controls.Add(this.piramid_RadioButton);
            this.groupBox1.Controls.Add(this.spere_RadioButton);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 92);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбирите фигуру";
            // 
            // parallelepiped_RadioButton
            // 
            this.parallelepiped_RadioButton.AutoSize = true;
            this.parallelepiped_RadioButton.Location = new System.Drawing.Point(6, 42);
            this.parallelepiped_RadioButton.Name = "parallelepiped_RadioButton";
            this.parallelepiped_RadioButton.Size = new System.Drawing.Size(111, 17);
            this.parallelepiped_RadioButton.TabIndex = 9;
            this.parallelepiped_RadioButton.Text = "Параллепепипед";
            this.parallelepiped_RadioButton.UseVisualStyleBackColor = true;
            this.parallelepiped_RadioButton.CheckedChanged += new System.EventHandler(this.Parallelepiped_RadioButton_CheckedChanged_1);
            // 
            // piramid_RadioButton
            // 
            this.piramid_RadioButton.AutoSize = true;
            this.piramid_RadioButton.Location = new System.Drawing.Point(6, 65);
            this.piramid_RadioButton.Name = "piramid_RadioButton";
            this.piramid_RadioButton.Size = new System.Drawing.Size(77, 17);
            this.piramid_RadioButton.TabIndex = 10;
            this.piramid_RadioButton.Text = "Пирамида";
            this.piramid_RadioButton.UseVisualStyleBackColor = true;
            this.piramid_RadioButton.CheckedChanged += new System.EventHandler(this.Piramid_RadioButton_CheckedChanged_1);
            // 
            // spere_RadioButton
            // 
            this.spere_RadioButton.AutoSize = true;
            this.spere_RadioButton.Location = new System.Drawing.Point(6, 19);
            this.spere_RadioButton.Name = "spere_RadioButton";
            this.spere_RadioButton.Size = new System.Drawing.Size(46, 17);
            this.spere_RadioButton.TabIndex = 8;
            this.spere_RadioButton.Text = "Шар";
            this.spere_RadioButton.CheckedChanged += new System.EventHandler(this.Spere_RadioButton_CheckedChanged_1);
            // 
            // piramideBindingSource
            // 
            this.piramideBindingSource.DataSource = typeof(ClassFigure.Piramide);
            // 
            // ObjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ObjectControl";
            this.Size = new System.Drawing.Size(312, 331);
            this.Load += new System.EventHandler(this.ObjectControl_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piramideBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource piramideBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton parallelepiped_RadioButton;
        private System.Windows.Forms.RadioButton piramid_RadioButton;
        private System.Windows.Forms.RadioButton spere_RadioButton;
        private PiramidControl piramidControl;
        private ParallelepipedContrlol parallelepipedContrlol;
        private BallControl ballControl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
