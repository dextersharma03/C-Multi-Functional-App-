using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_4;
using System.Collections; //must add this class library for LIST
using System.IO; // reading files

namespace Assignment_4
{
    public partial class Assignment4 : Form
    {
        public Assignment4()
        {
            //Dikshit Sharma
            //300287961
            InitializeComponent();
        }

        private void Assignment4_Load(object sender, EventArgs e)
        {
            ReadFile();                                                 // Read the PhoneList.txt file.            
            DisplayNames();                                             // Display the names.
        }

        #region Chapter 8

        #region Array List

        private void addButton_Click(object sender, EventArgs e)
        {
            lists();    //method is called
        }

        private void lists()
        {
            List<string> AddNames = new List<string>();     //list is declared 

            AddNames.Add(nameTextBox.Text);      //values from textbox is added to the list

            foreach (string x in AddNames)
            {
                nameListBox.Items.Add(x);      //listbox has items that are typed in textbox
                nameListBox.SelectedIndex = 0;
                nameTextBox.Clear();     //all text is selected from textbox
                nameTextBox.Focus();  //focus is made on textbox
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            removeit(); //method is called
        }

        private void removeit()
        {
            string s = nameListBox.SelectedItem.ToString();     //selected item is put into string
            nameListBox.Items.Remove(s);            //selected item is removed
            nameListBox.SelectedIndex = 0;          //focus is set back to the first item

        }
        private void sortButton_Click(object sender, EventArgs e)
        {
            nameListBox.Sorted = true;          //items are sorted in ascending
            nameListBox.SelectedIndex = 0;      //focus is set back to the first item
        }





        #endregion

        #region ref vs out

        private void refButton_Click(object sender, EventArgs e)
        {
            int r = 1;  //must be set before passing to method
            bezeroRef(ref r);   //ref is refering it to the method
            refLabel.Text = r.ToString();       //result zero is shoen by putting it to the string
        }

        private void bezeroRef(ref int num)
        {
            num = 0;   //value is set
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            int r;      //does not have to be set before passing to method
            bezeroOut(out r);
            outLabel.Text = r.ToString();   //result zero is shoen by putting it to the string
        }

        private void bezeroOut(out int num)
        {
            num = 0;    //value is set
        }
        #endregion

        #region Character testing for Password

        
        private void countCharButton_Click(object sender, EventArgs e)
        {
            string password = countCharTextBox.Text;      //entered string value is assigned to a string variable
            IsDigitCheck(password);         //methods are called and string is passed
          
            firstCharacterLabel.Text= FirstLetter(password).ToString();
            countCharsLabel.Text = MorethanSix(password).ToString();
            LastCharCheck(password);
            IsCapital(password);
            NoSpaces(password);
            CheckDigitAndString(password);
            WeakOrStrong(password);
        }

        private void IsDigitCheck(string password)
        {
            foreach (char ch in password)       //for each character in string

                if (char.IsDigit(ch))       //checks if the character is digit
                {
                    isDigitLabel.Text = "Yes";      //displays Yes
                    isDigitLabel.BackColor = Color.Aqua;        //sets background color
                }
                else
                {
                    isDigitLabel.BackColor = default(Color);     //sets background color
                    isDigitLabel.Text = "No";   //displays no
                }
          
          
        }
        private char FirstLetter(string password)
        {
            firstCharacterLabel.BackColor = Color.Aqua;      //sets background color
            return password[0];     //returns first character of string
        }
        private int MorethanSix(string password)
        {
            int x;
            if (password.Length >= 6)       //if entered string is greater than 6 character
            {
                countCharsLabel.BackColor = Color.Aqua;          //sets background color
                x = password.Count();       //counts the characters in string
            }
            else
            {
                countCharsLabel.BackColor = default(Color);      //sets background color back to default
                x = password.Count();   //counts the characters in string
            }
            return x;       //returns the count
        }

        private string LastCharCheck(string password)
        {
            foreach (char c in password)        //for every character in string 
            {
                if (char.IsDigit(password[password.Length - 1]))        //checks the string's last character for a digit
                {
                    lastCharacterLabel.BackColor = Color.Aqua;       //sets background color
                    lastCharacterLabel.Text = "Yes"; //display yes
                }
                else
                {
                    lastCharacterLabel.BackColor = default(Color);       //sets background color
                    lastCharacterLabel.Text = "No"; //display no
                }
            }
            return password;
        }
        private string IsCapital(string password)
        {
            string answer = "";
            foreach (char c in password)        //for every character in string 
            {
                 if (char.IsUpper(c) == true)      //checks if first letter is in capital
                {
                    oneCapitalLabel.BackColor = Color.Aqua;          //sets background color
                    oneCapitalLabel.Text = "Yes";            //sets texts as yes
                    return answer;
                }
                else 
                {
                    oneCapitalLabel.BackColor = default(Color);      //sets background color
                    oneCapitalLabel.Text = "No";     //sets texts as no
                }
            }
            return answer;
        }

        private string NoSpaces(string password)
        {   
            foreach (char c in password)        //for every character in string
                if (char.IsWhiteSpace(c) == true)       //checks the whitespaces in the whole string 
                {
                    noSpacesLabel.BackColor = default(Color);        //sets background color
                    noSpacesLabel.Text = "Yes";     //sets texts as yes
                }
                else
                {
                    noSpacesLabel.BackColor = Color.Aqua;        //sets background color
                    noSpacesLabel.Text = "No";      //sets texts as no
                }
            return password;
        }

        private string CheckDigitAndString(string password)
        {
            string str;
            int alp, digit, splch, i, l;        
            alp = digit = splch = i = 0;        //variables are initialized

            str = password;     //string assigned to variables
            l = str.Length;     //length is assigned 

            /* Checks each character of string*/

            while (i < l)       //loops till the length
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))   // checks for the alphabets ranging from a-z and A-Z
                {
                    alp++;          //increments the value
                }
                else if (str[i] >= '0' && str[i] <= '9') //checks for the number 0-9
                {
                    digit++;    //increments the value
                }
                i++;
            }

            numberOFCharsLabel.Text = alp.ToString();       //displays the and convert the char to string
            numberOfDigitsLabel.Text = digit.ToString();     //displays the and convert the digit to string
            return password;

        }
        private string WeakOrStrong(string password)
        {
            if(countCharsLabel.BackColor==Color.Aqua && firstCharacterLabel.BackColor==Color.Aqua
                && lastCharacterLabel.BackColor==Color.Aqua && isDigitLabel.BackColor==Color.Aqua
                && oneCapitalLabel.BackColor==Color.Aqua && noSpacesLabel.BackColor==Color.Aqua)  //checks on the basis of back color only when the conditions are met
            {
                strongPasswordLabel.Text = "Secure";
            }
            else
                strongPasswordLabel.Text = "Weak";      //sets the text to weak
            return password;    //returns the string value
        }

        #endregion

        #region Search string
        private void searchButton_Click(object sender, EventArgs e)
        {
            searchcondition();  //calls the value
        }

        private void searchcondition()
        {
            string x;
            string y;
            x = stringSearchLabel.Text; //assigns the string 
            y = searchStringTextBox.Text;       //assigns the string 
            if (count(x, y).ToString() == "0")      //checks if the count is zero then show "Not Found"
                searchLabel.Text = "Not Found";
            else                                     //if it has some count then show 
                searchLabel.Text = "Found " + count(x, y).ToString() + " charater!";
        }

        private int count(string text, string searchtext)
        {
                int count = 0;
                int i = 0;
               while ((i = text.IndexOf(searchtext, i)) != -1)      //checks the index value and if it has some value 
                {
                    i += searchtext.Length;     //increments i after search
                    count++;        //assigns value to count 
                }
              
                return count;   //returns the value stored in count
            
        }

        #endregion

        #region Average Student Marks       

        private void averageStudentButton_Click(object sender, EventArgs e)
        {
            string filename; // To hold the filename

            GetFileName(out filename); // Get the filename from the user.
            getaverage();
        }

        private void getaverage()
        {
            try
            {
                StreamReader inputFile;                     // To read the file
                string line;                                // To hold a line from the file
                int count = 0;                              // Student counter
                int total;                                  // Accumulator
                double average;                                 
                char delim = ',';                           
                                          

                inputFile = File.OpenText("Grades.csv");    // Open the CSV file.

                while (!inputFile.EndOfStream)
                {
                    count++;                                // Increment the counter.       
                    line = inputFile.ReadLine();            // Read a line from the file.                  
                    string[] tokens = line.Split(delim);                  
                    total = 0;                              // Set the accumulator to 0.

                    foreach (string str in tokens)          // Calculate the total of the// test score tokens.
                        total += int.Parse(str);
                    average = (double)total / tokens.Length;// Calculate the average of these// test scores.                   
                    averageStudentListBox.Items.Add("The average for student " + count + " is " + average.ToString("n1")); // Display the average.
                }
                inputFile.Close();                          // Close the file.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                // Display an error message.
            }
        }

        private void GetFileName(out string selectedFile)
        {
            // The GetFileName method gets a filename from the
            // user and assigns it to the variable passed as
            // an argument.
            OpenFileDialog openFile = new OpenFileDialog();
            if ( openFile.ShowDialog()== DialogResult.OK)
                selectedFile = openFile.FileName;
            else
                selectedFile = "";
        }

        #endregion

        #region Struct Add a Car

        struct AddSuperCars
        {
            public string Make;     
            public string Year;
            public string Mileage;
        }
        private void button_AddCar_Click(object sender, EventArgs e)
        {
            ReadData();         //calls the method 
            ShowData();         //calls the method
        }


        private List<AddSuperCars> CarsList = new List<AddSuperCars>(); // Field to hold a list of CarsList objects.

        private void ReadData()
        {
            AddSuperCars car = new AddSuperCars();
            CarsList.Clear();       //clears list
            car.Make = comboBox_Make.SelectedItem.ToString();       //sets the make to the classes property
            car.Year = comboBox_Year.SelectedItem.ToString();        //sets the year to the classes property
            car.Mileage = comboBox_Milage.SelectedItem.ToString();   //sets the mileage to the classes property
            CarsList.Add(car);      //adds the car and its properties to the list
           
        }


        private void ShowData()
        {
            foreach (AddSuperCars car in CarsList)      //for every car added to list
                listBox_Display.Items.Add(car.Year + " "+car.Make+" " +"with miles");       //then it is shown
        }

        #endregion

        #region Phone List

        struct PhoneBookEntry
        {
            public string Fname;
            public string Lname;
            public string phone3;
            public string phone4;
            public string email;
        }
       
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>(); // Field to hold a list of PhoneBookEntry objects.
        private void ReadFile()
        {
            try
            {
                StreamReader inputFile;                                 // To read the file
                string line;                                            // To hold a line from the file

                PhoneBookEntry entry = new PhoneBookEntry();            // Create an instance of the PhoneBookEntry structure.

                char[] delim = { ' ', ',', '-' };                        // Create a delimiter array.

                inputFile = File.OpenText("PhoneList.txt");             // Open the PhoneList file.

                while (!inputFile.EndOfStream)                          // Read the lines from the file.
                {
                    line = inputFile.ReadLine();                        // Read a line from the file.                 
                    string[] tokens = line.Split(delim);                // Tokenize the line                 
                    entry.Fname = tokens[0];
                    entry.Lname = tokens[1];                            // Store the tokens in the entry object.
                    entry.phone3 = tokens[2];
                    entry.phone4 = tokens[3];
                    entry.email = tokens[4];

                    phoneList.Add(entry);                               // Add the entry object to the List.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                            // Display an error message.
            }
        }

        

        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
                listBox_Contacts.Items.Add(entry.Fname + " " + entry.Lname);
        }



        private void listBox_Contacts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = listBox_Contacts.SelectedIndex;                      // Get the index of the selected item.          
            label_PhoneNumber.Text = phoneList[index].phone3+"-"+phoneList[index].phone4;                   // Display the corresponding phone number.
            label_eMail.Text = phoneList[index].email;         // Display the corresponding email.
        }






        #endregion

        #endregion

        #region Chapter 9

        #region Toss The Coin
        private void tossButton_Click(object sender, EventArgs e)
        {
            toss();
            HeadsTailsCount();

        }


        private void HeadsTailsCount()
        {
            string[] x = coinTossListBox.Items.OfType<string>().ToArray();      //string values of listbox are converted to string array
            string[] y = coinTossListBox.Items.OfType<string>().ToArray();
            string[] z = coinTossListBox.Items.OfType<string>().ToArray();

            int j = 0, k = 0; //integers are initialized
            for (int i = 0; i < x.Length; i++)      //int i is initialized to zero
            {
                if (x[i] == "Heads")          // checks if the array element's remainder after dividing by 2 is zero, that is whether it is even r
                {

                    j++;
                }
                else            //if the array element is odd
                {

                    k++;
                }
            }
            totalHeadsLabel.Text = j.ToString();       //shows on label
            totalTailsLabel.Text = k.ToString();
        }

        private void toss()
        {
            Coin_Class myCoin = new Coin_Class();             // Create a myCoin object.

            coinTossListBox.Items.Clear();                    // Clear the ListBox.
            for (int count = 0; count < 27; count++)         // Toss the coin 27 times.
            {
                myCoin.Toss();                              // Toss the coin.             
                coinTossListBox.Items.Add(myCoin.GetSideUp());// Display the side that is up.
            }
        }
        #endregion

        #region Cell Phone Data

        List<CellphoneData> PhoneList = new List<CellphoneData>();          // List to hold PhoneList objects

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CellphoneData myPhone = new CellphoneData();                // Create a myPhone object.
            GetPhoneData(myPhone);                              // Get the phone data.
            OutPutPhoneData(myPhone);
            OutPutPhoneData2(myPhone);

        }

        private void OutPutPhoneData2(CellphoneData myPhone)
        {
            PhoneList.Add(myPhone);                                 // Add the myPhone object to the List.            
            phoneListBox.Items.Add(myPhone.Brand + " " +            // Add an entry to the list box.
                                   myPhone.Model+" is "+myPhone.Price.ToString("$"+"0.00"));

            brandTextBox.Clear();                                   // Clear the TextBox controls.
            modelTextBox.Clear();
            priceTextBox.Clear();
            brandTextBox.Focus();
        }

        

        private void OutPutPhoneData(CellphoneData myPhone)
        {
            brandLabel.Text = myPhone.Brand;                    // Display the phone data.
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("c");
        }

       

        private void GetPhoneData(CellphoneData myPhone)
        {
            decimal price;                                      // Temporary variable to hold the price.           
            myPhone.Brand = brandTextBox.Text;                  // Get the phone's brand.          
            myPhone.Model = modelTextBox.Text;                  // Get the phone's model.           
            if (decimal.TryParse(priceTextBox.Text, out price)) // Check exception and Get the phone's price.
                myPhone.Price = price;                          // Assign the price to the property
            else
                MessageBox.Show("Invalid price");               // Display an error message.
        }

        #endregion

        #region Bank Account
        BankInfo account = new BankInfo(1000);                // BankAccount field with a $1000 starting balance 


        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount;                                         // To hold the amount of deposit           
            if (decimal.TryParse(depositTextBox.Text, out amount))  // Convert the amount to a decimal.
            {
                account.Deposit(amount);                            // Deposit the amount into the account.                
                balanceLabel.Text = account.Balance.ToString("c");  // Display the new balance.                
                depositTextBox.Clear();                             // Clear the text box.
            }
            else
            {
                MessageBox.Show("Invalid amount");                  // Display an error message.
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            decimal amount;                                         // To hold the amount of withdrawal           
            if (decimal.TryParse(withdrawTextBox.Text, out amount)) // Convert the amount to a decimal.
            {
                account.Withdraw(amount);                           // Withdraw the amount from the account.                
                balanceLabel.Text = account.Balance.ToString("c");  // Display the new balance.               
                withdrawTextBox.Clear();                            // Clear the text box.
            }
            else
            {
                MessageBox.Show("Invalid amount");                  // Display an error message.
            }
        }

        #endregion

        #region Automotive Shop

        private void buttonCharges_Click(object sender, EventArgs e)
        {
            REsult();
        }

        private void REsult()
        {
            Automotive_Car NewCar = new Automotive_Car();            // Create a NewCra object.
            Automotive_Customer NewCustomer = new Automotive_Customer();         // Create a NewCustomer object.
            ServiceRequest Charges = new ServiceRequest();       // Create a Charges object.
            getAutomiveCar(NewCar);
            getAutomiveCustomer(NewCustomer);
            getServiceCharges(Charges);
        }

        private void getServiceCharges(ServiceRequest charges)
        {
            decimal parts,labour,tax;                                                 

            if (decimal.TryParse(textBoxPartsCharge.Text, out parts)) // Check exception and Get the car's parts
            {
                charges.Parts = parts;                          
                {
                    if (decimal.TryParse(textBoxLaborCharge.Text, out labour)) // Check exception and Get the car's labour.
                    {
                        charges.Labour = labour;
                        {
                            if (decimal.TryParse(textBoxTaxRate.Text, out tax)) // Check exception and Get the car's tax.
                            {
                                charges.Tax = tax;
                                decimal x,y;            
                                x = tax + labour;
                                y = parts*x;
                                labelTotalCharge.Text = (y+x).ToString("$"+"0.00");     //calculates the charge
                                labelAutomive.Text = textBoxName.Text + " owns a " + textBoxMake.Text + " Cost " + labelTotalCharge.Text;
                            }
                        }
                    }
                }
            }
            else
                MessageBox.Show("Invalid Entry");
        }

      

        private void getAutomiveCustomer(Automotive_Customer newCustomer)
        {
                                                         
            newCustomer.Name = textBoxName.Text;                  // Get the customer's name.          
            newCustomer.Address = textBoxAddress.Text;                  // Get the customer's address.            
            newCustomer.Phone = textBoxPhone.Text;                  // Get the customer's phone

        }

        private void getAutomiveCar(Automotive_Car newCar)
        {
                                                         
            newCar.Make = textBoxMake.Text;                  // Get the car's make.          
            newCar.Model = textBoxModel.Text;                  // Get the car's model.           
            newCar.Year = textBoxYear.Text;             //   Get the car's year.
             
        }


        #endregion

        #region Aboutbox
        private void buttonAboutBox_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();        //aboutbox form is shown and called
            about.ShowDialog();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #endregion


    }
}