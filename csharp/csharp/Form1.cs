using System.Data;
using System.Data.SqlClient;

namespace csharp
{
    public partial class Form1 : Form
    {
        SqlConnection employee = new SqlConnection(@"Data Source=DESKTOP-4SMQ7B6\SQLEXPRESS;
initial catalog=Employee;
user id=sa;
password=12345;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            employee.Open();
            string empl = "Select * from emp";
            SqlCommand eeemp=new SqlCommand(empl,employee);
            SqlDataAdapter sam=new SqlDataAdapter(eeemp);
            DataTable Karmachari = new DataTable();
            sam.Fill(Karmachari);
            dataGridView1.DataSource = Karmachari;
            employee.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}