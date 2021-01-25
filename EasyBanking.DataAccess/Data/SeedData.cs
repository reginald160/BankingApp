using EasyBanking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBanking.DataAccess.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<NumberSequence>().HasData(
              new NumberSequence
              {
                  Id = Guid.NewGuid(),
                  Module = "",
                  NumberSequenceName = "",
                  LastNumber = 0,
                  Deleted = false,
                  IsNewRecord = true,
                  Prefix = ""
              }
              );
        }
    }
}
