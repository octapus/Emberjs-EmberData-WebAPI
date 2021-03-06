﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using hunter_warfield.Core.Interfaces;

namespace hunter_warfield.Core.Domain
{
    public partial class Person : IIdentifier<Int64>
    {
        public Int64 Id { get; set; }

        public Int16? Relationship { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Suffix { get; set; }

        public DateTime? DOB { get; set; }

        public string SSN { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string ClaimNumber { get; set; }

        public Int16? Country { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string County { get; set; }

        public string Phone { get; set; }

        // none null fields
        public DateTime upsertDateTime { get; set; }
        public int soft_comp_id { get; set; }
        public int trnsctn_nmbr { get; set; }
        public Int64 upsertUserId { get; set; }


        [ForeignKey("Debtor")]
        public Int64 DebtorId { get; set; }
        public virtual Debtor Debtor { get; set; }
    }
}
