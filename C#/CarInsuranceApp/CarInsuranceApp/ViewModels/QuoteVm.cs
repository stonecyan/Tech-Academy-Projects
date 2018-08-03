using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceApp.ViewModels
{
    public class QuoteVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string FullQuote { get; set; }
        public string LiabilityQuote { get; set; }

    }
}