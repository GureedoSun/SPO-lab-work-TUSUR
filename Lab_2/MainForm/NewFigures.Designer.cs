namespace MainForm
{
    partial class NewFigures
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CancleButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.objectControl1 = new Model_View.ObjectControl();
            this.SuspendLayout();
            // 
            // CancleButton
            // 
            this.CancleButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancleButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CancleButton.Location = new System.Drawing.Point(211, 278);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(87, 23);
            this.CancleButton.TabIndex = 14;
            this.CancleButton.Text = "Отмена";
            this.CancleButton.UseVisualStyleBackColor = false;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.White;
            this.CalculateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CalculateButton.Location = new System.Drawing.Point(12, 278);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 13;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // objectControl1
            // 
            this.objectControl1.BackColor = System.Drawing.Color.Transparent;
            this.objectControl1.Figure = null;
            this.objectControl1.Location = new System.Drawing.Point(1, 3);
            this.objectControl1.Name = "objectControl1";
            this.objectControl1.Size = new System.Drawing.Size(305, 309);
            this.objectControl1.TabIndex = 0;
            // 
            // NewFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 324);
            this.Controls.Add(this.CancleButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.objectControl1);
            this.Name = "NewFigures";
            this.Text = "New_Figure";
            this.ResumeLayout(false);

        }

        #endregion

        private Model_View.ObjectControl objectControl1;
        private System.Windows.Forms.Button CancleButton;
        private System.Windows.Forms.Button CalculateButton;
    }
}