using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.Application.Features.GetAllHolidays
{
    public class Request: IRequest<Response>
    {
        public string Name { get; set; }
    }
}
