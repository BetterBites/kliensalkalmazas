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
            textBox1.Text = "alma";
            Console.WriteLine("This is an API Sample Program for Hotcakes");
            Console.WriteLine();
            
            var url = string.Empty;
            var key = string.Empty;
            List<string> lista = new List<string>();

            // Kezdőértékek beállítása vagy parancssori argumentumokból olvasás
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 2)
            {
                url = args[1];
                key = args[2];
            }

            if (url == string.Empty) url = "http://20.234.113.211:8091/";
            if (key == string.Empty) key = "1-82c87d0f-f071-4466-852d-d683fc490e94";

            var proxy = new Api(url, key);

            var snaps = proxy.CategoriesFindAll();
            if (snaps.Content != null)
            {
                Console.WriteLine("Found " + snaps.Content.Count + " categories");
                Console.WriteLine("-- First 5 --");
                for (var i = 0; i < 5; i++)
                {
                    if (i < snaps.Content.Count)
                    {
                        Console.WriteLine(i + ") " + snaps.Content[i].Name + " [" + snaps.Content[i].Bvin + "]");
                        lista.Add(snaps.Content[i].Name);
                        var cat = proxy.CategoriesFind(snaps.Content[i].Bvin);
                        if (cat.Errors.Count > 0)
                        {
                            foreach (var err in cat.Errors)

                            {
                                Console.WriteLine("ERROR: " + err.Code + " " + err.Description);
                            }
                        }
                        else
                        {
                            Console.WriteLine("By Bvin: " + cat.Content.Name + " | " + cat.Content.Description);
                        }

                        var catSlug = proxy.CategoriesFindBySlug(snaps.Content[i].RewriteUrl);
                        if (catSlug.Errors.Count > 0)
                        {
                            foreach (var err in catSlug.Errors)
                            {
                                Console.WriteLine("ERROR: " + err.Code + " " + err.Description);
                            }
                        }
                        else
                        {
                            Console.WriteLine("By Slug: " + cat.Content.Name + " | " + cat.Content.Description);
                        }
                    }
                }
            }
            listBox1.DataSource = lista;
            listBox1.DisplayMember= "Name";
            //listBox1.ValueMember= "Name";
            textBox1.Text = "körte";


        }
    }
}

