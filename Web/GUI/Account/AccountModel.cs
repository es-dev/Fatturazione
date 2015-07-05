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

namespace Web.GUI.Account
{
	public partial class AccountModel : TemplateModel
	{
        public AccountModel()
		{
			InitializeComponent();
            try
            {
                InitCombo();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
		}

        private void InitCombo()
        {
            try
            {
                editRuolo.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.TipoAccount>(); 
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
                    var obj = (AccountDto)model;
                    infoSubtitle.Text = BusinessLogic.Account.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.account.png";
                    infoTitle.Text = (obj.Id!=0? "ACCOUNT " + BusinessLogic.Account.GetCodifica(obj): "NUOVO ACCOUNT");
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
                    var obj = (AccountDto)model;
                    editUsername.Value = obj.Username;
                    editNickname.Value = obj.Nickname;
                    editRuolo.Value = obj.Ruolo;
                    editPassword.Value = obj.Password;
                    editAbilitato.Value = obj.Abilitato;
                    editNote.Value = obj.Note;
                    editCreazione.Value = obj.Creazione;

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
                    var obj = (WcfService.Dto.AccountDto)model;
                    obj.Username = editUsername.Value;
                    obj.Nickname = editNickname.Value;
                    obj.Ruolo = editRuolo.Value;
                    obj.Password = editPassword.Value;
                    obj.Abilitato = editAbilitato.Value;
                    obj.Note = editNote.Value;
                    if(obj.Creazione==null)
                        obj.Creazione = editCreazione.Value;

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

        public override void SetNewValue(object model)
        {
            try
            {
                editCreazione.Value = DateTime.Now;
                editAbilitato.Value = true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
   
	}
}
