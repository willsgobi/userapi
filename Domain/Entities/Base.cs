using System;
using System.Collections.Generic;

namespace Domain {
    public abstract class Base {

        public Guid Id { get; set; }

        internal List<string> _errors;

        public IReadOnlyCollection<string> Erros => _errors;

        public abstract bool Validate();
    }
}
