using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Socio
{
	public partial class SocioView : TemplateView
	{
        public SocioView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                ViewModel = new SocioViewModel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
	}
}
