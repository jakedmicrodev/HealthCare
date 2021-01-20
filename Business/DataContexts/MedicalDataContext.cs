using Business.Core;
using Business.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace Business.DataContexts
{
    public class MedicalDataContext : IMedicalDataContext
    {
        #region Create

        public void CreateAccount(Account v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@PayeeId", v.PayeeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Number", v.Number, DbType.String, ParameterDirection.Input, v.Number.Length);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEACCOUNT, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateCity(City v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.CREATECITY, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateClaim(Claim v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@PatientId", v.PatientId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ProviderId", v.ProviderId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ClaimNumber", v.ClaimNumber, DbType.String, ParameterDirection.Input, v.ClaimNumber.Length);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.CREATECLAIM, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateInvoice(Invoice v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@LineItemId", v.LineItemId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PayeeId", v.PayeeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@AccountId", v.AccountId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@InvoiceNumber", v.InvoiceNumber, DbType.String, ParameterDirection.Input, v.InvoiceNumber.Length);
            parameters.Add("@Amount", v.Amount, DbType.Decimal, ParameterDirection.Input);
            parameters.Add("@DueDate", v.DueDate, DbType.DateTime, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEINVOICE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateLineItem(LineItem v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@ClaimId", v.ClaimId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ServiceId", v.ServiceId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ServiceDate", v.ServiceDate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@CopayAmount", v.CopayAmount, DbType.Decimal, ParameterDirection.Input);
            parameters.Add("@OwedAmount", v.OwedAmount, DbType.Decimal, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.CREATELINEITEM, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateMedication(Medication v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEMEDICATION, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreatePatient(Patient v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@FirstName", v.FirstName, DbType.String, ParameterDirection.Input, v.FirstName.Length);
            parameters.Add("@MI", v.MI, DbType.String, ParameterDirection.Input, v.MI.Length);
            parameters.Add("@LastName", v.LastName, DbType.String, ParameterDirection.Input, v.LastName.Length);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEPATIENT, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreatePayee(Payee v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@BusinessName", v.BusinessName, DbType.String, ParameterDirection.Input, v.BusinessName.Length);
            parameters.Add("@FirstName", v.FirstName, DbType.String, ParameterDirection.Input, v.FirstName.Length);
            parameters.Add("@MI", v.MI, DbType.String, ParameterDirection.Input, v.MI.Length);
            parameters.Add("@LastName", v.LastName, DbType.String, ParameterDirection.Input, v.LastName.Length);
            parameters.Add("@TitleId", v.TitleId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Address1", v.Address1, DbType.String, ParameterDirection.Input, v.Address1.Length);
            parameters.Add("@Address2", v.Address2, DbType.String, ParameterDirection.Input, v.Address2.Length);
            parameters.Add("@CityId", v.CityId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@StateId", v.StateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Zip", v.Zip, DbType.String, ParameterDirection.Input, v.Zip.Length);
            parameters.Add("@Phone", v.Phone, DbType.String, ParameterDirection.Input, v.Phone.Length);
            parameters.Add("@ActiveCd", v.ActiveCd, DbType.Boolean, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEPAYEE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreatePrescription(Prescription v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@MedicationId", v.MedicationId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@LineItemId", v.LineItemId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Amount", v.Amount, DbType.Decimal, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEPRESCRIPTION, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateProvider(Provider v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@BusinessName", v.BusinessName, DbType.String, ParameterDirection.Input, v.BusinessName.Length);
            parameters.Add("@FirstName", v.FirstName, DbType.String, ParameterDirection.Input, v.FirstName.Length);
            parameters.Add("@MI", v.MI, DbType.String, ParameterDirection.Input, v.MI.Length);
            parameters.Add("@LastName", v.LastName, DbType.String, ParameterDirection.Input, v.LastName.Length);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@TitleId", v.TitleId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Address1", v.Address1, DbType.String, ParameterDirection.Input, v.Address1.Length);
            parameters.Add("@Address2", v.Address2, DbType.String, ParameterDirection.Input, v.Address2.Length);
            parameters.Add("@CityId", v.CityId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@StateId", v.StateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Zip", v.Zip, DbType.String, ParameterDirection.Input, v.Zip.Length);
            parameters.Add("@Phone", v.Phone, DbType.String, ParameterDirection.Input, v.Phone.Length);
            parameters.Add("@ActiveCd", v.ActiveCd, DbType.Boolean, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEPROVIDER, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateService(Service v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.CREATESERVICE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateState(State v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.CREATESTATE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateTitle(Title v)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.CREATETITLE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region Edit

        public void EditAccount(Account v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PayeeId", v.PayeeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Number", v.Number, DbType.String, ParameterDirection.Input, v.Number.Length);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEACCOUNT, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditCity(City v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATECITY, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditClaim(Claim v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PatientId", v.PatientId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ProviderId", v.ProviderId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ClaimNumber", v.ClaimNumber, DbType.String, ParameterDirection.Input, v.ClaimNumber.Length);

            //var sql = string.Format("{0} @PatientId, @ProviderId, @ClaimNumber", "dbo.CreateClaim");// StoredProcedures.CREATECLAIM);
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATECLAIM, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditInvoice(Invoice v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@LineItemId", v.LineItemId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PayeeId", v.PayeeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@AccountId", v.AccountId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@InvoiceNumber", v.InvoiceNumber, DbType.String, ParameterDirection.Input, v.InvoiceNumber.Length);
            parameters.Add("@Amount", v.Amount, DbType.Decimal, ParameterDirection.Input);
            parameters.Add("@DueDate", v.DueDate, DbType.DateTime, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEINVOICE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditLineItem(LineItem v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ClaimId", v.ClaimId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ServiceId", v.ServiceId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ServiceDate", v.ServiceDate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@CopayAmount", v.CopayAmount, DbType.Decimal, ParameterDirection.Input);
            parameters.Add("@OwedAmount", v.OwedAmount, DbType.Decimal, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATELINEITEM, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditMedication(Medication v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEMEDICATION, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditPatient(Patient v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@FirstName", v.FirstName, DbType.String, ParameterDirection.Input, v.FirstName.Length);
            parameters.Add("@MI", v.MI, DbType.String, ParameterDirection.Input, v.MI.Length);
            parameters.Add("@LastName", v.LastName, DbType.String, ParameterDirection.Input, v.LastName.Length);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEPATIENT, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditPayee(Payee v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@BusinessName", v.BusinessName, DbType.String, ParameterDirection.Input, v.BusinessName.Length);
            parameters.Add("@FirstName", v.FirstName, DbType.String, ParameterDirection.Input, v.FirstName.Length);
            parameters.Add("@MI", v.MI, DbType.String, ParameterDirection.Input, v.MI.Length);
            parameters.Add("@LastName", v.LastName, DbType.String, ParameterDirection.Input, v.LastName.Length);
            parameters.Add("@TitleId", v.TitleId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Address1", v.Address1, DbType.String, ParameterDirection.Input, v.Address1.Length);
            parameters.Add("@Address2", v.Address2, DbType.String, ParameterDirection.Input, v.Address2.Length);
            parameters.Add("@CityId", v.CityId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@StateId", v.StateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Zip", v.Zip, DbType.String, ParameterDirection.Input, v.Zip.Length);
            parameters.Add("@Phone", v.Phone, DbType.String, ParameterDirection.Input, v.Phone.Length);
            parameters.Add("@ActiveCd", v.ActiveCd, DbType.Boolean, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEPAYEE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditPrescription(Prescription v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@MedicationId", v.MedicationId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@LineItemId", v.LineItemId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Amount", v.Amount, DbType.Decimal, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEPRESCRIPTION, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditProvider(Provider v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@BusinessName", v.BusinessName, DbType.String, ParameterDirection.Input, v.BusinessName.Length);
            parameters.Add("@FirstName", v.FirstName, DbType.String, ParameterDirection.Input, v.FirstName.Length);
            parameters.Add("@MI", v.MI, DbType.String, ParameterDirection.Input, v.MI.Length);
            parameters.Add("@LastName", v.LastName, DbType.String, ParameterDirection.Input, v.LastName.Length);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@TitleId", v.TitleId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Address1", v.Address1, DbType.String, ParameterDirection.Input, v.Address1.Length);
            parameters.Add("@Address2", v.Address2, DbType.String, ParameterDirection.Input, v.Address2.Length);
            parameters.Add("@CityId", v.CityId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@StateId", v.StateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Zip", v.Zip, DbType.String, ParameterDirection.Input, v.Zip.Length);
            parameters.Add("@Phone", v.Phone, DbType.String, ParameterDirection.Input, v.Phone.Length);
            parameters.Add("@ActiveCd", v.ActiveCd, DbType.Boolean, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEPROVIDER, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditService(Service v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATESERVICE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditState(State v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATESTATE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditTitle(Title v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATETITLE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region Get

        public Account GetAccount()
        {
            Account a = new Account();
            List<Payee> payees = GetPayees();
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Payee p in payees)
            {
                var payeeName = string.IsNullOrEmpty(p.FullName) ? p.BusinessName : p.FullName;
                l.Add(new SelectListItem { Text = payeeName, Value = p.Id.ToString(), Selected = (p.Id == a.PayeeId) }); ;
            }
            a.Payees = l;

            return a;
        }

        public Account GetAccount(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                Account a = null;
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                a = conn.QueryFirst<Account>(StoredProcedures.GETACCOUNTS + " @Id", parameters);

                List<Payee> payees = GetPayees();
                List<SelectListItem> l = new List<SelectListItem>();

                foreach (Payee p in payees)
                {
                    var payeeName = string.IsNullOrEmpty(p.FullName) ? p.BusinessName : p.FullName;
                    l.Add(new SelectListItem { Text = payeeName, Value = p.Id.ToString(), Selected = (p.Id == a.PayeeId) }); ;
                }
                a.Payees = l;

                return a;
            }
        }

        public List<Account> GetAccounts()
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                return conn.Query<Account>(StoredProcedures.GETACCOUNTS).ToList<Account>();
            }
        }

        public City GetCity(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<City>(StoredProcedures.GETCITIES + " @Id", parameters);
            }
        }

        public List<City> GetCities()
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                return conn.Query<City>(StoredProcedures.GETCITIES).ToList<City>();
            }
        }

        public Claim GetClaim()
        {
            Claim c = new Claim();
            List<Patient> patients = GetPatients();
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Patient p in patients)
            {
                l.Add(new SelectListItem { Text = p.FullName, Value = p.Id.ToString() });
            }
            c.Patients = l;


            List<Provider> providers = GetProviders();
            l = new List<SelectListItem>();

            foreach (Provider p in providers)
            {
                l.Add(new SelectListItem { Text = p.FullName, Value = p.Id.ToString() });
            }
            c.Providers = l;

            return c;
        }

        public Claim GetClaim(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                Claim c = null;
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                c = conn.QueryFirst<Claim>(StoredProcedures.GETCLAIMS + " @Id", parameters);

                List<Patient> patients = GetPatients();
                List<SelectListItem> l = new List<SelectListItem>();

                foreach (Patient p in patients)
                {
                    l.Add(new SelectListItem { Text = p.FullName, Value = p.Id.ToString(), Selected = (p.Id == c.PatientId) }); ;
                }
                c.Patients = l;


                List<Provider> providers = GetProviders();
                l = new List<SelectListItem>();

                foreach (Provider p in providers)
                {
                    l.Add(new SelectListItem { Text = p.FullName, Value = p.Id.ToString(), Selected = (p.Id == c.ProviderId) });
                }
                c.Providers = l;

                return c;
            }
        }

        public List<Claim> GetClaims()
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                return conn.Query<Claim>(StoredProcedures.GETCLAIMS).ToList<Claim>();
            }
        }

        public List<Claim> GetClaims(Claim c)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                var parameters = new DynamicParameters();
                string sql = string.Format(StoredProcedures.GETCLAIMS + " @Id, @PatientId, @ProviderId, @ClaimNumber");

                parameters.Add("@Id", (int?)null, DbType.Int32, ParameterDirection.Input);

                if (c.PatientId > 0)
                {
                    parameters.Add("@PatientId", c.PatientId, DbType.Int32, ParameterDirection.Input);
                }
                else
                {
                    parameters.Add("@PatientId", (int?)null, DbType.Int32, ParameterDirection.Input);
                }

                if (c.ProviderId > 0)
                {
                    parameters.Add("@ProviderId", c.ProviderId, DbType.Int32, ParameterDirection.Input);
                }
                else
                {
                    parameters.Add("@ProviderId", (int?)null, DbType.Int32, ParameterDirection.Input);
                }

                if (!string.IsNullOrEmpty(c.ClaimNumber))
                {
                    parameters.Add("@ClaimNumber", c.ClaimNumber, DbType.String, ParameterDirection.Input);
                }
                else
                {
                    parameters.Add("@ClaimNumber", null, DbType.String, ParameterDirection.Input);
                }

                return conn.Query<Claim>(sql, parameters).ToList<Claim>();
            }
        }

        public List<Claim> GetClaimsByLineItem(ClaimSearch cs)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                var parameters = new DynamicParameters();
                string sql = null;
                var isValid = false;

                if (cs.ServiceId > 0)
                {
                    sql = string.Format(StoredProcedures.GETCLAIMSBYSERVICE + " @ServiceId");
                    parameters.Add("@ServiceId", cs.ServiceId, DbType.Int32, ParameterDirection.Input);
                    isValid = true;
                }
                else if (cs.CopayAmount > 0 || cs.OwedAmount > 0)
                {
                    sql = string.Format(StoredProcedures.GETCLAIMSBYAMOUNT + " @CopayAmount, @OwedAmount");

                    if (cs.CopayAmount > 0)
                    {
                        parameters.Add("@CopayAmount", cs.CopayAmount, DbType.Currency, ParameterDirection.Input);
                        isValid = true;
                    }
                    else
                    {
                        parameters.Add("@CopayAmount", null, DbType.Currency, ParameterDirection.Input);
                    }
                    if (cs.OwedAmount > 0)
                    {
                        parameters.Add("@OwedAmount", cs.OwedAmount, DbType.Currency, ParameterDirection.Input);
                        isValid = true;
                    }
                    else
                    {
                        parameters.Add("@OwedAmount", null, DbType.Currency, ParameterDirection.Input);
                    }
                }
                else if (cs.StartDate != null && cs.EndDate != null)
                {
                    sql = string.Format(StoredProcedures.GETCLAIMSBYSERVICEDATE + " @StartDate, @EndDate");
                    parameters.Add("@StartDate", cs.StartDate, DbType.DateTime, ParameterDirection.Input);
                    parameters.Add("@EndDate", cs.EndDate, DbType.DateTime, ParameterDirection.Input);
                    isValid = true;
                }

                if (!isValid)
                {
                    return null;
                } 
                else
                {
                    return conn.Query<Claim>(sql, parameters).ToList<Claim>();
                }
            }
        }

        public Invoice GetInvoice(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                Invoice i = null;
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                i = conn.QueryFirst<Invoice>(StoredProcedures.GETINVOICES + " @Id", parameters);

                List<Payee> payees = GetPayees();
                List<SelectListItem> l = new List<SelectListItem>();

                foreach (Payee p in payees)
                {
                    l.Add(new SelectListItem { Text = p.BusinessName, Value = p.Id.ToString(), Selected = (p.Id == i.PayeeId) }); ;
                }

                i.Payees = l;

                List<Account> accounts = GetAccounts();
                l = new List<SelectListItem>();

                foreach (Account a in accounts)
                {
                    l.Add(new SelectListItem { Text = a.Number, Value = a.Id.ToString(), Selected = (a.Id == i.AccountId) }); ;
                }

                i.Accounts = l;

                return i;
            }
        }

        public Invoice GetInvoice()
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                Invoice i = new Invoice();

                List<Payee> payees = GetPayees();
                List<SelectListItem> l = new List<SelectListItem>();

                foreach (Payee p in payees)
                {
                    l.Add(new SelectListItem { Text = p.Name, Value = p.Id.ToString() });
                }

                i.Payees = l;

                List<Account> accounts = GetAccounts();
                l = new List<SelectListItem>();

                foreach (Account a in accounts)
                {                    
                    l.Add(new SelectListItem { Text = a.Number, Value = a.Id.ToString() });
                }

                i.Accounts = l;

                List<Service> services = GetServices();
                l = new List<SelectListItem>();

                foreach (Service a in services)
                {
                    l.Add(new SelectListItem { Text = a.Name, Value = a.Id.ToString() });
                }

                i.Services = l;

                return i;
            }
        }

        public List<Invoice> GetInvoices()
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                return conn.Query<Invoice>(StoredProcedures.GETINVOICES).ToList<Invoice>();
            }
        }

        public List<Invoice> GetInvoices(Invoice i)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                var parameters = new DynamicParameters();
                string sql = string.Format(StoredProcedures.GETINVOICES + " @Id, @LineItemId, @PayeeId, @AccountId, @InvoiceNumber, @Amount, @DueDate");

                parameters.Add("@Id", (int?)null, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@LineItemId", (int?)null, DbType.Int32, ParameterDirection.Input);

                if (i.PayeeId > 0)
                {
                    parameters.Add("@PayeeId", i.PayeeId, DbType.Int32, ParameterDirection.Input);
                }
                else
                {
                    parameters.Add("@PayeeId", (int?)null, DbType.Int32, ParameterDirection.Input);
                }

                if (i.AccountId > 0)
                {
                    parameters.Add("@AccountId", i.AccountId, DbType.Int32, ParameterDirection.Input);
                }
                else
                {
                    parameters.Add("@AccountId", (int?)null, DbType.Int32, ParameterDirection.Input);
                }

                if (!string.IsNullOrEmpty(i.InvoiceNumber))
                {
                    parameters.Add("@InvoiceNumber", i.InvoiceNumber, DbType.String, ParameterDirection.Input);
                }
                else
                {
                    parameters.Add("@InvoiceNumber", null, DbType.String, ParameterDirection.Input);
                }

                if(i.Amount > 0)
                {
                    parameters.Add("@Amount", i.Amount, DbType.Currency, ParameterDirection.Input);
                }
                else
                {
                    parameters.Add("@Amount", null, DbType.Currency, ParameterDirection.Input);
                }

                if(i.DueDate.ToShortDateString() != "1/1/0001")
                {
                    parameters.Add("@DueDate", i.DueDate, DbType.DateTime, ParameterDirection.Input);
                }
                else
                {
                    parameters.Add("@DueDate", null, DbType.DateTime, ParameterDirection.Input);
                }

                return conn.Query<Invoice>(sql, parameters).ToList<Invoice>();
            }
        }

        public List<Invoice> GetInvoicesByLineItem(InvoiceSearch s)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                var parameters = new DynamicParameters();
                string sql = null;
                var isValid = false;

                if (!string.IsNullOrEmpty(s.ClaimNumber))
                {
                    parameters.Add("@ClaimNumber", s.ClaimNumber, DbType.String, ParameterDirection.Input);
                    isValid = true;
                }
                else if (s.StartDate != null && s.EndDate != null)
                {
                    sql = string.Format(StoredProcedures.GETCLAIMSBYSERVICEDATE + " @StartDate, @EndDate");
                    parameters.Add("@StartDate", s.StartDate, DbType.DateTime, ParameterDirection.Input);
                    parameters.Add("@EndDate", s.EndDate, DbType.DateTime, ParameterDirection.Input);
                    isValid = true;
                }

                if (!isValid)
                {
                    return null;
                }
                else
                {
                    return conn.Query<Invoice>(sql, parameters).ToList<Invoice>();
                }
            }
        }
         
        public LineItem GetLineItem()
        {
            LineItem li = new LineItem();
            List<Service> services = GetServices();

            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Service s in services)
            {
                l.Add(new SelectListItem { Text = s.Name, Value = s.Id.ToString() });
            }
            li.Services = l;

            return li;
        }

        public LineItem GetLineItem(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                var parameters = new DynamicParameters();
                string sql = string.Format(StoredProcedures.GETLINEITEMS + " @Id, @ClaimId");

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@ClaimId", (int?)null, DbType.Int32, ParameterDirection.Input);
                LineItem li = conn.QueryFirstOrDefault<LineItem>(sql, parameters);

                List<Service> services = GetServices();
                List<SelectListItem> l = new List<SelectListItem>();

                foreach (Service s in services)
                {
                    l.Add(new SelectListItem { Text = s.Name, Value = s.Id.ToString() });
                }
                li.Services = l;

                return li;
            }
        }

        public List<LineItem> GetLineItems(int claimId)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                var parameters = new DynamicParameters();
                string sql = string.Format(StoredProcedures.GETLINEITEMS + " @Id, @ClaimId");

                parameters.Add("@Id", (int?)null, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@ClaimId", claimId, DbType.Int32, ParameterDirection.Input);
                return conn.Query<LineItem>(sql, parameters).ToList<LineItem>();
            }
        }

        public Medication GetMedication(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirstOrDefault<Medication>(StoredProcedures.GETMEDICATIONS, parameters);
            }
        }

        public List<Medication> GetMedications()
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                return conn.Query<Medication>(StoredProcedures.GETMEDICATIONS).ToList<Medication>();
            }
        }

        public Patient GetPatient(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirstOrDefault<Patient>(StoredProcedures.GETPATIENTS, parameters);
            }
        }

        public List<Patient> GetPatients()
        {

            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                return conn.Query<Patient>(StoredProcedures.GETPATIENTS).ToList<Patient>();
            }
        }

        public Payee GetPayee()
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                Payee p = new Payee();
                var parameters = new DynamicParameters();

                List<City> cities = GetCities();
                List<SelectListItem> l = new List<SelectListItem>();

                foreach (City c in cities)
                {
                    l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString() }); ;
                }

                p.Cities = l;

                List<State> states = GetStates();
                l = new List<SelectListItem>();

                foreach (State s in states)
                {
                    l.Add(new SelectListItem { Text = s.Name, Value = s.Id.ToString() }); ;
                }

                p.States = l;


                List<Title> titles = GetTitles();
                l = new List<SelectListItem>();

                foreach (Title t in titles)
                {
                    l.Add(new SelectListItem { Text = t.Name, Value = t.Id.ToString(), Selected = (t.Id == p.TitleId) }); ;
                }

                p.Titles = l;

                return p;
            }
        }

        public Payee GetPayee(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                Payee p = null;
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                p = conn.QueryFirst<Payee>(StoredProcedures.GETPAYEES + " @Id", parameters);

                List<City> cities = GetCities();
                List<SelectListItem> l = new List<SelectListItem>();

                foreach (City c in cities)
                {
                    l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString(), Selected = (c.Id == p.CityId) }); ;
                }

                p.Cities = l;

                List<State> states = GetStates();
                l = new List<SelectListItem>();

                foreach (State s in states)
                {
                    l.Add(new SelectListItem { Text = s.Name, Value = s.Id.ToString(), Selected = (s.Id == p.StateId) }); ;
                }

                p.States = l;


                List<Title> titles = GetTitles();
                l = new List<SelectListItem>();

                foreach (Title t in titles)
                {
                    l.Add(new SelectListItem { Text = t.Name, Value = t.Id.ToString(), Selected = (t.Id == p.TitleId) }); ;
                }

                p.Titles = l;

                return p;
            }
        }

        public List<Payee> GetPayees()
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                return conn.Query<Payee>(StoredProcedures.GETPAYEES).ToList<Payee>();
            }
        }

        public Prescription GetPrescription()
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                Prescription p = new Prescription();
                List<Medication> medications = GetMedications();
                List<SelectListItem> l = new List<SelectListItem>();

                foreach (Medication m in medications)
                {
                    l.Add(new SelectListItem { Text = m.Name, Value = m.Id.ToString(), Selected = (m.Id == p.MedicationId) }); ;
                }

                p.Medications = l;

                return p;
            }
        }

        public Prescription GetPrescription(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                Prescription p = null;
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                p = conn.QueryFirstOrDefault<Prescription>(StoredProcedures.GETPRESCRIPTIONS + " @Id", parameters);

                List<Medication> medications = GetMedications();
                List<SelectListItem> l = new List<SelectListItem>();

                foreach (Medication m in medications)
                {
                    l.Add(new SelectListItem { Text = m.Name, Value = m.Id.ToString(), Selected = (m.Id == p.MedicationId) }); ;
                }

                p.Medications = l;

                return p;
            }
        }

        public List<Prescription> GetPrescriptions()
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                return conn.Query<Prescription>(StoredProcedures.GETPRESCRIPTIONS).ToList<Prescription>();
            }
        }

        public List<Prescription> GetPrescriptions(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                var parameters = new DynamicParameters();
                var sql = string.Format("{0} {1}", StoredProcedures.GETPRESCRIPTIONS, "@Id, @LineItemId");

                parameters.Add("@Id", null, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@LineItemId", Id, DbType.Int32, ParameterDirection.Input);
                return conn.Query<Prescription>(sql, parameters).ToList<Prescription>();
            }
        }

        public Provider GetProvider()
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                Provider p = new Provider();

                List<City> cities = GetCities();
                List<SelectListItem> l = new List<SelectListItem>();

                foreach (City c in cities)
                {
                    l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString() }); ;
                }

                p.Cities = l;

                List<State> states = GetStates();
                l = new List<SelectListItem>();

                foreach (State s in states)
                {
                    l.Add(new SelectListItem { Text = s.Name, Value = s.Id.ToString() }); ;
                }

                p.States = l;


                List<Title> titles = GetTitles();
                l = new List<SelectListItem>();

                foreach (Title t in titles)
                {
                    l.Add(new SelectListItem { Text = t.Name, Value = t.Id.ToString() }); ;
                }

                p.Titles = l;

                return p;
            }
        }

        public Provider GetProvider(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                Provider p = null;
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                p = conn.QueryFirstOrDefault<Provider>(StoredProcedures.GETPROVIDERS + " @Id", parameters);


                List<City> cities = GetCities();
                List<SelectListItem> l = new List<SelectListItem>();

                foreach (City c in cities)
                {
                    l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString(), Selected = (c.Id == p.CityId) }); ;
                }

                p.Cities = l;

                List<State> states = GetStates();
                l = new List<SelectListItem>();

                foreach (State s in states)
                {
                    l.Add(new SelectListItem { Text = s.Name, Value = s.Id.ToString(), Selected = (s.Id == p.StateId) }); ;
                }

                p.States = l;


                List<Title> titles = GetTitles();
                l = new List<SelectListItem>();

                foreach (Title t in titles)
                {
                    l.Add(new SelectListItem { Text = t.Name, Value = t.Id.ToString(), Selected = (t.Id == p.TitleId) }); ;
                }

                p.Titles = l;

                return p;
            }
        }

        public List<Provider> GetProviders()
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                return conn.Query<Provider>(StoredProcedures.GETPROVIDERS).ToList<Provider>();
            }
        }

        public Service GetService(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirstOrDefault<Service>(StoredProcedures.GETSERVICES + " @Id", parameters);
            }
        }

        public List<Service> GetServices()
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                return conn.Query<Service>(StoredProcedures.GETSERVICES).ToList<Service>();
            }
        }

        public State GetState(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<State>(StoredProcedures.GETSTATES + " @Id", parameters);
            }
        }

        public List<State> GetStates()
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                return conn.Query<State>(StoredProcedures.GETSTATES).ToList<State>();
            }
        }

        public Title GetTitle(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirstOrDefault<Title>(StoredProcedures.GETTITLES + " @Id", parameters);
            }
        }

        public List<Title> GetTitles()
        {
            using (IDbConnection conn = new SqlConnection(Settings.MedicalConnectionString))
            {
                return conn.Query<Title>(StoredProcedures.GETTITLES).ToList<Title>();
            }
        }

        #endregion

    }
}