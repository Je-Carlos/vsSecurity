using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaDeLogin.DAL;
using static TelaDeLogin.DAL.loginDaoComandos;

namespace TelaDeLogin.modelo
{
    public class controle
    {
        public String mensagem = "";
        public bool tem;
        public bool temCarro;
        public bool temEnd;
        public bool acessar(String login, String senha)
        {
            loginDaoComandos loginComandos = new loginDaoComandos();
            tem = loginComandos.verificarLogin(login, senha);
            if (! loginComandos.mensagem.Equals(""))
            {
                this.mensagem = loginComandos.mensagem;
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            loginDaoComandos loginComandos = new loginDaoComandos();
            this.mensagem = loginComandos.cadastrar(email, senha, confSenha);
            if (loginComandos.tem)// a mensagem que vai vir e de sucesso
            {
                this.tem = true;
            }

            return mensagem;
        }

        public String cadastrarCarro(String fabricante, String ano, String modelo)
        {
            loginDaoComandos loginComandos = new loginDaoComandos();
            this.mensagem = loginComandos.cadastrarCarro(fabricante, ano, modelo);
            if (loginComandos.temCarro)
            {
                this.temCarro = true;
            }
            return mensagem;
        }

        public String cadastrarCep(String cep)
        {
            loginDaoComandos loginComandos = new loginDaoComandos();
            this.mensagem = loginComandos.cadastrarCep(cep);
            if (loginComandos.temEnd)
            {
                this.temEnd = true;
            }
            return mensagem;
        }

        public String cadastrarEnd(String rua, String bairro, String cidade, String numero)
        {
            loginDaoComandos loginComandos = new loginDaoComandos();
            this.mensagem = loginComandos.cadastrarEnd(rua, bairro, cidade,numero);
            if (loginComandos.temEnd)
            {
                this.temEnd = true;
            }
            return mensagem;
        }

        public String cadastrarCpf(String cpf)
        {
            loginDaoComandos loginComandos = new loginDaoComandos();
            this.mensagem = loginComandos.cadastrarCpf(cpf);
            if (loginComandos.temEnd)
            {
                this.temEnd = true;
            }
            return mensagem;
        }
    }

}
