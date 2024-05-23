using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void disciplinesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disciplinesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hellodbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hellodbDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.hellodbDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hellodbDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.hellodbDataSet.Groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hellodbDataSet.ExamResults". При необходимости она может быть перемещена или удалена.
            this.examResultsTableAdapter.Fill(this.hellodbDataSet.ExamResults);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hellodbDataSet.Disciplines". При необходимости она может быть перемещена или удалена.
            this.disciplinesTableAdapter.Fill(this.hellodbDataSet.Disciplines);

        }

        private void groupsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                long usePrimaryKey;
                DataRow result = null;

                
DataTable workTable;
                DataTable displayTable;
                if ((IsNumeric(textBox1.Text.Trim()) == false) ||
                (textBox1.Text.IndexOf(".") >= 0))
                {
                    MessageBox.Show("Первичный ключ должен быть допустимым целым числом.");
                    textBox1.Focus();
                    return;
                }
                try
                {
                    usePrimaryKey = long.Parse(textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Первичный ключ должен быть допустимым целым числом.");
                    textBox1.Focus();
                    return;
                }
                workTable = hellodbDataSet.ExamResults;
                try
                {
                    result = workTable.Rows.Find(usePrimaryKey);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сбой фильтра со следующей ошибкой: " +
                    ex.Message);
                    return;
                }
                if (result == null)
                {
                    MessageBox.Show("Предоставленный ключ не соответствует ни одной строке.");
                    textBox1.Focus();
                    return;
                }
                displayTable = workTable.Clone();
                displayTable.ImportRow(result);
                (new ResultsViewer()).ShowResults(displayTable); //передача таблицы для
                                                                 //отбражения в отдельной форме ResultsViewer.
            }
            // Пользовательский метод проверки допустимости значения в строке TextBox.
            private bool IsNumeric(string baseString)
            {
                // ----- тест на допустимое десятичное число в строке.
                decimal result;
                if ((baseString == null) || (baseString.Trim().Length == 0))
                    return false;
                return decimal.TryParse(baseString, out result);
            }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем новую строку в таблице ExamResults
                hellodbDataSet.ExamResults newRow = hellodbDataSet.ExamResults.NewExamResultsRow();

                // Заполняем значения для новой строки
                newRow.StudentID = 1; // Пример значения
                newRow.DisciplineID = 2; // Пример значения
                newRow.Result = 80; // Пример значения

                // Добавляем созданную строку в таблицу ExamResults
                hellodbDataSet.ExamResults.AddExamResultsRow(newRow);

                // Сохраняем изменения в базе данных
                this.tableAdapterManager.UpdateAll(this.hellodbDataSet);

                MessageBox.Show("Запись успешно добавлена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении записи: " + ex.Message);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем выделенную строку из DataGridView
                DataGridViewRow selectedRow = examResultsDataGridView.SelectedRows[0];

                // Получаем значение первичного ключа выделенной строки
                long primaryKey = Convert.ToInt64(selectedRow.Cells["PrimaryKeyColumn"].Value); // Замените "PrimaryKeyColumn" на имя вашего столбца с первичным ключом

                // Находим строку по первичному ключ


                // Сохраняем изменения в базе данных
                this.tableAdapterManager.UpdateAll(this.hellodbDataSet);

                MessageBox.Show("Запись успешно удалена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении записи: " + ex.Message);
            }
        }

    }
}

