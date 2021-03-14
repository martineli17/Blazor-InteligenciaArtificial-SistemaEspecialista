using System;

namespace Dominio.Entidades
{
    public abstract class Base
    {
        public Guid Id { get; init; }
        public Base(Guid id)
        {
            Id = id;
        }

        public Base()
        {
            Id = Guid.NewGuid();
        }


    }
}
