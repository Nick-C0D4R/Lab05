using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    public class ProDocumentWorker : DocumentWorker
    {
        sealed public override void EditDocument() => Console.WriteLine("Документ відредаговано");

        public override void SaveDocument() => Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт");
    }
}
