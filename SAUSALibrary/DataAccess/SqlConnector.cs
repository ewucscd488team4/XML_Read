using System;
using System.Collections.Generic;
using System.Text;
using SAUSALibrary.Models;

namespace SAUSALibrary.DataAccess
{
    public class SqlConnector : IDatabaseType
    {
        public DatabaseModel CreateDatabase(IDatabaseType model)
        {
            throw new NotImplementedException();
        }
    }
}
