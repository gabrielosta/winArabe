using System.Text;
using winArabe;

namespace Tipos
{
   /// <summary>
   /// Tipo de letra: Espacio, Letra, Harakat, Número, etc.
   /// </summary>
    public enum TipoLetra
    {
        Espacio,
        Letra,
        Movimiento,
        Numero,
        Puntuacion,
        Otro
    }

    public enum TipoPalabra 
    { 
        Sustantivo,
        Adjetivo,
        Pronombre,
        Partícula,
        Adverbio,
        Verbo,
        Otro
    }

    public class Raiz
    {
        private char[] _raiz;
        public Raiz(char[] raiz)
        {
            _raiz = raiz;
        }

        public override string ToString()
        {
            string strAux = "";
            foreach (char c in _raiz)
            {
                strAux += c.ToString();
            }
            return strAux;
        }
    }

    public class Palabra
    {
        public Palabra( string texto )
        {
            _texto = texto;
        }

        private string _texto;

        public string texto 
        {
            get { return _texto;  }
        }

        public char[] silabas;
        public Raiz raiz;
        public TipoPalabra tipo;

        public string getTexto(bool conVocales)
        {
            if (conVocales)
                return _texto;
            else
            {
                char[] chars = _texto.ToCharArray();
                Harf harf;
                string strAux = "";

                foreach (char c in chars)
                {
                    if (Program.m_Huruf.TryGetValue((int)c, out harf))
                    {
                        if (harf.Tipo == TipoLetra.Letra)
                            strAux += c.ToString();
                    }
                }
                return strAux;
            }
        }
    }

    public class Harf
    {
        private char _letra;
        private string _nombre;
        private string _translit;
        private TipoLetra _tipo;

        public Harf(char letra, string nombre, string translit, TipoLetra tipo)
        {
            _letra = letra;
            _nombre = nombre;
            _translit = translit;
            _tipo = tipo;
        }

        public char Letra
        {
            get { return _letra; }
            set { _letra=value; }
        }

        public string Nombre 
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Translit
        {
            get { return _translit; }
            set { _translit = value; }
        }

        public TipoLetra Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }

    public class Translit
    {   
        private char _letra;
        private string[] _aTranslit;

        public Translit(char letra, string[] arrTranslit )
        {
            _letra = letra;
            _aTranslit = arrTranslit;
        }
    }
}
