using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Nome { get; private set; }
        public string Descricao { get; set; }
        public int DanoMaximo { get; set; }
        public int Raridade { get; set; }

        //Relacionamento Item --> TipoItem

        public int TipoItemID { get; set; }
        public virtual TipoItem _TipoItem { get; set; }
    }
}