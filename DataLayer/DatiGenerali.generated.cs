#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using DataLayer;

namespace DataLayer	
{
	public partial class DatiGenerali
	{
		private int _id;
		public virtual int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		private FatturaElettronicaBody _fatturaElettronicaBody;
		public virtual FatturaElettronicaBody FatturaElettronicaBody
		{
			get
			{
				return this._fatturaElettronicaBody;
			}
			set
			{
				this._fatturaElettronicaBody = value;
			}
		}
		
		private IList<DatiPagamento> _datiPagamentos = new List<DatiPagamento>();
		public virtual IList<DatiPagamento> DatiPagamentos
		{
			get
			{
				return this._datiPagamentos;
			}
		}
		
		private DatiGeneraliDocumento _datiGeneraliDocumento;
		public virtual DatiGeneraliDocumento DatiGeneraliDocumento
		{
			get
			{
				return this._datiGeneraliDocumento;
			}
			set
			{
				this._datiGeneraliDocumento = value;
			}
		}
		
		private DatiBeniServizi _datiBeniServizi;
		public virtual DatiBeniServizi DatiBeniServizi
		{
			get
			{
				return this._datiBeniServizi;
			}
			set
			{
				this._datiBeniServizi = value;
			}
		}
		
	}
}
#pragma warning restore 1591
