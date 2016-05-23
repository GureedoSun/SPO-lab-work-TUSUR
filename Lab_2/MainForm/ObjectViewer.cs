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
    public partial class ObjectViewer : UserControl
    {
        public ObjectViewer()
        {
            InitializeComponent();
        }

        private void ObjectViewer_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Открытое свойсво figure 
        /// </summary>
        public IFigure figure
        {
            set
            {
                if (value is Spher)
                {
                    parallelepipedViewer.Visible = false;
                    piramidViewer.Visible = false;
                    ballViewer.Visible = true;

                    ballViewer.Value = (Spher)value;
                }

                else if (value is Parallelepiped)
                {
                    piramidViewer.Visible = false;
                    ballViewer.Visible = false;
                    parallelepipedViewer.Visible = true;

                    parallelepipedViewer.Value = (Parallelepiped)value;

                }
                else if (value is Piramide)
                {
                    parallelepipedViewer.Visible = false;
                    ballViewer.Visible = false;
                    piramidViewer.Visible = true;

                    piramidViewer.Value = (Piramide)value;
                }          
            }
        }


        public double Radius
        {
            get
            {
                return ballViewer.Radius;
            }
        }

        public double H
        {
            get
            {
                return piramidViewer.H;
            }
        }

        public double S
        {
            get
            {
                return piramidViewer.S;
            }
        }

        public double A
        {
            get
            {
                return parallelepipedViewer.A;
            }
        }
        public double B
        {
            get
            {
                return parallelepipedViewer.B;
            }
        }

        public double C
        {
            get
            {
                return parallelepipedViewer.C;
            }
        }
    }
}
