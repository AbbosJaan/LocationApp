using hududlar.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http.Headers;

namespace hududlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static HttpClient client = new HttpClient();
        private void button1_Click(object sender, EventArgs e)
        {
            //var jsontask = GetJsonAsync("http://localhost:5253/");
            //this.dataGridView1.DataSource = jsontask;
            var form2 = new Form2();
            form2.ShowDialog();
        }
        /*public static async Task<IEnumerable<Country>> GetJsonAsync(string uri)
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:5253/");
            var response = await client.GetAsync("api/Country");
            var data = response.Content.ReadAsAsync<IEnumerable<Country>>();
            //return data;
        }*/

    }
}