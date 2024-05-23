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
    public partial class ResultsViewer : Form
    {
        public ResultsViewer()
        {
            InitializeComponent();
        }

        private void ResultsViewer_Load(object sender, EventArgs e)
        {

        }
        public void ShowResults(DataTable s)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось отобразить обработанные результаты со следующей ошибкой: "
                + ex.Message);
            }
        }
    }
}
