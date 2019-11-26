using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFPProyectSQA.Views
{
    public partial class LogInView : Form
    {
        public LogInView()
        {
            InitializeComponent();
            txtContrasena.UseSystemPasswordChar = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCedula.Clear();
            txtContrasena.Clear();
        }

        public string ClientID { get { return this.txtCedula.Text; } }

        public string Contrasena { get { return this.txtContrasena.Text; } }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCedula.Text) == true)
            {
                MessageBox.Show("Favor llenar todos los campos.", "AFPServices", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtContrasena.Text) == true)
            {
                MessageBox.Show("Favor llenar todos los campos.", "AFPServices", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String cs = @"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS;Database=AFPSQAProject;Integrated Security=SSPI";

         

            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs);            
                                                           
                SqlCommand MyCommand = default(SqlCommand);

                MyCommand = new SqlCommand ("SELECT ([ClientID], [Contrasena]) FROM [dbo].[tblClient] WHERE ClientID = @ClientID AND Contrasena = @Contrasena", myConnection);


                SqlParameter paramContrasena = new SqlParameter("@Contrasena", SqlDbType.NVarChar);
                SqlParameter paramClientID = new SqlParameter("@ClientID", SqlDbType.Int);

                paramContrasena.Value = txtContrasena.Text;
                paramClientID.Value = txtCedula.Text;

                MyCommand.Connection.Open();

                SqlDataReader MyReader = MyCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (MyReader.Read() == true)
                {
                    MainMenuView form2 = new MainMenuView();
                    form2.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Datos incorrectos.", "AFPServices", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCedula.Clear();
                    txtContrasena.Clear();
                  
                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtContrasena.Clear();
            txtCedula.Clear();
        }
    }
}
