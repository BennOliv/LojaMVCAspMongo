using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMongoDB.Models
{
    public abstract class Produto
    {
        public long CodigoBarras { get; set; }
        public int Estoque { get; set; }
        public float PrecoVarejo { get; set; }
        public float PrecoAtacado { get; set; }
        public string UrlImagem { get; set; }
    }
}
