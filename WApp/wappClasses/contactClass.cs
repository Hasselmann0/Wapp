using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WApp.wappClasses
{
    internal class contactClass
    {
        //Propriedades e instancia da conexao

        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //Selecionando dados do Banco
        public DataTable Select ()
        {
            //Conexao com banco
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Codigo SQL query
                string sql = "SELECT * FROM tbl_contact";
                //Criando cmd usando sql e conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //criando sql dataadapter usando cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }

        //inserindo dados no banco
        public bool Insert (contactClass c)
        {
            // criando um retorno padrao e setando valor em falso
            bool isSuccess = false;
            //Conectando o banco
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Codigo SQL query
                string sql = "INSERT INTO tbl_contact(FirstName, LastName, ContactNo, Address, Gender) VALUES (@FirstName, @LastName, @ContactNo, @Address, @Gender)";
                //Criando cmd usando sql e conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //criando sql dataadapter usando cmd
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //se correr tudo bem o valor das colunas sera >1 else o valor sera 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess=false;    
                }

            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        //metodo update
        public bool Update (contactClass c)
        {
            // criando um retorno padrao e setando valor em falso
            bool isSuccess = false;
            //Conectando o banco
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Codigo SQL query
                string sql = "UPDATE tbl_contact SET FirstName=@FirstName, LastName=@LastName, ContactNo=@ContactNo, Address=@Address, Gender=@Gender WHERE ContactID=@ContactID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Criando parametros para adicionar o valor
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //se correr tudo bem o valor das colunas sera >1 else o valor sera 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close();
            }


            return isSuccess;
        }

        //metodo Delete
        public bool Delete (contactClass c)
        {
            // criando um retorno padrao e setando valor em falso
            bool isSuccess = false;
            //Conectando o banco
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql para deletar
                string sql = "DELETE FROM tbl_contact WHERE ContactID=@ContactID";
                //sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //se correr tudo bem o valor das colunas sera >1 else o valor sera 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
