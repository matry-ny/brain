using System;

namespace BrainConsoleApp.OOP.Interfaces
{
    public interface ISuperInterfaceDeclarationA
    {
        string Test { get; }
    }

    public interface ISuperInterfaceDeclarationB
    {
        int Test { get; }
    }

    public interface IInterfaceDeclaration : ISuperInterfaceDeclarationA, ISuperInterfaceDeclarationB
    {
        string Property { get; }

        string this[int index] { get; set; }

        void Clear();

        event EventHandler Notify;
    }
}