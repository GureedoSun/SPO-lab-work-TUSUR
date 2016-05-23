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
    public partial class ParallelepipedViewer : UserControl
    {
        public ParallelepipedViewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Открытое свойсво Value 
        /// </summary>
        public Parallelepiped Value
        {
            get { return new Parallelepiped() { A = Convert.ToInt32(ASide_TextBox.Text), B = Convert.ToInt32(BSide_TextBox.Text), C = Convert.ToInt32(CSide_TextBox.Text) };}
            set
            {
                ASide_TextBox.Text = value.A.ToString();
                BSide_TextBox.Text = value.B.ToString();
                CSide_TextBox.Text = value.C.ToString();
            }
        }

        public double A
        {
            get
            {
                return (Convert.ToDouble(ASide_TextBox.Text) / 2);
            }
        }
        public double B
        {
            get
            {
                return (Convert.ToDouble(BSide_TextBox.Text) / 2);
            }
        }
        public double C
        {
            get
            {
                return (Convert.ToDouble(CSide_TextBox.Text) / 2);
            }
        }
    }
}
