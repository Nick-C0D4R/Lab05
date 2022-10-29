using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument() => Console.WriteLine("Документ збережений в новому форматі");
    }
}
