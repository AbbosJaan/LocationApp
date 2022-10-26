using AppHududlar.Models;

namespace AppHududlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5253");
            HttpResponseMessage response = client.GetAsync("/api/Country").Result;
            var count = response.Content.ReadAsAsync<IEnumerable<Country>>().Result;
            dataGridView1.DataSource = count;
        }
    }
}