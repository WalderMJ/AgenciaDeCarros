using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_DISEÑO
{
    public partial class frmVehiculos: Form
    {

        CD_VEHICULOS cd_Vehiculo = new CD_VEHICULOS();
        public frmVehiculos()
        {
            InitializeComponent();
        }
        public void MtdMostrarVehiculos()
        {

            DataTable dtMostrarVehiculos = cd_Vehiculo.MtMostrarVehiculos();
            dgvVehiculos.DataSource = dtMostrarVehiculos;
        }

        public void mtdCrearVehiculo()
        {
            try
            {



                int año = Convert.ToInt32(txtAño.Text);
                decimal precio = Convert.ToDecimal(txtPrecio.Text);

                cd_Vehiculo.MtInsertarVehiculo(txtMarca.Text,txtModelo.Text,año, precio, cboxEstado.Text);

                MessageBox.Show("El vehiculo se agregó con éxito.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttonLimpiar_Click(object sender, EventArgs e)
        {
            txtIDVehiculo.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAño.Clear();
            txtPrecio.Clear();
            cboxEstado.Text="";

        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            MtdMostrarVehiculos();
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDVehiculo.Text = dgvVehiculos.SelectedCells[0].Value.ToString();
            txtMarca.Text = dgvVehiculos.SelectedCells[1].Value.ToString();
            txtModelo.Text = dgvVehiculos.SelectedCells[2].Value.ToString();
            txtAño.Text = dgvVehiculos.SelectedCells[3].Value.ToString();
            txtPrecio.Text = dgvVehiculos.SelectedCells[4].Value.ToString();
            cboxEstado.Text = dgvVehiculos.SelectedCells[5].Value.ToString();
           
        }

        private void bttonGuardar_Click(object sender, EventArgs e)
        {
            mtdCrearVehiculo();
            MtdMostrarVehiculos();
        }

        private void bttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int vehiculoID = int.Parse(txtIDVehiculo.Text);
                int año = int.Parse(txtAño.Text);
                decimal precio = decimal.Parse(txtPrecio.Text);

                

                cd_Vehiculo.MtdActualizarVehiculo(vehiculoID, txtMarca.Text, txtModelo.Text, año, precio, cboxEstado.Text);

                MessageBox.Show("El vehiculo se actualizó con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarVehiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                cd_Vehiculo.CD_mtdEliminarrVehiculo(int.Parse(txtIDVehiculo.Text));


                MessageBox.Show("El vehiculo se elimino con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarVehiculos();
            }


            catch (Exception ex)

            {
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
