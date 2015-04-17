using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Data;

namespace WS.Funcionarios
{
    /// <summary>
    /// Summary description for Funcionarios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Funcionarios : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(ResponseFormat= ResponseFormat.Xml)]
        public xml ObterFuncionariosPorSexo(string sexo)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Funcionario funcionario;

            DataTable dteFunc = DadosFuncionarios();

            foreach (DataRow row in dteFunc.Rows)
            {
                funcionario = new Funcionario();
                funcionario.idt_func = row["idt_func"].ToString();
                funcionario.cpf_func = row["cpf_func"].ToString(); 
                funcionario.nom_func = row["nom_func"].ToString(); 
                funcionario.ci_func = row["ci_func"].ToString(); 
                funcionario.email_func = row["email_func"].ToString(); 
                funcionario.tel_res_func = row["tel_res_func"].ToString(); 
                funcionario.tel_cel_func = row["tel_cel_func"].ToString(); 
                funcionario.dat_nasc_func = row["dat_nasc_func"].ToString(); 
                funcionario.sexo_func = row["sexo_func"].ToString(); 
                funcionarios.Add(funcionario);
            }

            var result = from f in funcionarios
                         where f.sexo_func.Equals(sexo)
                         select f;

            
            xml dadosXml = new xml(result.ToList());

            return dadosXml;
        }

        public DataTable DadosFuncionarios()
        {
            DataTable dteDadosFunc = new DataTable();

            dteDadosFunc.Columns.Add("idt_func");
            dteDadosFunc.Columns.Add("cpf_func");
            dteDadosFunc.Columns.Add("nom_func");
            dteDadosFunc.Columns.Add("ci_func"); 
            dteDadosFunc.Columns.Add("email_func"); 
            dteDadosFunc.Columns.Add("tel_res_func"); 
            dteDadosFunc.Columns.Add("tel_cel_func"); 
            dteDadosFunc.Columns.Add("dat_nasc_func"); 
            dteDadosFunc.Columns.Add("sexo_func"); 

            dteDadosFunc.Rows.Add("1", "123.456.789-10", "José Silva", "11111111", "jose@teste.com", null,"9999-8888", "01/01/2000", "M");
            dteDadosFunc.Rows.Add("2", "321.654.987-01", "Maria dos Santos", "222222222", "maria@teste.com", "2412-3546", "8888-7777", "01/01/1998", "F");
            dteDadosFunc.Rows.Add("3", "147.258.369-78", "Epaminondas Soares", "33333333", "epaminondas@teste.com",null, "9878-9878", "10/05/1990", "M"); 
            dteDadosFunc.Rows.Add("4", "741.852.963-63", "Astrogildo Pereira", "44444444", "astrogildo@teste.com", null,"3254-6588", "01/01/2002", "M"); 
            dteDadosFunc.Rows.Add("5", "987.654.321-00", "Marvio Costa", "555555", "marvio@teste.com", "9154-7899", null,"13/08/1996", "M");
            dteDadosFunc.Rows.Add("6", "789.456.123-55", "Silviano Neto", "66666666", "silviano@teste.com", "4156-3621", null,"01/12/1987","M"); 
            dteDadosFunc.Rows.Add("7", "326.159.487-65", "Justina Pimentel", "777777", "justina@teste.com","8163-5544", null,"20/05/1985", "F"); 
            return dteDadosFunc;
        }

    }
}
