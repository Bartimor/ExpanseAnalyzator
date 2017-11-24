using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expanses_analyzator
{
    public class PartnerAccount
    {
        public string iban { get; set; }
        public string bic { get; set; }
        public string number { get; set; }
        public string bankCode { get; set; }
        public object countryCode { get; set; }
        public object prefix { get; set; }
    }
}
