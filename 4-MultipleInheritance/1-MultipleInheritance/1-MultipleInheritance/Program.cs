using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_MultipleInheritance
{
    public class TextBox : UiControl, IDraggable, IDroppable
    {
        public void Drag()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }
    }
    public class UiControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }
        public virtual void Draw()
        {

        }
        public void Focus()
        {
            Console.WriteLine("Received focus.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
