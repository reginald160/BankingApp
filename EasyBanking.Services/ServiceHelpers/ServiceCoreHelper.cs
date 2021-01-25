using EasyBanking.DataAccess;
using EasyBanking.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;

namespace EasyBanking.Models
{
    public class ModelCorehelpers
    {
        public static bool IsDeletable<T>()
        where T : class

        {
            var result = typeof(T).GetInterfaces().Contains(typeof(ICoreDeletable));

            return result;
        }

        //public static bool IsDeletable()  
        //{
        //  //  var result = typeof(T);/*GetInterfaces().Contains(typeof(ICoreDeletable))*/;

        //    return T;
        //}
    }
}
