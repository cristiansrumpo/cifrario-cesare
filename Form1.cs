using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace cifrario_cesare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            int chiave;
            string frase,risultato;

            chiave = 0;
            frase = txt_n1.Text;

            chiave = Convert.ToInt32(txt_n2.Text);

            char[] caratteri = frase.ToCharArray();

            for (int i = 0; i < caratteri.Length; i++)
            {
                char lettera = caratteri[i];

                if (char.IsUpper(lettera))
                {
                    lettera = (char)(((lettera - 'A' + chiave) % 26 + 26) % 26 + 'A');
                }
                else if (char.IsLower(lettera))
                {
                    lettera = (char)(((lettera - 'a' + chiave) % 26 + 26) % 26 + 'a');
                }

                caratteri[i] = lettera;
            }
            lbl_n5.Text = new string(caratteri);
        }

    }
}   

