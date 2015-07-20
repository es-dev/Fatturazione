using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Cliente
{
	public partial class ClienteView : TemplateView
	{
        public ClienteView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                ViewModel = new ClienteViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
	}
}
