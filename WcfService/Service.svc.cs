using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {

        #region StudioProfessionale
        #region CRUD
        public Dto.StudioProfessionaleDto CreateStudioProfessionale(Dto.StudioProfessionaleDto studioProfessionale)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateStudioProfessionale(studioProfessionale);
                var newAStudioProfessionale = wcf.ReadStudioProfessionale(dtoKey);
                return newAStudioProfessionale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.StudioProfessionaleDto> ReadStudiProfessionali()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var studiProfessionali = wcf.ReadStudioProfessionales();
                return studiProfessionali;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateStudioProfessionale(Dto.StudioProfessionaleDto studioProfessionale)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateStudioProfessionale(studioProfessionale);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteStudioProfessionale(Dto.StudioProfessionaleDto studioProfessionale)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteStudioProfessionale(studioProfessionale);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountStudiProfessionali()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.StudioProfessionalesCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.StudioProfessionaleDto> LoadStudiProfessionali(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var studiProfessionali = QueryStudiProfessionali(search, advancedSearch, orderBy);
                studiProfessionali = (from q in studiProfessionali select q).Skip(skip).Take(take);

                var studiProfessionaliDto = UtilityPOCO.Assemble<Dto.StudioProfessionaleDto>(studiProfessionali);
                return studiProfessionaliDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountStudiProfessionali(string search = null, object advancedSearch = null)
        {
            try
            {
                var studiProfessionali = QueryStudiProfessionali(search, advancedSearch);
                var count = studiProfessionali.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.StudioProfessionaleDto ReadStudioProfessionale(object id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = UtilityPOCO.GetDtoKey((int)id);
                var studioProfessionale = wcf.ReadStudioProfessionale(dtoKey);
                return studioProfessionale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.StudioProfessionale> QueryStudiProfessionali(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var studiProfessionali = (from q in ef.StudioProfessionales select q);

                if (search != null && search.Length > 0)
                    studiProfessionali = (from q in studiProfessionali
                               where q.Codice.StartsWith(search) || q.RagioneSociale.Contains(search) || q.Comune.StartsWith(search) || q.Indirizzo.Contains(search) ||
                                   q.Provincia.StartsWith(search)
                               select q);

                if (advancedSearch != null)
                    studiProfessionali = studiProfessionali.Where((Func<DataLayer.StudioProfessionale, bool>)advancedSearch).AsQueryable();

                studiProfessionali = (from q in studiProfessionali orderby q.RagioneSociale select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        studiProfessionali = studiProfessionali.OrderBy((Func<DataLayer.StudioProfessionale, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        studiProfessionali = studiProfessionali.OrderByDescending((Func<DataLayer.StudioProfessionale, object>)orderBy.Value).AsQueryable();
                }
                return studiProfessionali;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region Account
        #region CRUD
        public Dto.AccountDto CreateAccount(Dto.AccountDto account)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateAccount(account);
                var newAccount = wcf.ReadAccount(dtoKey);
                return newAccount;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.AccountDto> ReadAccounts()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var accounts = wcf.ReadAccounts();
                return accounts;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateAccount(Dto.AccountDto account)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateAccount(account);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteAccount(Dto.AccountDto account)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteAccount(account);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountAccounts()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.AccountsCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.AccountDto> LoadAccounts(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var accounts = QueryAccounts(search, advancedSearch, orderBy);
                accounts = (from q in accounts select q).Skip(skip).Take(take);
                var accountsDto = UtilityPOCO.Assemble<Dto.AccountDto>(accounts);
                return accountsDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountAccounts(string search = null, object advancedSearch = null)
        {
            try
            {
                var accounts = QueryAccounts(search, advancedSearch);
                var count = accounts.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.AccountDto ReadAccount(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var account = (from q in ef.Accounts where q.Id == (int)id select q).FirstOrDefault();
                var accountDto = UtilityPOCO.Assemble<Dto.AccountDto>(account);
                return accountDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public Dto.AccountDto AuthenticateAccount(Dto.AccountDto account)
        {
            try
            {
                if (account != null && account.Username != null)
                {
                    var ef = new DataLayer.EntitiesModel();
                    var accountAuthenticated = (from q in ef.Accounts
                                                where q.Username != null && q.Username.ToUpper() == account.Username.ToUpper() &&
                                                    q.Password == account.Password
                                                select q).FirstOrDefault();
                    var accountAuthenticatedDto = UtilityPOCO.Assemble<Dto.AccountDto>(accountAuthenticated);
                    return accountAuthenticatedDto;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Account> QueryAccounts(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var accounts = (from q in ef.Accounts select q);

                if (search != null && search.Length > 0)
                    accounts = (from q in accounts
                                where q.Nickname.StartsWith(search) || q.Username.Contains(search)
                                select q);

                if (advancedSearch != null)
                    accounts = accounts.Where((Func<DataLayer.Account, bool>)advancedSearch).AsQueryable();

                accounts = (from q in accounts orderby q.Username select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        accounts = accounts.OrderBy((Func<DataLayer.Account, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        accounts = accounts.OrderByDescending((Func<DataLayer.Account, object>)orderBy.Value).AsQueryable();
                }
                return accounts;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region Socio
        #region CRUD
        public Dto.SocioDto CreateSocio(Dto.SocioDto socio)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateSocio(socio);
                var newSocio = wcf.ReadSocio(dtoKey);
                return newSocio;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.SocioDto> ReadSoci()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var soci = wcf.ReadSocios();
                return soci;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateSocio(Dto.SocioDto socio)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateSocio(socio);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteSocio(Dto.SocioDto socio)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteSocio(socio);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountSoci()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.SociosCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.SocioDto> LoadSoci(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var soci = QuerySoci(search, advancedSearch, orderBy);
                soci = (from q in soci select q).Skip(skip).Take(take);
                var sociDto = UtilityPOCO.Assemble<Dto.SocioDto>(soci);
                return sociDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountSoci(string search = null, object advancedSearch = null)
        {
            try
            {
                var soci = QuerySoci(search, advancedSearch);
                var count = soci.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.SocioDto ReadSocio(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var socio = (from q in ef.Accounts where q.Id == (int)id select q).FirstOrDefault();
                var socioDto = UtilityPOCO.Assemble<Dto.SocioDto>(socio);
                return socioDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Socio> QuerySoci(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var soci = (from q in ef.Socios select q);

                if (search != null && search.Length > 0)
                    soci = (from q in soci
                                where q.Cognome.StartsWith(search) || q.Nome.Contains(search)
                                select q);

                if (advancedSearch != null)
                    soci = soci.Where((Func<DataLayer.Socio, bool>)advancedSearch).AsQueryable();

                soci = (from q in soci orderby q.Cognome select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        soci = soci.OrderBy((Func<DataLayer.Socio, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        soci = soci.OrderByDescending((Func<DataLayer.Socio, object>)orderBy.Value).AsQueryable();
                }
                return soci;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region AnagraficaCliente
        #region CRUD
        public Dto.AnagraficaClienteDto CreateAnagraficaCliente(Dto.AnagraficaClienteDto anagraficaCliente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateAnagraficaCliente(anagraficaCliente);
                var newAnagraficaCliente = wcf.ReadAnagraficaCliente(dtoKey);
                return newAnagraficaCliente;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.AnagraficaClienteDto> ReadAnagraficheClienti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var anagraficheClienti = wcf.ReadAnagraficaClientes();
                return anagraficheClienti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateAnagraficaCliente(Dto.AnagraficaClienteDto anagraficaCliente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateAnagraficaCliente(anagraficaCliente);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteAnagraficaCliente(Dto.AnagraficaClienteDto anagraficaCliente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteAnagraficaCliente(anagraficaCliente);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountAnagraficheClienti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.AnagraficaClientesCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.AnagraficaClienteDto> LoadAnagraficheClienti(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var anagraficheClienti = QueryAnagraficheClienti(search, advancedSearch, orderBy);
                anagraficheClienti = (from q in anagraficheClienti select q).Skip(skip).Take(take);
                var anagraficheClientiDto = UtilityPOCO.Assemble<Dto.AnagraficaClienteDto>(anagraficheClienti);
                return anagraficheClientiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountAnagraficheClienti(string search = null, object advancedSearch = null)
        {
            try
            {
                var anagraficheClienti = QueryAnagraficheClienti(search, advancedSearch);
                var count = anagraficheClienti.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.AnagraficaClienteDto ReadAnagraficaCliente(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficaCliente = (from q in ef.AnagraficaClientes where q.Id == (int)id select q).FirstOrDefault();
                var anagraficaClienteDto = UtilityPOCO.Assemble<Dto.AnagraficaClienteDto>(anagraficaCliente);
                return anagraficaClienteDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.AnagraficaCliente> QueryAnagraficheClienti(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficheClienti = (from q in ef.AnagraficaClientes select q);

                if (search != null && search.Length > 0)
                    anagraficheClienti = (from q in anagraficheClienti
                            where q.Cognome.StartsWith(search) || q.RagioneSociale.Contains(search)
                            select q);

                if (advancedSearch != null)
                    anagraficheClienti = anagraficheClienti.Where((Func<DataLayer.AnagraficaCliente, bool>)advancedSearch).AsQueryable();

                anagraficheClienti = (from q in anagraficheClienti orderby q.RagioneSociale select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        anagraficheClienti = anagraficheClienti.OrderBy((Func<DataLayer.AnagraficaCliente, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        anagraficheClienti = anagraficheClienti.OrderByDescending((Func<DataLayer.AnagraficaCliente, object>)orderBy.Value).AsQueryable();
                }
                return anagraficheClienti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region Cliente
        #region CRUD
        public Dto.ClienteDto CreateCliente(Dto.ClienteDto cliente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateCliente(cliente);
                var newCliente = wcf.ReadCliente(dtoKey);
                return newCliente;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ClienteDto> ReadClienti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var clienti = wcf.ReadClientes();
                return clienti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateCliente(Dto.ClienteDto cliente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateCliente(cliente);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteCliente(Dto.ClienteDto cliente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteCliente(cliente);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountClienti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ClientesCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.ClienteDto> LoadClienti(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var clienti = QueryClienti(search, advancedSearch, orderBy);
                clienti = (from q in clienti select q).Skip(skip).Take(take);
                var clientiDto = UtilityPOCO.Assemble<Dto.ClienteDto>(clienti);
                return clientiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountClienti(string search = null, object advancedSearch = null)
        {
            try
            {
                var clienti = QueryClienti(search, advancedSearch);
                var count = clienti.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ClienteDto ReadCliente(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var cliente = (from q in ef.Clientes where q.Id == (int)id select q).FirstOrDefault();
                var clienteDto = UtilityPOCO.Assemble<Dto.ClienteDto>(cliente);
                return clienteDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Cliente> QueryClienti(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var clienti = (from q in ef.Clientes select q);

                if (search != null && search.Length > 0)
                    clienti = (from q in clienti
                                          where q.Tipo.StartsWith(search) select q);

                if (advancedSearch != null)
                    clienti = clienti.Where((Func<DataLayer.Cliente, bool>)advancedSearch).AsQueryable();

                clienti = (from q in clienti orderby q.Id select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        clienti = clienti.OrderBy((Func<DataLayer.Cliente, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        clienti = clienti.OrderByDescending((Func<DataLayer.Cliente, object>)orderBy.Value).AsQueryable();
                }
                return clienti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region Incasso
        #region CRUD
        public Dto.IncassoDto CreateIncasso(Dto.IncassoDto incasso)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateIncasso(incasso);
                var newIncasso = wcf.ReadIncasso(dtoKey);
                return newIncasso;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.IncassoDto> ReadIncassi()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var incassi = wcf.ReadIncassos();
                return incassi;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateIncasso(Dto.IncassoDto incasso)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateIncasso(incasso);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteIncasso(Dto.IncassoDto incasso)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteIncasso(incasso);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountIncassi()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.IncassosCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.IncassoDto> LoadIncassi(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var incassi = QueryIncassi(search, advancedSearch, orderBy);
                incassi = (from q in incassi select q).Skip(skip).Take(take);
                var incassiDto = UtilityPOCO.Assemble<Dto.IncassoDto>(incassi);
                return incassiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountIncassi(string search = null, object advancedSearch = null)
        {
            try
            {
                var incassi = QueryIncassi(search, advancedSearch);
                var count = incassi.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.IncassoDto ReadIncasso(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var incasso = (from q in ef.AnagraficaClientes where q.Id == (int)id select q).FirstOrDefault();
                var incassiDto = UtilityPOCO.Assemble<Dto.IncassoDto>(incasso);
                return incassiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Incasso> QueryIncassi(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var incassi = (from q in ef.Incassos select q);

                if (search != null && search.Length > 0)
                    incassi = (from q in incassi
                                          where q.Codice.StartsWith(search) || q.Descrizione.Contains(search)
                                          select q);

                if (advancedSearch != null)
                    incassi = incassi.Where((Func<DataLayer.Incasso, bool>)advancedSearch).AsQueryable();

                incassi = (from q in incassi orderby q.Codice select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        incassi = incassi.OrderBy((Func<DataLayer.Incasso, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        incassi = incassi.OrderByDescending((Func<DataLayer.Incasso, object>)orderBy.Value).AsQueryable();
                }
                return incassi;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region Trasmissione
        #region CRUD
        public Dto.TrasmissioneDto CreateTrasmissione(Dto.TrasmissioneDto trasmissione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateTrasmissione(trasmissione);
                var newTrasmissione = wcf.ReadTrasmissione(dtoKey);
                return newTrasmissione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.TrasmissioneDto> ReadTrasmissioni()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var trasmissioni = wcf.ReadTrasmissiones();
                return trasmissioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateTrasmissione(Dto.TrasmissioneDto trasmissione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateTrasmissione(trasmissione);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteTrasmissione(Dto.TrasmissioneDto trasmissione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteTrasmissione(trasmissione);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountTrasmissioni()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.TrasmissionesCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.TrasmissioneDto> LoadTrasmissioni(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var trasmissioni = QueryTrasmissioni(search, advancedSearch, orderBy);
                trasmissioni = (from q in trasmissioni select q).Skip(skip).Take(take);
                var trasmissioniDto = UtilityPOCO.Assemble<Dto.TrasmissioneDto>(trasmissioni);
                return trasmissioniDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountTrasmissioni(string search = null, object advancedSearch = null)
        {
            try
            {
                var trasmissioni = QueryTrasmissioni(search, advancedSearch);
                var count = trasmissioni.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.TrasmissioneDto ReadTrasmissione(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var trasmissione = (from q in ef.Trasmissiones where q.Id == (int)id select q).FirstOrDefault();
                var trasmissioneDto = UtilityPOCO.Assemble<Dto.TrasmissioneDto>(trasmissione);
                return trasmissioneDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Trasmissione> QueryTrasmissioni(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var trasmissioni = (from q in ef.Trasmissiones select q);

                if (search != null && search.Length > 0)
                    trasmissioni = (from q in trasmissioni
                                          where q.Stato.StartsWith(search) || q.XmlFile.Contains(search)
                                          select q);

                if (advancedSearch != null)
                    trasmissioni = trasmissioni.Where((Func<DataLayer.Trasmissione, bool>)advancedSearch).AsQueryable();

                trasmissioni = (from q in trasmissioni orderby q.Id select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        trasmissioni = trasmissioni.OrderBy((Func<DataLayer.Trasmissione, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        trasmissioni = trasmissioni.OrderByDescending((Func<DataLayer.Trasmissione, object>)orderBy.Value).AsQueryable();
                }
                return trasmissioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion


    }
}
