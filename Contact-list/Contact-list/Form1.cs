using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_list
{
    public partial class Form1 : Form
    {
        private Contact[] contactlist = new Contact[1];
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Contact objcontact = new Contact(nametxt.Text, lastnametxt.Text, numbertxt.Text, emailtxt.Text);
            Write(objcontact);
            Sort();
            Read();
            Refreshdisplay();
            Cleanform();    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Write(Contact contato)
        {
            StreamWriter writer = new StreamWriter("Contatos.txt");
            writer.WriteLine(contactlist.Length + 1);
            writer.WriteLine(contato.FirstName);
            writer.WriteLine(contato.LastName);
            writer.WriteLine(contato.Phone);
            writer.WriteLine(contato.Email);



            // Recuperador de contatos anteriores :)
            for (int i = 0; i < contactlist.Length; i++)
            {
                //writer.WriteLine(contactlist.Length + 1);
                writer.WriteLine(contactlist[i].FirstName);
                writer.WriteLine(contactlist[i].LastName);
                writer.WriteLine(contactlist[i].Phone);
                writer.WriteLine(contactlist[i].Email);
            }
            writer.Close();
        }


        private void Read()
        {
            StreamReader leitorDeArquivos = new StreamReader("Contatos.txt");
            contactlist = new Contact[Convert.ToInt32(leitorDeArquivos.ReadLine())];
            // Copia os dados do arquivo de texto para o vetor listaDeContatos
            for (int i = 0; i < contactlist.Length; i++)
            {
                contactlist[i] = new Contact();
                contactlist[i].FirstName = leitorDeArquivos.ReadLine();
                contactlist[i].LastName = leitorDeArquivos.ReadLine();
                contactlist[i].Phone = leitorDeArquivos.ReadLine();
                contactlist[i].Email = leitorDeArquivos.ReadLine();
            }
            leitorDeArquivos.Close();
        }

        private void Refreshdisplay()
        {
            contactlst.Items.Clear();
            for (int i = 0; i < contactlist.Length;i++) 
            {
                contactlst.Items.Add(contactlist[i].ToString());
            }
        }
        
        private void Cleanform()
        {
            nametxt.Text = string.Empty;
            lastnametxt.Text = string.Empty;
            numbertxt.Text = string.Empty;
            emailtxt.Text = string.Empty;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Sort();
            Refreshdisplay();
        }

        //bubble sort
        private void Sort()
        {
            //temp var
            Contact temp;
            bool change;
            do
            {
                change = false;
                for (int i = 0; i < (contactlist.Length - 1); i++ )
                {
                    if (contactlist[i].FirstName.CompareTo(contactlist[i + 1].FirstName) > 0)
                    {
                        temp= contactlist[i];
                        contactlist[i] = contactlist[i + 1];
                        contactlist[i+1] = temp;
                        change = true;
                    }
                }
            }
            while (change == true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Read();
            Refreshdisplay();
        }
    }
}