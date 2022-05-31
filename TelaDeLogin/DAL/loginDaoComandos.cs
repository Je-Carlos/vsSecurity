using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TelaDeLogin.DAL
{
    public class loginDaoComandos
    {
        public bool tem = false;
        public bool temCarro = false;
        public bool temEnd = false;
        public String mensagem = "";//tudo ok
        NpgsqlCommand cmd = new NpgsqlCommand();
        conexao con = new conexao();
        NpgsqlDataReader dr;

        public bool verificarLogin(String login, String senha)
        {
            //comandos sql para verificar se tem no banco
            cmd.CommandText = "select * from cadastro where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//se foi encontrado
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (NpgsqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            //comandos para inserir
            tem = false;
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into cadastro(email,senha) values (@e,@s)";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }
                catch (NpgsqlException)
                {
                    this.mensagem = "Erro com Banco de Dados";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            cmd.CommandText = "";
            return mensagem;

        }

        public String cadastrarCarro(String fabricante, String ano, String modelo) //veiculo
        {
            temCarro = false;

            cmd.CommandText = "insert into veiculo(fabricante,anoveiculo,versaomodelo) values (@fab,@ano,@ver)";
            cmd.Parameters.AddWithValue("@fab", fabricante);
            cmd.Parameters.AddWithValue("@ano", ano);
            cmd.Parameters.AddWithValue("@ver", modelo);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Deu certo!";
                temCarro = true;
            }

            catch (NpgsqlException)
            {
                this.mensagem = "Preencha todos os dados corretamente";
            }
            cmd.CommandText = "";
            return mensagem;

        }

        public String cadastrarCep(String cep) //cep
        {
            temEnd = false;

            cmd.CommandText = "insert into cep(cep) values (@cep)";
            cmd.Parameters.AddWithValue("@cep", cep);


            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Deu certo!";
                temEnd = true;
            }

            catch (NpgsqlException)
            {
                this.mensagem = "Preencha todos os dados corretamente";
            }
            cmd.CommandText = "";
            return mensagem;

        }

        public String cadastrarEnd(String rua, String bairro, String cidade, String numero) //endereco
        {
            temEnd = false;

            cmd.CommandText = "insert into endereço(rua,bairro,cidade,numero) values (@rua,@bairro,@cid,@num)";
            cmd.Parameters.AddWithValue("@rua", rua);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@cid", cidade);
            cmd.Parameters.AddWithValue("@num", numero);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Deu certo!";
                temEnd = true;
            }

            catch (NpgsqlException)
            {
                this.mensagem = "Preencha todos os dados corretamente";
            }
            cmd.CommandText = "";
            return mensagem;
        }
        public String cadastrarCpf(String cpf) //cpf
        {
            temEnd = false;

            cmd.CommandText = "insert into cpf(cpf) values (@cpf)";
            cmd.Parameters.AddWithValue("@cpf", cpf);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Deu certo!";
                temEnd = true;
            }

            catch (NpgsqlException)
            {
                this.mensagem = "Preencha todos os dados corretamente";
            }
            cmd.CommandText = "";
            return mensagem;

        }
    }
}   

