using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AbstractFactoryAutomovil.mundo.clases;
using AbstractFactoryAutomovil.mundo.interfaces;
using AbstractFactoryAutomovil.mundo.fabricas;

namespace AbstractFactoryAutomovil
{
    public partial class Cliente : Form
    {
        private IAuto auto;
        private ICarroceria carroceria;
        private IFabricaDePartes fabrica;
        private IMotor motor;

        public Cliente()
        {
            InitializeComponent();
            cmb_tipo.SelectedIndex = 0;
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (rbtn_mazda.Checked)
                fabrica = new FabricaMazda();
            else if (rbtn_renault.Checked)
                fabrica = new FabricaRenault();
            else if (rbtn_chevrolet.Checked)
                fabrica = new FabricaChevrolet();

            auto = fabrica.crearAuto();
            carroceria = fabrica.crearCarroceria();
            motor = fabrica.crearMotor();

            if (cmb_tipo.SelectedIndex == 0)
                MessageBox.Show(auto.darNombre());
            else if (cmb_tipo.SelectedIndex == 1)
                MessageBox.Show(carroceria.darNombre());
            else if (cmb_tipo.SelectedIndex == 2)
                MessageBox.Show(motor.darNombre());
            else
                MessageBox.Show("Selección no valida");
        }
    }
}
