using BancosAPI.Dominio.Entidades;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancosAPI.Infra.Data.Contexto
{
    public interface ISistemaContexto
    {
        IMongoCollection<BancoEntidade> Bancos { get; }
    }
}
