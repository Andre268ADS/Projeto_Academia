using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Projeto_Academia
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        //Funções Genéricas 

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source="+Globais.caminhoBanco + Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }

        public static DataTable dql(string sql)// Data Query Language
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;

            }

        }
       
        public static void dml(string q, string msgOK=null, string msgERRO=null)//Data Manipulation Langage (Insert,Delete, Update)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = q;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if(msgOK!=null)
                {
                    MessageBox.Show(msgOK);
                }
            }
            catch (Exception ex)
            {
                if (msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                throw ex;
            }
        }


        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
               var vcon = ConexaoBanco();
               var cmd =vcon.CreateCommand();                
               cmd.CommandText = "SELECT * FROM tb_usuarios";
               da = new SQLiteDataAdapter(cmd.CommandText, vcon);
               da.Fill(dt);
               vcon.Close();
               return dt;
                
            }catch(Exception ex)
            {
                throw ex;
            }
                
            
        }

      

        //Funções do FORM F_Gestão Usuários

        public static DataTable ObterUsuariosIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT N_IDUSUARIO as 'ID Usuário' ,T_NOMEUSUARIO as 'Nome Usuário' FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public static void AtualizarUsuario(Usuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_usuarios  SET T_NOMEUSUARIO='"+u.T_NOMEUSUARIO+ "', T_USERNAME='" + u.T_USERNAME + "',  T_SENHAUSUARIO='" + u.T_SENHAUSUARIO + "', T_STATUSUSUARIO='" + u.T_STATUSUSUARIO + "', N_NIVELUSUARIO=" + u.N_NIVELUSUARIO + " WHERE N_IDUSUARIO="+u.N_IDUSUARIO;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void DeletarUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_usuarios WHERE N_IDUSUARIO="+id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Fim das Funções do FORM F_Gestão Usuários


        public static DataTable ObterDadosUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO="+id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        /////funcoes do FORM F_NovoUsuario

        public static void NovoUsuario(Usuario u)
        {
            if(existeUserName(u))
            {
                MessageBox.Show("Username já existe");
                return;
            }
            try
            {

                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO,T_USERNAME,T_SENHAUSUARIO,T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome,@username,@senha,@status,@nivel)";
                cmd.Parameters.AddWithValue("@nome", u.T_NOMEUSUARIO);
                cmd.Parameters.AddWithValue("@username", u.T_USERNAME);
                cmd.Parameters.AddWithValue("@senha", u.T_SENHAUSUARIO);
                cmd.Parameters.AddWithValue("@status", u.T_STATUSUSUARIO);
                cmd.Parameters.AddWithValue("@nivel", u.N_NIVELUSUARIO);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuário inserido com sucesso");
                vcon.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuário");
                
            }
        }

        
        ////FIM - funcoes do FORM F_NovoUsuario
    
        ///// Rotinas Gerais 
        public static bool existeUserName(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();


            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME='"+u.T_USERNAME+"'";
            da=new SQLiteDataAdapter(cmd.CommandText,vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
               
            }
            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }
    
    }

}
