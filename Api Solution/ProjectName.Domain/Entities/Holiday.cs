using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.Domain.Entities
{
    public class Holiday
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public string Occasion { get; set; }
    }
}
