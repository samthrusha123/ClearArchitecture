using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Flurl.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Globalization;
using ProjectName.Domain.Entities;
using ProjectName.Application.Interfaces;

namespace ProjectName.Application.Features.GetAllHolidays
{
    public class Handler : IRequestHandler<Request, Response>
    {
        private readonly ISampleDbContext _context;

        public Handler(ISampleDbContext context)
        {
            _context = context;
        }

        public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
        {
            try
            {
                var data = _context.Holiday.ToList();
                return new Response { successCode = "1", Success = true, holidays = data};
            }
            catch (Exception ex)
            {
                var x = ex.Message;
                return null;
            }
        }
    }
}
