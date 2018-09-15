using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.2 Проверить скорость работы (добавление, поиск элемента, удаление) следующих коллекций. 
//NOTE: Для наглядности рекомендуется использовать от 10000+ элементов в коллекции
//a.Листы(ArrayList vs LinkedList);
//b.Списки(Stack vs Queue);
//c.Словари(HashTable vs Dictionary).

namespace Collections_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            CompareService.CompareArrayListVsLinkedList();
            CompareService.CompareStackVsQueue();
            CompareService.CompareHashTableVsDictionary();
        }

        
    }
    
}
