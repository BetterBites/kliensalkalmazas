//
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//felso ket sor kommentelheto
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1.Client;
using System.Collections;

namespace ApiSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();

            var url = "http://20.234.113.211:8091/";
            var key = "1-82c87d0f-f071-4466-852d-d683fc490e94";

            var proxy = new Api(url, key);

            var snaps = proxy.CategoriesFindAll();
            if (snaps.Content != null)
            {
                for (var i = 0; i < 5; i++)
                {
                    if (i < snaps.Content.Count)
                    {

                        lista.Add(snaps.Content[i].Name);
                        var cat = proxy.CategoriesFind(snaps.Content[i].Bvin);
                        var catSlug = proxy.CategoriesFindBySlug(snaps.Content[i].RewriteUrl);
                    }
                }
            }
            listBox1.DataSource = lista;
            listBox1.DisplayMember= "Name";

            textBox1.Text = "körte";


        }
    }
}

