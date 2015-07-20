using BusinessLogic;
using Library.Code;
using Library.Controls;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;
using WcfService.Dto;

namespace Web.GUI.Trasmissione
{
    public partial class TrasmissioneModel : TemplateModel
    {
        public TrasmissioneModel()
        {
            InitializeComponent();
            try
            {
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (TrasmissioneDto)model;
                    //infoSubtitle.Text = BusinessLogic.Account.GetCodifica(obj);
                    //infoSubtitleImage.Image = "Images.dashboard.account.png";
                    //infoTitle.Text = (obj.Id!=0? "ACCOUNT " + BusinessLogic.Account.GetCodifica(obj): "NUOVO ACCOUNT");
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (TrasmissioneDto)model;
                    editStato.Value = obj.Stato;
                    editTrasmissione.Value = obj.Trasmessa;
                    editXMLFile.Value = obj.XmlFile;
                    BindViewFattura(obj.Fattura);
                    BindViewStudioProfessionale(obj.StudioProfessionale);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewFattura(FatturaDto fattura)
        {
            try
            {
                editStudioProfessionale.Model = fattura;
                //editStudioProfessionale.Value = BusinessLogic.Fattura.GetCodifica(studioProfessionale);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

      
        private void BindViewStudioProfessionale(StudioProfessionaleDto studioProfessionale)
        {
            try
            {
                editStudioProfessionale.Model = studioProfessionale;
                editStudioProfessionale.Value = BusinessLogic.StudioProfessionale.GetCodifica(studioProfessionale);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        public override void BindModel(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.TrasmissioneDto)model;
                    obj.Stato = editStato.Value;
                    obj.Trasmessa = editTrasmissione.Value;
                    obj.XmlFile = editXMLFile.Value;

                    var fattura = (WcfService.Dto.FatturaDto)editFattura.Model;
                    if (fattura != null)
                        obj.FatturaId = fattura.Id;

                    var studioProfessionale = (WcfService.Dto.StudioProfessionaleDto)editStudioProfessionale.Model;
                    if (studioProfessionale != null)
                        obj.StudioProfessionaleId = studioProfessionale.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editStudioProfessionale_ComboClick()
        {
            try
            {
                var view = new StudioProfessionale.StudioProfessionaleView();
                view.Title = "SELEZIONA UNO STUDIO PROFESSIONALE";
                editStudioProfessionale.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editStudioProfessionale_ComboConfirm(object model)
        {
            try
            {
                var studioProfessionale = (WcfService.Dto.StudioProfessionaleDto)model;
                BindViewStudioProfessionale(studioProfessionale);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFattura_ComboClick()
        {
            try
            {
                //var view = new Fattura.FatturaView();
                //view.Title = "SELEZIONA UNA FATTURA";
                //editFattura.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void editFattura_ComboConfirm(object model)
        {
            try
            {
                var fattura = (WcfService.Dto.FatturaDto)model;
                BindViewFattura(fattura);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}
