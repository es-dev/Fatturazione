using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class StudioProfessionale
    {
        public static string GetCodifica(StudioProfessionaleDto studioProfessionale)
        {
            try
            {
                if(studioProfessionale!=null)
                {
                    var codifica = studioProfessionale.Codice + " - " + studioProfessionale.RagioneSociale;
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
