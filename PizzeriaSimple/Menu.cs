using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzeriaSimple
{
    public partial class Menu : Form
    {
        //Atributos
        public Pizza VPizza;

        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VPizza = new Pizza();
            //Entrega datos a la Vista Pizza
            VPizza.subtotal = calcularPrecio(); //Entrega el calculo del precio hasta el momento
            VPizza.cantidad = (int)nupCantidad.Value; //Cantidad de Pizzas
            VPizza.cliente = txtCliente.Text; //Cliente.Nombre
            VPizza.variedad = cmbVariedad.Text; //Variedad.Texto

            if (rbtCuatro.Checked) VPizza.tamaño=rbtCuatro.Text;
            if (rbtOcho.Checked) VPizza.tamaño = rbtOcho.Text;
            if (rbtDiez.Checked) VPizza.tamaño = rbtDiez.Text;
            if (rbtDoce.Checked) VPizza.tamaño = rbtDoce.Text;

            VPizza.ShowDialog();
        }

        //Metodo Auxiliar
        private float calcularPrecio()
        {
            float resultado=0;
            if (rbtCuatro.Checked) resultado = 40;
            if (rbtOcho.Checked) resultado = 50;
            if (rbtDiez.Checked) resultado = 60;
            if (rbtDoce.Checked) resultado = 80;

            resultado = resultado + (cmbVariedad.SelectedIndex+1)*10;
            return resultado;
        }

    }
}
