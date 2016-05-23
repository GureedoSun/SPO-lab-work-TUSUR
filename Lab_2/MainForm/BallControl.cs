using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassFigure;

namespace Model_View
{
    public partial class BallControl : UserControl
    {
        public BallControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Открытое свойсво Value 
        /// </summary>
        public Spher Value
        {
            get { return new Spher() { Radius = Convert.ToInt32(Radius_TextBox.Text) }; }
            set
            {
                Radius_TextBox.Text = value.Radius.ToString();
            }
        }


        /// <summary>
        /// Ограничение ввода в textbox
        /// </summary>
        private void Radius_TextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
