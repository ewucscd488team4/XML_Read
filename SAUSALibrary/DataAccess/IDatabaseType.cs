using SAUSALibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAUSALibrary.DataAccess
{
    public interface IDatabaseType
    {
        DatabaseModel CreateDatabase(IDatabaseType model);
    }
}
