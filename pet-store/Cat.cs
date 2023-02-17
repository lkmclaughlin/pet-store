using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_store;
internal class Cat : IPet
{
    public string Name { get; set; }

    public string Speak()
     {
         return "'Meow!'";
     }
     public void DontPeeOnRug() { }
     public void DontScratchFurniture() { }
     public void CleanYourOwnLitterBox() { }
}
