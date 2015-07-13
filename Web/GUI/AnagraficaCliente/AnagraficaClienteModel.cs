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

namespace Web.GUI.AnagraficaCliente
{
    public partial class AnagraficaClienteModel : TemplateModel
    {
        public AnagraficaClienteModel()
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
                    var obj = (AnagraficaClienteDto)model;
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
                    var obj = (AnagraficaClienteDto)model;
                    editRagioneSociale.Value = obj.RagioneSociale;
                    editCodice.Value = obj.Codice;

                    BindViewStudioProfessionale(obj.StudioProfessionale);
                }
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
                    var obj = (WcfService.Dto.AnagraficaClienteDto)model;
                    obj.RagioneSociale = editRagioneSociale.Value;
                    obj.Codice = editCodice.Value;

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
                var StudioProfessionale = (WcfService.Dto.StudioProfessionaleDto)model;
                BindViewStudioProfessionale(StudioProfessionale);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}
