using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sprint4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double DataY;
        Double DataX;
        int cont = 0;

        private void calibrationBtn_Click(object sender, EventArgs e)
        {
            timerTemp.Enabled = true;
        }
        Dictionary<string, string> tiempoTemperatura = new Dictionary<string, string>();

        private void timerTemp_Tick(object sender, EventArgs e)
        {
            string line, tiempo, temperatura;
            bool finArchivo;
            int contLine;

            cont = 0;
            if (cont < 1001)
            {
                DataX = cont;
                DataY = Math.Pow(Math.E, cont / 100.0);

                graficaTempTiem.Series[0].Points.AddXY(DataX, DataY);

                if(cont < 12)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter("registrosTemp.txt", true))
                        {
                            sw.WriteLine($"{DataX}|{DataY}");
                            sw.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("No se a encontrado el registro en el lugar de compilacion");
                    }
                }
                cont += 1;
            }
            else
            {
                timerTemp.Enabled = false;
            }

            finArchivo = false;
            contLine = 0;
            try
            {
                using (StreamReader sr = new StreamReader("registrosTemp.txt"))
                {
                    while (!finArchivo)
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            tiempo = line.Split('|')[0];
                            temperatura = line.Split('|')[1];

                            // Añadimos al diccionario si no existe
                            if (!tiempoTemperatura.ContainsKey(tiempo))
                            {
                                tiempoTemperatura.Add(tiempo, temperatura);

                                // Creamos un nuevo ListViewItem para agregar al ListView
                                ListViewItem item = new ListViewItem(tiempo);
                                item.SubItems.Add(temperatura);
                                tiempoTemperatura1.Items.Add(item);
                            }
                        }
                        else
                        {
                            finArchivo = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }
        }
    }
}