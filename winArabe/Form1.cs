using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tipos;

namespace winArabe
{
    public partial class Form1 : Form
    {
        private string m_Texto;
        private Palabra m_palabra;
        private List<string> m_Frases = new List<string>();
        private char ultChar = ' ';

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_palabra = new Palabra("كِتَابٌ");
            m_palabra.raiz = new Raiz( new char[]{'ك','ت','ب'} );

            m_Frases.Add("هَلْ تَعْرِفُ اللُّغَةَ الْعَرَبِيَّةَ؟");
            m_Frases.Add("اللُّغَةُ العَرَبِيَّةُ مِنْ أَصْعَبُ لُغَاتِ العَالَمِ.");
            m_Frases.Add("وُلِدْتُ فِي اليَوْمِ 12 مِن شَهْرِ أيْلُوْل عَام 1964.");

            lblPalTexto.Text = m_palabra.getTexto( !chkOcultarBreves.Checked );
            lblPalRaiz.Text = m_palabra.raiz.ToString();

            ListViewItem itm;
            foreach (Harf harf in Program.m_Huruf.Values)
            {
                if (harf.Tipo == TipoLetra.Letra)
                {
                    itm = listView1.Items.Add(harf.Letra.ToString());
                    itm.SubItems.Add(harf.Nombre);
                    itm.SubItems.Add(harf.Translit.ToString());
                    itm.SubItems.Add(Trasliterar(harf.Nombre));
                }
            }
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    label1.Text = Trasliterar(textBox1.Text);
        //}

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // m_Texto = Corregir(richTextBox1.Text);
            // richTextBox1.Text = m_Texto;
            m_Texto = richTextBox1.Text;
            label1.Text = Trasliterar(m_Texto);
        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog(this);
            richTextBox1.Font = fontDialog1.Font;
            richTextBox1.Refresh();
            comboBox1.Text = fontDialog1.Font.Name + ", " + fontDialog1.Font.Style + ", " + fontDialog1.Font.SizeInPoints.ToString();
            lblPalTexto.Font = fontDialog1.Font;
            lblPalRaiz.Font = fontDialog1.Font;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void chkUsarDosPuntos_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = Trasliterar(richTextBox1.Text);
        }

        private void chkUsarUnion_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = Trasliterar(richTextBox1.Text);
        }

        private void chkNrosArabes_CheckedChanged(object sender, EventArgs e)
        {
            string strAux = richTextBox1.Text;
            if (chkNrosArabes.Checked)
                strAux = strAux.Replace('0','٠').Replace('1','١').Replace('2','٢').Replace('3','٣').Replace('4','٤')
                      .Replace('5','٥').Replace('6','٦').Replace('7','٧').Replace('8','٨').Replace('9','٩');
            else
               strAux = strAux.Replace('٠', '0').Replace('١', '1').Replace('٢', '2').Replace('٣', '3').Replace('٤', '4')
                     .Replace('٥', '5').Replace('٦', '6').Replace('٧', '7').Replace('٨', '8').Replace('٩', '9');

            richTextBox1.Text = strAux;
        }

        private void chkMostrarBreves_CheckedChanged(object sender, EventArgs e)
        {
            string strAux = richTextBox1.Text;
            string strTexto = strAux;

            lblPalTexto.Text = m_palabra.getTexto(!chkOcultarBreves.Checked);

            if (chkOcultarBreves.Checked)
            {
                strAux = strAux.Replace(((char)0x64B).ToString(), "")   // fathatan
                               .Replace(((char)0x64C).ToString(), "")   // dammatan
                               .Replace(((char)0x64D).ToString(), "")   // kasratan
                               .Replace(((char)0x64E).ToString(), "")   // fatha
                               .Replace(((char)0x64F).ToString(), "")   // damma
                               .Replace(((char)0x650).ToString(), "")   // kasra
                               .Replace(((char)0x651).ToString(), "")   // shadda
                               .Replace(((char)0x652).ToString(), "")   // suku:n
                               // .Replace("وْ","و")
                               .Replace(((char)0x670).ToString(), "");  // 
                richTextBox1.Text = strAux;
                m_Texto = strTexto;
            }
            else
                richTextBox1.Text = m_Texto;
        }

        private string Trasliterar(string texto)
        {
            string strAux = "";
            string shadda = "";
            char c; int key;
            Tipos.Harf harf;

            for (int i = 0; i < texto.Length; i++)
            {
                c = texto[i];
                if (c == '\n') strAux += c;

                key = (int)c;
                Program.m_Huruf.TryGetValue(key, out harf);
                if (harf != null)
                {
                    strAux += (harf.Translit == "_" ? shadda : harf.Translit);
                    shadda = harf.Translit;
                }
            }

            // Palabras especiales
            strAux = strAux.Replace(" Alḏy", " Allaḏī").Replace(" Alty", " Allatī");
            strAux = strAux.Replace("haḏihi", "hāḏihi").Replace("haḏaA", "hāḏa");

            strAux = strAux.Replace("-un", "un").Replace("-in", "in").Replace("-anA", "an").Replace("-an", "an");

            strAux = strAux.Replace("iy°", "ī").Replace("aA", "ā").Replace("uw°", "ū");
            strAux = strAux.Replace("iy ", "ī ").Replace("A ", "ā ").Replace("uw ", "ū ")
                .Replace(" Al", " l-").Replace("Eu", "'u").Replace("Y", "'").Replace("U", "'")
                .Replace("E°", "'").Replace("Ea", "'a").Replace("E", "'a").Replace("°", "");

            if (chkUsarUnion.Checked)
                strAux = strAux.Replace(" l-", "﹍l-");


            // reemplazar el artículo en letras solares (con shadda)
            strAux = strAux.Replace("l-tt", "t-t").Replace("l-ṯṯ", "ṯ-ṯ").Replace("l-dd", "d-d").Replace("l-ḏḏ", "ḏ-ḏ")
                .Replace("l-rr", "r-r").Replace("l-zz", "z-z").Replace("l-ss", "s-s").Replace("l-šš", "š-š")
                .Replace("l-ṣṣ", "ṣ-ṣ").Replace("l-ḍḍ", "ḍ-ḍ").Replace("l-ṭṭ", "ṭ-ṭ").Replace("l-ẓẓ", "ẓ-ẓ")
                .Replace("l-ll", "l-l").Replace("l-nn", "n-n");

            // reemplazar el artículo en letras solares (sin shadda)
            strAux = strAux.Replace("l-t", "t-t").Replace("l-ṯ", "ṯ-ṯ").Replace("l-d", "d-d").Replace("l-ḏ", "ḏ-ḏ")
                .Replace("l-r", "r-r").Replace("l-z", "z-z").Replace("l-s", "s-s").Replace("l-š", "š-š")
                .Replace("l-ṣ", "ṣ-ṣ").Replace("l-ḍ", "ḍ-ḍ").Replace("l-ṭ", "ṭ-ṭ").Replace("l-ẓ", "ẓ-ẓ")
                //.Replace("l-l", "l-l")
                .Replace("l-n", "n-n");

            // reemplazar el artículo inicial en letras solares
            strAux = strAux.Replace("Altt", "'at-t").Replace("Alṯṯ", "'aṯ-ṯ").Replace("Aldd", "'ad-d").Replace("Alḏḏ", "'aḏ-ḏ")
                .Replace("Alrr", "'ar-r").Replace("Alzz", "'az-z").Replace("Alss", "'as-s").Replace("Alšš", "'aš-š")
                .Replace("Alṣṣ", "'aṣ-ṣ").Replace("Alḍḍ", "'aḍ-ḍ").Replace("Alṭṭ", "'aṭ-ṭ").Replace("Alẓẓ", "'aẓ-ẓ")
                .Replace("Alll", "'al-l").Replace("Alnn", "'an-n");

            // reemplazar ta' marbutaʰ  por  ta'
            strAux = strAux.Replace("ʰu", "tu").Replace("ʰi", "ti").Replace("ʰa", "ta");

            // reemplazar lam-alef
            strAux = strAux.Replace("lA", "lā");

            // reemplazar números 
            strAux = strAux.Replace('٠', '0').Replace('١', '1').Replace('٢', '2').Replace('٣', '3').Replace('٤', '4')
                     .Replace('٥', '5').Replace('٦', '6').Replace('٧', '7').Replace('٨', '8').Replace('٩', '9');

            if (optLarga1.Checked)
                strAux = strAux.Replace("ū", "u:").Replace("ī", "i:").Replace("ā", "a:");

            if (optLarga3.Checked)
                strAux = strAux.Replace("ū", "û").Replace("ī", "î").Replace("ā", "â");

            if (chkUsarUnion.Checked)
                strAux = strAux.Replace(" l-", "﹍l-");

            return strAux;
        }

        private string Corregir(string texto)
        {
            string strAux = texto;
            strAux = strAux.Replace("أَا", "آ");
            return strAux;
        }

        private void richTextBox1_FontChanged(object sender, EventArgs e)
        {

        }

        private void lblPalTexto_Click(object sender, EventArgs e)
        {

        }

        private void btnFrase_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            StringBuilder sbTmp = new StringBuilder();

            foreach( string frase in m_Frases )
            {
                sbTmp.AppendLine(frase);
            }
            this.richTextBox1.Text = sbTmp.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            ultChar = ' ';
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tmpChar = e.KeyChar;
            if( tmpChar != ' ' && tmpChar == ultChar) 
                switch(tmpChar)
                { 
                    case 'a': e.KeyChar = (char)0x64B; break; // fahatan
                    case 'u': e.KeyChar = (char)0x64C; break; // dammatan
                    case 'i': e.KeyChar = (char)0x64D; break; // kasratan
                    default: e.KeyChar = (char)0x651; break; // shadda
                }
            else
            switch (tmpChar)
            {
                case 'b': e.KeyChar = 'ب'; break;
                case 't': e.KeyChar = 'ت'; break;
                case 'c': e.KeyChar = 'ث'; break;
                case 'j': e.KeyChar = 'ج'; break;
                case 'H': e.KeyChar = 'ح'; break;
                case 'J': e.KeyChar = 'خ'; break;
                case 'd': e.KeyChar = 'د'; break;
                case 'v': e.KeyChar = 'ذ'; break;
                case 'r': e.KeyChar = 'ر'; break;
                case 'z': e.KeyChar = 'ز'; break;
                case 's': e.KeyChar = 'س'; break;
                case 'x': e.KeyChar = 'ش'; break;
                case 'S': e.KeyChar = 'ص'; break;
                case 'D': e.KeyChar = 'ض'; break;
                case 'T': e.KeyChar = 'ط'; break;
                case 'Z': e.KeyChar = 'ظ'; break;
                case 'ç': e.KeyChar = 'ع'; break;
                case 'g': e.KeyChar = 'غ'; break;
                case 'f': e.KeyChar = 'ف'; break;
                case 'q': e.KeyChar = 'ق'; break;
                case 'k': e.KeyChar = 'ك'; break;
                case 'l': e.KeyChar = 'ل'; break;
                case 'm': e.KeyChar = 'م'; break;
                case 'n': e.KeyChar = 'ن'; break;
                case 'h': e.KeyChar = 'ه'; break;
                case 'w': e.KeyChar = 'و'; break;
                case 'y': e.KeyChar = 'ي'; break;
                case 'A': e.KeyChar = 'ا'; break;
                case 'E': e.KeyChar = 'أ'; break;
                case 'I': e.KeyChar = 'إ'; break;
                case 'Y': e.KeyChar = 'ئ'; break;
                case 'U': e.KeyChar = 'ؤ'; break;
                case '\'': e.KeyChar = 'ء'; break;
                case 'á': e.KeyChar = 'ى'; break;
                case 'p': e.KeyChar = 'ٱ'; break;
                case 'P': e.KeyChar = 'پ'; break;
                case 'V': e.KeyChar = 'ڤ'; break;
                case 'G': e.KeyChar = 'چ'; break;
                case '0': e.KeyChar = '٠'; break;
                case '1': e.KeyChar = '١'; break;
                case '2': e.KeyChar = '٢'; break;
                case '3': e.KeyChar = '٣'; break;
                case '4': e.KeyChar = '٤'; break;
                case '5': e.KeyChar = '٥'; break;
                case '6': e.KeyChar = '٦'; break;
                case '7': e.KeyChar = '٧'; break;
                case '8': e.KeyChar = '٨'; break;
                case '9': e.KeyChar = '٩'; break;
                case ':':
                    {
                        if( ultChar == 'a' ) e.KeyChar = 'ا';
                        if (ultChar == 'i') e.KeyChar = 'ي';
                        if (ultChar == 'u') e.KeyChar = 'و';
                        if (ultChar == 'A') e.KeyChar = 'آ';
                        break; 
                    }
                case 'a': e.KeyChar = (char)0x64E; break; // fatha
                case 'u': e.KeyChar = (char)0x64F; break; // damma
                case 'i': e.KeyChar = (char)0x650; break; // kasra
                case 'o': e.KeyChar = (char)0x652; break; // suku:n
                case 'e': e.KeyChar = (char)0x670; break; // 'alef superíndice
                // case default: e.KeyChar = e.KeyChar;
            }
            ultChar = tmpChar;
        }

        private void optRayaSup_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = Trasliterar(richTextBox1.Text);
        }

        private void optLarga1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = Trasliterar(richTextBox1.Text);
        }

        private void optLarga3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = Trasliterar(richTextBox1.Text);
        }

    }
}
