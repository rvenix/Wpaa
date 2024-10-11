using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefusedBequest
{
    public class Manager : IEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public void ManageTeam() { /* Implementacja */ }


        public void AttendMeeting()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
