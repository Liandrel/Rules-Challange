using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesChall
{
    public class PersonModel
    {
        public delegate void UIDialog(string messege);
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostalCode { get; set; }

        public void ApplyRules(UIDialog dialog)
        {
            if (LastName == "Corey" && FirstName != "Tim")
            {
                dialog("Possibly related to Tim Corey");
            }
            if (FirstName[0] == 'T' && LastName[0] == 'C')
            {
                dialog("Same initials as Tim Corey");
            }
            if (PostalCode.Substring(0, 2) == "18")
            {
                dialog("In the same general area as Tim");
            }
        }
    }
}
