//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testeProgramadorCSharp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class fornecedores
    {
        public int id { get; set; }
        public int empresa { get; set; }
        public string nome_fornecedor { get; set; }
        public string cpf_cnpj { get; set; }
        public System.DateTime data_hora_cadastro { get; set; }
        public string telefone { get; set; }
        public string rg { get; set; }
        public string data_nascimento { get; set; }
        public string tipo_pessoa { get; set; }
    
        public virtual empresas empresas { get; set; }
    }
}
