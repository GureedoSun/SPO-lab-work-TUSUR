namespace Model_View
{
    partial class ObjectViewer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.parallelepipedViewer = new Model_View.ParallelepipedViewer();
            this.piramidViewer = new Model_View.PiramidViewer();
            this.ballViewer = new Model_View.BallViewer();
            this.parallelepipedViewer1 = new Model_View.ParallelepipedViewer();
            this.piramideViewer1 = new Model_View.PiramidViewer();
            this.ballViewer1 = new Model_View.BallViewer();
            this.piramidViewer2 = new Model_View.PiramidViewer();
            this.parallelepipedViewer2 = new Model_View.ParallelepipedViewer();
            this.ballViewer2 = new Model_View.BallViewer();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 168);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные о фигурах";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.parallelepipedViewer);
            this.groupBox2.Controls.Add(this.piramidViewer);
            this.groupBox2.Controls.Add(this.ballViewer);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 279);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные о фигурах";
            // 
            // parallelepipedViewer
            // 
            this.parallelepipedViewer.Location = new System.Drawing.Point(2, 64);
            this.parallelepipedViewer.Name = "parallelepipedViewer";
            this.parallelepipedViewer.Size = new System.Drawing.Size(134, 124);
            this.parallelepipedViewer.TabIndex = 1;
            // 
            // piramidViewer
            // 
            this.piramidViewer.Location = new System.Drawing.Point(0, 194);
            this.piramidViewer.Name = "piramidViewer";
            this.piramidViewer.Size = new System.Drawing.Size(132, 78);
            this.piramidViewer.TabIndex = 2;
            // 
            // ballViewer
            // 
            this.ballViewer.Location = new System.Drawing.Point(0, 19);
            this.ballViewer.Name = "ballViewer";
            this.ballViewer.Size = new System.Drawing.Size(136, 45);
            this.ballViewer.TabIndex = 0;
            // 
            // parallelepipedViewer1
            // 
            this.parallelepipedViewer1.Location = new System.Drawing.Point(148, 23);
            this.parallelepipedViewer1.Name = "parallelepipedViewer1";
            this.parallelepipedViewer1.Size = new System.Drawing.Size(134, 138);
            this.parallelepipedViewer1.TabIndex = 2;
            // 
            // piramideViewer1
            // 
            this.piramideViewer1.Location = new System.Drawing.Point(10, 68);
            this.piramideViewer1.Name = "piramideViewer1";
            this.piramideViewer1.Size = new System.Drawing.Size(132, 81);
            this.piramideViewer1.TabIndex = 1;
            // 
            // ballViewer1
            // 
            this.ballViewer1.Location = new System.Drawing.Point(10, 23);
            this.ballViewer1.Name = "ballViewer1";
            this.ballViewer1.Size = new System.Drawing.Size(136, 45);
            this.ballViewer1.TabIndex = 0;
            // 
            // piramidViewer2
            // 
            this.piramidViewer2.Location = new System.Drawing.Point(0, 194);
            this.piramidViewer2.Name = "piramidViewer2";
            this.piramidViewer2.Size = new System.Drawing.Size(132, 78);
            this.piramidViewer2.TabIndex = 2;
            // 
            // parallelepipedViewer2
            // 
            this.parallelepipedViewer2.Location = new System.Drawing.Point(2, 64);
            this.parallelepipedViewer2.Name = "parallelepipedViewer2";
            this.parallelepipedViewer2.Size = new System.Drawing.Size(134, 124);
            this.parallelepipedViewer2.TabIndex = 1;
            // 
            // ballViewer2
            // 
            this.ballViewer2.Location = new System.Drawing.Point(0, 19);
            this.ballViewer2.Name = "ballViewer2";
            this.ballViewer2.Size = new System.Drawing.Size(136, 45);
            this.ballViewer2.TabIndex = 0;
            // 
            // ObjectViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "ObjectViewer";
            this.Size = new System.Drawing.Size(154, 291);
            this.Load += new System.EventHandler(this.ObjectViewer_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BallViewer ballViewer1;
        private ParallelepipedViewer parallelepipedViewer1;
        private PiramidViewer piramideViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private BallViewer ballViewer;
        private ParallelepipedViewer parallelepipedViewer;
        private PiramidViewer piramidViewer;
        private System.Windows.Forms.GroupBox groupBox2;
        private PiramidViewer piramidViewer2;
        private ParallelepipedViewer parallelepipedViewer2;
        private BallViewer ballViewer2;
    }
}
