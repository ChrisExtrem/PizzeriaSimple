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
    public partial class Principal : Form
    {
        //Atributos
        Menu VMenu;

        //Constructores
        public Principal()
        {
            InitializeComponent();
        }

        //Metodos
        private void button1_Click(object sender, EventArgs e)
        {
           VMenu = new Menu();
           VMenu.ShowDialog();
        }
    }
}
