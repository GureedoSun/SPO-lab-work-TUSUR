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
    public partial class ParallelepipedContrlol : UserControl
    {
        public ParallelepipedContrlol()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Открытое свойсво Value 
        /// </summary>
        public Parallelepiped Value
        {
            get { return new Parallelepiped() { A = Convert.ToInt32(ASide_TextBox.Text), B = Convert.ToInt32(BSide_TextBox.Text), C = Convert.ToInt32(CSide_TextBox.Text) }; }
            set
            {
               ASide_TextBox.Text = value.A.ToString();
               BSide_TextBox.Text = value.B.ToString();
               CSide_TextBox.Text = value.C.ToString();
            }
        }

        /// <summary>
        /// Ограничение ввода в textbox
        /// </summary>
        private void ASide_TextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        /// <summary>
        /// Ограничение ввода в textbox
        /// </summary>
        private void BSide_TextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        /// <summary>
        /// Ограничение ввода в textbox
        /// </summary>
        private void CSide_TextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
