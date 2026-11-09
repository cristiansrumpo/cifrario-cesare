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

        private void btn_n2_Click(object sender, EventArgs e)
        {
            string testoCifrato = txt_n3.Text;
            int chiave = 0;

            // 2. Converte il testo in un array di caratteri per poterlo elaborare
            char[] buffer = testoCifrato.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char lettera = buffer[i];

                // Gestione lettere maiuscole
                if (char.IsUpper(lettera))
                {
                    // Il +26 serve a gestire correttamente il calcolo quando si va all'indietro
                    lettera = (char)(((lettera - 'A' - chiave + 26) % 26) + 'A');
                }
                // Gestione lettere minuscole
                else if (char.IsLower(lettera))
                {
                    lettera = (char)(((lettera - 'a' - chiave + 26) % 26) + 'a');
                }

                buffer[i] = lettera;
            }
            lbl_n11.Text = new string(buffer);
        }

    }
}       

