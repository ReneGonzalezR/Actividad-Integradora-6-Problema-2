using System;
using System.Windows.Forms;
/// <summary>
/// Lenguaje de programacion III
/// Autor: Rene Gonzalez Rodriguez
/// Maestro: Aarón I. Salazar
/// </summary>
namespace Actividad_Integradora_6_Problema_2
{
    public partial class Form1 : Form
    {
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvComponentes.Rows.Add(1);
            int id = Convert.ToInt32(txtId.Text);
            switch (id)
            {
                case 1:
                    dgvComponentes.Rows[contador].Cells[0].Value = "Targeta Madre";
                    dgvComponentes.Rows[contador].Cells[1].Value = "1500";
                    contador++;
                    break;
                case 2:
                    dgvComponentes.Rows[contador].Cells[0].Value = "Procesador";
                    dgvComponentes.Rows[contador].Cells[1].Value = "3500";
                    contador++;
                    break;
                case 3:
                    dgvComponentes.Rows[contador].Cells[0].Value = "Memoria Ram 4GB";
                    dgvComponentes.Rows[contador].Cells[1].Value = "850";
                    contador++;
                    break;
                case 4:
                    dgvComponentes.Rows[contador].Cells[0].Value = "Memoria Ram 8GB";
                    dgvComponentes.Rows[contador].Cells[1].Value = "1350";
                    contador++;
                    break;
                case 5:
                    dgvComponentes.Rows[contador].Cells[0].Value = "Fuente de Poder";
                    dgvComponentes.Rows[contador].Cells[1].Value = "750";
                    contador++;
                    break;
                case 6:
                    dgvComponentes.Rows[contador].Cells[0].Value = "Targeta de Video";
                    dgvComponentes.Rows[contador].Cells[1].Value = "5500";
                    contador++;
                    break;
                case 7:
                    dgvComponentes.Rows[contador].Cells[0].Value = "SSD";
                    dgvComponentes.Rows[contador].Cells[1].Value = "1000";
                    contador++;
                    break;
                case 8:
                    dgvComponentes.Rows[contador].Cells[0].Value = "Disco Duro";
                    dgvComponentes.Rows[contador].Cells[1].Value = "600";
                    contador++;
                    break;
                case 9:
                    dgvComponentes.Rows[contador].Cells[0].Value = "Monitor";
                    dgvComponentes.Rows[contador].Cells[1].Value = "4700";
                    contador++;
                    break;
                case 10:
                    dgvComponentes.Rows[contador].Cells[0].Value = "Teclado";
                    dgvComponentes.Rows[contador].Cells[1].Value = "120";
                    contador++;
                    break;
                case 11:
                    dgvComponentes.Rows[contador].Cells[0].Value = "Mouse";
                    dgvComponentes.Rows[contador].Cells[1].Value = "90";
                    contador++;
                    break;
                default:
                    MessageBox.Show("Debe ingresar un Id de la lista", "Aviso");
                    break;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow dgvRenglon in dgvComponentes.Rows)
            {
                total = total + Convert.ToDouble(dgvRenglon.Cells[1].Value.ToString());
            }

            lblTotal.Text = total.ToString();
        }
    }
}
