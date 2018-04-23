using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dgv.Model
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public DateTime? BirthDay { get; set; }
        public DateTime? HireDate { get; set; }
        public string TelNum { get; set; }
        public string Address { get; set; }
    }
}
