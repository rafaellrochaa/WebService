using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Data;

namespace WS.Funcionarios
{
    public class Funcionario
    {
        [XmlElement("idt_func")]
        public string idt_func { get; set; }

        [XmlElement("cpf")]
        public string cpf_func { get; set; }

        [XmlElement("nome")]
        public string nom_func { get; set; }

        [XmlElement("rg")]
        public string ci_func { get; set; }

        [XmlElement("email")]
        public string email_func { get; set; }

        [XmlElement("tel_residencial")]
        public string tel_res_func { get; set; }

        [XmlElement("tel_celular")]
        public string tel_cel_func { get; set; }

        [XmlElement("data_nascimento")]
        public string dat_nasc_func { get; set; }

        [XmlElement("sexo")]
        public string sexo_func { get; set; }
    }
}
