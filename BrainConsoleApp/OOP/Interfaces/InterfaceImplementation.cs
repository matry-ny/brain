using System;

namespace BrainConsoleApp.OOP.Interfaces
{
    class InterfaceImplementation : IInterfaceDeclaration
    {
        string ISuperInterfaceDeclarationA.Test
        {
            get { return "test"; }
        }

        int ISuperInterfaceDeclarationB.Test {
            get { return 1; }
        }
        public string Property { get; private set; }

        public string this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public event EventHandler Notify;
    }
}
