using System;
using System.Collections.Generic;

namespace LootSort
{
    /// <summary>
    /// The Loot class should implement IComparable<Loot>
    /// and override GetHashCode() and Equals()
    /// </summary>
    public class Loot : IComparable<Loot>
    {
        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }

        /// <summary>
        /// Create a new instance of loot.
        /// </summary>
        /// <param name="kind">Type of loot.</param>
        /// <param name="description">Loot description.</param>
        /// <param name="value">Loot value.</param>
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        /// <summary>
        /// Return a nicely formatted string representing the loot instance.
        /// </summary>
        /// <returns>
        /// A nicely formatted string representing the loot instance.
        /// </returns>
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";


        public override int GetHashCode()
        {
            return HashCode.Combine(Kind, Description, Value);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Loot otherLoot = (Loot)obj;
            return Kind == otherLoot.Kind &&
                   Description == otherLoot.Description &&
                   Value == otherLoot.Value;
        }

        public int CompareTo(Loot other)
        {
            // Sort by loot type (alphabetical order)
            int kindComparison = string.Compare(Kind.ToString(), 
                                 other.Kind.ToString(), 
                                 StringComparison.Ordinal);
            if (kindComparison != 0)
                return kindComparison;

            // If loot types are the same, sort by loot value
            int valueComparison = Value.CompareTo(other.Value);
            if (valueComparison != 0)
                return -valueComparison; // Reverse order

            // If loot types and their values are equal, sort by loot description
            return string.Compare(Description, other.Description, StringComparison.Ordinal);
        }
    }
}