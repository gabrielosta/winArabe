using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tipos;
using System.Threading;

namespace winArabe
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CargarHuruf();

            // Application.Run(new Form1());
            var hebra1 = new Thread(lanzarForm1);
            var hebra2 = new Thread(lanzarForm2);
            hebra1.Start();
            hebra2.Start();
        }

        private static void lanzarForm1()
        {
            Application.Run(new Form1());
        }

        private static void lanzarForm2()
        {
            Application.Run(new Form2()); 
        }

        public static Dictionary<int, Harf> m_Huruf;

       /// <summary>
       /// Carga el diccionario de letras árabes (huruf)
       /// </summary>
        private static void CargarHuruf()
        {
            Program.m_Huruf = new Dictionary<int, Tipos.Harf>();

            Program.m_Huruf.Add(32, new Tipos.Harf(' ', "espacio", " ", TipoLetra.Espacio));

            // números latinos
            Program.m_Huruf.Add(48, new Tipos.Harf('0', "صِفْر", "0", TipoLetra.Numero));
            Program.m_Huruf.Add(49, new Tipos.Harf('1', "وَاحِد", "1", TipoLetra.Numero));
            Program.m_Huruf.Add(50, new Tipos.Harf('2', "إثْنَانِ", "2", TipoLetra.Numero));
            Program.m_Huruf.Add(51, new Tipos.Harf('3', "ثَلاثَة", "3", TipoLetra.Numero));
            Program.m_Huruf.Add(52, new Tipos.Harf('4', "أرْبَعَة", "4", TipoLetra.Numero));
            Program.m_Huruf.Add(53, new Tipos.Harf('5', "خَمسَة", "5", TipoLetra.Numero));
            Program.m_Huruf.Add(54, new Tipos.Harf('6', "سِتَّة", "6", TipoLetra.Numero));
            Program.m_Huruf.Add(55, new Tipos.Harf('7', "سَبْعًة", "7", TipoLetra.Numero));
            Program.m_Huruf.Add(56, new Tipos.Harf('8', "ثَمَانِيَة", "8", TipoLetra.Numero));
            Program.m_Huruf.Add(57, new Tipos.Harf('9', "تِسْعُة", "9", TipoLetra.Numero));

            // números árabes
            Program.m_Huruf.Add(1632, new Tipos.Harf('٠', "صِفْر", "0", TipoLetra.Numero));
            Program.m_Huruf.Add(1633, new Tipos.Harf('١', "وَاحِد", "1", TipoLetra.Numero));
            Program.m_Huruf.Add(1634, new Tipos.Harf('٢', "إثْنَانِ", "2", TipoLetra.Numero));
            Program.m_Huruf.Add(1635, new Tipos.Harf('٣', "ثَلاثَة", "3", TipoLetra.Numero));
            Program.m_Huruf.Add(1636, new Tipos.Harf('٤', "أرْبَعَة", "4", TipoLetra.Numero));
            Program.m_Huruf.Add(1637, new Tipos.Harf('٥', "خَمسَة", "5", TipoLetra.Numero));
            Program.m_Huruf.Add(1638, new Tipos.Harf('٦', "سِتَّة", "6", TipoLetra.Numero));
            Program.m_Huruf.Add(1639, new Tipos.Harf('٧', "سَبْعًة", "7", TipoLetra.Numero));
            Program.m_Huruf.Add(1640, new Tipos.Harf('٨', "ثَمَانِيَة", "8", TipoLetra.Numero));
            Program.m_Huruf.Add(1641, new Tipos.Harf('٩', "تِسْعُة", "9", TipoLetra.Numero));

            Program.m_Huruf.Add(1575, new Tipos.Harf('ا', "ألِف", "A", TipoLetra.Letra));
            Program.m_Huruf.Add(1576, new Tipos.Harf('ب', "بَاء", "b", TipoLetra.Letra));
            Program.m_Huruf.Add(1578, new Tipos.Harf('ت', "تَاء", "t", TipoLetra.Letra));
            Program.m_Huruf.Add(1579, new Tipos.Harf('ث', "ثَاء", "ṯ", TipoLetra.Letra));
            Program.m_Huruf.Add(1580, new Tipos.Harf('ج', "جِيْم", "ŷ", TipoLetra.Letra));
            //Program.m_Huruf.Add(1580, new Tipos.Harf('ج', "جِيْم", "ĝ", TipoLetra.Letra));
            Program.m_Huruf.Add(1581, new Tipos.Harf('ح', "حَاء", "ḥ", TipoLetra.Letra));
            Program.m_Huruf.Add(1582, new Tipos.Harf('خ', "خَاء", "j", TipoLetra.Letra));
            Program.m_Huruf.Add(1583, new Tipos.Harf('د', "دَال", "d", TipoLetra.Letra));
            Program.m_Huruf.Add(1584, new Tipos.Harf('ذ', "ذَال", "ḏ", TipoLetra.Letra));
            Program.m_Huruf.Add(1585, new Tipos.Harf('ر', "رَاء", "r", TipoLetra.Letra));
            Program.m_Huruf.Add(1586, new Tipos.Harf('ز', "زَاي", "z", TipoLetra.Letra));
            Program.m_Huruf.Add(1587, new Tipos.Harf('س', "سِيْن", "s", TipoLetra.Letra));
            Program.m_Huruf.Add(1588, new Tipos.Harf('ش', "شِيْن", "š", TipoLetra.Letra));
            Program.m_Huruf.Add(1589, new Tipos.Harf('ص', "صَاد", "ṣ", TipoLetra.Letra));
            Program.m_Huruf.Add(1590, new Tipos.Harf('ض', "ضَاد", "ḍ", TipoLetra.Letra));
            Program.m_Huruf.Add(1591, new Tipos.Harf('ط', "طَاء", "ṭ", TipoLetra.Letra));
            Program.m_Huruf.Add(1592, new Tipos.Harf('ظ', "ظَاء", "ẓ", TipoLetra.Letra));
            Program.m_Huruf.Add(1593, new Tipos.Harf('ع', "عَيْن", "ʕ", TipoLetra.Letra));
            Program.m_Huruf.Add(1594, new Tipos.Harf('غ', "غَيْن", "ḡ", TipoLetra.Letra));

            Program.m_Huruf.Add(1601, new Tipos.Harf('ف', "فَاء", "f", TipoLetra.Letra));
            Program.m_Huruf.Add(1602, new Tipos.Harf('ق', "قَاف", "q", TipoLetra.Letra));
            Program.m_Huruf.Add(1603, new Tipos.Harf('ك', "كَاف", "k", TipoLetra.Letra));
            Program.m_Huruf.Add(1604, new Tipos.Harf('ل', "لام", "l", TipoLetra.Letra));
            Program.m_Huruf.Add(1605, new Tipos.Harf('م', "مِيْم", "m", TipoLetra.Letra));
            Program.m_Huruf.Add(1606, new Tipos.Harf('ن', "نُوْن", "n", TipoLetra.Letra));
            Program.m_Huruf.Add(1607, new Tipos.Harf('ه', "هَاء", "h", TipoLetra.Letra));
            Program.m_Huruf.Add(1608, new Tipos.Harf('و', "وَاو", "w", TipoLetra.Letra));
            Program.m_Huruf.Add(1610, new Tipos.Harf('ي', "يَاء", "y", TipoLetra.Letra));

            // Program.m_Huruf.Add(1577, new Tipos.Harf('ة', "تَاء مَرْبُوْطَة", "ħ", TipoLetra.Letra));
            Program.m_Huruf.Add(1577, new Tipos.Harf('ة', "تَاء مَرْبُوْطَة", "ʰ", TipoLetra.Letra));
            Program.m_Huruf.Add(1609, new Tipos.Harf('ى', "ألِف مَقْصُوْرَة", "à", TipoLetra.Letra));

            // Movimientos (declinaciones)
            Program.m_Huruf.Add(1611, new Tipos.Harf(Convert.ToChar(1611), "فتحة", "-an", TipoLetra.Movimiento));
            Program.m_Huruf.Add(1612, new Tipos.Harf(Convert.ToChar(1612), "ضمّة", "-un", TipoLetra.Movimiento));
            Program.m_Huruf.Add(1613, new Tipos.Harf(Convert.ToChar(1613), "كسرة", "-in", TipoLetra.Movimiento));
            Program.m_Huruf.Add(1614, new Tipos.Harf(Convert.ToChar(1614), "فتحة", "a", TipoLetra.Movimiento));
            Program.m_Huruf.Add(1615, new Tipos.Harf(Convert.ToChar(1615), "ضمّة", "u", TipoLetra.Movimiento));
            Program.m_Huruf.Add(1616, new Tipos.Harf(Convert.ToChar(1616), "كسرة", "i", TipoLetra.Movimiento));
            Program.m_Huruf.Add(1617, new Tipos.Harf(Convert.ToChar(1615), "شدّة", "_", TipoLetra.Movimiento));
            Program.m_Huruf.Add(1618, new Tipos.Harf(Convert.ToChar(1616), "سكون", "°", TipoLetra.Movimiento));

            // Signos de puntuación
            Program.m_Huruf.Add(0x60C, new Tipos.Harf('،', "فَصْلِ", ",", TipoLetra.Puntuacion));
            Program.m_Huruf.Add(0x61B, new Tipos.Harf('؛', "", ";", TipoLetra.Puntuacion));
            Program.m_Huruf.Add(0x61F, new Tipos.Harf('؟', "عَلامَة الإسْتِفْهَام", "?", TipoLetra.Puntuacion));

            Program.m_Huruf.Add(0x621, new Tipos.Harf('ء', "هَمْزَة", "'", TipoLetra.Letra));
            Program.m_Huruf.Add(0x622, new Tipos.Harf('آ', "ألِف مَدَّة", "'a:", TipoLetra.Letra));

            Program.m_Huruf.Add(0x623, new Tipos.Harf('أ', "ألِف هَمْزَة", "E", TipoLetra.Otro));
            Program.m_Huruf.Add(0x624, new Tipos.Harf('ؤ', "واو هَمْزَة", "U", TipoLetra.Otro));
            Program.m_Huruf.Add(0x625, new Tipos.Harf('إ', "ألِف هَمْزَة", "I", TipoLetra.Otro));
            Program.m_Huruf.Add(0x626, new Tipos.Harf('ئ', "ياء هَمْزَة", "Y", TipoLetra.Otro));

            Program.m_Huruf.Add(1648, new Tipos.Harf('ٰ', "", "á", TipoLetra.Letra));
            Program.m_Huruf.Add(1649, new Tipos.Harf('ٱ', "ألِف وَصْلَة", "", TipoLetra.Otro));
        }

    }
}
