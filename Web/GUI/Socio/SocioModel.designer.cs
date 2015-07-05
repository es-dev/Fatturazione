using System.Drawing;

namespace Web.GUI.Socio
{
    partial class SocioModel
	{
	        /// <summary>
	        /// Required designer variable.
	        /// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
	        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Visual WebGui Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.editCognome = new Library.Template.Controls.TemplateEditText();
            this.editStudioProfessionale = new Library.Template.Controls.TemplateEditCombo();
            this.editNome = new Library.Template.Controls.TemplateEditText();
            this.editTipoCarica = new Library.Template.Controls.TemplateEditText();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editTipoCarica);
            this.container.Controls.Add(this.editNome);
            this.container.Controls.Add(this.editStudioProfessionale);
            this.container.Controls.Add(this.editCognome);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editCognome, 0);
            this.container.Controls.SetChildIndex(this.editStudioProfessionale, 0);
            this.container.Controls.SetChildIndex(this.editNome, 0);
            this.container.Controls.SetChildIndex(this.editTipoCarica, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // editCognome
            // 
            this.editCognome.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCognome.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCognome.BackColor = System.Drawing.Color.Transparent;
            this.editCognome.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCognome.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCognome.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCognome.Changed = true;
            this.editCognome.Editing = false;
            this.editCognome.Label = "Cognome";
            this.editCognome.LabelWidth = 175;
            this.editCognome.Location = new System.Drawing.Point(25, 122);
            this.editCognome.Name = "editCognome";
            this.editCognome.ReadOnly = false;
            this.editCognome.Required = true;
            this.editCognome.Size = new System.Drawing.Size(792, 30);
            this.editCognome.TabIndex = 1;
            this.editCognome.Text = "EditControl";
            this.editCognome.Value = null;
            // 
            // editStudioProfessionale
            // 
            this.editStudioProfessionale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editStudioProfessionale.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editStudioProfessionale.BackColor = System.Drawing.Color.Transparent;
            this.editStudioProfessionale.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editStudioProfessionale.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editStudioProfessionale.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editStudioProfessionale.Changed = true;
            this.editStudioProfessionale.Editing = false;
            this.editStudioProfessionale.Label = "Studio professionale";
            this.editStudioProfessionale.LabelWidth = 175;
            this.editStudioProfessionale.Location = new System.Drawing.Point(25, 75);
            this.editStudioProfessionale.Model = null;
            this.editStudioProfessionale.Name = "editStudioProfessionale";
            this.editStudioProfessionale.ReadOnly = false;
            this.editStudioProfessionale.Required = true;
            this.editStudioProfessionale.Size = new System.Drawing.Size(794, 30);
            this.editStudioProfessionale.TabIndex = 0;
            this.editStudioProfessionale.Text = "EditControl";
            this.editStudioProfessionale.Value = null;
            this.editStudioProfessionale.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editStudioProfessionale_ComboConfirm);
            this.editStudioProfessionale.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editStudioProfessionale_ComboClick);
            // 
            // editNome
            // 
            this.editNome.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editNome.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editNome.BackColor = System.Drawing.Color.Transparent;
            this.editNome.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editNome.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editNome.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editNome.Changed = true;
            this.editNome.Editing = false;
            this.editNome.Label = "Nome";
            this.editNome.LabelWidth = 175;
            this.editNome.Location = new System.Drawing.Point(25, 168);
            this.editNome.Name = "editNome";
            this.editNome.ReadOnly = false;
            this.editNome.Required = true;
            this.editNome.Size = new System.Drawing.Size(792, 30);
            this.editNome.TabIndex = 3;
            this.editNome.Text = "EditControl";
            this.editNome.Value = null;
            // 
            // editTipoCarica
            // 
            this.editTipoCarica.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTipoCarica.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTipoCarica.BackColor = System.Drawing.Color.Transparent;
            this.editTipoCarica.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTipoCarica.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTipoCarica.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTipoCarica.Changed = true;
            this.editTipoCarica.Editing = false;
            this.editTipoCarica.Label = "Tipo carica";
            this.editTipoCarica.LabelWidth = 175;
            this.editTipoCarica.Location = new System.Drawing.Point(25, 210);
            this.editTipoCarica.Name = "editTipoCarica";
            this.editTipoCarica.ReadOnly = false;
            this.editTipoCarica.Required = true;
            this.editTipoCarica.Size = new System.Drawing.Size(792, 30);
            this.editTipoCarica.TabIndex = 3;
            this.editTipoCarica.Value = null;
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editCognome;
        private Library.Template.Controls.TemplateEditCombo editStudioProfessionale;
        private Library.Template.Controls.TemplateEditText editNome;
        private Library.Template.Controls.TemplateEditText editTipoCarica;


    }
}
