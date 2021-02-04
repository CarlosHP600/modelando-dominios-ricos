using System;

namespace NerdStore.Core.DomainObjects
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        // Override no equals, de modo a facilitar a comparar entre duas entidades, by E.Pires.
        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;
            if (ReferenceEquals(this, compareTo))
                return false;

            if (ReferenceEquals(null, compareTo))
                return false;

            return Id.Equals(compareTo.Id);
        }

        // O operator == também foi alterado, de modo a ter o mesmo comportamento do Equals.
        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return true;

            return a.Equals(b);
        }

        // É necessário sobreescrever o operator !=, para que a diferença feita pelo Id.
        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        // A ideia é mitigar a chance de termos 2 hashcode para objetos diferentes.
        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{GetType().Name} - [Id:{Id}]";
        }
    }
}