using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;
using Web.Code;

namespace Web.GUI.Socio
{
	public partial class SocioItem : TemplateItem
	{
        public SocioItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (SocioDto)model;
                    var cognome = UtilityValidation.GetStringND(obj.Cognome);
                    var nome = UtilityValidation.GetStringND(obj.Nome);
                    var tipoCarica = UtilityValidation.GetStringND(obj.TipoCarica);

                    infoCodice.Text = "SOC-" + obj.Id;
                    infoImage.Image = "Images.dashboard.socio.png";
                    infoCognomeNome.Text = cognome.ToUpper() + " " + nome.ToUpper();
                    infoTipoCarica.Text = tipoCarica;

                    var studioProfessionale = obj.StudioProfessionale;
                    if (studioProfessionale != null)
                        infoStudioProfessionale.Text = "Studio professionale: " + studioProfessionale.RagioneSociale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
