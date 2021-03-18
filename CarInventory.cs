// Author : Devanshu Dave
// Date - 17-03-2021
// Description- The lab 4 c# code which loows the user to enter the car make, model , year and price, even 
//                giving the option to check its new or not. The form will also show the entered car on the list.
//               This will also check for errors if the user forget to enter the input 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class formCarInventory : Form
    {
        private List<Car> carList = new List<Car>();
        // the is declared as false
        private bool isAutomated = false;
        // declared selected index = -1 which will reference to indexes
       private int selectedIndex = -1;

        
        public formCarInventory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This when enterd validates the input and if all worked well then it will add the input to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonToEnter(object sender, EventArgs e)
        {
            // error output set to empty
            labelErrorOutput.Text = String.Empty;
            // To check validation
            if (IsCarvalid(comboBoxTitle.Text, textBoxModel.Text, Convert.ToInt16(comboBox1.Text),textBoxPrice.SelectionLength))
            {
                // object has been created and if customer details are valid
                Car newCarToAdd = new Car(comboBoxTitle.Text, textBoxModel.Text,Convert.ToInt32( comboBox1.Text),Convert.ToDecimal( textBoxPrice.Text),  checkBoxNew.Checked);

                // this if checkes wheter car is selected ot not
                if (selectedIndex >= 0)
                {
                    // this is to replace to new version of input.
                    carList[selectedIndex] = newCarToAdd;
                }
                else
                {
                    // this will add freshly input to the list
                    carList.Add(newCarToAdd);
                    labelErrorOutput.Text += "It Worked!";
                    // listViewCar.Refresh();

                }
                // This will refresh the listview
                PopulateListView(carList);

                SetDefaults();

            }
        }
        /// <summary>
        /// This is to reset the form to default
        /// </summary>

        private void ButtonToReset(object sender, EventArgs e)
        {
            SetDefaults();
        }
        /// <summary>
        /// Cleses the form(exits)
        /// </summary>

        private void ButtonToExit(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// When the car is selected then this will write the car's property to the contros when the user will input
        /// </summary>

        private void CarSelected(object sender, EventArgs e)
        {
            // if list is populated with entries
            if (listViewCar.Items.Count > 0 && listViewCar.FocusedItem != null)
            {
                // this will fill into the fields 
                comboBoxTitle.Text = listViewCar.FocusedItem.SubItems[1].Text;
                textBoxModel.Text = listViewCar.FocusedItem.SubItems[2].Text;
                comboBox1.Text = listViewCar.FocusedItem.SubItems[3].Text;                
                textBoxPrice.Text = listViewCar.FocusedItem.SubItems[4].Text;
                checkBoxNew.Checked = listViewCar.FocusedItem.Checked;

                // seting the selected index to match the list view
                selectedIndex = listViewCar.FocusedItem.Index;

            }
            else
            {
                // if nothing is selected and set to -1
                selectedIndex = -1;
            }
        }
        /// <summary>
        /// When a check box is checked and then user can not change any thing
        /// </summary>
        
        private void PreventCheck(object sender, ItemCheckEventArgs e)
        {
            // allows the users input
            if (!isAutomated)
            {
                e.NewValue = e.CurrentValue;
            }
        }
        /// <summary>
        /// This will cunvert car to list view list view and will add to the lsit entries
        /// </summary>
        /// <param name="carList"></param>
        private void PopulateListView(List<Car> carList)
        {
            // clearing to repopulate
            listViewCar.Items.Clear();
           
         

            foreach (Car newCar in carList)
            {
                // declared here and this will create a new list item
                ListViewItem carItem = new ListViewItem();
                // allows to chenge the boxex
                isAutomated = true;

                carItem.Checked = newCar.NewStatus;
                carItem.SubItems.Add(newCar.IdentificationNumber.ToString());
                carItem.SubItems.Add(newCar.Make);
                carItem.SubItems.Add(newCar.Model);
                carItem.SubItems.Add(newCar.Year.ToString());
                carItem.SubItems.Add(newCar.Price.ToString("$,#,0.00"));

                labelErrorOutput.Text += "It Worked!";
                // to add car to list which will be displayed to user
                listViewCar.Items.Add(carItem);
                // not alowed to modify
                isAutomated = false;

            }

        }
        /// <summary>
        /// when reset button selected this will put the form to its default form as coded down
        /// </summary>
        private void SetDefaults()
        {
            // set each field to default when resets
            comboBoxTitle.SelectedIndex = -1;
            textBoxModel.Clear();
            comboBox1.SelectedIndex = -1;
            
            
            textBoxPrice.Clear();

            checkBoxNew.Checked = false;
            listViewCar.SelectedItems.Clear();
            labelErrorOutput.Text = String.Empty;
            selectedIndex = -1;

            comboBoxTitle.Focus();


        }

        /// <summary>
        /// Checking for validation for every field
        /// </summary>
        /// <param name="Make"></param>
        /// <param name="Model"></param>
        /// <param name="Year"></param>
        /// <param name="Price"></param>
        /// <returns></returns>
        private bool IsCarvalid(string Make, string Model, int Year, decimal Price)
        {
            // assume to be true
            bool isValid = true;
            // checking make field
            if (Make == String.Empty)
            {
                // error if its empty
                isValid &= false;
                labelErrorOutput.Text += "You must select a Make.\n";
            }
            // checking the model field
            if (Model == String.Empty)
            {
                // error if the model
                isValid &= false;
                labelErrorOutput.Text += "You must enter the Model";
            }
            // checking tryparse and also if price is positive or not anf for price field to empty
            if (decimal.TryParse(textBoxPrice.Text, out Price))
            {
                //checking for price to be positive
                if(Price <= 0)
                {
                    // if not show this error
                    isValid &= false;
                    labelErrorOutput.Text += " \nYear positive please";
                }

            }
            else
            {
                // if not entered anything then to show this error
                isValid &= false;
                labelErrorOutput.Text += " \nEnter  a price";
            }

            // return the isvalid value
            return isValid;
        }
        private void formCarInventory_Load(object sender, EventArgs e)
        {

        }
    }
}
