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

    }
}
