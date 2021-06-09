using Compartilhado.Interfaces;
using Flunt.Notifications;

namespace Compartilhado.EntidadeBase
{
    public abstract class StringEntidadeChave : Notifiable, IEntidadeChave<string>
    {
        protected StringEntidadeChave(string id)
        {
            Id = id;
        }

        protected StringEntidadeChave()
        {
        }

        public string Id { get; protected set; }
    }
}
