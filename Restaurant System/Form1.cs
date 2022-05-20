using Business.Services;
using Repository;
using Repository.DataAccess;
using Repository.Models;
using Repository.Serializer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Restaurant_System
{
    public partial class Form1 : Form
    {
        private int id;
        private int pinCode;
        readonly string filePath;
        readonly string foodListFilePath;
        readonly string drinksListFilePath;
        readonly string orderedProductsFilePath;
        private int foodQuantityCounter = 1;
        private int drinkQuantityCounter = 1;
        private readonly IEmployeeService _employeeService;
        private readonly IEmployeeRepo _employeeRepo;
        private readonly IProductRepo _productRepo;
        private readonly ISerializer _serializer;
        private Employee currentEmployee;
        private Table currentTable;
        private List<Employee> employees;
        private List<Table> tableList;
        private List<Product> drinksList;
        private List<Product> foodList;
        private List<Order> ordersList;
        private List<OrderProduct> orderedProductsList;


        public Form1()
        {
            InitializeComponent();
            filePath = @"..\..\..\..\DataFiles\Employees.json";
            foodListFilePath = @"..\..\..\..\DataFiles\food.csv";
            drinksListFilePath = @"..\..\..\..\DataFiles\drinks.csv";
            orderedProductsFilePath = @"..\..\..\..\DataFiles\Orders\allOrders.json";
            _employeeRepo = new EmployeeRepo(new Deserializer(), filePath);
            _employeeService = new EmployeeService();
            employees = _employeeRepo.RetrieveEmployees();
            _productRepo = new ProductRepo();
            _serializer = new Serializer();
            drinksList = _productRepo.RetrieveProducts(drinksListFilePath, false);
            foodList = _productRepo.RetrieveProducts(foodListFilePath);
            CreateTables();
            ChangeLoginPosition();
            ordersList = new List<Order>();
            orderedProductsList = new List<OrderProduct>();
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
            if(ordersList.Count > 0)
            {
                Table1Button.BackColor = Color.MistyRose;
            }
        }

        private void Table2Button_Click(object sender, EventArgs e)
        {
            currentTable = tableList[1];
            if(ordersList.Count > 0)
            {
                Table2Button.BackColor = Color.MistyRose;
            }
        }

        private void Table3Button_Click(object sender, EventArgs e)
        {

        }

        private void Table4Button_Click(object sender, EventArgs e)
        {

        }

        private void Table5Button_Click(object sender, EventArgs e)
        {

        }

        private void Table6Button_Click(object sender, EventArgs e)
        {

        }

        private void Table7Button_Click(object sender, EventArgs e)
        {

        }

        private void Table8Button_Click(object sender, EventArgs e)
        {

        }

        private void Table9Button_Click(object sender, EventArgs e)
        {

        }

        private void Table10Button_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmLoginButton_Click(object sender, EventArgs e)
        {
            ExecuteValidation();
        }

        private void ExecuteValidation()
        {
            bool isIdConvertSuccess = int.TryParse(IdTextBox.Text, out id);
            bool isPinCodeConvertSuccess = int.TryParse(PinCodeTextBox.Text, out pinCode);
            if (isIdConvertSuccess && isPinCodeConvertSuccess)
            {
                bool regexMatchForId = Regex.Match(IdTextBox.Text, "^[0-9]{6,6}$").Success;
                bool regexMatchForPin = Regex.Match(PinCodeTextBox.Text, "^[0-9]{4,4}$").Success;
                if (regexMatchForId && regexMatchForPin)
                {
                    bool isValid = _employeeService.Validate(id, pinCode, employees);
                    if (isValid)
                    {
                        currentEmployee = employees.Single(i => i.Id == id);
                        ShowApp();
                        FillFoodList();
                        FillDrinksList();
                    }
                    else
                    {
                        MessageBox.Show("Error: Employee not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Error: not valid id number(6 digits) or pin code(4 digits).");
                }
            }
            else
            {
                MessageBox.Show("Error: id number and pin code fields can't by empty!");
            }
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
            RemoveAllItemsButton.Visible = true;
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
            if (currentTable == null)
            {
                MessageBox.Show("Error: Table not selected.");
                return;
            }

            if (FoodListComboBox.SelectedItem != null)
            {
                int indexNumber = FoodListComboBox.SelectedIndex;
                int quantity = Convert.ToInt32(FoodQuantityTextBox.Text);
                decimal currentPrice = foodList[indexNumber].CurrentPrice;
                decimal price = currentPrice * quantity;

                OrderedProductsListBox.Items.Add($"{FoodListComboBox.SelectedItem} X {FoodQuantityTextBox.Text} = {price}Eu");

                int selectedIndex = FoodListComboBox.SelectedIndex;

                orderedProductsList.Add(new OrderProduct(foodList[selectedIndex], Convert.ToInt32(FoodQuantityTextBox.Text)));

                TotalAmountTextBox.Clear();
                TotalAmountTextBox.Text = $"{GetAllOrdersTotalAmount()}Eu";
            }
        }

        private void AddDrinkButton_Click(object sender, EventArgs e)
        {
            if (currentTable == null)
            {
                MessageBox.Show("Error: Table not selected.");
                return;
            }

            if (DrinksListComboBox.SelectedItem != null)
            {
                int indexNumber = DrinksListComboBox.SelectedIndex;
                int quantity = Convert.ToInt32(DrinkQuantityTextBox.Text);
                decimal currentPrice = drinksList[indexNumber].CurrentPrice;
                decimal price = currentPrice * quantity;

                OrderedProductsListBox.Items.Add($"{DrinksListComboBox.SelectedItem} X {DrinkQuantityTextBox.Text} = {price}Eu;");

                int selectedIndex = DrinksListComboBox.SelectedIndex;

                orderedProductsList.Add(new OrderProduct(drinksList[selectedIndex], Convert.ToInt32(DrinkQuantityTextBox.Text)));
                //ordersList.Add(new Order(currentTable.Number, currentTable.Seating, orderedProductsList, GetAllOrdersTotalAmount(), DateTime.Now));

                TotalAmountTextBox.Clear();
                TotalAmountTextBox.Text = $"{GetAllOrdersTotalAmount()}Eu";
            }
        }

        private decimal GetAllOrdersTotalAmount()
        {
            decimal totalAmount = 0;

            for (int i = 0; i < orderedProductsList.Count; i++)
            {
                totalAmount += orderedProductsList[i].Product.CurrentPrice * orderedProductsList[i].Quantity;
            }

            return totalAmount;
        }

        private void RemoveSelectedItemButton_Click(object sender, EventArgs e)
        {
            var temp = new List<object>();
            for (int i = 0; i < OrderedProductsListBox.Items.Count; i++)
            {
                temp.Add(OrderedProductsListBox.Items[i]);
            }
            var listboxItemIndex = temp.IndexOf(temp.Find(x => x.Equals(OrderedProductsListBox.SelectedItem)));
            orderedProductsList.RemoveAt(listboxItemIndex);

            OrderedProductsListBox.Items.Remove(OrderedProductsListBox.SelectedItem);

            TotalAmountTextBox.Clear();
            TotalAmountTextBox.Text = $"{GetAllOrdersTotalAmount()}Eu";
        }

        private void RemoveAllItemsButton_Click(object sender, EventArgs e)
        {
            OrderedProductsListBox.Items.Clear();

            orderedProductsList.Clear();

            TotalAmountTextBox.Clear();
            TotalAmountTextBox.Text = $"{GetAllOrdersTotalAmount()}Eu";
        }

        private void ConfirmOrderButton_Click(object sender, EventArgs e)
        {
            if (currentTable == null)
            {
                MessageBox.Show("Error: Table not selected.");
                return;
            }

            if (orderedProductsList.Count < 1)
            {
                MessageBox.Show("Error: Table has no orders.");
                return;
            }

            ordersList.Add(new Order(currentTable.Number, currentTable.Seating, orderedProductsList, GetAllOrdersTotalAmount(), DateTime.Now));
            ChangeCurrentTableButtonColor();

            _serializer.WriteOrderDataToFile(ordersList, orderedProductsFilePath);

            currentTable.Occupied = true;
            OrderedProductsListBox.Items.Clear();
            MessageBox.Show("Success! Order sent to kitchen.");
        }

        private void ChangeCurrentTableButtonColor()
        {
            int index = currentTable.Number;

            switch (index)
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
    }
}
      