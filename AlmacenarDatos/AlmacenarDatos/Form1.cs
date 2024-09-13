using AlmacenarDatos.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmacenarDatos
{
    public partial class Form1 : Form
    {
        Persona names = new Persona();
        Persona lastNames = new Persona();//arreglo 
        int index = 0;
        private int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void AddData()
        {
            try
            {
                string name = tbName.Text;
                names.AddName(name, index);
                string lastName= tbLastName.Text;
                lastNames.AddlastName(lastName, index);
                index++;
                ShowData();
                tbName.Clear();
                tbName.Focus();
                tbLastName.Clear();
                tbLastName.Focus();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowData()
        { 
            
            /*try 
            {
                lbData.Items.Clear();
                for (int i = 0; i < index; i++) ;
                {
                    lbData.Items.Add(names.GetNames()[i]);
                }
                for (int i = 0; i < index; i++)
                {
                    lbData.Items.Add(lastNames.GetlastNames()[i]);
                }
            }catch (Exception ex)
            {
                MessageBox.Show (ex.Message,"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            try
                {
                    lbData.Items.Clear();
                    for (int i = 0; i < index; i++)
                    {
                        string fullName = $"{names.GetNames()[i]} {lastNames.GetlastNames()[i]}";
                        lbData.Items.Add($"{fullName} {DateTime.Now.ToString("d-M-yy")}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void BtnShow_Click_1(object sender, EventArgs e)
        {


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }
    }
}
