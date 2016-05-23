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
    public partial class BallViewer : UserControl
    {
        public BallViewer()
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

        public double Radius
        {
            get
            {
                return Convert.ToDouble(Radius_TextBox.Text);
            }
        }
    }
}
