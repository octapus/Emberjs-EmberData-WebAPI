﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using hunter_warfield.Core.Interfaces;

namespace hunter_warfield.Core.Domain
{
    public partial class DebtorDto : IDataTransfer<Debtor>
    {
        public DebtorDto() { }

        public DebtorDto(Debtor debtor)
        {
            if (debtor == null) return;
            Id = debtor.Id;
            //AccountId = debtor.AccountId;
            //AgencyId = debtor.AgencyId;
            //CreditorId = debtor.CreditorId;
            Type = debtor.Type;
            Title = debtor.Title;
            FirstName = debtor.FirstName;
            MiddleName = debtor.MiddleName;
            LastName = debtor.LastName;
            Suffix = debtor.Suffix;
            DateTime dobDate = debtor.DOB ?? DateTime.Now;
            DOB = Convert.ToDateTime(debtor.DOB).ToShortDateString();
            MaritalStatus = debtor.MaritalStatus;
            Email = debtor.Email;
            EmailValidity = debtor.EmailValidity;
            OptIn = debtor.OptIn;
            if (debtor.Type.Equals("Y"))
                EIN = debtor.SSN;
            else
                SSN = debtor.SSN;
            CommContact = debtor.Contact;
            Country = debtor.Country;
            Address1 = debtor.Address1;
            Address2 = debtor.Address2;
            Address3 = debtor.Address3;
            City = debtor.City;
            State = debtor.State;
            Zip = debtor.Zip;
            County = debtor.County;
            DLIssuer = debtor.DLIssuer;
            DLNumber = debtor.DLNumber;
            Passport = debtor.Passport;
            PIN = debtor.PIN;
            Contacts = new List<ContactDto>();
            Persons = new List<PersonDto>();
            Employments = new List<EmploymentDto>();
            Notes = new List<NoteDto>();
            if (debtor.Contacts != null)
            {
                foreach (Contact contact in debtor.Contacts)
                {
                    Contacts.Add(new ContactDto(contact));
                }
            }
            if (debtor.Persons != null)
            {
                foreach (Person person in debtor.Persons)
                {
                    Persons.Add(new PersonDto(person));
                }
            }
            if (debtor.Employments != null)
            {
                foreach (Employment employment in debtor.Employments)
                {
                    Employments.Add(new EmploymentDto(employment));
                }
            }
            if (debtor.Notes != null)
            {
                foreach (Note note in debtor.Notes)
                {
                    Notes.Add(new NoteDto(note));
                }
            }
            if (debtor.DebtorAccounts != null)
            {
                foreach (DebtorAccount debtorAccount in debtor.DebtorAccounts)
                {
                    DebtorAccounts.Add(new DebtorAccountDto(debtorAccount));
                }
            }
        }

        [Key]
        public Int64 Id { get; set; }

        //public Int64 AccountId { get; set; }

        //public Int64 AgencyId { get; set; }

        //public Int64 CreditorId { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Suffix { get; set; }

        public string DOB { get; set; }

        public string SSN { get; set; }

        public Int16 MaritalStatus { get; set; }

        public string Email { get; set; }

        public Int16? EmailValidity { get; set; }

        public string OptIn { get; set; }

        public string EIN { get; set; }

        public string CommContact { get; set; }

        public Int16 Country { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string County { get; set; }

        public string DLIssuer { get; set; }

        public string DLNumber { get; set; }

        public string Passport { get; set; }

        public string PIN { get; set; }

        public virtual List<ContactDto> Contacts { get; set; }

        public virtual List<PersonDto> Persons { get; set; }

        public virtual List<EmploymentDto> Employments { get; set; }

        public virtual List<NoteDto> Notes { get; set; }

        public virtual List<DebtorAccountDto> DebtorAccounts { get; set; }

        public Debtor ToEntity()
        {
            string value = null;
            if (Type.Equals("Y"))
                value = EIN;
            else
                value = SSN;
            Debtor debtor = new Debtor
            {
                Id = Id,
                //AccountId = AccountId,
                //AgencyId = AgencyId,
                //CreditorId = CreditorId,
                Type = Type,
                Title = Title,
                FirstName = FirstName,
                MiddleName = MiddleName,
                LastName = LastName,
                Suffix = Suffix,
                DOB = Convert.ToDateTime(DOB),
                MaritalStatus = MaritalStatus,
                Email = Email,
                EmailValidity = EmailValidity,
                OptIn = OptIn,
                SSN = value,
                Contact = CommContact,
                Country = Country,
                Address1 = Address1,
                Address2 = Address2,
                Address3 = Address3,
                City = City,
                State = State,
                Zip = Zip,
                County = County,
                DLIssuer = DLIssuer,
                DLNumber = DLNumber,
                Passport = Passport,
                PIN = PIN,
                Contacts = new List<Contact>(),
                Persons = new List<Person>(),
                Employments = new List<Employment>(),
                //Historicals = new List<Historical>(),
                Notes = new List<Note>(),
                DebtorAccounts = new List<DebtorAccount>()
            };

            if (Contacts != null)
            {
                foreach (ContactDto contact in Contacts)
                {
                    debtor.Contacts.Add(contact.ToEntity());
                }
            }

            if (Persons != null)
            {
                foreach (PersonDto person in Persons)
                {
                    debtor.Persons.Add(person.ToEntity());
                }
            }

            if (Employments != null)
            {
                foreach (EmploymentDto employment in Employments)
                {
                    debtor.Employments.Add(employment.ToEntity());
                }
            }

            if (Notes != null)
            {
                foreach (NoteDto note in Notes)
                {
                    debtor.Notes.Add(note.ToEntity());
                }
            }

            if (DebtorAccounts != null)
            {
                foreach (DebtorAccountDto debtorAccount in DebtorAccounts)
                {
                    debtor.DebtorAccounts.Add(debtorAccount.ToEntity());
                }
            }

            return debtor;
        }
    }
}
