namespace MainForm
{
    partial class DrawFigureControl
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
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarAngle = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFigure = new System.Windows.Forms.ComboBox();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.comboBoxOs = new System.Windows.Forms.ComboBox();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(379, 121);
            this.trackBarY.Maximum = 50000;
            this.trackBarY.Minimum = -50000;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarY.Size = new System.Drawing.Size(45, 199);
            this.trackBarY.TabIndex = 60;
            this.trackBarY.Scroll += new System.EventHandler(this.trackBarY_Scroll);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(328, 85);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(75, 17);
            this.checkBox.TabIndex = 59;
            this.checkBox.Text = "Сеточный";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Угол";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "X";
            // 
            // trackBarAngle
            // 
            this.trackBarAngle.Location = new System.Drawing.Point(481, 121);
            this.trackBarAngle.Maximum = 360;
            this.trackBarAngle.Minimum = -360;
            this.trackBarAngle.Name = "trackBarAngle";
            this.trackBarAngle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarAngle.Size = new System.Drawing.Size(45, 197);
            this.trackBarAngle.TabIndex = 54;
            this.trackBarAngle.Scroll += new System.EventHandler(this.trackBarAngle_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Выбирети фигуру";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Вращение по осям";
            // 
            // comboBoxFigure
            // 
            this.comboBoxFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFigure.FormattingEnabled = true;
            this.comboBoxFigure.Items.AddRange(new object[] {
            "Сфера",
            "Параллелепипед",
            "Пирамида"});
            this.comboBoxFigure.Location = new System.Drawing.Point(328, 58);
            this.comboBoxFigure.Name = "comboBoxFigure";
            this.comboBoxFigure.Size = new System.Drawing.Size(182, 21);
            this.comboBoxFigure.TabIndex = 51;
            // 
            // trackBarZ
            // 
            this.trackBarZ.Location = new System.Drawing.Point(430, 121);
            this.trackBarZ.Maximum = 50000;
            this.trackBarZ.Minimum = -50000;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarZ.Size = new System.Drawing.Size(45, 197);
            this.trackBarZ.TabIndex = 50;
            this.trackBarZ.Scroll += new System.EventHandler(this.trackBarZ_Scroll);
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(328, 121);
            this.trackBarX.Maximum = 50000;
            this.trackBarX.Minimum = -50000;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarX.Size = new System.Drawing.Size(45, 197);
            this.trackBarX.TabIndex = 49;
            this.trackBarX.Scroll += new System.EventHandler(this.trackBarX_Scroll);
            // 
            // comboBoxOs
            // 
            this.comboBoxOs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOs.FormattingEnabled = true;
            this.comboBoxOs.Items.AddRange(new object[] {
            "Вращение вдоль оси X",
            "Вращение вдоль оси Y",
            "Вращение вдоль оси Z"});
            this.comboBoxOs.Location = new System.Drawing.Point(328, 19);
            this.comboBoxOs.Name = "comboBoxOs";
            this.comboBoxOs.Size = new System.Drawing.Size(182, 21);
            this.comboBoxOs.TabIndex = 48;
            this.comboBoxOs.SelectedIndexChanged += new System.EventHandler(this.comboBoxOs_SelectedIndexChanged);
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(3, 19);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(319, 299);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 61;
            // 
            // DrawFigureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AnT);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarAngle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFigure);
            this.Controls.Add(this.trackBarZ);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.comboBoxOs);
            this.Name = "DrawFigureControl";
            this.Size = new System.Drawing.Size(527, 325);
            this.Load += new System.EventHandler(this.DrawFigureControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFigure;
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.ComboBox comboBoxOs;
        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Timer RenderTimer;
    }
}
