using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleções.Entities
{
    internal class LogRecords
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }
        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(!(obj is LogRecords))
            {
                return false;
            }
            LogRecords other = (LogRecords)obj;
            return Username.Equals(other.Username);
        }
    }
}
