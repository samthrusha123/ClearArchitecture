using ProjectName.Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.Application.Features.GetAllHolidays
{
    public class Response
    {
        public string successCode { get; set; }

        public bool Success { get; set; }

        public List<Domain.Entities.Holiday> holidays { get; set; }
    }
}
