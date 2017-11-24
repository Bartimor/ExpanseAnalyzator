using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expanses_analyzator
{
    public class RootObject
    {
        public DateTime booking { get; set; }
        public DateTime valuation { get; set; }
        public string partnerName { get; set; }
        public PartnerAccount partnerAccount { get; set; }
        public Amount amount { get; set; }
        public string reference { get; set; }
        public object referenceNumber { get; set; }
        public object note { get; set; }
        public object categories { get; set; }
        public bool favorite { get; set; }
        public object constantSymbol { get; set; }
        public object variableSymbol { get; set; }
        public object specificSymbol { get; set; }
        public object receiverReference { get; set; }
        public object senderReference { get; set; }
        public object cardNumber { get; set; }
        public object cardLocation { get; set; }
        public object investmentInstrumentName { get; set; }
        public object bookingTypeTranslation { get; set; }
    }
}
