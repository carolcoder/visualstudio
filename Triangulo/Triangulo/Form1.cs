using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {

        UI.DecoratorValidator validator = new UI.NumericValidator();

        public Form1()
        {
            InitializeComponent();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Model.TrianguloHandler handlerNivel1 = new Model.EquilateroHandler();
                Model.TrianguloHandler handlerNivel2 = new Model.IsoscelesHandler();
                Model.TrianguloHandler handlerNivel3 = new Model.EscalenoHandler();
                handlerNivel1.SetNext(handlerNivel2);
                handlerNivel2.SetNext(handlerNivel3);
                int side1 = Convert.ToInt32(txtLado1.Text);
                int side2 = Convert.ToInt32(txtLado2.Text);
                int side3 = Convert.ToInt32(txtLado3.Text);
                String result = handlerNivel1.GetTrianguloType(side1, side2, side3);
                lblResult.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TextBoxes_Leave(Object sender, EventArgs e)
        {
            TextBox txtDigited = (TextBox)sender;
            UI.Message message = validator.isValid(txtDigited.Text);
            if (!message.IsValid)
            {
                MessageBox.Show(message.Description);
                txtDigited.Text = "";
                txtDigited.Focus();
            }
            
        
        }

        private void TextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                string keyed = e.KeyChar.ToString();
                UI.Message message = validator.isValid(keyed);
                if (!message.IsValid)
                {
                    e.Handled = true;

                }
                else
                {
                    e.Handled = false;
                }
            }
            
        }
    }
}
