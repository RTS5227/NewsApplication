using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsApplication.Infrastructure;

namespace NewsApplication.Infrastructure.Abstract
{
    public interface IDBFacetory:IDisposable
    {
        ApplicationDBContext Get();
    }
}