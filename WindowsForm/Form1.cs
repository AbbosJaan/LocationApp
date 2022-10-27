using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using winform.Models;

namespace winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5253");
            var response = await client.GetStringAsync($"/api/{textBox1.Text}");
            if(textBox1.Text == "Country")
            {
                var data = JsonConvert.DeserializeObject<List<CountryResponse>>(response);
                dataGridView1.DataSource = data;
            }
            else
            {
                var data = JsonConvert.DeserializeObject<List<RegionResponse>>(response);
                dataGridView1.DataSource = data;
            }
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
        //Delete
        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Visible = false;
            groupBox4.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }

        private async void button6_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5253");
            if (textBox1.Text == "Country")
            {
                var result = new List<CountryResponse>();
                var response = await client.GetStringAsync($"/api/{textBox1.Text}/{int.Parse(textBox2.Text)}");
                var data = JsonConvert.DeserializeObject<CountryResponse>(response);
                result.Add(data);
                dataGridView1.DataSource = result;
            }
            else if(textBox1.Text == "Region")
            {
                var result = new List<RegionResponse>();
                var response = await client.GetStringAsync($"/api/{textBox1.Text}/{int.Parse(textBox2.Text)}");
                var data = JsonConvert.DeserializeObject<RegionResponse>(response);
                result.Add(data);
                dataGridView1.DataSource = result;
            }
            else
                MessageBox.Show("Xato ma'lumot kiritildi. Region yoki Countrydan birini kiriting!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button7_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5253");
            if (textBox1.Text == "Country")
            {
                var element = new CountryCr();
                element.Title = textBox3.Text;
                element.ShortTitle = textBox4.Text;
                element.Code = int.Parse(textBox5.Text);
                var stringContent = new StringContent(JsonConvert.SerializeObject(element), Encoding.UTF8, "application/json");
                var data = await client.PostAsync($"api/{textBox1.Text}", stringContent);
                if (data.IsSuccessStatusCode)
                    MessageBox.Show("Data muvaffaqiyatli qo'shildi");
                else
                    MessageBox.Show("Something went wrong!");
            }
            else if (textBox1.Text == "Region")
            {
                var element = new RegionCr();
                element.Title = textBox3.Text;
                element.ShortTitle = textBox4.Text;
                element.Code = int.Parse(textBox5.Text);
                element.CountryId = int.Parse(textBox6.Text);
                var stringContent = new StringContent(JsonConvert.SerializeObject(element), Encoding.UTF8, "application/json");
                var data = await client.PostAsync($"api/{textBox1.Text}", stringContent);
                if (data.IsSuccessStatusCode)
                    MessageBox.Show("Data muvaffaqiyatli qo'shildi");
                else
                    MessageBox.Show("Something went wrong!");
            }
            else
                MessageBox.Show("Something went wrong! Please, try again.");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button8_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5253");
            if (textBox1.Text == "Country")
            {
                var element = new CountryCr();
                element.Title = textBox10.Text;
                element.ShortTitle = textBox9.Text;
                element.Code = Convert.ToInt32(textBox8.Text);
                var stringContent = new StringContent(JsonConvert.SerializeObject(element), Encoding.UTF8, "application/json");
                var data = await client.PutAsync($"api/{textBox1.Text}/{Convert.ToInt32(textBox11.Text)}", stringContent);
                if (data.IsSuccessStatusCode)
                    MessageBox.Show("Data muvaffaqiyatli o'zgartirildi");
                else
                    MessageBox.Show("Something went wrong!");
            }
            else if(textBox1.Text == "Region")
            {
                var element = new RegionCr();
                element.Title = textBox10.Text;
                element.ShortTitle = textBox9.Text;
                element.Code = Convert.ToInt32(textBox8.Text);
                element.CountryId = Convert.ToInt32(textBox7.Text);
                var stringContent = new StringContent(JsonConvert.SerializeObject(element), Encoding.UTF8, "application/json");
                var data = await client.PutAsync($"api/{textBox1.Text}/{Convert.ToInt32(textBox11.Text)}", stringContent);
                if (data.IsSuccessStatusCode)
                    MessageBox.Show("Data muvaffaqiyatli o'zgartirildi");
                else
                    MessageBox.Show("Something went wrong!");
            }

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button9_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5253");
            // var stringContent = new StringContent(JsonConvert.SerializeObject(element), Encoding.UTF8, "application/json");
            var data = await client.DeleteAsync($"api/{textBox1.Text}/{Convert.ToInt32(textBox12.Text)}");
            if (data.IsSuccessStatusCode)
                MessageBox.Show("Data muvaffaqiyatli o'chirildi!");
            else
                MessageBox.Show("Something went wrong!");
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}