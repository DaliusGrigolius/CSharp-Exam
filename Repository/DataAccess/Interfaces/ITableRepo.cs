using Repository.Models;
using System.Collections.Generic;

namespace Repository.DataAccess.Interfaces
{
    public interface ITableRepo
    {
        List<Table> RetrieveTableList();
    }
}