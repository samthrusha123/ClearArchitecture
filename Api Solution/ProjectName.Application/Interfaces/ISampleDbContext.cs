using Microsoft.EntityFrameworkCore;
using ProjectName.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectName.Application.Interfaces
{
    public interface ISampleDbContext
    {
        DbSet<Holiday> Holiday { get; set; }
    }
}
