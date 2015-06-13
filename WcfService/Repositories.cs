#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace WcfService.Repositories
{
	using Telerik.OpenAccess;
	using DataLayer;
	using System;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.Serialization;

	
	public partial interface IRepository<TEntity>
	{
	    void Add(TEntity entity);
	    void Remove(TEntity entity);
	
	    TEntity Get(ObjectKey objectKey);
	    
	    IQueryable<TEntity> GetAll();
	
	    IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
	}
	
	public partial class Repository<TEntity> : IRepository<TEntity>
	        where TEntity : class
	{
	    protected IUnitOfWork unitOfWork;
	
	    public Repository(IUnitOfWork unitOfWork)
	    {
	        this.unitOfWork = unitOfWork;
	    }
	
	    public void Add(TEntity entity)
	    {
			this.unitOfWork.Add(entity);
	    }
	
	    public void Remove(TEntity entity)
	    {
	        this.unitOfWork.Delete(entity);
	    }
	
	    public IQueryable<TEntity> GetAll()
	    {
	        return this.unitOfWork.GetAll<TEntity>();
	    }
	
	    public TEntity Get(ObjectKey objectKey)
	    {
	        return this.unitOfWork.GetObjectByKey<TEntity>(objectKey);
	    }
	
	    public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
	    {
	        return this.unitOfWork.GetAll<TEntity>().Where(predicate);
	    }
	}
	
	public partial interface IAziendaRepository : IRepository<Azienda>
	{ 
	
	}
	
	public partial class AziendaRepository : Repository<Azienda>, IAziendaRepository
	{
	    public AziendaRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface IClienteRepository : IRepository<Cliente>
	{ 
	
	}
	
	public partial class ClienteRepository : Repository<Cliente>, IClienteRepository
	{
	    public ClienteRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface IFatturaRepository : IRepository<Fattura>
	{ 
	
	}
	
	public partial class FatturaRepository : Repository<Fattura>, IFatturaRepository
	{
	    public FatturaRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface ITrasmissioneRepository : IRepository<Trasmissione>
	{ 
	
	}
	
	public partial class TrasmissioneRepository : Repository<Trasmissione>, ITrasmissioneRepository
	{
	    public TrasmissioneRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface IAnagraficaClienteRepository : IRepository<AnagraficaCliente>
	{ 
	
	}
	
	public partial class AnagraficaClienteRepository : Repository<AnagraficaCliente>, IAnagraficaClienteRepository
	{
	    public AnagraficaClienteRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface IIncassoRepository : IRepository<Incasso>
	{ 
	
	}
	
	public partial class IncassoRepository : Repository<Incasso>, IIncassoRepository
	{
	    public IncassoRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface ISocioRepository : IRepository<Socio>
	{ 
	
	}
	
	public partial class SocioRepository : Repository<Socio>, ISocioRepository
	{
	    public SocioRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface IAnagraficaPARepository : IRepository<AnagraficaPA>
	{ 
	
	}
	
	public partial class AnagraficaPARepository : Repository<AnagraficaPA>, IAnagraficaPARepository
	{
	    public AnagraficaPARepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface IFatturaElettronicaHeaderRepository : IRepository<FatturaElettronicaHeader>
	{ 
	
	}
	
	public partial class FatturaElettronicaHeaderRepository : Repository<FatturaElettronicaHeader>, IFatturaElettronicaHeaderRepository
	{
	    public FatturaElettronicaHeaderRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface IFatturaElettronicaBodyRepository : IRepository<FatturaElettronicaBody>
	{ 
	
	}
	
	public partial class FatturaElettronicaBodyRepository : Repository<FatturaElettronicaBody>, IFatturaElettronicaBodyRepository
	{
	    public FatturaElettronicaBodyRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface IDatiTrasmissioneRepository : IRepository<DatiTrasmissione>
	{ 
	
	}
	
	public partial class DatiTrasmissioneRepository : Repository<DatiTrasmissione>, IDatiTrasmissioneRepository
	{
	    public DatiTrasmissioneRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface IIdFiscaleRepository : IRepository<IdFiscale>
	{ 
	
	}
	
	public partial class IdFiscaleRepository : Repository<IdFiscale>, IIdFiscaleRepository
	{
	    public IdFiscaleRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface IContattiTrasmittenteRepository : IRepository<ContattiTrasmittente>
	{ 
	
	}
	
	public partial class ContattiTrasmittenteRepository : Repository<ContattiTrasmittente>, IContattiTrasmittenteRepository
	{
	    public ContattiTrasmittenteRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface ICedentePrestatoreRepository : IRepository<CedentePrestatore>
	{ 
	
	}
	
	public partial class CedentePrestatoreRepository : Repository<CedentePrestatore>, ICedentePrestatoreRepository
	{
	    public CedentePrestatoreRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface IDatiAnagraficiCedenteRepository : IRepository<DatiAnagraficiCedente>
	{ 
	
	}
	
	public partial class DatiAnagraficiCedenteRepository : Repository<DatiAnagraficiCedente>, IDatiAnagraficiCedenteRepository
	{
	    public DatiAnagraficiCedenteRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface IAnagraficaRepository : IRepository<Anagrafica>
	{ 
	
	}
	
	public partial class AnagraficaRepository : Repository<Anagrafica>, IAnagraficaRepository
	{
	    public AnagraficaRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface ISedeRepository : IRepository<Sede>
	{ 
	
	}
	
	public partial class SedeRepository : Repository<Sede>, ISedeRepository
	{
	    public SedeRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface IIscrizioneREARepository : IRepository<IscrizioneREA>
	{ 
	
	}
	
	public partial class IscrizioneREARepository : Repository<IscrizioneREA>, IIscrizioneREARepository
	{
	    public IscrizioneREARepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface IAccountRepository : IRepository<Account>
	{ 
	
	}
	
	public partial class AccountRepository : Repository<Account>, IAccountRepository
	{
	    public AccountRepository(IEntitiesModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
}
#pragma warning restore 1591
