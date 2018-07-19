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
    public partial class Pizza : Form
    {
        //Atributos
        public float subtotal;
        public int cantidad;
        public String cliente;
        public String variedad;
        public String tamaño;

        public Pizza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float total = subtotal + (cmbTipo.SelectedIndex+1) * 10;

            if (chkAceituna.Checked) total = total + 8;
            if (chkPimiento.Checked) total = total + 5;
            if (chkChampiñon.Checked) total = total + 2;

            total = total * cantidad;
            DateTime fecha = DateTime.Now; //Define y genera instancia de la clase
            //DataTime, extrayendo la hora actual con DataTime.Now
            fecha = fecha.AddMinutes(30); //Incrementa la fecha y hora actual en 
            //30 minutos
            String mensaje = "Cliente: "+cliente+"\nCantidad: "+cantidad+
                "\nTamaño: "+tamaño+"\nVariedad: "+variedad+"\nTotal: "+total+
                "\nFecha: "+ fecha.ToString("d MMM yyyy") +
                "\nHora: "+fecha.ToShortTimeString(); //Concatenacion de Cadenas
                                                        //.ToShortTimeString()
                                                      //     Convierte el valor del objeto System.DateTime actual en su representación de
                                                      //     cadena de hora corta equivalente.
            MessageBox.Show(mensaje,
                             "Total a Pagar");
        }
    }
}
