using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahalil.Models.Users;

namespace Tahalil.Models.Anals
{
    public class Anal
    {
        public int Id { get; set; }
        public string codeAnal { get; set; }
        public int PrescriptId { get; set; }
        public DateTime Jour { get; set; }
        public decimal Mnt { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

}
}
