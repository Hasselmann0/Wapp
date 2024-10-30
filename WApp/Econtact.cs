using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using WApp.wappClasses;

namespace WApp
{
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }

        contactClass c = new contactClass();

        private void Econtact_Load(object sender, EventArgs e)
        {
            //Carregar dados no gridview inicial
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Pega o valor do botão em questão
            c.FirstName = txtBoxFirstName.Text;
            c.LastName = txtBoxLastName.Text;
            c.ContactNo = txtBoxContactNumber.Text;
            c.Address = txtBoxAddress.Text;
            c.Gender = cmbGender.Text;

            //Inserindo dados ao banco
            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("Novo contato inserido corretamente.");

            }
            else
            {
                MessageBox.Show("Falha ao adicionar um novo contato. Tente novamente!!");

            }

            //Carregar dados no gridview inicial
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

            btnClear_Click(sender, e);

        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.ContactID = int.Parse(txtBoxContactID.Text);
            c.FirstName = txtBoxFirstName.Text;
            c.LastName = txtBoxLastName.Text;
            c.ContactNo = txtBoxContactNumber.Text.Trim();
            c.Address = txtBoxAddress.Text;
            c.Gender = cmbGender.Text;
            //Atualiza dados do banco
            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Contato atualizado com seucesso");
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                //invoca o metodo clear
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Falha a atualizar o contato. Tente novamente!!");
            }

        }
        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Pega os dados da GridView e atualiza nas caixas de texto
            //identifica a row onde o mouse clicou
            int rowIndex = e.RowIndex;
            txtBoxContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtBoxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtBoxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtBoxContactNumber.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtBoxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.ContactID = Convert.ToInt32(txtBoxContactID.Text);
            bool success = c.Delete(c);
            if (success)
            {
                MessageBox.Show("Contato deletado com sucesso!!");
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao deletar o contato. Tente novamente!!");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxContactID.Text = string.Empty;
            txtBoxFirstName.Text = string.Empty;
            txtBoxLastName.Text = string.Empty;
            txtBoxContactNumber.Text = string.Empty;
            txtBoxAddress.Text = string.Empty;
            txtBoxSearch.Text = string.Empty;
            cmbGender.Text = string.Empty;

        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //captura o valor da caixa de texto
            string keyword = txtBoxSearch.Text;
            
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%"+keyword+"%' OR LastName LIKE '%"+keyword+"%' OR Address LIKE '%"+keyword+"%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt; 


            conn.Open();
        }
    }
}
