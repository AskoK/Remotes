using System;
namespace Remote
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
