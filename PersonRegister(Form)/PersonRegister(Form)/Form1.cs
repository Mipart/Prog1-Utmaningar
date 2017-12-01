using System;
using System.Linq;
using System.Windows.Forms;

namespace PersonRegister_Form_
{
    // TODO Remove person!!!
    public partial class Form1 : Form
    {
        Register theRegister = new Register();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        private void AddPerson()
        {
            //Get the person data
            string name = txt_name.Text;
            string town = txt_town.Text;
            byte age;
            byte.TryParse(txt_age.Text, out age);

            //Add the person
            theRegister.AddPerson(name, town, age);

            //Update the CB
            UpdateCB();
        }

        private void UpdateText()
        {
            Person person = theRegister.GetList().ElementAt(cb_nameBox.SelectedIndex);
            txt_name.Text = person.GetName();
            txt_town.Text = person.GetTown();
            txt_age.Text = person.GetAge();
        }

        //Update the combobox
        private void UpdateCB()
        {
            //Remove the list
            cb_nameBox.Items.Clear();
            //Add all person again
            foreach (Person item in theRegister.GetList())
            {
                cb_nameBox.Items.Add(item.GetName());
            }
        }

        private void cb_nameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateText();
            Console.WriteLine("Change in CB!!!");
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            RemovePerson();
        }

        private void RemovePerson()
        {
            //Dont run code if no item is selected or the ammount of stuff in the register is zero
            if (theRegister.GetList().Capacity == 0 || cb_nameBox.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                theRegister.GetList().RemoveAt(cb_nameBox.SelectedIndex);
                cb_nameBox.SelectedIndex = 0;
                UpdateCB();
                //Clear the text
                txt_age.Text = "";
                txt_name.Text = "";
                txt_town.Text = "";
                //Debug
                Console.WriteLine("Removed!");
            }
        }
    }
}
