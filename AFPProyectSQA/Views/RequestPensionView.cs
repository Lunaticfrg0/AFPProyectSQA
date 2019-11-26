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
    public partial class RequestPensionView : Form
    {
        public RequestPensionView()
        {
            InitializeComponent();
        }
        public string Motivo { get { return this.Motivotxtbox.Text; } }

        private void RequestPension_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(Motivotxtbox.Text) == true)
            {
                MessageBox.Show("Agregado fallido, llenar todos los campos", "AFPServices", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //To do
            //DateTime date;
            //var age = GetAge(date);
            //if (age < 60)
            //{
            //    MessageBox.Show("Agregado fallido, no cumple con la edad especificada", "AFPServices", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            SqlConnection oConnection = new SqlConnection(@"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS;Database=AFPSQAProject;Integrated Security=SSPI");

            if (oConnection.State != System.Data.ConnectionState.Open)
            {
                oConnection.Open();
            }
            SqlParameter paramEstado = new SqlParameter("@EstadoPension", "s");
            SqlParameter paramMotivo = new SqlParameter("@Motivo", Motivo);
            SqlParameter paramClientID = new SqlParameter("@ClientID", 60); // To do implmentar
            try 
            {
                string sql = " INSERT INTO	[dbo].[tblRequestRetirement] ([EstadoPension],[ClientID], FechaSolicitud,[Motivo])" +
                                                            "VALUES(@EstadoPension, @ClientID, getdate(), @Motivo)";

                SqlCommand oCommand = new SqlCommand();
                oCommand.Connection = oConnection;
                oCommand.CommandType = System.Data.CommandType.Text;
                oCommand.CommandText = sql;
                oCommand.Parameters.Add(paramEstado);
                oCommand.Parameters.Add(paramClientID);
                oCommand.Parameters.Add(paramMotivo);
                
                oCommand.ExecuteNonQuery();
                MessageBox.Show("Agregado exitoso", "AFPServices", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                oConnection.Close();
                
            }
            catch (Exception EX)
            {
                MessageBox.Show("Agregado fallido", "AFPServices", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(EX.Message);
            }
            ClearTextBoxes();

        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        public int GetAge(DateTime date)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - date.Year;
            if (date > today.AddYears(-age))
                age--;
            return age;
        }
    }
}
