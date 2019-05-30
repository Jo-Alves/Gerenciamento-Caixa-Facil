using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassValidacaoEmail
    {
        public static bool validarEmail(string Email)
        {
            bool validar = false;
            int analisar = Email.IndexOf("@");
            if (analisar > 0)
            {
                if (Email.IndexOf("@", analisar + 1) > 0)
                {
                    return validar;
                }
                int i = Email.IndexOf(".", analisar);
                if (i - 1 > analisar)
                {
                    if (i + 1 < Email.Length)
                    {
                        string r = Email.Substring(i + 1, 1);
                        if (r != ".")
                        {
                            validar = true;
                        }
                    }
                }
            }
            return validar;
        }
    }
}
