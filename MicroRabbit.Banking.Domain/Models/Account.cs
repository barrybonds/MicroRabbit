using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Models
{
   public class Account
    {
        public int Id { get; set; }
        public string AccoutType { get; set; }
        public decimal Accountbalance { get; set; }
    }
}
