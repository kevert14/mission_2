using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission2.Models
{
    public class CalcModel
    {
        [Range(1, 100)]
        public float assign { get; set; }

        [Range(1, 100)]
        public float grp_proj { get; set; }

        [Range(1, 100)]
        public float quiz { get; set; }

        [Range(1, 100)]
        public float exam { get; set; }

        [Range(1, 100)]
        public float inte { get; set; }

    }
}