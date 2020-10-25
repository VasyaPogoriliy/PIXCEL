using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1_Spreadsheet
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, string> grid = new Dictionary<string, string>();   //словник ключів і елемантів, що їм відповідають

        private static Form1 copy;               //екзимпляр класу
  
        public static Form1 GetFormCopy()        //перевіряємо чи такий екзимпляр вже існує, якщо ні, то створюємо
        {
            if (copy == null)
            {
                copy = new Form1();
            }
            return copy;
        }

        public bool IsContainValue(string key)              //перевіряємо, чи в таблиці є ключ уведений користувачем       
        {
            string value;
            return grid.TryGetValue(key, out value);
        }


        public string GetValueFromName(string name)         //бремо значення яке відповідає ключу
        {
            return grid[name];
        }
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)             //створюємо форму з початковими параметрами
        {
            for(char i = 'A'; i <= 'K'; i++)
            {
                dataGridView1.Columns.Add(Convert.ToString(i), Convert.ToString(i));
  
            }

            for (int i = 0; i < 20; i++)
            { 
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.RowCount - 2].HeaderCell.Value = (i + 1).ToString();             
            }
            
        }
                
        private void button1_Click(object sender, EventArgs e)          //додаємо рядок
        {
            int RowCount = (dataGridView1.RowCount + 1);                //кількість рядків в таблиці

            if (RowCount > 52)
            {
                MessageBox.Show("Неможливо додати рядок, завелика кількість");
            }
            else
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[RowCount - 2].HeaderCell.Value = (RowCount - 1).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)          //додаємо стовпчик
        {
            int ColCount = dataGridView1.Columns.Count;                 //кількість стовпчиків в таблиці

            if (ColCount > 25 && ColCount < 52)
            {
                char colname = 'A';
                dataGridView1.Columns.Add(Convert.ToString(colname + Convert.ToString(dataGridView1.Columns[ColCount - 26].Name[0])),
                                          Convert.ToString(colname + Convert.ToString(dataGridView1.Columns[ColCount - 26].Name[0])));
            }
            else if (dataGridView1.Columns.Count <= 25)
            {
                dataGridView1.Columns.Add(Convert.ToString(Convert.ToChar(dataGridView1.Columns[ColCount - 1].Name[0] + 1)),
                                          Convert.ToString(Convert.ToChar(dataGridView1.Columns[ColCount - 1].Name[0] + 1)));
            }
            else
            {
                MessageBox.Show("Неможливо додати стовпчик, завелика кількість");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)          //видаляємо стовпчик
        {
            int ColCount = dataGridView1.ColumnCount;                   //кількість стовпчиків в таблиці

            if ((ColCount - 1) > 0)
            {
                dataGridView1.Columns.RemoveAt(ColCount - 1);
            }
            else
            {
                MessageBox.Show("Вибачте, вже було видалено максимальну кількість стовпчиків");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)          //видаляємо рядок
        {
            int RowCount = dataGridView1.RowCount;                      //кількість рядків в таблиці

            if ((RowCount - 2) >= 0)
            {
                dataGridView1.Rows.RemoveAt(RowCount - 2);
            }
            else
            {
                MessageBox.Show("Вибачте, вже було видалено максимальну кількість рядків");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)          //виконуємо обчислення виразу в текстбоксі і записуємо отримане значення в словник, що відповідає ключу даної клітинки   
        {
            try
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells) 
                {
                    cell.Value = Calculator.Evaluate(textBox1.Text);
                    string value = dataGridView1.Columns[cell.ColumnIndex].Name[0].ToString();
                    value += cell.RowIndex + 1;
                    grid[value] = cell.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)     //записуємо в словник ключ, що відповідає клітинці в яку ми записали вираз
        {
            if (dataGridView1.CurrentCell.Value == null)
            {
                return;
            }
            
            string key = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name[0].ToString();
            key += (dataGridView1.CurrentCell.RowIndex + 1);
            grid[key] = dataGridView1.CurrentCell.Value.ToString();
            
        }

        private void DataGridInit(int columns)                                  //функція ініціалізації таблиці для файлу, що відкрито
        {
            for (int i = 0; i < columns; ++i)
            {
                DataGridViewTextBoxColumn A = new DataGridViewTextBoxColumn();
                A.HeaderText = (Convert.ToChar(65 + i)).ToString();
                A.Name = A.HeaderText;
                dataGridView1.Columns.Add(A);
            }
        }

        private void SaveToXML()                                                //функція збереження файла
        {
            SaveFileDialog saveFile = new SaveFileDialog();                     
            saveFile.Filter = "MyExcelFiles|*.xml";                             
            saveFile.Title = "Save an *xml file";                               
            
            if (saveFile.ShowDialog() != DialogResult.OK)
            {
                return;
            }      
            
            FileStream file = (FileStream)saveFile.OpenFile();
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(dataGridView1.ColumnCount);
            writer.WriteLine(dataGridView1.RowCount);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    writer.WriteLine(cell.Value);
                }
            }

            writer.Close();
            file.Close();
            MessageBox.Show("Успішно");
        }

        private void OpenXMLFile()                                             //функція відкриття файлу
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "MyExcelFiles|*.xml";
            openFile.Title = "Open an *.xml file";

            if (openFile.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            StreamReader reader = new StreamReader(openFile.FileName);
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            int colNum = int.Parse(reader.ReadLine());
            int rowNum = int.Parse(reader.ReadLine());
            DataGridInit(colNum);

            for (int i = 0; i < rowNum; ++i)
            {
                DataGridViewRow dataRow = new DataGridViewRow();

                for (int j = 0; j < colNum; ++j)
                {
                    var value = reader.ReadLine();
                    dataRow.Cells.Add(new DataGridViewTextBoxCell { Value = value });
                    grid[dataGridView1.Columns[j].Name + i.ToString()] = value;
                }
                dataGridView1.Rows.Add(dataRow);
                dataGridView1.Rows[dataGridView1.RowCount - 2].HeaderCell.Value = (dataGridView1.RowCount - 1).ToString();
            }
            reader.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveToXML();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenXMLFile();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функціонал програми:\n" +
                "-редагування текстового значення комірки;\n" +
                "-редагування арифметичного значення комірки;\n" +
                "-збереження файлу;\n" +
                "-відкриття файлу в розширенні *xml;\n" +
                "-додавання та видалення рядків та стовпчиків;\n\n" +
                "Щоб змінити значення у комірці, двічі натисніть на неї лкм,\n" +
                "потім уведіть значення яке вам потрібно, та вийдіть з комірки натиснувши на іншу." +
                " Щоб порахувати арифметичне значення, виберіть потрібну вам комірку, та запишіть потрібні вам дії з комірками у текстбоксі.\n\n" +
                "Арифметичні операції:\n" +
                "*, /, +, -\n" +
                "arg1^arg2\n" +
                "max(arg1;arg2) :максимальне значення 2 аргуметнів;\n" +
                "min(arg1;arg2) :мінімальне значення 2 аргуметнів;\n" +
                "mmin(arg1;arg2;...argN) :мінімальне значення серед N аргументів;\n" +
                "mmax(arg1;arg2;...argN) :максимальне значення серед N аргументів;\n\n" +
                "Формат введення клітинок та чисел з плаваючою комою:\n" +
                "Числа типу DOUBLE вводяться через кому (99,9)\n" +
                "Щоб звернутись до комірки, спочатку напишіть Велику літеру, що відповідає назві стовпчика, а потім індекс рядка (А1,B1)");
        }
    }

}



