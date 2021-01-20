using Business.Entities;
using System.Collections.Generic;

namespace Business.DataContexts
{
    public interface IMedicalDataContext
    {

        #region Create

        void CreateAccount(Account v);
        void CreateCity(City v);
        void CreateClaim(Claim v);
        void CreateInvoice(Invoice v);
        void CreateLineItem(LineItem v);
        void CreateMedication(Medication v);
        void CreatePatient(Patient v);
        void CreatePayee(Payee v);
        void CreatePrescription(Prescription v);
        void CreateProvider(Provider v);
        void CreateService(Service v);
        void CreateState(State v);
        void CreateTitle(Title v);

        #endregion

        #region Edit

        void EditAccount(Account v);
        void EditCity(City v);
        void EditClaim(Claim v);
        void EditInvoice(Invoice v);
        void EditLineItem(LineItem v);
        void EditMedication(Medication v);
        void EditPatient(Patient v);
        void EditPayee(Payee v);
        void EditPrescription(Prescription v);
        void EditProvider(Provider v);
        void EditService(Service v);
        void EditState(State v);
        void EditTitle(Title v);

        #endregion

        #region Get

        Account GetAccount(int Id);
        List<Account> GetAccounts();
        City GetCity(int Id);
        List<City> GetCities();
        Claim GetClaim(int Id);
        List<Claim> GetClaims();
        List<Claim> GetClaims(Claim c);
        Invoice GetInvoice(int Id);
        List<Invoice> GetInvoices();
        LineItem GetLineItem(int Id);
        List<LineItem> GetLineItems(int claimId);
        Medication GetMedication(int Id);
        List<Medication> GetMedications();
        Patient GetPatient(int Id);
        List<Patient> GetPatients();
        Payee GetPayee(int Id);
        List<Payee> GetPayees();
        Prescription GetPrescription();
        Prescription GetPrescription(int Id);
        List<Prescription> GetPrescriptions();
        Provider GetProvider(int Id);
        List<Provider> GetProviders();
        Service GetService(int Id);
        List<Service> GetServices();
        State GetState(int Id);
        List<State> GetStates();
        Title GetTitle(int Id);
        List<Title> GetTitles();

        #endregion
    }
}
