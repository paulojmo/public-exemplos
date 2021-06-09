using Compartilhado.Interfaces;
using System;

namespace Compartilhado.EntidadeBase
{
    public abstract class EntidadeBase : LongEntidadeChave //, IEntidadeChaveExterna
    {
        protected EntidadeBase(long id) : base(id)
        {
            IdExterno = Guid.NewGuid();
        }

        /// <summary>
        /// Utilizado para sincronização de bases. Onde o IdExterno deve ser o mesmo entre duas bases.
        /// </summary>
        /// <param name="idExterno"></param>
        protected EntidadeBase(Guid? idExterno)
        {
            if (idExterno == null || Guid.Empty.Equals(idExterno))
            {
                IdExterno = Guid.NewGuid();
                return;
            }

            IdExterno = (Guid)idExterno;
        }

        protected EntidadeBase()
        {
            IdExterno = Guid.NewGuid();
        }

        public Guid IdExterno { get; private set; }
        public DateTime? CriadoEm { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }
    }
}