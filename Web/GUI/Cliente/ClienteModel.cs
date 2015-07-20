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

namespace Web.GUI.Cliente
{
    public partial class ClienteModel : TemplateModel
    {
        public ClienteModel()
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
                    var obj = (ClienteDto)model;
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
                    var obj = (ClienteDto)model;
                    editTipo.Value = obj.Tipo;
                    BindViewAnagraficaCliente(obj.AnagraficaCliente);
                    BindViewStudioProfessionale(obj.StudioProfessionale);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewAnagraficaCliente(AnagraficaClienteDto anagraficaCliente)
        {
            try
            {
                editAnagraficaCliente.Model = anagraficaCliente;
                editAnagraficaCliente.Value = BusinessLogic.AnagraficaCliente.GetCodifica(anagraficaCliente);
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
                    var obj = (WcfService.Dto.ClienteDto)model;
                    obj.Tipo = editTipo.Value;

                    var anagraficaCliente = (WcfService.Dto.AnagraficaClienteDto)editAnagraficaCliente.Model;
                    if (anagraficaCliente != null)
                        obj.AnagraficaClienteId = anagraficaCliente.Id;

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

        private void editAnagraficaCliente_ComboClick()
        {
            try
            {
                var view = new AnagraficaCliente.AnagraficaClienteView();
                view.Title = "SELEZIONA UN CLIENTE IN ANAGRAFICA";
                editAnagraficaCliente.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void editAnagraficaCliente_ComboConfirm(object model)
        {
            try
            {
                var anagraficaCliente = (WcfService.Dto.AnagraficaClienteDto)model;
                BindViewAnagraficaCliente(anagraficaCliente);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}
