using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
    public interface IContext
    {
        IDbConnection GetConnection();
    }
}
