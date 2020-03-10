using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int inde;
        public char sign2;
        public string Current_str;
        public double Current_Num;
        // public double Current_Num2;
        public double result;
        public char sign;
        public string comma=null;
        public string cut;
        public int size = 0;
        public bool k = false;
        public bool h = false;
        public string equal;
        public string str;
        
       

        Regex regex = new Regex(@"^[-+]?[0-9]{0,1}\.?[0-9]$");


        private void button10_Click(object sender, EventArgs e)
        { 
        
            
            if (comma != ", ") { textBox1.Text += "0"; }
            else if (textBox1.Text.Contains(",")) { textBox1.Text += "0"; }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (comma != ",") { textBox1.Text += "1"; }
                else if (textBox1.Text.Contains(",")) { textBox1.Text += "1"; }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (comma != ",") { textBox1.Text += "2"; }
                else if (textBox1.Text.Contains(",")) { textBox1.Text += "2"; }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
               if (comma != ",") { textBox1.Text += "3"; }
                else if (textBox1.Text.Contains(",")) { textBox1.Text += "3"; }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                if (comma != ",") { textBox1.Text += "4"; }
            else if (textBox1.Text.Contains(",")) { textBox1.Text += "4"; }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            if (comma != ",") { textBox1.Text += "5"; }
            else if (textBox1.Text.Contains(",")) { textBox1.Text += "5"; }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
                if (comma != ",") { textBox1.Text += "6"; }
            else if (textBox1.Text.Contains(",")) { textBox1.Text += "6"; }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            if (comma != ",") { textBox1.Text += "7"; }
            else if (textBox1.Text.Contains(",")) { textBox1.Text += "7"; }
            
           

        }

        private void button8_Click(object sender, EventArgs e)
        {
          
            if (comma != ",") { textBox1.Text += "8"; }
            else if (textBox1.Text.Contains(",")) { textBox1.Text += "8"; }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            if (comma != ",") { textBox1.Text += "9"; }
            else if (textBox1.Text.Contains(",")) { textBox1.Text += "9"; }
            

        }
        private void button26_Click(object sender, EventArgs e)
        { if (comma != ",") 
            { 
                textBox1.Text += ","; 
                comma = ","; 
            }
            
           
        }
        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Current_str = "";                                    //кнопка очистить
            Current_Num = 0;
            comma = null;
            //Current_Num2 = 0;
            result = 0;
            sign =' ';
        }
//знаки мат операций .Вся логика программы идёт дальше.
        private void button17_Click(object sender, EventArgs e)
        {
            if (!regex.IsMatch(textBox1.Text) && (textBox1.Text == "")) { MessageBox.Show("Неверный ввод.Введите число!"); textBox1.Text = ""; }
            else
            {
                sign = ' ';
                comma = null;
                if (Current_Num == 0)
                {
                    try
                    { Current_Num = Convert.ToDouble(textBox1.Text); }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка ввода!");
                        textBox1.Text = "";
                        Current_Num = 0;
                        result = 0;
                    }
                }
                else if (result != 0) { Current_Num = result; }
                textBox1.Text = textBox1.Text.Substring(textBox1.Text.IndexOf('=') + 1);
                result = Current_Num;
                equal = null;
                Current_Num = 0;
                sign = '+';

                textBox1.Text += " + ";
                Current_str = textBox1.Text;
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!regex.IsMatch(textBox1.Text) && (textBox1.Text == "")) { MessageBox.Show("Неверный ввод.Введите число!"); textBox1.Text = ""; }
            else
            {
                sign = ' ';
                comma = null;
                if (Current_Num == 0)
                {
                    try
                    { Current_Num = Convert.ToDouble(textBox1.Text); }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка ввода!");
                        textBox1.Text = "";
                        Current_Num = 0;
                        result = 0;
                    }
                }
                else if (result != 0) { Current_Num = result; }
                textBox1.Text = textBox1.Text.Substring(textBox1.Text.IndexOf('=') + 1);
                result = Current_Num;
                equal = null;
                Current_Num = 0;
                sign = '-';

                textBox1.Text += " - ";
                Current_str = textBox1.Text;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!regex.IsMatch(textBox1.Text) && (textBox1.Text == "")) { MessageBox.Show("Неверный ввод.Введите число!"); textBox1.Text = ""; }
            else
            {
                sign = ' ';
                comma = null;
                if (Current_Num == 0)
                {
                    try
                    { Current_Num = Convert.ToDouble(textBox1.Text); }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка ввода!");
                        textBox1.Text = "";
                        Current_Num = 0;
                        result = 0;
                    }
                }
                else if (result != 0) { Current_Num = result; }
                textBox1.Text = textBox1.Text.Substring(textBox1.Text.IndexOf('=') + 1);
                result = Current_Num;
                equal = null;
                Current_Num = 0;
                sign = '*';

                textBox1.Text += " * ";
                Current_str = textBox1.Text;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!regex.IsMatch(textBox1.Text) && (textBox1.Text == "")) { MessageBox.Show("Неверный ввод.Введите число!"); textBox1.Text = ""; }
            else
            {
                sign = ' ';
                comma = null;
                if (Current_Num == 0)
                {
                    try
                    { Current_Num = Convert.ToDouble(textBox1.Text); }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка ввода!");
                        textBox1.Text = "";
                        Current_Num = 0;
                        result = 0;
                    }
                }
                else if (result != 0) { Current_Num = result; }
                textBox1.Text = textBox1.Text.Substring(textBox1.Text.IndexOf('=') + 1);
                result = Current_Num;
                equal = null;
                Current_Num = 0;
                sign = '/';

                textBox1.Text += " / ";
                Current_str = textBox1.Text;
            }
        }
        private void button30_Click(object sender, EventArgs e)
        {
            if (!regex.IsMatch(textBox1.Text)&&(textBox1.Text=="")) { MessageBox.Show("Неверный ввод.Введите число!"); textBox1.Text = ""; }
            else
            {
                sign = ' ';
                comma = null;
                if (Current_Num == 0)
                {
                    try
                    { Current_Num = Convert.ToDouble(textBox1.Text); }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка ввода!");
                        textBox1.Text = "";
                        Current_Num = 0;
                        result = 0;
                    }
                }
                else if (result != 0) { Current_Num = result; }
                textBox1.Text = textBox1.Text.Substring(textBox1.Text.IndexOf('=') + 1);
                result = Current_Num;
                equal = null;
                Current_Num = 0;
                sign = '%';

                textBox1.Text += " % ";
                Current_str = textBox1.Text;
            }
        }

        private void button16_Click(object sender, EventArgs e) {
            if (Current_Num ==0)
            {
                char[] a = new char[] { '+', '-', '/', '*', '%' };
                char[] mystr = textBox1.Text.ToCharArray();
                for (int j = 0; j < a.Length; j++)
                {
                    for (int i = 0; i < mystr.Length; i++)
                    {
                        switch (mystr[i])
                        {
                            case '+':
                                Current_str = textBox1.Text.Substring(0, i);
                                result = Convert.ToDouble(Current_str);
                                sign = '+';
                                break;
                            case '-':
                                Current_str = textBox1.Text.Substring(0, i);
                                result = Convert.ToDouble(Current_str);
                                sign = '-';
                                break;
                            case '*':
                                Current_str = textBox1.Text.Substring(0, i);
                                result = Convert.ToDouble(Current_str);
                                sign = '*';
                                break;
                            case '/':
                                Current_str = textBox1.Text.Substring(0, i);
                                result = Convert.ToDouble(Current_str);
                                sign = '/';
                                break;
                            case '%':
                                Current_str = textBox1.Text.Substring(0, i);
                                result = Convert.ToDouble(Current_str);
                                sign = '%';
                                break;
                        }


                    }

                }
                
            } 
            if (sign!=' ')
            {
                int length;length= textBox1.Text.IndexOf(sign);
            string str;
            str= textBox1.Text.Substring(length+1);
                Current_str = str.Substring(str.IndexOf(sign)+1);
                str = length> str.IndexOf(sign)?str:Current_str;
                //Current_str=str.Replace(".", ",");
                try { Current_Num = Convert.ToDouble(str); }
                catch (Exception ex)
                {
                    
                    Current_Num = 0;
                    result = 0;
                    textBox1.Text = " ";
                }

                try
            {
                switch (sign)
                {
                    case '+':
                        result += Current_Num;
                        break;
                    case '-':
                        result -= Current_Num;
                        break;
                    case '*':
                        result *= Current_Num;
                        break;
                    case '/':
                            if (Current_Num == 0.0) { MessageBox.Show("Ошибка ввода,возможно деление на ноль!");textBox1.Text = ""; }
                        result /= Current_Num;
                            break;
                        case '%':
                            result=result -((int)(result/ Current_Num)*Current_Num);
                            break;
                    }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Ошибка!Произошло деление на 0");
                textBox1.Text = "";
                Current_str = "";
                Current_Num = 0;
                //Current_Num2 = 0;
                result = 0;
            }
            }
            str = Current_str;
            
            if (result == 0) { textBox1.Text = Convert.ToString(result); }
            else { textBox1.Text += " = " + Convert.ToString(result); }
            listBox1.Items.Add(textBox1.Text);
            if ((result != 0) && (textBox1.Text.Contains('='))) { textBox1.Text = textBox1.Text.Substring(textBox1.Text.IndexOf('=') + 1); }
            Current_Num=0;
            
        }
        private void button21_Click(object sender, EventArgs e)//добавление в память
        {
            if (!textBox1.Text.Contains("="))
            {
                
                int pos = textBox1.Text.IndexOf(' ');
                cut = textBox1.Text.Substring(pos + 1);
                listBox2.Items.Add(cut);
                textBox1.Text = "";
                
            }
            else 
            {
                int pos = textBox1.Text.IndexOf('=');
                cut = textBox1.Text.Substring(pos + 1);
                listBox2.Items.Add(cut);
                textBox1.Text = "";
            }
            


        }
        private void button22_Click(object sender, EventArgs e)//возврат из памяти
        { 
            textBox1.Text +=cut;
            
           try {Current_Num = Convert.ToDouble(cut);} 
            catch (Exception err) {if (listBox2.Items.Count== 0) { MessageBox.Show("Память пуста.Нечего возвращать!"); } else { MessageBox.Show("Введено строка ,а не число.Нажмите ОК и введите число правильно"); }
                textBox1.Text = "";
                result = 0;
                Current_Num = 0;
            }
            size--;
        }

        private void button23_Click(object sender, EventArgs e)//очистить память
        { if (listBox2.Items.Count != 0)
            { listBox2.Items.RemoveAt(listBox2.SelectedIndex); }
            else { MessageBox.Show("Память очищена"); }
            //listBox2.Update();
            cut = " ";
            Current_Num = 0;
        }
        //конец мат операций
        private void button12_Click(object sender, EventArgs e)//возведение в квадрат
        {
            try
            {
                if (textBox1.Text == "") { Current_Num = 0; textBox1.Text = "0"; }
                else Current_Num = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception err) { MessageBox.Show("Убедитесь в правильности ввода"); Current_Num = 0; result = 0; textBox1.Text = ""; }
            result = Current_Num * Current_Num;
            
        }

        private void button13_Click(object sender, EventArgs e)//возведение в куб
        {
            try
            {
                if (textBox1.Text == "") { Current_Num = 0; textBox1.Text = "0"; }
                else Current_Num = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception err) { MessageBox.Show("Убедитесь в правильности ввода");Current_Num = 0; result = 0;textBox1.Text = ""; }
            result = Math.Pow(Current_Num, 3.0);
   
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try { 
            if (textBox1.Text == "") { Current_Num = 0; textBox1.Text = "0"; }
            else Current_Num = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception err) { MessageBox.Show("Убедитесь в правильности ввода"); Current_Num = 0; result = 0; textBox1.Text = ""; }
            result = Math.Pow(10.0, Current_Num);
         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try { 
            if (textBox1.Text == "") { Current_Num = 0; textBox1.Text = "0"; }
            else Current_Num = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception err) { MessageBox.Show("Убедитесь в правильности ввода"); Current_Num = 0; result = 0; textBox1.Text = ""; }
            result = Math.Log10(Current_Num);
           
        }

        private void button24_Click(object sender, EventArgs e)//нахождение натурального логарифма
        {
            try { 
            if (textBox1.Text == "") { Current_Num = 0; textBox1.Text = "0"; }
           else Current_Num = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception err) { MessageBox.Show("Убедитесь в правильности ввода"); Current_Num = 0; result = 0; textBox1.Text = ""; }
            result = Math.Log(Current_Num);
            
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            if (k == false) { this.Width = 600;k = true; listBox1.Show();} else  { this.Width = 270; k = false;listBox1.Visible = false; }          
        }
        private void memoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            if (h == false) { this.Width = 600; h = true; listBox2.Show(); } else { this.Width = 270; h = false; listBox2.Visible = false; }

        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)

        {listBox1.Visible = true;
            try
            {
                if (listBox1.Items.Count != 0)
                {
                    
                    var stroka = listBox1.SelectedIndex;
                    var ctr = Convert.ToString(listBox1.Items[stroka]);
                    var polo = ctr.IndexOf('=');
                    Current_Num = Convert.ToDouble(ctr.Substring(polo + 1));
                    textBox1.Text = Convert.ToString(Current_Num);
                }
            }
            catch (Exception ex) { MessageBox.Show("Входная строка имела неверный формат!"); }
        }

        

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа написана для курса \"Технологии программирования\"\nАвтор - Смирнов А.С.");
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="") { textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);}
            else { textBox1.Text = ""; Current_Num = 0; result = 0; }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "") { Current_Num = 0; textBox1.Text = "0"; }
                else Current_Num = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception err) { MessageBox.Show("Убедитесь в правильности ввода"); Current_Num = 0; result = 0; textBox1.Text = ""; }
            result =(double) 1/Current_Num;
        }

     /*  private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str =Convert.ToString(listBox1.SelectedItem);
            textBox1.Text = textBox1.Text.Substring(textBox1.Text.IndexOf('=')+1);
            listBox1.Update();
            result = 0;
            Current_Num = 0;
        }*/

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = Convert.ToString(listBox2.SelectedItem);
            textBox1.Text = textBox1.Text.Substring(textBox1.Text.IndexOf('=') + 1);
            listBox2.Update();
            result = 0;
            Current_Num = 0;
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox2.Visible = true;
            try
            {
                if (listBox2.Items.Count != 0)
                {

                    var stroka = listBox2.SelectedIndex;
                    var ctr = Convert.ToString(listBox2.Items[stroka]);
                    var polo = ctr.IndexOf('=');
                    Current_Num = Convert.ToDouble(ctr.Substring(polo + 1));
                    textBox1.Text = Convert.ToString(Current_Num);
                }
            }
            catch (Exception ex) { MessageBox.Show("Входная строка имела неверный формат!"); }

        }
    }










}