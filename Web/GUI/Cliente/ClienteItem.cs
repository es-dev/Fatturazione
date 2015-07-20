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

namespace Web.GUI.Cliente
{
	public partial class ClienteItem : TemplateItem
	{
        public ClienteItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (ClienteDto)model;
                    var tipo = UtilityValidation.GetStringND(obj.Tipo);

                   infoImage.Image = "Images.dashboard.committente.png";
                   infoTipo.Text = tipo;

                   var anagraficaCliente = obj.AnagraficaCliente;
                   if (anagraficaCliente != null)
                       infoAnagraficaCliente.Text = anagraficaCliente.RagioneSociale;

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
