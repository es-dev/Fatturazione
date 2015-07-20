using System.Drawing;

namespace Web.GUI.Cliente
{
    partial class ClienteModel
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
            this.editTipo = new Library.Template.Controls.TemplateEditText();
            this.editAnagraficaCliente = new Library.Template.Controls.TemplateEditCombo();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editAnagraficaCliente);
            this.container.Controls.Add(this.editTipo);
            this.container.Controls.Add(this.editStudioProfessionale);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editStudioProfessionale, 0);
            this.container.Controls.SetChildIndex(this.editTipo, 0);
            this.container.Controls.SetChildIndex(this.editAnagraficaCliente, 0);
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
            // editTipo
            // 
            this.editTipo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTipo.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTipo.BackColor = System.Drawing.Color.Transparent;
            this.editTipo.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTipo.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTipo.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTipo.Changed = true;
            this.editTipo.Editing = false;
            this.editTipo.Label = "Tipo";
            this.editTipo.LabelWidth = 175;
            this.editTipo.Location = new System.Drawing.Point(27, 168);
            this.editTipo.Name = "editTipo";
            this.editTipo.ReadOnly = false;
            this.editTipo.Required = true;
            this.editTipo.Size = new System.Drawing.Size(792, 30);
            this.editTipo.TabIndex = 3;
            this.editTipo.Text = "EditControl";
            this.editTipo.Value = null;
            // 
            // editAnagraficaCliente
            // 
            this.editAnagraficaCliente.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editAnagraficaCliente.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editAnagraficaCliente.BackColor = System.Drawing.Color.Transparent;
            this.editAnagraficaCliente.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editAnagraficaCliente.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editAnagraficaCliente.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editAnagraficaCliente.Changed = true;
            this.editAnagraficaCliente.Editing = false;
            this.editAnagraficaCliente.Label = "Cliente";
            this.editAnagraficaCliente.LabelWidth = 175;
            this.editAnagraficaCliente.Location = new System.Drawing.Point(27, 120);
            this.editAnagraficaCliente.Model = null;
            this.editAnagraficaCliente.Name = "editAnagraficaCliente";
            this.editAnagraficaCliente.ReadOnly = false;
            this.editAnagraficaCliente.Required = true;
            this.editAnagraficaCliente.Size = new System.Drawing.Size(794, 30);
            this.editAnagraficaCliente.TabIndex = 0;
            this.editAnagraficaCliente.Text = "EditControl";
            this.editAnagraficaCliente.Value = null;
            this.editAnagraficaCliente.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editAnagraficaCliente_ComboConfirm);
            this.editAnagraficaCliente.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editAnagraficaCliente_ComboClick);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditCombo editStudioProfessionale;
        private Library.Template.Controls.TemplateEditText editTipo;
        private Library.Template.Controls.TemplateEditCombo editAnagraficaCliente;


    }
}
