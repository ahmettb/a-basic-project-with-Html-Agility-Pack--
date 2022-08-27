using HtmlAgilityPack;
using System.IO;
using System.Net;
namespace htmlAgility
{
    public partial class Form1 : Form
    {
        HtmlWeb htmlWeb = new HtmlWeb();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var  document=htmlWeb.Load(textBox1.Text);
            var haber=new List<Haberler>();
            HtmlNodeCollection data = document.DocumentNode.SelectNodes(xpath: "//div[@class='card movie-single is-flex']");
            foreach (var item in data)
            {
                Haberler temp = new Haberler();
                temp.baslik = item.SelectSingleNode("./div[@class='movie-detail long']/div/h2/a").InnerText;
                temp.link= item.SelectSingleNode("./div[@class='movie-detail long']/div/h2/a").Attributes["href"].Value;

                haber.Add(temp);
            }
            listBox1.DataSource = haber;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}