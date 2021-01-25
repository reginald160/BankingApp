using EasyBanking.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EasyBanking.Services.ServiceHelpers
{
    public  class ServiceCoreHelper
    {
        private  readonly ApplicationDbContext _context;

        public  ServiceCoreHelper( ApplicationDbContext context)
        {
            _context = context;   
        }
        public  string GetNumberSequence(string module)
        {
            string result = "";
            try
            {
                int counter = 1;


                var numberSequence = _context.NumberSequences
                    .Where(x => x.Module.Equals(module))
                    .FirstOrDefault();

                if (numberSequence == null)
                {
                    numberSequence = new Models.NumberSequence();
                    numberSequence.Module = module;
                    Interlocked.Increment(ref counter);
                    numberSequence.LastNumber = counter;
                    numberSequence.NumberSequenceName = module;
                    numberSequence.Prefix = module;

                    _context.Add(numberSequence);
                    _context.SaveChanges();
                }
                else
                {
                    counter = numberSequence.LastNumber;

                    Interlocked.Increment(ref counter);
                    numberSequence.LastNumber = counter;

                    _context.Update(numberSequence);
                    _context.SaveChanges();
                }

                result = numberSequence.Prefix + counter.ToString().PadLeft(3, '0');
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
