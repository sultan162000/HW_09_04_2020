using System;

namespace HW_09_04_task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string pro = "123pro";
            const string exp = "123exp";
            
            
        }
    }
    public class DocumentWorker{

        public void OpenDocument(){
            System.Console.WriteLine("Документ открыть");
        }
        public virtual void EditDocument(){
            System.Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument(){
            System.Console.WriteLine("Сохранение документа доступно в Про");
        }
    }

    class ProDocumentWorker : DocumentWorker{
        public override void EditDocument(){
            System.Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument(){
            System.Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }

    }
    class ExpertDocumentWorker : ProDocumentWorker{
        public override void SaveDocument(){
            System.Console.WriteLine("Документ сохранен в новом формате");
        }
    }


}
