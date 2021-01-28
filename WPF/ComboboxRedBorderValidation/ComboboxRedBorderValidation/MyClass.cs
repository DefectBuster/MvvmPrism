using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboboxRedBorderValidation
{
    public class MyClass
    {
        public string Name { get; set; }

        public string FullName { get; set; }
        public bool IsSelected { get; set; }

        public bool Validate()
        {
            //bool retValue = false;
            //if (!string.IsNullOrWhiteSpace(Name))
            //{
            //    retValue = true;
            //}
            //return retValue;

            return false;
        }
    }
}
