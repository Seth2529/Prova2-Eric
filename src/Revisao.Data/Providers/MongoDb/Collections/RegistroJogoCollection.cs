using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Providers.MongoDb.Collections
{
    [BsonCollection("RegistroJogo")]
    public class RegistroJogoCollection : Document
    {
        public int primeiroNumero { get; private set; }
        public int segundoNumero { get; private set; }
        public int terceiroNumero { get; private set; }
        public int quartoNumero { get; private set; }
        public int quintoNumero { get; private set; }
        public int sextoNumero { get; private set; }
    }
}