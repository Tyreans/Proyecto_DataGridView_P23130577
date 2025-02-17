using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerApp2025C
{
    public partial class frmDataGrid : Form
    {
        string filePath = "";
        public frmDataGrid()
        {
            InitializeComponent();
            DialogResult resultado;
            resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                try
                {
                    string texto = File.ReadAllText(filePath);
                    string[] excel = texto.Split('\n');
                    string[] arr = excel[0].Split(',');
                    int a = arr.Length;
                    dgvDatos.ColumnCount = a;
                    dgvDatos.RowCount = excel.Length;
                    for (int i = 0; i < a; i++)
                    {
                        dgvDatos.Rows[0].Cells[i].Value = arr[i];
                    }

                    for (int i = 1; i < (excel.Length) - 1; i++)
                    {
                        arr = excel[i].Split(',');
                        for (int j = 0; j < a; j++)
                        {
                            dgvDatos.Rows[i].Cells[j].Value = arr[j];
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
            else
            {
                this.Close();
            }
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialogDataGrid.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = saveFileDialogDataGrid.FileName;
                int total = dgvDatos.Rows.Count - 1;
                string linea = "";
                for (int i = 0; i < total; i++)
                {

                    for (int j = 0; j < dgvDatos.Columns.Count; j++)
                    {
                        if (j == dgvDatos.Columns.Count - 1)
                            linea += dgvDatos.Rows[i].Cells[j].Value.ToString() + "\n";
                        else
                            linea += dgvDatos.Rows[i].Cells[j].Value.ToString() + ",";
                    }

                }
                File.WriteAllText(filename, linea);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                try
                {
                    string texto = File.ReadAllText(filePath);
                    string[] excel = texto.Split('\n');
                    string[] arr = excel[0].Split(',');
                    int a = arr.Length;
                    dgvDatos.ColumnCount = a;
                    dgvDatos.RowCount = excel.Length;
                    for (int i = 0; i < a; i++)
                    {
                        dgvDatos.Rows[0].Cells[i].Value = arr[i];
                    }

                    for (int i = 1; i < (excel.Length) - 1; i++)
                    {
                        arr = excel[i].Split(',');
                        for (int j = 0; j < a; j++)
                        {
                            dgvDatos.Rows[i].Cells[j].Value = arr[j];
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
        }
    }
}
