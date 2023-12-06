using MongoDB.Bson;
using Revisao.Data.Providers.MongoDb.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Providers.MongoDb
{
    public abstract class Document : IDocument
    {

        public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}
