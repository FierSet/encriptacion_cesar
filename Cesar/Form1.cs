using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cesar
{
    public partial class Form1 : Form
    {
        private String path;
        private String subrutaguarda, NombreArchivo, Extencionesg;
        private int key;
        byte[] Textobyte = null;
        String textos_g = "";
        public String[] abc = new string[] 
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z","Ñ",
            "`","|","^","_","~","@","-","´","+","*","¨","[","]","{","}","¡","!","¿","?","=","(",")","&","%","$","#","\'","\"","°","\\","/",":",".",";",",","\n", " ",
            "0","1","2","3","4","5","6","7","8","9",
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };

        public Form1()
        {
            InitializeComponent();
            Inicio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cobobox();
        }

        public void Inicio()
        {
            //path_box.Enabled = false;

        }

        public void BuscaArchivo()
        {
            textarea.ForeColor = Color.Black;
            OpenFileDialog busca = new OpenFileDialog();
            busca.Filter = "All files (*.*)|*.*" + "|" + "TXT(*.txt)|*.txt"; // "PDF(*.pdf)|*.pdf|" + |DOCX(*.docx)|*.docx
            busca.FilterIndex = 2;

            if (busca.ShowDialog() == DialogResult.OK)
            {
                path_box.Text = busca.FileName;
                path = busca.FileName;
            }
            textos_g = Leer();
            textarea.Text = textos_g;
        }

        public void buscarutaG()
        {
            FolderBrowserDialog buscar = new FolderBrowserDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                subrutaguarda = buscar.SelectedPath;
                guardar();
            }
        }

        public void guardar()
        {
            if (comprobararchivo())
            {
                textarea.ForeColor = Color.Green;
                Textobyte = Encoding.ASCII.GetBytes(textos_g);
                Escribe();
                Mensajebox("Datos guardado en: " + subrutaguarda + "\\" + NombreArchivo + "." + Extencionesg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                Mensajebox("No se puede Guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void Escribe()
        {                                                                  //Extencionesg
            File.WriteAllBytes(subrutaguarda + "\\" + NombreArchivo + "." + "txt", Textobyte);
        }

        public string Leer()//abre el archivo
        {
            Textobyte = File.ReadAllBytes(path);
            return System.Text.Encoding.UTF8.GetString(Textobyte);
        }

        public bool comprobararchivo() // verifica la compatibilidad
        {
            bool cumple = false;
            try
            {
                NombreArchivo = path.Substring(path.LastIndexOf(((char)92)) + 1);
                int index = NombreArchivo.LastIndexOf('.');
                Extencionesg = NombreArchivo.Substring(index + 1);
                NombreArchivo = NombreArchivo.Substring(0, index);

                cumple = true;

            }
            catch (Exception e)
            {
                textarea.ForeColor = Color.Red;
                textarea.Text = "\n\t=-=-=-=-=-=-=\'" + path + "\' No es una ruta Correcta=-=-=-=-=-=-=\n" + e.ToString();
            }
            return cumple;
        }

        public void Cobobox()
        {
            for (int i = 1; i < abc.Length; i++)
                key_list.Items.Add(i);
        }

        public void Cesar()
        {
            String texto = textos_g;
            string textos = "";

            Invoke(new Action(() =>
            {
                progressBar1.Value = 0;
                progressBar1.Maximum = texto.Length;
            }));

            foreach (char charac in texto)
            {
                for(int i = 0; i < abc.Length; i++)
                    if(abc[i] == charac.ToString())
                    {
                        if((i + key) >= abc.Length)
                            textos += abc[key -  (abc.Length - i)];
                        else
                            textos += abc[key + i];
                        break;
                    }
                Invoke(new Action(() => progressBar1.Value++));
            }
            textos_g = textos;
            Invoke(new Action(() =>
            {
                textarea.Text = textos_g;
                bloqueo(true);
            }));
        }

        public void Descesar()
        {
            String texto = textos_g;
            string textos = "";
            
            Invoke(new Action(() =>
            {
                progressBar1.Value = 0;
                progressBar1.Maximum = texto.Length;
            }));

            foreach (char charac in texto)
            {
                for (int i = 0; i < abc.Length; i++)
                    if (abc[i] == charac.ToString())
                    {
                        if ((i - key) < 0)
                            textos += abc[abc.Length + (i - key)];
                        else
                            textos += abc[i - key];
                        break;
                    }
                Invoke(new Action(() => progressBar1.Value++));
            }
            textos_g = textos;
            Invoke(new Action(() =>
            {
                textarea.Text = textos_g;
                bloqueo(true);
            }));
        }

        public void fuerzabruta()
        {
            String texto = textos_g;
            string textos = "";

            Invoke(new Action(() =>
            {
                progressBar1.Value = 0;
                progressBar1.Maximum = abc.Length;
            }));

            for(int k = 0; k < abc.Length; k++)
            {
                textos += "key: " + k + "\n____________________________________________________\n";
                foreach (char charac in texto)
                {
                    for (int i = 0; i < abc.Length; i++)
                        if (abc[i] == charac.ToString())
                        {
                            if ((i - k) < 0)
                                textos += abc[abc.Length + (i - k)];
                            else
                                textos += abc[i - k];
                            break;
                        }
                }
                textos += "\n______________________________________________________\n";
                Invoke(new Action(() => progressBar1.Value++));
            }

            textos_g = textos;
            Invoke(new Action(() =>
            {
                textarea.Text = textos_g;
                bloqueo(true);
            }));
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            BuscaArchivo();
        }

        private void encriptar_Click(object sender, EventArgs e)
        {
            if (textos_g != string.Empty)
                if ((key_list.SelectedItem != null))
                {
                    key = (int)key_list.SelectedItem;
                    bloqueo(false);
                    Thread cesarenc = new Thread(Cesar);
                    cesarenc.Start();
                }
                else
                    Mensajebox("No selecciono key: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                Mensajebox("No selecciono Ruta: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void desencriptar_Click(object sender, EventArgs e)
        {
            if (textos_g != string.Empty)
                if ((key_list.SelectedItem != null))
                {
                    key = (int)key_list.SelectedItem;
                    bloqueo(false);
                    Thread descesarenc = new Thread(Descesar);
                    descesarenc.Start();
                }
                else
                    Mensajebox("No selecciono key: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                Mensajebox("No selecciono Ruta: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void guarda_Click(object sender, EventArgs e)
        {
            buscarutaG();
        }

        private void bruta_Click(object sender, EventArgs e)
        {
            if (textos_g != string.Empty)
            {
                bloqueo(false);
                Thread FB = new Thread(fuerzabruta);
                FB.Start();
            }
            else
                Mensajebox("No selecciono Ruta: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void bloqueo(bool estado)
        {
            buscar.Enabled = estado;
            key_list.Enabled = estado;
            encriptar.Enabled = estado;
            desencriptar.Enabled = estado;
        }

        public DialogResult Mensajebox(string mensaje, string titulo, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            return MessageBox.Show(mensaje, titulo, botones, icono);
        }
    }
}