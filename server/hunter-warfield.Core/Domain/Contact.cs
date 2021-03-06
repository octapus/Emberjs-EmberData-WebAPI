﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using hunter_warfield.Core.Interfaces;

namespace hunter_warfield.Core.Domain
{
    public partial class Contact : IIdentifier<Int64>
    {
        public Int64 Id { get; set; }

        public Int16 Type { get; set; }

        public Int16 Country { get; set; }

        public string Phone { get; set; }

        public string Extension { get; set; }

        public Int64 Score { get; set; }

        public Int16? Status { get; set; }

        public Int16? Source { get; set; }

        public string Consent { get; set; }

        // none null fields
        public string sft_dlt_flg { get; set; }
        public DateTime upsertDateTime { get; set; }
        public int soft_comp_id { get; set; }
        public int trnsctn_nmbr { get; set; }
        public Int64 upsertUserId { get; set; }

        [ForeignKey("Debtor")]
        public Int64 DebtorId { get; set; }
        public virtual Debtor Debtor { get; set; }
    }
}
