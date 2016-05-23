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
    public partial class PiramidControl : UserControl
    {
        public PiramidControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Открытое свойсво Value 
        /// </summary>
        public Piramide Value
        {
            get { return new Piramide() { S = Convert.ToInt32(S_TextBox.Text), H = Convert.ToInt32(H_TextBox.Text) }; }
            set
            {
                H_TextBox.Text = value.H.ToString();
                S_TextBox.Text = value.S.ToString();
            }
        }

        /// <summary>
        /// Ограничение ввода в textbox
        /// </summary>

        private void S_TextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        /// <summary>
        /// Ограничение ввода в textbox
        /// </summary>
        private void H_TextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
        if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            e.Handled = true;
        }
    }
}
