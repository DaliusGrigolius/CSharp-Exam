using Repository.DataAccess.Interfaces;
using Repository.Models;
using System.Collections.Generic;

namespace Repository.DataAccess
{
    public class TableRepo : ITableRepo
    {
        private List<Table> tableList { get; }

        public TableRepo()
        {
            tableList = new List<Table>
            {
                new Table(1, 2, false),
                new Table(2, 2, false),
                new Table(3, 2, false),
                new Table(4, 4, false),
                new Table(5, 4, false),
                new Table(6, 4, false),
                new Table(7, 6, false),
                new Table(8, 6, false),
                new Table(9, 8, false),
                new Table(10, 8, false),
            };
        }

        public List<Table> RetrieveTableList()
        {
            return tableList;
        }
    }
}
