using System.Data.SqlClient;
using System.Resources;
using System.Configuration;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace projekthetifeladat
{
    public partial class Form1 : Form
    {
        private int selectedID = -1;

        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=musor;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                conn.Open();
                dgv.Rows.Clear();
                SqlDataReader reader = new SqlCommand(
                "SELECT id, cime, mufaj, kiadasi_ev FROM musor",
                 conn)
                .ExecuteReader();

                while (reader.Read())
                {
                    dgv.Rows.Add(
                        reader[0],
                        reader[1],
                        reader[2],
                        reader[3]
                    );
                }
                conn.Close();

            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedID = (int)dgv[0, e.RowIndex].Value;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                conn.Open();
                SqlDataAdapter sda = new()
                {
                    InsertCommand = new(
                    cmdText: "INSERT INTO filmek (cime, leiras, mufaj, kiadasi_ev, borito) VALUES ('"
                    + tb_Ujcim.Text + "', '"
                    + tb_Ujleiras.Text + "', '"
                    + tb_Ujmufaj.Text + "', '"
                    + tb_Ujev.Text + "', '"
                    + tb_path.Text + "' )",
                    connection: conn),
                };

                sda.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Sikeresen felvetted az adatokat!");
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                conn.Open();
                SqlDataAdapter sda = new()
                {
                    InsertCommand = new(
                    cmdText: "UPDATE filmek SET cime = '"
                    + tb_Mcim.Text + "', mufaj = '"
                    + tb_Mmufaj.Text + "', kiadas_eve = '"
                    + tb_Mev.Text + "' WHERE id = '"
                    + selectedID + "')",
                    connection: conn),
                };

                sda.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Sikeresen módosítottad az adatokat!");
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                 caption: "Figyelmeztetés",
                 text: "Biztos vagy ebben? ha rányomsz az igenre véglegesen törlõdnek az adatok.",
                 icon: MessageBoxIcon.Warning,
                 buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlDataAdapter sqldel = new()
                    {
                        DeleteCommand = new(
                        cmdText: "DELETE FROM filmek" +
                        $"WHERE id = {selectedID};",
                        connection: conn),
                    };
                    sqldel.DeleteCommand.ExecuteNonQuery();
                }
            }
        }
    }
}