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
    public partial class ResultCode : IIdentifier<Int16>
    {
        public Int16 Id { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }
    }
}
