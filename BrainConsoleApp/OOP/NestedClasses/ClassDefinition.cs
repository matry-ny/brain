using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainConsoleApp.OOP.NestedClasses
{
    public class ClassDefinition
    {
        private string _hidden;

        public ClassDefinition(string hidden)
        {
            _hidden = hidden;
        }

        public class NestedPublicMorozow
        {
            private ClassDefinition _owner;

            public NestedPublicMorozow(ClassDefinition owner)
            {
                _owner = owner;
            }

            public string GetOwnerHiddenValue()
            {
                return _owner._hidden;
            }
        }
    }
}
