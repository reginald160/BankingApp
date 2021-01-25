using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBanking.Services.IRepository
{
    public interface ICoreServices
    {
        public bool IPseudeletable<T>(T model) where T : class;
        string SequenceNumberGenerator(string module);
    }
}
