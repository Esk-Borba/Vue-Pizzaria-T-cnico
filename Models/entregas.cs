//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sa_pro_chefe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class entregas
    {
        public int id { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public string cliente { get; set; }
        public string endereco { get; set; }
        public string sabor1 { get; set; }
        public string sabor2 { get; set; }
        public string sabor3 { get; set; }
        public string sabor4 { get; set; }
        public string borda { get; set; }
        public string formaPagamento { get; set; }
        public string pizzaTamanhoPreco { get; set; }
        public string bebida { get; set; }
        public string bebidaPrecoTamanho { get; set; }
        public Nullable<bool> finalizado { get; set; }
        public string valorTotal { get; set; }
    
        public virtual dados_cliente dados_cliente { get; set; }
    }
}
