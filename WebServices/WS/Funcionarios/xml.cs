using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Data;
using System.Xml.Serialization;

namespace WS.Funcionarios
{
    [XmlRoot("xml")]
    public class xml
    {
        public List<Funcionario> funcionarios { get; set; }

        public xml() 
        {
        }

        public xml(List<Funcionario> funcionarios)
        {
            this.funcionarios = funcionarios;
        }
        
    }
}
