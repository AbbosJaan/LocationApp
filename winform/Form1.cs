using System.Net.Http.Headers;

namespace winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5253");
            HttpResponseMessage response = client.GetAsync($"/api/{textBox1.Text}").Result;
            var count = response.Content.ReadAsAsync<IEnumerable<Country>>().Result;
            dataGridView1.DataSource = count;*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox1.Visible = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox2.Visible = true;
            if (textBox1.Text != "Region")
                textBox6.Visible = false;
            else
                textBox6.Visible = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox4.Visible = false;
            if (textBox1.Text != "Region")
                textBox7.Visible = false;
            else
                textBox7.Visible = true;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Visible = false;
            groupBox4.Visible = true;

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }
    }
}