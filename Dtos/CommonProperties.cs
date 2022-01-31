using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndcsvfile.Dtos
{
    public class CommonProperties
    {
        public Boolean IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
