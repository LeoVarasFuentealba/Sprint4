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
            verificarOCrearArchivo();
            borrarDocumentotxt();
        }

        Double DataY;
        Double DataX;
        int cont = 0;

        private void calibrationBtn_Click(object sender, EventArgs e)
        {
            timerTemp.Enabled = true;
        }

        Dictionary<string, string> tiempoTemperatura = new Dictionary<string, string>();
        private void borrarDocumentotxt()
        {
            File.WriteAllText("registrosTemp.txt", String.Empty);
        }
        private void verificarOCrearArchivo() //creo el registro si no existe
        {
            string path = "registrosTemp.txt";
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path))
                {
                }
            }
        }

        private void timerTemp_Tick(object sender, EventArgs e)
        {
            string line, tiempo, temperatura;
            bool finArchivo = false;

            if (cont < 1001)
            {
                DataX = cont;
                DataY = Math.Pow(Math.E, cont / 100.0);
                graficaTempTiem.Series[0].Points.AddXY(DataX, DataY);

                try
                {
                    using (StreamWriter sw = new StreamWriter("registrosTemp.txt", true))
                    {
                        sw.WriteLine($"{DataX}|{DataY}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al escribir en el archivo: {ex.Message}");
                }

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

                                if (!tiempoTemperatura.ContainsKey(tiempo))
                                {
                                    tiempoTemperatura.Add(tiempo, temperatura);

                                    if (cont <= 5 && cont != 0)
                                    {
                                        ListViewItem item = new ListViewItem(tiempo);
                                        item.SubItems.Add(temperatura);
                                        tiempoTemperatura1.Items.Add(item);
                                    }

                                    if (cont % 25 == 0 || cont == 0)
                                    {
                                        ListViewItem item25 = new ListViewItem(tiempo);
                                        item25.SubItems.Add(temperatura);
                                        tiempoTemperatura25.Items.Add(item25);
                                    }
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

                cont += 1;
            }
            else
            {
                timerTemp.Enabled = false;
            }
        }
    }
}
