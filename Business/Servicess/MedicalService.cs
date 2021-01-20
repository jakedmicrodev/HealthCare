using Business.DataContexts;
using Business.Entities;
using System.Collections.Generic;

namespace Business.Servicess
{
    public class MedicalService
    {

        #region Create

        public void CreateAccount(Account a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.CreateAccount(a) ;
        }

        public void CreateCity(City a)
        {
            IMedicalDataContext m = new MedicalDataContext();
            m.CreateCity(a);
        }

        public void CreateClaim(Claim a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.CreateClaim(a);
        }

        public void CreateInvoice(Invoice a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.CreateInvoice(a);
        }

        public void CreateLineItem(LineItem a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.CreateLineItem(a);
        }

        public void CreateMedication(Medication a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.CreateMedication(a);
        }

        public void CreatePatient(Patient a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.CreatePatient(a);
        }

        public void CreatePayee(Payee a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.CreatePayee(a);
        }

        public void CreatePrescription(Prescription a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.CreatePrescription(a);
        }

        public void CreateProvider(Provider a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.CreateProvider(a);
        }

        public void CreateService(Service a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.CreateService(a);
        }

        public void CreateState(State a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.CreateState(a);
        }

        public void CreateTitle(Title a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.CreateTitle(a);
        }

        #endregion

        #region Edit

        public void EditAccount(Account a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.EditAccount(a);
        }

        public void EditCity(City a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.EditCity(a);
        }

        public void EditClaim(Claim a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.EditClaim(a);
        }

        public void EditInvoice(Invoice a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.EditInvoice(a);
        }

        public void EditLineItem(LineItem a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.EditLineItem(a);
        }

        public void EditMedication(Medication a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.EditMedication(a);
        }

        public void EditPatient(Patient a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.EditPatient(a);
        }

        public void EditPayee(Payee a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.EditPayee(a);
        }

        public void EditPrescription(Prescription a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.EditPrescription(a);
        }

        public void EditProvider(Provider a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.EditProvider(a);
        }

        public void EditService(Service a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.EditService(a);
        }

        public void EditState(State a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.EditState(a);
        }

        public void EditTitle(Title a)
        {
            MedicalDataContext m = new MedicalDataContext();
            m.EditTitle(a);
        }

        #endregion

        #region Get

        public Account GetAccount()
        {
            return new MedicalDataContext().GetAccount();
        }

        public Account GetAccount(int Id)
        {
            return new MedicalDataContext().GetAccount(Id);
        }

        public List<Account> GetAccounts()
        {
            return new MedicalDataContext().GetAccounts();
        }

        public City GetCity(int Id)
        {
            return new MedicalDataContext().GetCity(Id);
        }

        public List<City> GetCities()
        {
            return new MedicalDataContext().GetCities();
        }

        public Claim GetClaim()
        {
            return new MedicalDataContext().GetClaim();
        }

        public Claim GetClaim(int Id)
        {
            return new MedicalDataContext().GetClaim(Id);
        }

        public List<Claim> GetClaims()
        {
            return new MedicalDataContext().GetClaims();
        }

        public List<Claim> GetClaims(Claim c)
        {
            return new MedicalDataContext().GetClaims(c);
        }

        public List<Claim> GetClaimsByLineItem(ClaimSearch cs)
        {
            return new MedicalDataContext().GetClaimsByLineItem(cs);
        }

        public Invoice GetInvoice()
        {
            return new MedicalDataContext().GetInvoice();
        }

        public Invoice GetInvoice(int Id)
        {
            return new MedicalDataContext().GetInvoice(Id);
        }

        public List<Invoice> GetInvoices()
        {
            return new MedicalDataContext().GetInvoices();
        }

        public List<Invoice> GetInvoices(Invoice i)
        {
            return new MedicalDataContext().GetInvoices(i);
        }

        public LineItem GetLineItem()
        {
            return new MedicalDataContext().GetLineItem();
        }

        public LineItem GetLineItem(int Id)
        {
            return new MedicalDataContext().GetLineItem(Id);
        }

        public List<LineItem> GetLineItems(int claimId)
        {
            return new MedicalDataContext().GetLineItems(claimId);
        }

        public Medication GetMedication(int Id)
        {
            return new MedicalDataContext().GetMedication(Id);
        }

        public List<Medication> GetMedications()
        {
            return new MedicalDataContext().GetMedications();
        }

        public Patient GetPatient(int Id)
        {
            return new MedicalDataContext().GetPatient(Id);
        }

        public List<Patient> GetPatients()
        {
            return new MedicalDataContext().GetPatients();
        }

        public Payee GetPayee()
        {
            return new MedicalDataContext().GetPayee();
        }

        public Payee GetPayee(int Id)
        {
            return new MedicalDataContext().GetPayee(Id);
        }

        public List<Payee> GetPayees()
        {
            return new MedicalDataContext().GetPayees();
        }

        public Prescription GetPrescription()
        {
            return new MedicalDataContext().GetPrescription();
        }

        public Prescription GetPrescription(int Id)
        {
            return new MedicalDataContext().GetPrescription(Id);
        }

        public List<Prescription> GetPrescriptions()
        {
            return new MedicalDataContext().GetPrescriptions();
        }

        public List<Prescription> GetPrescriptions(int LineItemId)
        {
            return new MedicalDataContext().GetPrescriptions(LineItemId);
        }

        public Provider GetProvider()
        {
            return new MedicalDataContext().GetProvider();
        }

        public Provider GetProvider(int Id)
        {
            return new MedicalDataContext().GetProvider(Id);
        }

        public List<Provider> GetProviders()
        {
            return new MedicalDataContext().GetProviders();
        }

        public Service GetService(int Id)
        {
            return new MedicalDataContext().GetService(Id);
        }

        public List<Service> GetServices()
        {
            return new MedicalDataContext().GetServices();
        }

        public State GetState(int Id)
        {
            return new MedicalDataContext().GetState(Id);
        }

        public List<State> GetStates()
        {
            return new MedicalDataContext().GetStates();
        }

        public Title GetTitle(int Id)
        {
            return new MedicalDataContext().GetTitle(Id);
        }

        public List<Title> GetTitles()
        {
            return new MedicalDataContext().GetTitles();
        }

        #endregion

    }
}