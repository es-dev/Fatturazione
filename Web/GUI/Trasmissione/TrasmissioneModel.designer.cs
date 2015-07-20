using System.Drawing;

namespace Web.GUI.Trasmissione
{
    partial class TrasmissioneModel
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
            this.editStudioProfessionale = new Library.Template.Controls.TemplateEditCombo();
            this.editStato = new Library.Template.Controls.TemplateEditText();
            this.editFattura = new Library.Template.Controls.TemplateEditCombo();
            this.editXMLFile = new Library.Template.Controls.TemplateEditText();
            this.editTrasmissione = new Library.Template.Controls.TemplateEditDate();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editTrasmissione);
            this.container.Controls.Add(this.editXMLFile);
            this.container.Controls.Add(this.editFattura);
            this.container.Controls.Add(this.editStato);
            this.container.Controls.Add(this.editStudioProfessionale);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editStudioProfessionale, 0);
            this.container.Controls.SetChildIndex(this.editStato, 0);
            this.container.Controls.SetChildIndex(this.editFattura, 0);
            this.container.Controls.SetChildIndex(this.editXMLFile, 0);
            this.container.Controls.SetChildIndex(this.editTrasmissione, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
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
            this.editStudioProfessionale.Location = new System.Drawing.Point(27, 75);
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
            // editStato
            // 
            this.editStato.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editStato.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editStato.BackColor = System.Drawing.Color.Transparent;
            this.editStato.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editStato.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editStato.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editStato.Changed = true;
            this.editStato.Editing = false;
            this.editStato.Label = "Stato";
            this.editStato.LabelWidth = 175;
            this.editStato.Location = new System.Drawing.Point(27, 165);
            this.editStato.Name = "editStato";
            this.editStato.ReadOnly = false;
            this.editStato.Required = true;
            this.editStato.Size = new System.Drawing.Size(794, 30);
            this.editStato.TabIndex = 3;
            this.editStato.Text = "EditControl";
            this.editStato.Value = null;
            // 
            // editFattura
            // 
            this.editFattura.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editFattura.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editFattura.BackColor = System.Drawing.Color.Transparent;
            this.editFattura.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editFattura.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editFattura.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editFattura.Changed = true;
            this.editFattura.Editing = false;
            this.editFattura.Label = "Fattura";
            this.editFattura.LabelWidth = 175;
            this.editFattura.Location = new System.Drawing.Point(27, 120);
            this.editFattura.Model = null;
            this.editFattura.Name = "editFattura";
            this.editFattura.ReadOnly = false;
            this.editFattura.Required = true;
            this.editFattura.Size = new System.Drawing.Size(794, 30);
            this.editFattura.TabIndex = 0;
            this.editFattura.Text = "EditControl";
            this.editFattura.Value = null;
            this.editFattura.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editFattura_ComboConfirm);
            this.editFattura.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editFattura_ComboClick);
            // 
            // editXMLFile
            // 
            this.editXMLFile.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editXMLFile.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editXMLFile.BackColor = System.Drawing.Color.Transparent;
            this.editXMLFile.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editXMLFile.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editXMLFile.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editXMLFile.Changed = true;
            this.editXMLFile.Editing = false;
            this.editXMLFile.Label = "XML file";
            this.editXMLFile.LabelWidth = 175;
            this.editXMLFile.Location = new System.Drawing.Point(27, 255);
            this.editXMLFile.Name = "editXMLFile";
            this.editXMLFile.ReadOnly = false;
            this.editXMLFile.Required = true;
            this.editXMLFile.Size = new System.Drawing.Size(794, 30);
            this.editXMLFile.TabIndex = 3;
            this.editXMLFile.Text = "EditControl";
            this.editXMLFile.Value = null;
            // 
            // editTrasmissione
            // 
            this.editTrasmissione.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTrasmissione.BackColor = System.Drawing.Color.Transparent;
            this.editTrasmissione.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTrasmissione.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTrasmissione.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTrasmissione.Changed = true;
            this.editTrasmissione.Editing = false;
            this.editTrasmissione.Label = "Trasmissione";
            this.editTrasmissione.LabelWidth = 175;
            this.editTrasmissione.Location = new System.Drawing.Point(27, 210);
            this.editTrasmissione.Name = "editTrasmissione";
            this.editTrasmissione.ReadOnly = false;
            this.editTrasmissione.Required = false;
            this.editTrasmissione.Size = new System.Drawing.Size(794, 30);
            this.editTrasmissione.TabIndex = 1000;
            this.editTrasmissione.Value = null;
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditCombo editStudioProfessionale;
        private Library.Template.Controls.TemplateEditText editStato;
        private Library.Template.Controls.TemplateEditCombo editFattura;
        private Library.Template.Controls.TemplateEditDate editTrasmissione;
        private Library.Template.Controls.TemplateEditText editXMLFile;


    }
}
