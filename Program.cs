using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using console_app;
using console_app.DataStructure;
using console_app.Recursion;
using console_app.Sorters;
using console_app.Strings;

namespace ConsoleApplication
{
    public class Program
    {

        static int makeArrayConsecutive2(int[] statues) {
            HashSet<int> inexists = new HashSet<int>();
            HashSet<int> exists = new HashSet<int>(statues);
            
            for (var i = 0; i < statues.Length - 1; i++) {
                var gap = Math.Abs(statues[i] - statues[i + 1]);
                if (gap > 1) {
                    var range = Enumerable.Range((statues[i] > statues[i + 1] ? statues[i + 1] : statues[i]) + 1, gap - 1);
                    inexists.UnionWith(range);
                }
            }
            
            return inexists.Count;
        }

        public static void Main(string[] args) {
            Sorts(new MergeSort());
        }

        static void HashTable() {
            HashTable ht = new HashTable();
            ht.Put("4", 40);
            ht.Put("6", 60);
            ht.Put("7", 70);
            ht.Put("8", 80);
            ht.Put("9", 90);
            ht.Put("5", 50);
            System.Console.WriteLine(ht.KeyExists("2"));
            System.Console.WriteLine(ht.KeyExists("4"));
            System.Console.WriteLine(ht.Get(2));
        }

        static void BinarySearchTree() {
            int[] sample = { 212, 580, 6, 7, 28, 84, 112, 434 };
            BinarySearchTree bst = new BinarySearchTree();
            foreach(int i in sample) {
                bst.Insert(i);
            }

            System.Console.WriteLine(bst.LeafCount());
            System.Console.WriteLine(bst.GetHeight());
            bst.TraverseInOrder();
        }

        static void AddRecursive() {
            MathRecursive teste = new MathRecursive();
            System.Console.WriteLine(teste.Sum(2, 8));
        }

        static void TowerOfHanoi() {
            TowerOfHanoi test = new TowerOfHanoi();
            test.Move(3, 'A', 'C', 'B');
        }

        static void StackTest(IStack stack) {
            stack.Push(5);
            stack.Push(4);
            stack.Push(6);
            stack.Push(10);
            System.Console.WriteLine(stack.IsEmpty());
            System.Console.WriteLine(stack.Peek());
            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Peek());
            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());
        }
        static void LinkedListTest() {
            var linkedList = new CustomLinkedList<int>();
            linkedList.AddAtStart(1);
            linkedList.AddAtStart(5);
            linkedList.AddAtStart(6);
            linkedList.AddAtStart(5);
            linkedList.AddAtStart(2);
            linkedList.AddAtStart(2);
            linkedList.AddAtStart(5);
            linkedList.AddAtStart(1);

            System.Console.WriteLine(linkedList.Length());
            System.Console.WriteLine(linkedList.Find(1));
            System.Console.WriteLine(linkedList.ToString());

            linkedList.Reverse();

            System.Console.WriteLine(linkedList.ToString());

            // linkedList.DeleteDuplicates();

            // System.Console.WriteLine(linkedList.ToString());

            linkedList.DeleteElement(linkedList.Head);

            System.Console.WriteLine(linkedList.ToString());

            System.Console.WriteLine(linkedList.IsCircular());


        }
        static void IsAnagram() {
            var anagram = new Anagram();
            //Console.WriteLine(anagram.IsAnagram("ABABABC", "BABABAD"));
		    Console.WriteLine(anagram.IsAnagram("daniel clowes", "enid coleslaw"));
        }
        static void DuplicationCheck() {
            string word = "great";
            var checker = new CharacterChecker();
            Console.Write(checker.HasDuplicatedCharater(word));

        }

        static void Sorts(ISort sorter) {
            int[] test = new int[] {8, 30, 1, 2, 5, 6};

            int[] result = sorter.Sort(test);

            System.Console.WriteLine(string.Join(", ", result));
                
        }
        static void SortEmployee() {
            var employees = new List<Employee>() {
                new Employee() {
                    EmployeeNumber = 100
                },
                 new Employee() {
                    EmployeeNumber = 15
                },
                 new Employee() {
                    EmployeeNumber = 200
                },
                 new Employee() {
                    EmployeeNumber = 1
                }
            };

            IEmployeeSort employeeSorter = new InsertionSort();
            Employee[] result = employeeSorter.Sort(employees.ToArray());
            Console.WriteLine(string.Join(",", result.Select(p => p.EmployeeNumber)));
        }

    }
}
