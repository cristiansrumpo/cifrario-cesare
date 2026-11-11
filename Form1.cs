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
            int chiave;
            string frase;

            chiave = 0;
            frase = txt_n3.Text;

            chiave = Convert.ToInt32(txt_n4.Text);

            char[] caratteri = frase.ToCharArray();

            for (int i = 0; i < caratteri.Length; i++)
            {
                char lettera = caratteri[i];

                if (char.IsUpper(lettera))
                {
                    lettera = (char)(((lettera - 'A' - chiave) % 26 + 26) % 26 + 'A');
                }
                else if (char.IsLower(lettera))
                {
                    lettera = (char)(((lettera - 'a' - chiave) % 26 + 26) % 26 + 'a');
                }

                caratteri[i] = lettera;
            }

            lbl_n11.Text = new string(caratteri);
        }

        private void btn_n3_Click(object sender, EventArgs e)
        {
            string frase, chiaveStringa, risultato;

            frase = txt_n5.Text;
            chiaveStringa = txt_n6.Text;

            if (string.IsNullOrEmpty(chiaveStringa))
            {
                chiaveStringa = "CHIAVE";
            }

            char[] caratteri = frase.ToCharArray();

            for (int i = 0; i < caratteri.Length; i++)
            {
                char lettera = caratteri[i];

                if (!char.IsLetter(lettera))
                {
                    continue;
                }

                // Trova la lettera corrispondente nella chiave (usando il modulo)
                char letteraChiave = chiaveStringa[i % chiaveStringa.Length];

                // Calcola lo spostamento basato sulla lettera della chiave (da 0 a 25)
                int spostamento;
                if (char.IsUpper(letteraChiave))
                {
                    spostamento = letteraChiave - 'A';
                }
                else
                {
                    spostamento = letteraChiave - 'a';
                }

                // Applica lo spostamento alla lettera del testo in chiaro
                if (char.IsUpper(lettera))
                {
                    lettera = (char)(((lettera - 'A' + spostamento) % 26 + 26) % 25 + 'A');
                }
                else
                {
                    lettera = (char)(((lettera - 'a' + spostamento) % 26 + 26) % 25 + 'a');
                }

                caratteri[i] = lettera;
            }
            lbl_n20.Text = new string(caratteri);
        }
    }
}       

