using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.GUI.Dashboard;
using Library.Template.Dashboard;
using Web.GUI.Account;
using Web.GUI.StudioProfessionale;

namespace Web.GUI.Dashboard
{
    public class DashboardViewModel: TemplateViewModel<DashboardDto, DashboardItem>
    {

        public DashboardViewModel() : base() 
        {

        }
       
        public override IQueryable<DashboardDto> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardDto>();
                var dashboardStudioProfessionale = new DashboardDto("STUDIO PROFESSIONALE", "SP", "Definisci il tuo studio professionale, inserisci il logo aziendale, l'intestazione e i dati commerciali...", "Images.dashboard.azienda.png", "", typeof(StudioProfessionaleView));
                var dashboardAccount = new DashboardDto("Accounts", "ACC", "Definisci gli accounts specificando le credenziali di accesso ed il ruolo ad associato ai vari operatori che avranno accesso al sistema...", "Images.dashboard.account.png", "", typeof(AccountView));
                var dashboardFatturazioni = new DashboardDto("Fatturazioni", "FA", "Inserisci le fatture di acquisto, di vendita e le note di credito per le tue commesse. Potrai verificare lo stato della fatturazione in dare/avere e analizzare in qualunque momento la contabilità aziendle...", "Images.dashboard.fatturazioni.png", "", null, false);

                dashboards.Add(dashboardFatturazioni);

                var query = dashboards.AsQueryable();
                return query;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}