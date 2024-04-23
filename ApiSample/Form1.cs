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
using Hotcakes.CommerceDTO.v1.Orders;
using Hotcakes.CommerceDTO.v1;

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
        public string kivalasztott_order_bvin = "";

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var proxy = new Api(url, key);

            userek_listaz();
            orderek_listaz();
            osszes_order();

            //design
            this.BackColor = Color.FromArgb(130, 191, 145);
            label1.ForeColor = Color.FromArgb(92, 50, 99);
            label2.ForeColor = Color.FromArgb(92, 50, 99);
            label3.ForeColor = Color.FromArgb(92, 50, 99);
            buttonAtvetel.BackColor = Color.FromArgb(92, 50, 99);
            dgwOrder.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(92, 50, 99);
            dgwOrder.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(92, 50, 99);
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

        void orderek_listaz()
        {
            List<rendeles> lista = new List<rendeles>();
            var proxy = new Api(url, key);
            var kiv = listBoxUser.SelectedValue;


            var rendelesek = proxy.OrdersFindAll();
            for (var i = 0; i < rendelesek.Content.Count; i++)
            {
                var elem = rendelesek.Content[i];
                if (elem.UserEmail == kiv.ToString())
                {
                    rendeles r = new rendeles();
                    r.bvin = elem.bvin;
                    r.vevo = elem.UserEmail;
                    r.rendelesi_ido = elem.TimeOfOrderUtc.ToString("yyyy-MM-dd HH:mm:ss");
                    r.osszeg = elem.TotalGrand;
                    r.statusz = elem.StatusName.ToString();

                    lista.Add(r);
                }
            }
            listBoxOrder.DataSource = lista.ToList();
        }

        void osszes_order()
        {
            string kiv_bvin = ((rendeles)listBoxOrder.SelectedItem).bvin;
            
            List<rendeles2> lista = new List<rendeles2>();
            var proxy = new Api(url, key);
            var rendelesek = proxy.OrdersFindAll();

            
            for (var i = 0; i < rendelesek.Content.Count; i++)
            {
                var elem = rendelesek.Content[i];
                if (elem.bvin.ToString() == kiv_bvin)
                {
                    rendeles2 r = new rendeles2();

                    r.bvin = elem.bvin.ToString();
                    r.vevo = elem.UserEmail.ToString();
                    r.rendelesi_ido = elem.TimeOfOrderUtc.ToString("yyyy-MM-dd HH:mm:ss");
                    r.osszeg = (decimal)elem.TotalGrand;
                    r.statusz = elem.StatusName.ToString();

                    lista.Add(r);
                }
            }

            dgwOrder.DataSource = lista.ToList();

            
            //dgwOrder.DataSource = rendelesek.Content.ToList();
        }


        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            userek_listaz();
        }

        private void listBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderek_listaz();
            osszes_order();
        }

        private void buttonAtvetel_Click(object sender, EventArgs e)
        {
            string kiv_bvin = ((rendeles)listBoxOrder.SelectedItem).bvin;
            var proxy = new Api(url, key);

            var rendeles = proxy.OrdersFind(kiv_bvin).Content;

            
            rendeles.IsPlaced= true;
            rendeles.StatusName = "Complete";
            rendeles.StatusCode = "09D7305D-BD95-48d2-A025-16ADC827582A";


            // call the API to update the order
            ApiResponse<OrderDTO> response = proxy.OrdersUpdate(rendeles);
            osszes_order();
        }

        private void listBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            osszes_order();
        }
    }
}

