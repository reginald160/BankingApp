using EasyBanking.DataAccess;
using EasyBanking.Models;
using EasyBanking.Services.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EasyBanking.Services.Repository
{
    public class CoreService : ICoreServices
    {
        private readonly ApplicationDbContext _context;
        public CoreService(ApplicationDbContext context)
        {
            _context = context;
        }

        public  bool IPseudeletable<T>(T model)
               where T : class
        {
            var IsIherit = typeof(T).GetInterfaces().Contains(typeof(ICoreDeletable));

            return IsIherit;
        }

        public string SequenceNumberGenerator(string module)
        {
            string result = "";
            try
            {
                int counter = 12;


                var numberSequence = _context.NumberSequences
                    .Where(x => x.Module.Equals(module))
                    .FirstOrDefault();

                if (numberSequence == null)
                {
                    numberSequence = new NumberSequence();
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
                    numberSequence.Prefix = module;
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
