using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    public class DocumentWorker
    {
        public void OpenDocument() => Console.WriteLine("Документ відкрито");

        public virtual void EditDocument() => Console.WriteLine("Правка документа доступна у версії Про");

        public virtual void SaveDocument() => Console.WriteLine("Збереження документа доступне у версії Про");
    }
}
