using Business.Services;
using Repository;
using Repository.DataAccess;
using Repository.Models;
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
        private int foodQuantityCounter = 1;
        private int drinkQuantityCounter = 1;
        readonly IEmployeeService _employeeService;
        readonly IEmployeeRepo _employeeRepo;
        readonly IProductRepo _productRepo;
        readonly List<Employee> employees;
        Employee currentEmployee;
        private List<Table> TableList;
        List<Product> drinksList;
        List<Product> foodList;


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
            drinksList = _productRepo.RetrieveProducts(drinksListFilePath, false);
            foodList = _productRepo.RetrieveProducts(foodListFilePath);
            CreateTables();
            ChangeLoginPosition();
        }

        private void ChangeLoginPosition()
        {
            LogoPictureBox.Location = new Point(277,6);
            LoginLabel.Location = new Point(350,194);
            IdTextBox.Location = new Point(342, 228);
            IdLabel.Location = new Point(315, 232);
            PinCodeTextBox.Location = new Point(342, 261);
            PinCodeLabel.Location = new Point(314, 265);
            ConfirmLoginButton.Location = new Point(342, 291);
        }

        private void CreateTables()
        {
            TableList = new List<Table>
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
            TableList[0].Occupied = true;
            Table1Button.BackColor = Color.MistyRose;
            //Table1Button.Enabled = false;
        }

        private void Table2Button_Click(object sender, EventArgs e)
        {

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
                DrinksListComboBox.Items.Add($"\"{ drinksList[i].Name }\" - { drinksList[i].CurrentPrice }Eu");
            }
        }

        private void FillFoodList()
        {
            for (int i = 0; i < foodList.Count; i++)
            {
                FoodListComboBox.Items.Add($"\"{ foodList[i].Name }\" - { foodList[i].CurrentPrice }Eu");
            }
        }

        private void ShowApp()
        {
            LoggedInAsTextBox.Text = $"{ currentEmployee.FirstName } { currentEmployee.LastName }";
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
            OrderedProductsTextBox.Visible = true;
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
            if(foodQuantityCounter < 2)
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
            if(FoodListComboBox.SelectedItem != null)
            {
                int indexNumber = FoodListComboBox.SelectedIndex;
                int quantity = Convert.ToInt32(FoodQuantityTextBox.Text);
                decimal currentPrice = foodList[indexNumber].CurrentPrice;
                decimal price = currentPrice * quantity;

                OrderedProductsTextBox.Text += $"{ FoodListComboBox.SelectedItem } X { FoodQuantityTextBox.Text } = { price }Eu\r\n";
            }
        }

        private void AddDrinkButton_Click(object sender, EventArgs e)
        {
            if (DrinksListComboBox.SelectedItem != null)
            {
                int indexNumber = DrinksListComboBox.SelectedIndex;
                int quantity = Convert.ToInt32(DrinkQuantityTextBox.Text);
                decimal currentPrice = drinksList[indexNumber].CurrentPrice;
                decimal price = currentPrice * quantity;

                OrderedProductsTextBox.Text += $"{ DrinksListComboBox.SelectedItem } X { DrinkQuantityTextBox.Text } = { price }Eu;\r\n";
            }
        }
    }
}
      