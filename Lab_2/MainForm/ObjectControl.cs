using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ClassFigure;


namespace Model_View
{
    public partial class ObjectControl : UserControl
    {
        public IFigure Figure { get; set; }

        public ObjectControl()
        {
            InitializeComponent();
        }

        private void ObjectControl_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Открытое свойсво figure 
        /// </summary>
        public IFigure FigureType
        {
            get
            {
                if (spere_RadioButton.Checked)
                {
                    return ballControl.Value;
                }

                else if (piramid_RadioButton.Checked) 
                {
                    return piramidControl.Value;
                }

                else if (parallelepiped_RadioButton.Checked)
                {
                    return parallelepipedContrlol.Value;
                }

                throw new NotImplementedException();
            }


            set 
            {
                if (spere_RadioButton.Checked)
                {
                    ballControl.Value = (Spher)value;
                }

                else if (parallelepiped_RadioButton.Checked)
                {
                    parallelepipedContrlol.Value = (Parallelepiped)value;
                }

                else if (piramid_RadioButton.Checked)
                {
                    piramidControl.Value = (Piramide)value;
                }

            }
        }

        /// <summary>
        /// Если нажата кнопка "Шар"
        /// </summary>
        private void Spere_RadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            parallelepipedContrlol.Visible = false;
            piramidControl.Visible = false;
            ballControl.Visible = true;
        }

        /// <summary>
        /// Если нажата кнопка "Параллелепипед"
        /// </summary>
        private void Parallelepiped_RadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            piramidControl.Visible = false;
            ballControl.Visible = false;
            parallelepipedContrlol.Visible = true;
        }

        /// <summary>
        /// Если нажата кнопка "Пирамида"
        /// </summary>
        private void Piramid_RadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            parallelepipedContrlol.Visible = false;
            ballControl.Visible = false;
            piramidControl.Visible = true;
        }


    }
}
