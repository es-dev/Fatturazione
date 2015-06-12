using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.GUI.Dashboard;
using Library.Template.Dashboard;

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