using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AnagraficaCliente
    {
        public static string GetCodifica(WcfService.Dto.AnagraficaClienteDto anagraficaCliente)
        {
            try
            {
                if (anagraficaCliente != null)
                {
                    var codifica = anagraficaCliente.Codice + " - " + anagraficaCliente.RagioneSociale;
                    return codifica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}
