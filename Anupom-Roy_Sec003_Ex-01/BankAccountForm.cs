using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anupom_Roy_Sec003_Ex_01
{
    public partial class BankAccountForm : Form
    {
        SortedDictionary<int, BankAccount> bankAccDict = new SortedDictionary<int, BankAccount>();
        public double[] doubleArray = new double[5];
        LinkedList newLinlist = new LinkedList();
        public BankAccountForm()
        {
            InitializeComponent();
        }
        private void AddDictionaryItem(SortedDictionary<int, BankAccount> var, BankAccount bankAcc)
        {
            int id = Convert.ToInt32(textBoxAccNum.Text);
            var.Add(id, bankAcc);

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
           
                int accNum = Convert.ToInt32(textBoxAccNum.Text);
                string name = textBoxCustName.Text;
                double balance = Convert.ToDouble(textBoxBalance.Text);
                string banker = textBoxBanker.Text;
                BankAccount bankAcc = new BankAccount(accNum, name, balance, banker);

                AddDictionaryItem(bankAccDict, bankAcc);
           
           
        }
        private void RemoveDictionaryItem(SortedDictionary<int, BankAccount> dict, int key)
        {
            dict.Remove(key);
            // foreach (var k in dict.Keys.OrderBy(k => k).Take(key).ToArray()) dict.Remove(k);
        }
        private void btnDell_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxAccNum.Text);
            RemoveDictionaryItem(bankAccDict, id);
        }
        private void SearchDictionaryItem(SortedDictionary<int, BankAccount> var, int key)
        {
           
            if (var.ContainsKey(key))
            {
                listBoxOutput.Items.Clear();               
                listBoxOutput.Items.Add($"{key} is Found !!!");            
                
            }
            else
            {                
                listBoxOutput.Items.Clear();
                listBoxOutput.Items.Add($"Key is Not Found !!");

            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxAccNum.Text);
            SearchDictionaryItem(bankAccDict, id);
        }
    
        private void PrintDictionary(SortedDictionary<int, BankAccount> verAcc)
        {
            foreach (var item in verAcc.Keys)
            {
                listBoxOutput.Items.Add(verAcc[item].ToString());
            }
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            PrintDictionary(bankAccDict);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random ranNum = new Random();

            listBoxLinkedList.Items.Clear();
            for (int i = 0; i < doubleArray.Length; i++)
            {
                doubleArray[i] = Math.Round(ranNum.NextDouble()*100, 2);//ranNum.Next(11,99);
                listBoxLinkedList.Items.Add(doubleArray[i].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add to linked list
            try
            {
                InputValidation(listBoxLinkedList.SelectedItem.ToString());
                double num = Convert.ToDouble(listBoxLinkedList.SelectedItem.ToString());
                newLinlist.InsertAtBack(num);
                listBoxOutput.Items.Add(newLinlist.Display());
            }
            catch (InputException el)
            {
                MessageBox.Show(el.Message, "LinkedList");
            }
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Remove From Front
            try
            {
                newLinlist.RemoveFromFront();
                listBoxOutput.Items.Add(newLinlist.Display());
            }
            catch (EmptyListException el)
            {
                MessageBox.Show(el.Message, "LinkedList");
            }

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Add("Max : " + newLinlist.MaxNumber().ToString());
        }

        public void KeyPressValivation(object sender, KeyPressEventArgs e)
        {
            if (textBoxAccNum.Focused)
            { if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }
            if (textBoxCustName.Focused)
            { if (char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }
            if (textBoxBalance.Focused)
            { if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }
            if (textBoxBanker.Focused)
            { if (char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }
        }
        //validating user input
        public void InputValidation(string input)
        {
            string inputNum = input;
            if (inputNum == "") throw new InputException("Give an appropriate input");
            if (listBoxLinkedList.SelectedItem.ToString()==null) throw new InputException("Please generate Number");
            //if (inputNum == "" && rbDoubles.Checked) throw new InputException("Give an appropriate Decemal number");
            //..if (inputNum == "" && rbChar.Checked) throw new InputException("Give an appropriate Letter");
        }
    }
}
