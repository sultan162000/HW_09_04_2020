using System;

namespace HW_09_04_task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string pro = "123pro";
            const string exp = "123exp";
            System.Console.Write("Введите ключ доступа: ");
            string a = Console.ReadLine();
            DocumentWorker program = null;
            switch (a)
            {
                case "":
                program = new DocumentWorker();
                break;
                case pro:
                program = new ProDocumentWorker();
                break;
                case exp:
                program = new ExpertDocumentWorker();
                break;
                
            }

            System.Console.WriteLine("1.Открыть Документ\n2.Отредактировать документ\n3.Сохранить в другом формате");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                program.OpenDocument();
                break;
                case 2:
                program.EditDocument();
                break;
                case 3:
                program.SaveDocument();
                break;
                default:
                System.Console.WriteLine("Error!");
                break;
            }
            
            
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
