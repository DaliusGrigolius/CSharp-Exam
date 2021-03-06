namespace Restaurant_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConfirmOrderButton = new System.Windows.Forms.Button();
            this.FoodListComboBox = new System.Windows.Forms.ComboBox();
            this.DrinksListComboBox = new System.Windows.Forms.ComboBox();
            this.FoodLabel = new System.Windows.Forms.Label();
            this.DrinksLabel = new System.Windows.Forms.Label();
            this.Table1Button = new System.Windows.Forms.Button();
            this.Table2Button = new System.Windows.Forms.Button();
            this.Table3Button = new System.Windows.Forms.Button();
            this.Table6Button = new System.Windows.Forms.Button();
            this.Table5Button = new System.Windows.Forms.Button();
            this.Table4Button = new System.Windows.Forms.Button();
            this.Table9Button = new System.Windows.Forms.Button();
            this.Table8Button = new System.Windows.Forms.Button();
            this.Table7Button = new System.Windows.Forms.Button();
            this.Table10Button = new System.Windows.Forms.Button();
            this.TablesLabel = new System.Windows.Forms.Label();
            this.FoodQuantityLabel = new System.Windows.Forms.Label();
            this.DrinkQuantityLabel = new System.Windows.Forms.Label();
            this.FoodQuantityTextBox = new System.Windows.Forms.TextBox();
            this.DrinkQuantityTextBox = new System.Windows.Forms.TextBox();
            this.AddFoodButton = new System.Windows.Forms.Button();
            this.AddDrinkButton = new System.Windows.Forms.Button();
            this.FoodQuantityAddButton = new System.Windows.Forms.Button();
            this.FoodQuantitySubtractButton = new System.Windows.Forms.Button();
            this.DrinkQuantitySubtractButton = new System.Windows.Forms.Button();
            this.DrinkQuantityAddButton = new System.Windows.Forms.Button();
            this.TableDetailsLabel = new System.Windows.Forms.Label();
            this.FreeUpTableButton = new System.Windows.Forms.Button();
            this.CashRadioButton = new System.Windows.Forms.RadioButton();
            this.CardRadioButton = new System.Windows.Forms.RadioButton();
            this.ExecutePaymentButton = new System.Windows.Forms.Button();
            this.PaymentDetailsLabel = new System.Windows.Forms.Label();
            this.CustomerChequeCheckBox = new System.Windows.Forms.CheckBox();
            this.AmountReceivedLabel = new System.Windows.Forms.Label();
            this.AmountReceivedTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.PinCodeLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PinCodeTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmLoginButton = new System.Windows.Forms.Button();
            this.LoggedInAsLabel = new System.Windows.Forms.Label();
            this.LoggedInAsTextBox = new System.Windows.Forms.TextBox();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.OrderedProductsListBox = new System.Windows.Forms.ListBox();
            this.RemoveSelectedItemButton = new System.Windows.Forms.Button();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.TotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.ChequeViaEmailForCustomerCheckBox = new System.Windows.Forms.CheckBox();
            this.CustomerEmailAddressLabel = new System.Windows.Forms.Label();
            this.CustomerEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.ChequeViaEmailForRestaurantCheckBox = new System.Windows.Forms.CheckBox();
            this.RestaurantEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.RestaurantEmailAddressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmOrderButton
            // 
            this.ConfirmOrderButton.BackColor = System.Drawing.Color.LightGreen;
            this.ConfirmOrderButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfirmOrderButton.Location = new System.Drawing.Point(530, 307);
            this.ConfirmOrderButton.Name = "ConfirmOrderButton";
            this.ConfirmOrderButton.Size = new System.Drawing.Size(267, 37);
            this.ConfirmOrderButton.TabIndex = 5;
            this.ConfirmOrderButton.Text = "Confirm Order";
            this.ConfirmOrderButton.UseVisualStyleBackColor = false;
            this.ConfirmOrderButton.Visible = false;
            this.ConfirmOrderButton.Click += new System.EventHandler(this.ConfirmOrderButton_Click);
            // 
            // FoodListComboBox
            // 
            this.FoodListComboBox.FormattingEnabled = true;
            this.FoodListComboBox.Location = new System.Drawing.Point(573, 134);
            this.FoodListComboBox.MaxDropDownItems = 100;
            this.FoodListComboBox.Name = "FoodListComboBox";
            this.FoodListComboBox.Size = new System.Drawing.Size(224, 23);
            this.FoodListComboBox.TabIndex = 6;
            this.FoodListComboBox.Visible = false;
            // 
            // DrinksListComboBox
            // 
            this.DrinksListComboBox.FormattingEnabled = true;
            this.DrinksListComboBox.Location = new System.Drawing.Point(573, 205);
            this.DrinksListComboBox.MaxDropDownItems = 100;
            this.DrinksListComboBox.Name = "DrinksListComboBox";
            this.DrinksListComboBox.Size = new System.Drawing.Size(224, 23);
            this.DrinksListComboBox.TabIndex = 7;
            this.DrinksListComboBox.Visible = false;
            // 
            // FoodLabel
            // 
            this.FoodLabel.AutoSize = true;
            this.FoodLabel.Location = new System.Drawing.Point(530, 137);
            this.FoodLabel.Name = "FoodLabel";
            this.FoodLabel.Size = new System.Drawing.Size(37, 15);
            this.FoodLabel.TabIndex = 8;
            this.FoodLabel.Text = "Food:";
            this.FoodLabel.Visible = false;
            // 
            // DrinksLabel
            // 
            this.DrinksLabel.AutoSize = true;
            this.DrinksLabel.Location = new System.Drawing.Point(530, 208);
            this.DrinksLabel.Name = "DrinksLabel";
            this.DrinksLabel.Size = new System.Drawing.Size(43, 15);
            this.DrinksLabel.TabIndex = 9;
            this.DrinksLabel.Text = "Drinks:";
            this.DrinksLabel.Visible = false;
            // 
            // Table1Button
            // 
            this.Table1Button.BackColor = System.Drawing.Color.LightGreen;
            this.Table1Button.Location = new System.Drawing.Point(191, 40);
            this.Table1Button.Name = "Table1Button";
            this.Table1Button.Size = new System.Drawing.Size(50, 50);
            this.Table1Button.TabIndex = 10;
            this.Table1Button.Text = "1";
            this.Table1Button.UseVisualStyleBackColor = false;
            this.Table1Button.Visible = false;
            this.Table1Button.Click += new System.EventHandler(this.Table1Button_Click);
            // 
            // Table2Button
            // 
            this.Table2Button.BackColor = System.Drawing.Color.LightGreen;
            this.Table2Button.Location = new System.Drawing.Point(254, 40);
            this.Table2Button.Name = "Table2Button";
            this.Table2Button.Size = new System.Drawing.Size(50, 50);
            this.Table2Button.TabIndex = 11;
            this.Table2Button.Text = "2";
            this.Table2Button.UseVisualStyleBackColor = false;
            this.Table2Button.Visible = false;
            this.Table2Button.Click += new System.EventHandler(this.Table2Button_Click);
            // 
            // Table3Button
            // 
            this.Table3Button.BackColor = System.Drawing.Color.LightGreen;
            this.Table3Button.Location = new System.Drawing.Point(316, 40);
            this.Table3Button.Name = "Table3Button";
            this.Table3Button.Size = new System.Drawing.Size(50, 50);
            this.Table3Button.TabIndex = 12;
            this.Table3Button.Text = "3";
            this.Table3Button.UseVisualStyleBackColor = false;
            this.Table3Button.Visible = false;
            this.Table3Button.Click += new System.EventHandler(this.Table3Button_Click);
            // 
            // Table6Button
            // 
            this.Table6Button.BackColor = System.Drawing.Color.LightGreen;
            this.Table6Button.Location = new System.Drawing.Point(501, 40);
            this.Table6Button.Name = "Table6Button";
            this.Table6Button.Size = new System.Drawing.Size(50, 50);
            this.Table6Button.TabIndex = 15;
            this.Table6Button.Text = "6";
            this.Table6Button.UseVisualStyleBackColor = false;
            this.Table6Button.Visible = false;
            this.Table6Button.Click += new System.EventHandler(this.Table6Button_Click);
            // 
            // Table5Button
            // 
            this.Table5Button.BackColor = System.Drawing.Color.LightGreen;
            this.Table5Button.Location = new System.Drawing.Point(439, 40);
            this.Table5Button.Name = "Table5Button";
            this.Table5Button.Size = new System.Drawing.Size(50, 50);
            this.Table5Button.TabIndex = 14;
            this.Table5Button.Text = "5";
            this.Table5Button.UseVisualStyleBackColor = false;
            this.Table5Button.Visible = false;
            this.Table5Button.Click += new System.EventHandler(this.Table5Button_Click);
            // 
            // Table4Button
            // 
            this.Table4Button.BackColor = System.Drawing.Color.LightGreen;
            this.Table4Button.Location = new System.Drawing.Point(378, 40);
            this.Table4Button.Name = "Table4Button";
            this.Table4Button.Size = new System.Drawing.Size(50, 50);
            this.Table4Button.TabIndex = 13;
            this.Table4Button.Text = "4";
            this.Table4Button.UseVisualStyleBackColor = false;
            this.Table4Button.Visible = false;
            this.Table4Button.Click += new System.EventHandler(this.Table4Button_Click);
            // 
            // Table9Button
            // 
            this.Table9Button.BackColor = System.Drawing.Color.LightGreen;
            this.Table9Button.Location = new System.Drawing.Point(686, 40);
            this.Table9Button.Name = "Table9Button";
            this.Table9Button.Size = new System.Drawing.Size(50, 50);
            this.Table9Button.TabIndex = 18;
            this.Table9Button.Text = "9";
            this.Table9Button.UseVisualStyleBackColor = false;
            this.Table9Button.Visible = false;
            this.Table9Button.Click += new System.EventHandler(this.Table9Button_Click);
            // 
            // Table8Button
            // 
            this.Table8Button.BackColor = System.Drawing.Color.LightGreen;
            this.Table8Button.Location = new System.Drawing.Point(625, 40);
            this.Table8Button.Name = "Table8Button";
            this.Table8Button.Size = new System.Drawing.Size(50, 50);
            this.Table8Button.TabIndex = 17;
            this.Table8Button.Text = "8";
            this.Table8Button.UseVisualStyleBackColor = false;
            this.Table8Button.Visible = false;
            this.Table8Button.Click += new System.EventHandler(this.Table8Button_Click);
            // 
            // Table7Button
            // 
            this.Table7Button.BackColor = System.Drawing.Color.LightGreen;
            this.Table7Button.Location = new System.Drawing.Point(563, 40);
            this.Table7Button.Name = "Table7Button";
            this.Table7Button.Size = new System.Drawing.Size(50, 50);
            this.Table7Button.TabIndex = 16;
            this.Table7Button.Text = "7";
            this.Table7Button.UseVisualStyleBackColor = false;
            this.Table7Button.Visible = false;
            this.Table7Button.Click += new System.EventHandler(this.Table7Button_Click);
            // 
            // Table10Button
            // 
            this.Table10Button.BackColor = System.Drawing.Color.LightGreen;
            this.Table10Button.Location = new System.Drawing.Point(747, 40);
            this.Table10Button.Name = "Table10Button";
            this.Table10Button.Size = new System.Drawing.Size(50, 50);
            this.Table10Button.TabIndex = 19;
            this.Table10Button.Text = "10";
            this.Table10Button.UseVisualStyleBackColor = false;
            this.Table10Button.Visible = false;
            this.Table10Button.Click += new System.EventHandler(this.Table10Button_Click);
            // 
            // TablesLabel
            // 
            this.TablesLabel.AutoSize = true;
            this.TablesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TablesLabel.Location = new System.Drawing.Point(461, 6);
            this.TablesLabel.Name = "TablesLabel";
            this.TablesLabel.Size = new System.Drawing.Size(66, 25);
            this.TablesLabel.TabIndex = 20;
            this.TablesLabel.Text = "Tables";
            this.TablesLabel.Visible = false;
            // 
            // FoodQuantityLabel
            // 
            this.FoodQuantityLabel.AutoSize = true;
            this.FoodQuantityLabel.Location = new System.Drawing.Point(530, 169);
            this.FoodQuantityLabel.Name = "FoodQuantityLabel";
            this.FoodQuantityLabel.Size = new System.Drawing.Size(56, 15);
            this.FoodQuantityLabel.TabIndex = 21;
            this.FoodQuantityLabel.Text = "Quantity:";
            this.FoodQuantityLabel.Visible = false;
            // 
            // DrinkQuantityLabel
            // 
            this.DrinkQuantityLabel.AutoSize = true;
            this.DrinkQuantityLabel.Location = new System.Drawing.Point(530, 240);
            this.DrinkQuantityLabel.Name = "DrinkQuantityLabel";
            this.DrinkQuantityLabel.Size = new System.Drawing.Size(56, 15);
            this.DrinkQuantityLabel.TabIndex = 23;
            this.DrinkQuantityLabel.Text = "Quantity:";
            this.DrinkQuantityLabel.Visible = false;
            // 
            // FoodQuantityTextBox
            // 
            this.FoodQuantityTextBox.Location = new System.Drawing.Point(586, 166);
            this.FoodQuantityTextBox.Name = "FoodQuantityTextBox";
            this.FoodQuantityTextBox.ReadOnly = true;
            this.FoodQuantityTextBox.Size = new System.Drawing.Size(23, 23);
            this.FoodQuantityTextBox.TabIndex = 24;
            this.FoodQuantityTextBox.Visible = false;
            // 
            // DrinkQuantityTextBox
            // 
            this.DrinkQuantityTextBox.Location = new System.Drawing.Point(586, 237);
            this.DrinkQuantityTextBox.Name = "DrinkQuantityTextBox";
            this.DrinkQuantityTextBox.ReadOnly = true;
            this.DrinkQuantityTextBox.Size = new System.Drawing.Size(23, 23);
            this.DrinkQuantityTextBox.TabIndex = 25;
            this.DrinkQuantityTextBox.Visible = false;
            // 
            // AddFoodButton
            // 
            this.AddFoodButton.BackColor = System.Drawing.Color.LightGreen;
            this.AddFoodButton.Location = new System.Drawing.Point(680, 166);
            this.AddFoodButton.Name = "AddFoodButton";
            this.AddFoodButton.Size = new System.Drawing.Size(117, 23);
            this.AddFoodButton.TabIndex = 26;
            this.AddFoodButton.Text = "Add";
            this.AddFoodButton.UseVisualStyleBackColor = false;
            this.AddFoodButton.Visible = false;
            this.AddFoodButton.Click += new System.EventHandler(this.AddFoodButton_Click);
            // 
            // AddDrinkButton
            // 
            this.AddDrinkButton.BackColor = System.Drawing.Color.LightGreen;
            this.AddDrinkButton.Location = new System.Drawing.Point(680, 238);
            this.AddDrinkButton.Name = "AddDrinkButton";
            this.AddDrinkButton.Size = new System.Drawing.Size(117, 23);
            this.AddDrinkButton.TabIndex = 27;
            this.AddDrinkButton.Text = "Add";
            this.AddDrinkButton.UseVisualStyleBackColor = false;
            this.AddDrinkButton.Visible = false;
            this.AddDrinkButton.Click += new System.EventHandler(this.AddDrinkButton_Click);
            // 
            // FoodQuantityAddButton
            // 
            this.FoodQuantityAddButton.BackColor = System.Drawing.Color.LightGreen;
            this.FoodQuantityAddButton.Location = new System.Drawing.Point(621, 166);
            this.FoodQuantityAddButton.Name = "FoodQuantityAddButton";
            this.FoodQuantityAddButton.Size = new System.Drawing.Size(23, 23);
            this.FoodQuantityAddButton.TabIndex = 28;
            this.FoodQuantityAddButton.Text = "+";
            this.FoodQuantityAddButton.UseVisualStyleBackColor = false;
            this.FoodQuantityAddButton.Visible = false;
            this.FoodQuantityAddButton.Click += new System.EventHandler(this.FoodQuantityAddButton_Click);
            // 
            // FoodQuantitySubtractButton
            // 
            this.FoodQuantitySubtractButton.BackColor = System.Drawing.Color.MistyRose;
            this.FoodQuantitySubtractButton.Location = new System.Drawing.Point(651, 166);
            this.FoodQuantitySubtractButton.Name = "FoodQuantitySubtractButton";
            this.FoodQuantitySubtractButton.Size = new System.Drawing.Size(23, 23);
            this.FoodQuantitySubtractButton.TabIndex = 29;
            this.FoodQuantitySubtractButton.Text = "-";
            this.FoodQuantitySubtractButton.UseVisualStyleBackColor = false;
            this.FoodQuantitySubtractButton.Visible = false;
            this.FoodQuantitySubtractButton.Click += new System.EventHandler(this.FoodQuantitySubtractButton_Click);
            // 
            // DrinkQuantitySubtractButton
            // 
            this.DrinkQuantitySubtractButton.BackColor = System.Drawing.Color.MistyRose;
            this.DrinkQuantitySubtractButton.Location = new System.Drawing.Point(651, 237);
            this.DrinkQuantitySubtractButton.Name = "DrinkQuantitySubtractButton";
            this.DrinkQuantitySubtractButton.Size = new System.Drawing.Size(23, 23);
            this.DrinkQuantitySubtractButton.TabIndex = 31;
            this.DrinkQuantitySubtractButton.Text = "-";
            this.DrinkQuantitySubtractButton.UseVisualStyleBackColor = false;
            this.DrinkQuantitySubtractButton.Visible = false;
            this.DrinkQuantitySubtractButton.Click += new System.EventHandler(this.DrinkQuantitySubtractButton_Click);
            // 
            // DrinkQuantityAddButton
            // 
            this.DrinkQuantityAddButton.BackColor = System.Drawing.Color.LightGreen;
            this.DrinkQuantityAddButton.Location = new System.Drawing.Point(621, 237);
            this.DrinkQuantityAddButton.Name = "DrinkQuantityAddButton";
            this.DrinkQuantityAddButton.Size = new System.Drawing.Size(23, 23);
            this.DrinkQuantityAddButton.TabIndex = 30;
            this.DrinkQuantityAddButton.Text = "+";
            this.DrinkQuantityAddButton.UseVisualStyleBackColor = false;
            this.DrinkQuantityAddButton.Visible = false;
            this.DrinkQuantityAddButton.Click += new System.EventHandler(this.DrinkQuantityAddButton_Click);
            // 
            // TableDetailsLabel
            // 
            this.TableDetailsLabel.AutoSize = true;
            this.TableDetailsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TableDetailsLabel.Location = new System.Drawing.Point(434, 102);
            this.TableDetailsLabel.Name = "TableDetailsLabel";
            this.TableDetailsLabel.Size = new System.Drawing.Size(126, 25);
            this.TableDetailsLabel.TabIndex = 34;
            this.TableDetailsLabel.Text = "Order details";
            this.TableDetailsLabel.Visible = false;
            // 
            // FreeUpTableButton
            // 
            this.FreeUpTableButton.BackColor = System.Drawing.Color.MistyRose;
            this.FreeUpTableButton.Location = new System.Drawing.Point(360, 307);
            this.FreeUpTableButton.Name = "FreeUpTableButton";
            this.FreeUpTableButton.Size = new System.Drawing.Size(159, 37);
            this.FreeUpTableButton.TabIndex = 36;
            this.FreeUpTableButton.Text = "Free up the table";
            this.FreeUpTableButton.UseVisualStyleBackColor = false;
            this.FreeUpTableButton.Visible = false;
            this.FreeUpTableButton.Click += new System.EventHandler(this.FreeUpTableButton_Click_1);
            // 
            // CashRadioButton
            // 
            this.CashRadioButton.AutoSize = true;
            this.CashRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CashRadioButton.Location = new System.Drawing.Point(516, 394);
            this.CashRadioButton.Name = "CashRadioButton";
            this.CashRadioButton.Size = new System.Drawing.Size(51, 19);
            this.CashRadioButton.TabIndex = 39;
            this.CashRadioButton.TabStop = true;
            this.CashRadioButton.Text = "Cash";
            this.CashRadioButton.UseVisualStyleBackColor = true;
            this.CashRadioButton.Visible = false;
            // 
            // CardRadioButton
            // 
            this.CardRadioButton.AutoSize = true;
            this.CardRadioButton.Location = new System.Drawing.Point(427, 394);
            this.CardRadioButton.Name = "CardRadioButton";
            this.CardRadioButton.Size = new System.Drawing.Size(50, 19);
            this.CardRadioButton.TabIndex = 40;
            this.CardRadioButton.TabStop = true;
            this.CardRadioButton.Text = "Card";
            this.CardRadioButton.UseVisualStyleBackColor = true;
            this.CardRadioButton.Visible = false;
            // 
            // ExecutePaymentButton
            // 
            this.ExecutePaymentButton.BackColor = System.Drawing.Color.LightGreen;
            this.ExecutePaymentButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExecutePaymentButton.Location = new System.Drawing.Point(191, 520);
            this.ExecutePaymentButton.Name = "ExecutePaymentButton";
            this.ExecutePaymentButton.Size = new System.Drawing.Size(606, 45);
            this.ExecutePaymentButton.TabIndex = 41;
            this.ExecutePaymentButton.Text = "Execute payment";
            this.ExecutePaymentButton.UseVisualStyleBackColor = false;
            this.ExecutePaymentButton.Visible = false;
            this.ExecutePaymentButton.Click += new System.EventHandler(this.ExecutePaymentButton_Click);
            // 
            // PaymentDetailsLabel
            // 
            this.PaymentDetailsLabel.AutoSize = true;
            this.PaymentDetailsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PaymentDetailsLabel.Location = new System.Drawing.Point(420, 360);
            this.PaymentDetailsLabel.Name = "PaymentDetailsLabel";
            this.PaymentDetailsLabel.Size = new System.Drawing.Size(152, 25);
            this.PaymentDetailsLabel.TabIndex = 42;
            this.PaymentDetailsLabel.Text = "Payment details";
            this.PaymentDetailsLabel.Visible = false;
            // 
            // CustomerChequeCheckBox
            // 
            this.CustomerChequeCheckBox.AutoSize = true;
            this.CustomerChequeCheckBox.Location = new System.Drawing.Point(573, 426);
            this.CustomerChequeCheckBox.Name = "CustomerChequeCheckBox";
            this.CustomerChequeCheckBox.Size = new System.Drawing.Size(166, 19);
            this.CustomerChequeCheckBox.TabIndex = 43;
            this.CustomerChequeCheckBox.Text = "Print cheque for Customer";
            this.CustomerChequeCheckBox.UseVisualStyleBackColor = true;
            this.CustomerChequeCheckBox.Visible = false;
            // 
            // AmountReceivedLabel
            // 
            this.AmountReceivedLabel.AutoSize = true;
            this.AmountReceivedLabel.Location = new System.Drawing.Point(274, 428);
            this.AmountReceivedLabel.Name = "AmountReceivedLabel";
            this.AmountReceivedLabel.Size = new System.Drawing.Size(101, 15);
            this.AmountReceivedLabel.TabIndex = 44;
            this.AmountReceivedLabel.Text = "Amount received:";
            this.AmountReceivedLabel.Visible = false;
            // 
            // AmountReceivedTextBox
            // 
            this.AmountReceivedTextBox.Location = new System.Drawing.Point(381, 424);
            this.AmountReceivedTextBox.Name = "AmountReceivedTextBox";
            this.AmountReceivedTextBox.Size = new System.Drawing.Size(186, 23);
            this.AmountReceivedTextBox.TabIndex = 45;
            this.AmountReceivedTextBox.Visible = false;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(30, 232);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 15);
            this.IdLabel.TabIndex = 46;
            this.IdLabel.Text = "ID:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(57, 228);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(78, 23);
            this.IdTextBox.TabIndex = 47;
            // 
            // PinCodeLabel
            // 
            this.PinCodeLabel.AutoSize = true;
            this.PinCodeLabel.Location = new System.Drawing.Point(29, 265);
            this.PinCodeLabel.Name = "PinCodeLabel";
            this.PinCodeLabel.Size = new System.Drawing.Size(29, 15);
            this.PinCodeLabel.TabIndex = 48;
            this.PinCodeLabel.Text = "PIN:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(65, 194);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(63, 25);
            this.LoginLabel.TabIndex = 49;
            this.LoginLabel.Text = "Login";
            // 
            // PinCodeTextBox
            // 
            this.PinCodeTextBox.Location = new System.Drawing.Point(57, 261);
            this.PinCodeTextBox.Name = "PinCodeTextBox";
            this.PinCodeTextBox.Size = new System.Drawing.Size(78, 23);
            this.PinCodeTextBox.TabIndex = 50;
            // 
            // ConfirmLoginButton
            // 
            this.ConfirmLoginButton.BackColor = System.Drawing.Color.LightGreen;
            this.ConfirmLoginButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfirmLoginButton.Location = new System.Drawing.Point(57, 291);
            this.ConfirmLoginButton.Name = "ConfirmLoginButton";
            this.ConfirmLoginButton.Size = new System.Drawing.Size(78, 45);
            this.ConfirmLoginButton.TabIndex = 51;
            this.ConfirmLoginButton.Text = "Confirm";
            this.ConfirmLoginButton.UseVisualStyleBackColor = false;
            this.ConfirmLoginButton.Click += new System.EventHandler(this.ConfirmLoginButton_Click);
            // 
            // LoggedInAsLabel
            // 
            this.LoggedInAsLabel.AutoSize = true;
            this.LoggedInAsLabel.Location = new System.Drawing.Point(30, 472);
            this.LoggedInAsLabel.Name = "LoggedInAsLabel";
            this.LoggedInAsLabel.Size = new System.Drawing.Size(77, 15);
            this.LoggedInAsLabel.TabIndex = 52;
            this.LoggedInAsLabel.Text = "Logged in as:";
            this.LoggedInAsLabel.Visible = false;
            // 
            // LoggedInAsTextBox
            // 
            this.LoggedInAsTextBox.Location = new System.Drawing.Point(30, 490);
            this.LoggedInAsTextBox.Name = "LoggedInAsTextBox";
            this.LoggedInAsTextBox.ReadOnly = true;
            this.LoggedInAsTextBox.Size = new System.Drawing.Size(133, 23);
            this.LoggedInAsTextBox.TabIndex = 53;
            this.LoggedInAsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoggedInAsTextBox.Visible = false;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.LightGreen;
            this.LogOutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogOutButton.Location = new System.Drawing.Point(30, 520);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(133, 45);
            this.LogOutButton.TabIndex = 54;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Visible = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Restaurant_System.Properties.Resources.restaurants_logo;
            this.LogoPictureBox.Location = new System.Drawing.Point(-8, 6);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(193, 166);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 55;
            this.LogoPictureBox.TabStop = false;
            // 
            // OrderedProductsListBox
            // 
            this.OrderedProductsListBox.FormattingEnabled = true;
            this.OrderedProductsListBox.ItemHeight = 15;
            this.OrderedProductsListBox.Location = new System.Drawing.Point(191, 134);
            this.OrderedProductsListBox.Name = "OrderedProductsListBox";
            this.OrderedProductsListBox.Size = new System.Drawing.Size(328, 169);
            this.OrderedProductsListBox.TabIndex = 56;
            this.OrderedProductsListBox.Visible = false;
            // 
            // RemoveSelectedItemButton
            // 
            this.RemoveSelectedItemButton.BackColor = System.Drawing.Color.MistyRose;
            this.RemoveSelectedItemButton.Location = new System.Drawing.Point(191, 307);
            this.RemoveSelectedItemButton.Name = "RemoveSelectedItemButton";
            this.RemoveSelectedItemButton.Size = new System.Drawing.Size(161, 37);
            this.RemoveSelectedItemButton.TabIndex = 57;
            this.RemoveSelectedItemButton.Text = "Remove selected";
            this.RemoveSelectedItemButton.UseVisualStyleBackColor = false;
            this.RemoveSelectedItemButton.Visible = false;
            this.RemoveSelectedItemButton.Click += new System.EventHandler(this.RemoveSelectedItemButton_Click);
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Location = new System.Drawing.Point(530, 278);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(42, 15);
            this.TotalAmountLabel.TabIndex = 58;
            this.TotalAmountLabel.Text = "TOTAL:";
            this.TotalAmountLabel.Visible = false;
            // 
            // TotalAmountTextBox
            // 
            this.TotalAmountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalAmountTextBox.Location = new System.Drawing.Point(573, 272);
            this.TotalAmountTextBox.Name = "TotalAmountTextBox";
            this.TotalAmountTextBox.ReadOnly = true;
            this.TotalAmountTextBox.Size = new System.Drawing.Size(224, 29);
            this.TotalAmountTextBox.TabIndex = 59;
            this.TotalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalAmountTextBox.Visible = false;
            // 
            // ChequeViaEmailForCustomerCheckBox
            // 
            this.ChequeViaEmailForCustomerCheckBox.AutoSize = true;
            this.ChequeViaEmailForCustomerCheckBox.Location = new System.Drawing.Point(573, 455);
            this.ChequeViaEmailForCustomerCheckBox.Name = "ChequeViaEmailForCustomerCheckBox";
            this.ChequeViaEmailForCustomerCheckBox.Size = new System.Drawing.Size(190, 19);
            this.ChequeViaEmailForCustomerCheckBox.TabIndex = 60;
            this.ChequeViaEmailForCustomerCheckBox.Text = "Cheque via email for Customer";
            this.ChequeViaEmailForCustomerCheckBox.UseVisualStyleBackColor = true;
            this.ChequeViaEmailForCustomerCheckBox.Visible = false;
            // 
            // CustomerEmailAddressLabel
            // 
            this.CustomerEmailAddressLabel.AutoSize = true;
            this.CustomerEmailAddressLabel.Location = new System.Drawing.Point(237, 457);
            this.CustomerEmailAddressLabel.Name = "CustomerEmailAddressLabel";
            this.CustomerEmailAddressLabel.Size = new System.Drawing.Size(139, 15);
            this.CustomerEmailAddressLabel.TabIndex = 61;
            this.CustomerEmailAddressLabel.Text = "Customer email Address:";
            this.CustomerEmailAddressLabel.Visible = false;
            // 
            // CustomerEmailAddressTextBox
            // 
            this.CustomerEmailAddressTextBox.Location = new System.Drawing.Point(382, 453);
            this.CustomerEmailAddressTextBox.Name = "CustomerEmailAddressTextBox";
            this.CustomerEmailAddressTextBox.Size = new System.Drawing.Size(185, 23);
            this.CustomerEmailAddressTextBox.TabIndex = 62;
            this.CustomerEmailAddressTextBox.Visible = false;
            // 
            // ChequeViaEmailForRestaurantCheckBox
            // 
            this.ChequeViaEmailForRestaurantCheckBox.AutoSize = true;
            this.ChequeViaEmailForRestaurantCheckBox.Location = new System.Drawing.Point(573, 484);
            this.ChequeViaEmailForRestaurantCheckBox.Name = "ChequeViaEmailForRestaurantCheckBox";
            this.ChequeViaEmailForRestaurantCheckBox.Size = new System.Drawing.Size(194, 19);
            this.ChequeViaEmailForRestaurantCheckBox.TabIndex = 63;
            this.ChequeViaEmailForRestaurantCheckBox.Text = "Cheque via email for Restaurant";
            this.ChequeViaEmailForRestaurantCheckBox.UseVisualStyleBackColor = true;
            this.ChequeViaEmailForRestaurantCheckBox.Visible = false;
            // 
            // RestaurantEmailAddressTextBox
            // 
            this.RestaurantEmailAddressTextBox.Location = new System.Drawing.Point(382, 482);
            this.RestaurantEmailAddressTextBox.Name = "RestaurantEmailAddressTextBox";
            this.RestaurantEmailAddressTextBox.Size = new System.Drawing.Size(185, 23);
            this.RestaurantEmailAddressTextBox.TabIndex = 65;
            this.RestaurantEmailAddressTextBox.Visible = false;
            // 
            // RestaurantEmailAddressLabel
            // 
            this.RestaurantEmailAddressLabel.AutoSize = true;
            this.RestaurantEmailAddressLabel.Location = new System.Drawing.Point(231, 486);
            this.RestaurantEmailAddressLabel.Name = "RestaurantEmailAddressLabel";
            this.RestaurantEmailAddressLabel.Size = new System.Drawing.Size(143, 15);
            this.RestaurantEmailAddressLabel.TabIndex = 64;
            this.RestaurantEmailAddressLabel.Text = "Restaurant email Address:";
            this.RestaurantEmailAddressLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 580);
            this.Controls.Add(this.RestaurantEmailAddressTextBox);
            this.Controls.Add(this.RestaurantEmailAddressLabel);
            this.Controls.Add(this.ChequeViaEmailForRestaurantCheckBox);
            this.Controls.Add(this.CustomerEmailAddressTextBox);
            this.Controls.Add(this.CustomerEmailAddressLabel);
            this.Controls.Add(this.ChequeViaEmailForCustomerCheckBox);
            this.Controls.Add(this.TotalAmountTextBox);
            this.Controls.Add(this.TotalAmountLabel);
            this.Controls.Add(this.RemoveSelectedItemButton);
            this.Controls.Add(this.OrderedProductsListBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.LoggedInAsTextBox);
            this.Controls.Add(this.LoggedInAsLabel);
            this.Controls.Add(this.ConfirmLoginButton);
            this.Controls.Add(this.PinCodeTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PinCodeLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.AmountReceivedTextBox);
            this.Controls.Add(this.AmountReceivedLabel);
            this.Controls.Add(this.CustomerChequeCheckBox);
            this.Controls.Add(this.PaymentDetailsLabel);
            this.Controls.Add(this.ExecutePaymentButton);
            this.Controls.Add(this.CardRadioButton);
            this.Controls.Add(this.CashRadioButton);
            this.Controls.Add(this.FreeUpTableButton);
            this.Controls.Add(this.TableDetailsLabel);
            this.Controls.Add(this.DrinkQuantitySubtractButton);
            this.Controls.Add(this.DrinkQuantityAddButton);
            this.Controls.Add(this.FoodQuantitySubtractButton);
            this.Controls.Add(this.FoodQuantityAddButton);
            this.Controls.Add(this.AddDrinkButton);
            this.Controls.Add(this.AddFoodButton);
            this.Controls.Add(this.DrinkQuantityTextBox);
            this.Controls.Add(this.FoodQuantityTextBox);
            this.Controls.Add(this.DrinkQuantityLabel);
            this.Controls.Add(this.FoodQuantityLabel);
            this.Controls.Add(this.TablesLabel);
            this.Controls.Add(this.Table10Button);
            this.Controls.Add(this.Table9Button);
            this.Controls.Add(this.Table8Button);
            this.Controls.Add(this.Table7Button);
            this.Controls.Add(this.Table6Button);
            this.Controls.Add(this.Table5Button);
            this.Controls.Add(this.Table4Button);
            this.Controls.Add(this.Table3Button);
            this.Controls.Add(this.Table2Button);
            this.Controls.Add(this.Table1Button);
            this.Controls.Add(this.DrinksLabel);
            this.Controls.Add(this.FoodLabel);
            this.Controls.Add(this.DrinksListComboBox);
            this.Controls.Add(this.FoodListComboBox);
            this.Controls.Add(this.ConfirmOrderButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConfirmOrderButton;
        private System.Windows.Forms.ComboBox FoodListComboBox;
        private System.Windows.Forms.ComboBox DrinksListComboBox;
        private System.Windows.Forms.Label FoodLabel;
        private System.Windows.Forms.Label DrinksLabel;
        private System.Windows.Forms.Button Table1Button;
        private System.Windows.Forms.Button Table2Button;
        private System.Windows.Forms.Button Table3Button;
        private System.Windows.Forms.Button Table6Button;
        private System.Windows.Forms.Button Table5Button;
        private System.Windows.Forms.Button Table4Button;
        private System.Windows.Forms.Button Table9Button;
        private System.Windows.Forms.Button Table8Button;
        private System.Windows.Forms.Button Table7Button;
        private System.Windows.Forms.Button Table10Button;
        private System.Windows.Forms.Label TablesLabel;
        private System.Windows.Forms.Label FoodQuantityLabel;
        private System.Windows.Forms.Label DrinkQuantityLabel;
        private System.Windows.Forms.TextBox FoodQuantityTextBox;
        private System.Windows.Forms.TextBox DrinkQuantityTextBox;
        private System.Windows.Forms.Button AddFoodButton;
        private System.Windows.Forms.Button AddDrinkButton;
        private System.Windows.Forms.Button FoodQuantityAddButton;
        private System.Windows.Forms.Button FoodQuantitySubtractButton;
        private System.Windows.Forms.Button DrinkQuantitySubtractButton;
        private System.Windows.Forms.Button DrinkQuantityAddButton;
        private System.Windows.Forms.Label TableDetailsLabel;
        private System.Windows.Forms.Button FreeUpTableButton;
        private System.Windows.Forms.RadioButton CashRadioButton;
        private System.Windows.Forms.RadioButton CardRadioButton;
        private System.Windows.Forms.Button ExecutePaymentButton;
        private System.Windows.Forms.Label PaymentDetailsLabel;
        private System.Windows.Forms.CheckBox CustomerChequeCheckBox;
        private System.Windows.Forms.Label AmountReceivedLabel;
        private System.Windows.Forms.TextBox AmountReceivedTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label PinCodeLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox PinCodeTextBox;
        private System.Windows.Forms.Button ConfirmLoginButton;
        private System.Windows.Forms.Label LoggedInAsLabel;
        private System.Windows.Forms.TextBox LoggedInAsTextBox;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.ListBox OrderedProductsListBox;
        private System.Windows.Forms.Button RemoveSelectedItemButton;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.TextBox TotalAmountTextBox;
        private System.Windows.Forms.CheckBox ChequeViaEmailForCustomerCheckBox;
        private System.Windows.Forms.Label CustomerEmailAddressLabel;
        private System.Windows.Forms.TextBox CustomerEmailAddressTextBox;
        private System.Windows.Forms.CheckBox ChequeViaEmailForRestaurantCheckBox;
        private System.Windows.Forms.TextBox RestaurantEmailAddressTextBox;
        private System.Windows.Forms.Label RestaurantEmailAddressLabel;
    }
}
