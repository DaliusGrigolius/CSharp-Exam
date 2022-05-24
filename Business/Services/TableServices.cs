using Business.Services.Interfaces;

namespace Business.Services
{
    public class TableServices : ITableServices
    {
        public string GetFilePathByCurrentTable(int currentTableNumber)
        {
            string path = "";

            switch (currentTableNumber)
            {
                case 1:
                    path = @"..\..\..\..\DataFiles\Orders\ordersTable1.json";
                    break;
                case 2:
                    path = @"..\..\..\..\DataFiles\Orders\ordersTable2.json";
                    break;
                case 3:
                    path = @"..\..\..\..\DataFiles\Orders\ordersTable3.json";
                    break;
                case 4:
                    path = @"..\..\..\..\DataFiles\Orders\ordersTable4.json";
                    break;
                case 5:
                    path = @"..\..\..\..\DataFiles\Orders\ordersTable5.json";
                    break;
                case 6:
                    path = @"..\..\..\..\DataFiles\Orders\ordersTable6.json";
                    break;
                case 7:
                    path = @"..\..\..\..\DataFiles\Orders\ordersTable7.json";
                    break;
                case 8:
                    path = @"..\..\..\..\DataFiles\Orders\ordersTable8.json";
                    break;
                case 9:
                    path = @"..\..\..\..\DataFiles\Orders\ordersTable9.json";
                    break;
                case 10:
                    path = @"..\..\..\..\DataFiles\Orders\ordersTable10.json";
                    break;
                default:
                    break;
            }

            return path;
        }
    }
}
