using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XsdRendererCS
{
    partial class Person
    {
        public string CombinedAddress
        {
            get { return String.Format("{0} {1}. {2} {3}. {4}",Address.Street, Address.Number, Address.City, Address.State , Address.Country) ; }
        }
    }
}
