using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTrackingApp.Models
{
    public class PersonLocation
    {
        public PersonLocation(int perconCode, string personRole, int lastSecurityPointNumber, string lastSecurityPointDirection, DateTime lastSecurityPointTime)
        {
            PersonCode = perconCode;
            PersonRole = personRole;
            LastSecurityPointNumber = lastSecurityPointNumber;
            LastSecurityPointDirection = lastSecurityPointDirection;
            LastSecurityPointTime = lastSecurityPointTime;
        }

        public int PersonCode { get; set; }
        public string PersonRole { get; set; } //Клиент или Сотрудник
        public int LastSecurityPointNumber { get; set; } //от 0 до 22 включительно
        public string LastSecurityPointDirection { get; set; } //in или out
        public DateTime LastSecurityPointTime { get; set; }
    }
}
