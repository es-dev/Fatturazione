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
	public partial class Cliente
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
		
		private int _aziendaId;
		public virtual int AziendaId
		{
			get
			{
				return this._aziendaId;
			}
			set
			{
				this._aziendaId = value;
			}
		}
		
		private int _anagraficaClienteId;
		public virtual int AnagraficaClienteId
		{
			get
			{
				return this._anagraficaClienteId;
			}
			set
			{
				this._anagraficaClienteId = value;
			}
		}
		
		private int _anagraficaPAId;
		public virtual int AnagraficaPAId
		{
			get
			{
				return this._anagraficaPAId;
			}
			set
			{
				this._anagraficaPAId = value;
			}
		}
		
		private string _tipo;
		public virtual string Tipo
		{
			get
			{
				return this._tipo;
			}
			set
			{
				this._tipo = value;
			}
		}
		
		private AnagraficaCliente _anagraficaCliente;
		public virtual AnagraficaCliente AnagraficaCliente
		{
			get
			{
				return this._anagraficaCliente;
			}
			set
			{
				this._anagraficaCliente = value;
			}
		}
		
		private AnagraficaPA _anagraficaPA;
		public virtual AnagraficaPA AnagraficaPA
		{
			get
			{
				return this._anagraficaPA;
			}
			set
			{
				this._anagraficaPA = value;
			}
		}
		
		private Azienda _azienda;
		public virtual Azienda Azienda
		{
			get
			{
				return this._azienda;
			}
			set
			{
				this._azienda = value;
			}
		}
		
		private IList<Fattura> _fatturas = new List<Fattura>();
		public virtual IList<Fattura> Fatturas
		{
			get
			{
				return this._fatturas;
			}
		}
		
	}
}
#pragma warning restore 1591
