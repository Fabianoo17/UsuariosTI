using Corretora.Business.Entities;
using Corretora.Business.Interfaces;
using Corretora.Data.Context;
using Corretora.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corretora.Data.Repository
{
    public class diectvw006_willis_rural_visaoRepository : Repository<diectvw006_willis_rural_visao>, Idiectvw006_willis_rural_visaoRepository
    {
        public diectvw006_willis_rural_visaoRepository(CorretoraContext context) : base(context)
        {

        }
    }
}
