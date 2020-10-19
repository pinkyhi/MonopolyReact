namespace Monopoly.Core.Extensions
{
    using System;
    using System.Collections.Generic;

    public class MapToAttribute : Attribute
    {
        public MapToAttribute(params Type[] assignedTypes)
        {
            this.AssignedTypes = assignedTypes;
        }

        public IEnumerable<Type> AssignedTypes { get; set; }
    }
}