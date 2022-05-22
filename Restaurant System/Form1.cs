using Business.Services;
using Repository;
using Repository.DataAccess;
using Repository.Models;
using Repository.Serializer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Restaurant_System
{
    public partial class Form1 : Form
    {
        private int id;
        private int pinCode;
        private readonly string filePath;
        private readonly string foodListFilePath;
        private readonly string drinksListFilePath;
        private int foodQuantityCounter = 1;
        private int drinkQuantityCounter = 1;
        private readonly IEmployeeService _employeeService;
        private readonly IEmployeeRepo _employeeRepo;
        private readonly IProductRepo _productRepo;
        private readonly ISerializer _serializer;
        private readonly IDeserializer _deserializer;
        private readonly List<Employee> employees;
        private readonly List<Product> drinksList;
        private readonly List<Product> foodList;
        private List<Table> tableList;
        private List<Order> orders;
        private List<OrderProduct> orderedProductsList;
        private Employee currentEmployee;
        private Table currentTable;

        public Form1()
        {
            InitializeComponent();
            filePath = @"..\..\..\..\DataFiles\Employees.json";
            foodListFilePath = @"..\..\..\..\DataFiles\food.csv";
            drinksListFilePath = @"..\..\..\..\DataFiles\drinks.csv";
            _employeeRepo = new EmployeeRepo(new Deserializer(), filePath);
            _employeeService = new EmployeeService();
            employees = _employeeRepo.RetrieveEmployees();
            _productRepo = new ProductRepo();
            _serializer = new Serializer();
            _deserializer = new Deserializer();
            drinksList = _productRepo.RetrieveProducts(drinksListFilePath, false);
            foodList = _productRepo.RetrieveProducts(foodListFilePath);
            CreateTables();
            ChangeLoginPosition();
            orderedProductsList = new List<OrderProduct>();
            orders = new List<Order>();
        }

        private void ChangeLoginPosition()
        {
            LogoPictureBox.Location = new Point(277, 6);
            LoginLabel.Location = new Point(350, 194);
            IdTextBox.Location = new Point(342, 228);
            IdLabel.Location = new Point(315, 232);
            PinCodeTextBox.Location = new Point(342, 261);
            PinCodeLabel.Location = new Point(314, 265);
            ConfirmLoginButton.Location = new Point(342, 291);
        }

        private void CreateTables()
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

        private void Table1Button_Click(object sender, EventArgs e)
        {
            currentTable = tableList[0];
            CRUD();
        }

        private void Table2Button_Click(object sender, EventArgs e)
        {
            currentTable = tableList[1];
            CRUD();
        }

        private void Table3Button_Click(object sender, EventArgs e)
        {
            currentTable = tableList[2];
            CRUD();
        }

        private void Table4Button_Click(object sender, EventArgs e)
        {
            currentTable = tableList[3];
            CRUD();
        }

        private void Table5Button_Click(object sender, EventArgs e)
        {
            currentTable = tableList[4];
            CRUD();
        }

        private void Table6Button_Click(object sender, EventArgs e)
        {
            currentTable = tableList[5];
            CRUD();
        }

        private void Table7Button_Click(object sender, EventArgs e)
        {
            currentTable = tableList[6];
            CRUD();
        }

        private void Table8Button_Click(object sender, EventArgs e)
        {
            currentTable = tableList[7];
            CRUD();
        }

        private void Table9Button_Click(object sender, EventArgs e)
        {
            currentTable = tableList[8];
            CRUD();
        }

        private void Table10Button_Click(object sender, EventArgs e)
        {
            currentTable = tableList[9];
            CRUD();
        }

        private void ConfirmLoginButton_Click(object sender, EventArgs e)
        {
            ExecuteValidation();
        }

        private void ExecuteValidation()
        {
            bool isIdConvertSuccess = int.TryParse(IdTextBox.Text, out id);
            bool isPinCodeConvertSuccess = int.TryParse(PinCodeTextBox.Text, out pinCode);

            if (!isIdConvertSuccess && !isPinCodeConvertSuccess)
            {
                MessageBox.Show("Error: id number and pin code fields can't by empty.");
                return;
            }

            bool regexMatchForId = Regex.Match(IdTextBox.Text, "^[0-9]{6,6}$").Success;
            bool regexMatchForPin = Regex.Match(PinCodeTextBox.Text, "^[0-9]{4,4}$").Success;

            if (!regexMatchForId && !regexMatchForPin)
            {
                MessageBox.Show("Error: not valid id number(6 digits) or pin code(4 digits).");
                return;
            }

            bool isValid = _employeeService.Validate(id, pinCode, employees);

            if (!isValid)
            {
                MessageBox.Show("Error: Employee not found.");
                return;
            }

            currentEmployee = employees.Single(i => i.Id == id);

            ShowApp();
            FillFoodList();
            FillDrinksList();
        }

        private void ShowApp()
        {
            LoggedInAsTextBox.Text = $"{currentEmployee.FirstName} {currentEmployee.LastName}";
            FoodQuantityTextBox.Text = foodQuantityCounter.ToString();
            DrinkQuantityTextBox.Text = drinkQuantityCounter.ToString();

            LogoPictureBox.Location = new Point(-8, 6);
            LoginLabel.Visible = false;
            IdLabel.Visible = false;
            IdTextBox.Visible = false;
            PinCodeLabel.Visible = false;
            PinCodeTextBox.Visible = false;
            ConfirmLoginButton.Visible = false;
            LoggedInAsLabel.Visible = true;
            LoggedInAsTextBox.Visible = true;
            LogOutButton.Visible = true;
            TablesLabel.Visible = true;
            Table1Button.Visible = true;
            Table2Button.Visible = true;
            Table3Button.Visible = true;
            Table4Button.Visible = true;
            Table5Button.Visible = true;
            Table6Button.Visible = true;
            Table7Button.Visible = true;
            Table8Button.Visible = true;
            Table9Button.Visible = true;
            Table10Button.Visible = true;
            TableDetailsLabel.Visible = true;
            OrderedProductsListBox.Visible = true;
            RemoveSelectedItemButton.Visible = true;
            FreeUpTableButton.Visible = true;
            FoodLabel.Visible = true;
            FoodListComboBox.Visible = true;
            FoodQuantityAddButton.Visible = true;
            FoodQuantityLabel.Visible = true;
            FoodQuantitySubtractButton.Visible = true;
            FoodQuantityTextBox.Visible = true;
            AddFoodButton.Visible = true;
            DrinksLabel.Visible = true;
            DrinksListComboBox.Visible = true;
            DrinkQuantityAddButton.Visible = true;
            DrinkQuantityLabel.Visible = true;
            DrinkQuantitySubtractButton.Visible = true;
            DrinkQuantityTextBox.Visible = true;
            AddDrinkButton.Visible = true;
            ConfirmOrderButton.Visible = true;
            PaymentDetailsLabel.Visible = true;
            CardRadioButton.Visible = true;
            CashRadioButton.Visible = true;
            CustomerChequeCheckBox.Visible = true;
            AmountReceivedLabel.Visible = true;
            AmountReceivedTextBox.Visible = true;
            ExecutePaymentButton.Visible = true;
            TotalAmountLabel.Visible = true;
            TotalAmountTextBox.Visible = true;
        }

        private void FillDrinksList()
        {
            for (int i = 0; i < drinksList.Count; i++)
            {
                DrinksListComboBox.Items.Add($"\"{drinksList[i].Name}\" - {drinksList[i].CurrentPrice}Eu");
            }
        }

        private void FillFoodList()
        {
            for (int i = 0; i < foodList.Count; i++)
            {
                FoodListComboBox.Items.Add($"\"{foodList[i].Name}\" - {foodList[i].CurrentPrice}Eu");
            }
        }

        private void CRUD()
        {
            TotalAmountTextBox.Clear();
            orders.Clear();
            orderedProductsList.Clear();
            OrderedProductsListBox.Items.Clear();

            if (!File.Exists(GetFilePathByCurrentTable()))
            {
                return;
            }
            else
            {
                orders = _deserializer.DeserializeTableOrder(GetFilePathByCurrentTable());
                TotalAmountTextBox.Text = $"{GetAllOrdersTotalAmount()}Eu";
                FillOrderedProductsListBox();
            }
        }

        private void FillOrderedProductsListBox()
        {
            for (int i = 0; i < orders[0].OrderedProducts.Count; i++)
            {
                OrderedProductsListBox.Items.Add($"\"{orders[0].OrderedProducts[i].Product.Name}\" - {orders[0].OrderedProducts[i].Product.CurrentPrice}Eu X {orders[0].OrderedProducts[i].Quantity} = {orders[0].OrderedProducts[i].Product.CurrentPrice * orders[0].OrderedProducts[i].Quantity}Eu");
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FoodQuantityAddButton_Click(object sender, EventArgs e)
        {
            if (foodQuantityCounter > 9)
            {
                FoodQuantityTextBox.Text = foodQuantityCounter.ToString();
            }
            else
            {
                foodQuantityCounter++;
                FoodQuantityTextBox.Text = foodQuantityCounter.ToString();
            }
        }

        private void FoodQuantitySubtractButton_Click(object sender, EventArgs e)
        {
            if (foodQuantityCounter < 2)
            {
                FoodQuantityTextBox.Text = foodQuantityCounter.ToString();
            }
            else
            {
                foodQuantityCounter--;
                FoodQuantityTextBox.Text = foodQuantityCounter.ToString();
            }
        }

        private void DrinkQuantityAddButton_Click(object sender, EventArgs e)
        {
            if (drinkQuantityCounter > 9)
            {
                DrinkQuantityTextBox.Text = drinkQuantityCounter.ToString();
            }
            else
            {
                drinkQuantityCounter++;
                DrinkQuantityTextBox.Text = drinkQuantityCounter.ToString();
            }
        }

        private void DrinkQuantitySubtractButton_Click(object sender, EventArgs e)
        {
            if (drinkQuantityCounter < 2)
            {
                DrinkQuantityTextBox.Text = drinkQuantityCounter.ToString();
            }
            else
            {
                drinkQuantityCounter--;
                DrinkQuantityTextBox.Text = drinkQuantityCounter.ToString();
            }
        }

        private void AddFoodButton_Click(object sender, EventArgs e)
        {
            if (CheckIfTableIsSelected()) return;

            CheckIfFileExists();

            if (FoodListComboBox.SelectedItem != null)
            {
                int indexNumber = FoodListComboBox.SelectedIndex;
                int quantity = Convert.ToInt32(FoodQuantityTextBox.Text);
                decimal currentPrice = foodList[indexNumber].CurrentPrice;
                decimal price = currentPrice * quantity;

                OrderedProductsListBox.Items.Add($"{FoodListComboBox.SelectedItem} X {FoodQuantityTextBox.Text} = {price}Eu");

                AddOrderByPopulatedList(indexNumber);

                ResetTextBoxes();
            }
        }

        private void AddDrinkButton_Click(object sender, EventArgs e)
        {
            if (CheckIfTableIsSelected()) return;

            CheckIfFileExists();

            if (DrinksListComboBox.SelectedItem != null)
            {
                int indexNumber = DrinksListComboBox.SelectedIndex;
                int quantity = Convert.ToInt32(DrinkQuantityTextBox.Text);
                decimal currentPrice = drinksList[indexNumber].CurrentPrice;
                decimal price = currentPrice * quantity;

                OrderedProductsListBox.Items.Add($"{DrinksListComboBox.SelectedItem} X {DrinkQuantityTextBox.Text} = {price}Eu;");

                AddOrderByPopulatedList(indexNumber, false);

                ResetTextBoxes(false);
            }
        }

        private void ConfirmOrderButton_Click(object sender, EventArgs e)
        {
            if (CheckIfTableIsSelected()) return;

            if (orderedProductsList.Count < 1 && orders.Count < 1)
            {
                MessageBox.Show("Error: Table has no orders.");
                return;
            }

            if (orderedProductsList.Count > 0)
            {
                orders.Add(new Order(currentTable.Number, currentTable.Seating, orderedProductsList, GetAllOrdersTotalAmount(), DateTime.Now));
                string path = GetFilePathByCurrentTable();
                _serializer.WriteOrderDataToFile(orders, path);
            }

            ChangeCurrentTableButtonColorWhenTableOccupied();
            currentTable.Occupied = true;
            currentTable.Reserved = DateTime.Now;
            orderedProductsList.Clear();
            orders.Clear();

            MessageBox.Show("Success! Order sent to kitchen.");
        }
        
        private void RemoveSelectedItemButton_Click(object sender, EventArgs e)
        {
            if (CheckIfTableIsSelected()) return;

            if (OrderedProductsListBox.SelectedItem == null)
            {
                MessageBox.Show("Error: Item not selected.");
                return;
            }

            int indexOfSelectedItem = GetIndexOfSelectedItemFromOrdersList();

            if (File.Exists(GetFilePathByCurrentTable()))
            {
                orders = _deserializer.DeserializeTableOrder(GetFilePathByCurrentTable());
                orders[0].OrderedProducts.RemoveAt(indexOfSelectedItem);
            }
            
            if (indexOfSelectedItem >= 0 && orderedProductsList.Count > 0)
            {
                orderedProductsList.RemoveAt(indexOfSelectedItem);
            }

            string path = GetFilePathByCurrentTable();
            if(orders.Count > 0)
            {
                orders[0].TotalAmount = GetAllOrdersTotalAmount();
                _serializer.WriteOrderDataToFile(orders, path);
            }

            OrderedProductsListBox.Items.Remove(OrderedProductsListBox.SelectedItem);
            TotalAmountTextBox.Clear();
            TotalAmountTextBox.Text = $"{GetAllOrdersTotalAmount()}Eu";
        }

        private void FreeUpTableButton_Click_1(object sender, EventArgs e)
        {
            if (CheckIfTableIsSelected()) return;

            currentTable.Occupied = false;

            OrderedProductsListBox.Items.Clear();
            TotalAmountTextBox.Clear();
            TotalAmountTextBox.Clear();
            orderedProductsList.Clear();
            orders.Clear();
            File.Delete(GetFilePathByCurrentTable());
            ChangeCurrentTableButtonColorWhenTableFreed();
        }

        private int GetIndexOfSelectedItemFromOrdersList()
        {
            var temp = new List<object>();

            for (int i = 0; i < OrderedProductsListBox.Items.Count; i++)
            {
                temp.Add(OrderedProductsListBox.Items[i]);
            }

            int listboxItemIndex = temp.IndexOf(temp.Find(x => x.Equals(OrderedProductsListBox.SelectedItem)));

            return listboxItemIndex;
        }

        private void WriteDataToFile()
        {
            string path = GetFilePathByCurrentTable();
            orders[0].TotalAmount = GetAllOrdersTotalAmount();
            _serializer.WriteOrderDataToFile(orders, path);
        }

        private void AddOrderByPopulatedList(int indexNumber, bool isFood = true)
        {
            if (isFood)
            {
                if (orders.Count > 0)
                {
                    orders[0].OrderedProducts.Add(new OrderProduct(foodList[indexNumber], Convert.ToInt32(FoodQuantityTextBox.Text)));
                    WriteDataToFile();
                }
                else
                {
                    orderedProductsList.Add(new OrderProduct(foodList[indexNumber], Convert.ToInt32(FoodQuantityTextBox.Text)));
                }
            }
            else
            {
                if (orders.Count > 0)
                {
                    orders[0].OrderedProducts.Add(new OrderProduct(drinksList[indexNumber], Convert.ToInt32(DrinkQuantityTextBox.Text)));
                    WriteDataToFile();
                }
                else
                {
                    orderedProductsList.Add(new OrderProduct(drinksList[indexNumber], Convert.ToInt32(DrinkQuantityTextBox.Text)));
                }
            }
        }

        private decimal GetAllOrdersTotalAmount()
        {
            decimal totalAmount = 0;

            if (File.Exists(GetFilePathByCurrentTable()))
            {
                for (int i = 0; i < orders[0].OrderedProducts.Count; i++)
                {
                    totalAmount += orders[0].OrderedProducts[i].Product.CurrentPrice * orders[0].OrderedProducts[i].Quantity;
                }
            }

            for (int i = 0; i < orderedProductsList.Count; i++)
            {
                totalAmount += orderedProductsList[i].Product.CurrentPrice * orderedProductsList[i].Quantity;
            }

            return totalAmount;
        }

        private void ResetTextBoxes(bool isFood = true)
        {
            if (isFood)
            {
                FoodQuantityTextBox.Text = "1";
            }
            else
            {
                DrinkQuantityTextBox.Text = "1";
            }

            TotalAmountTextBox.Clear();
            TotalAmountTextBox.Text = $"{GetAllOrdersTotalAmount()}Eu";
        }

        private void CheckIfFileExists()
        {
            if (File.Exists(GetFilePathByCurrentTable()))
            {
                orders = _deserializer.DeserializeTableOrder(GetFilePathByCurrentTable());
            }
        }

        private bool CheckIfTableIsSelected()
        {
            if (currentTable == null)
            {
                MessageBox.Show("Error: Table not selected.");
                return true;
            }
            return false;
        }

        private string GetFilePathByCurrentTable()
        {
            string path = "";

            switch (currentTable.Number)
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
                    MessageBox.Show("Error: Table number not found.");
                    break;
            }

            return path;
        }

        private void ChangeCurrentTableButtonColorWhenTableOccupied()
        {
            switch (currentTable.Number)
            {
                case 1:
                    Table1Button.BackColor = Color.MistyRose;
                    break;
                case 2:
                    Table2Button.BackColor = Color.MistyRose;
                    break;
                case 3:
                    Table3Button.BackColor = Color.MistyRose;
                    break;
                case 4:
                    Table4Button.BackColor = Color.MistyRose;
                    break;
                case 5:
                    Table5Button.BackColor = Color.MistyRose;
                    break;
                case 6:
                    Table6Button.BackColor = Color.MistyRose;
                    break;
                case 7:
                    Table7Button.BackColor = Color.MistyRose;
                    break;
                case 8:
                    Table8Button.BackColor = Color.MistyRose;
                    break;
                case 9:
                    Table9Button.BackColor = Color.MistyRose;
                    break;
                case 10:
                    Table10Button.BackColor = Color.MistyRose;
                    break;
                default:
                    MessageBox.Show("Error: Table number not found.");
                    break;
            }
        }

        private void ChangeCurrentTableButtonColorWhenTableFreed()
        {
            switch (currentTable.Number)
            {
                case 1:
                    Table1Button.BackColor = Color.LightGreen;
                    break;
                case 2:
                    Table2Button.BackColor = Color.LightGreen;
                    break;
                case 3:
                    Table3Button.BackColor = Color.LightGreen;
                    break;
                case 4:
                    Table4Button.BackColor = Color.LightGreen;
                    break;
                case 5:
                    Table5Button.BackColor = Color.LightGreen;
                    break;
                case 6:
                    Table6Button.BackColor = Color.LightGreen;
                    break;
                case 7:
                    Table7Button.BackColor = Color.LightGreen;
                    break;
                case 8:
                    Table8Button.BackColor = Color.LightGreen;
                    break;
                case 9:
                    Table9Button.BackColor = Color.LightGreen;
                    break;
                case 10:
                    Table10Button.BackColor = Color.LightGreen;
                    break;
                default:
                    MessageBox.Show("Error: Table number not found.");
                    break;
            }
        }
    }
}
      