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
using System.Security.Policy;

namespace ApiSample
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public string url = "http://20.234.113.211:8091/";
        public string key = "1-82c87d0f-f071-4466-852d-d683fc490e94";

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var proxy = new Api(url, key);

            userek_listaz();
           
            //var snaps = proxy.CategoriesFindAll();
            //if (snaps.Content != null)
            //{
            //    for (var i = 0; i < snaps.Content.Count; i++)
            //    {
                    
            //        //lista.Add(rendelesek.Content[i].UserEmail);
            //        var cat = proxy.CategoriesFind(snaps.Content[i].Bvin);
            //        var catSlug = proxy.CategoriesFindBySlug(snaps.Content[i].RewriteUrl);
            //    }
            //}

        }

        void userek_listaz()
        {
            List<string> lista = new List<string>();
            var proxy = new Api(url, key);

            var rendelesek = proxy.OrdersFindAll();

            for (var i = 0; i < rendelesek.Content.Count; i++)
            {
                var elem = rendelesek.Content[i].UserEmail;
                if (!lista.Contains(elem) && elem != "" && elem.Contains(textBoxUser.Text))
                {
                    lista.Add(elem);
                }
            }

            listBoxUser.DataSource = lista.ToList();
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            userek_listaz();
        }
    }
}

