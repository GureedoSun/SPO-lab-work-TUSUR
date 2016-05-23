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
    public partial class PiramidViewer : UserControl
    {
        public PiramidViewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Открытое свойсво Value 
        /// </summary>
        public Piramide Value
        {
            get { return new Piramide() { S = Convert.ToInt32(S_TextBox.Text), H = Convert.ToInt32(H_TextBox.Text) };}
            set
            {
                H_TextBox.Text = value.H.ToString();
                S_TextBox.Text = value.S.ToString();
            }
        }

        public double H
        {
            get
            {
                return Convert.ToDouble(H_TextBox.Text);
            }
        }

        public double S
        {
            get
            {
                return (Convert.ToDouble(S_TextBox.Text)/2);
            }
        }
    }
}
