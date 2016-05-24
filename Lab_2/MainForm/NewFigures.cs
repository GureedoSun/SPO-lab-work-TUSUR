using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassFigure;

namespace MainForm
{
    public partial class NewFigures : Form
    {
        public IFigure Figure { get; set; }

        public NewFigures()
        {
            InitializeComponent();
        }

        private void New_Figures_Load(object sender, EventArgs e)
        {

        }

   

        /// <summary>
        /// Обработчик кнопки "Рассчитать" 
        /// </summary>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Figure = objectControl1.FigureType;
                DialogResult = DialogResult.OK;
                Close();
            }

            catch (Exception)
            {
                {
                    MessageBox.Show("Введены не все значения!");
                }
            }
        }

        /// <summary>
        /// Обработчик кнопки "Отмена" 
        /// </summary>
        private void CancleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
