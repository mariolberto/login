using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace login
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void subir_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = 127.0.0.1; Database=login; User Id = root; password=lentp123");
            try
            {
                con.Open();
            }
            catch (MySqlException ex) { MessageBox.Show("Error " + ex.ToString()); }

            string query = "insert into users(user,pass) values('" + n_name.Text + "','" + n_pass.Text + "')";

            MySqlCommand cmd = new MySqlCommand(query,con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registrado correctamente");
                this.Hide();
                inicio f1 = new inicio();
                f1.Show();
            }
            catch (MySqlException ex) { MessageBox.Show("No se pudo ejecutar " + ex.ToString()); }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir?", "Esta apunto de salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                inicio f1 = new inicio();
                f1.Show();

            }
        }
    }
}
