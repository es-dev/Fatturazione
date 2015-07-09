using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.AnagraficaCliente
{
	public partial class AnagraficaClienteView : TemplateView
	{
        public AnagraficaClienteView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                ViewModel = new AnagraficaClienteViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
	}
}
