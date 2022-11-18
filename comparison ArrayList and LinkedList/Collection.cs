using System.Collections;
using System.Diagnostics;

internal partial class Program
{
    class Collection
    {
        private Random random = new();
        private int rand(int max = /*int.MaxValue*/10)
        {
            return random.Next(0, max);
        }

        private Stopwatch ArrayListWatch = new();
        private ArrayList arrayList = new();

        private Stopwatch LinkedListWatch = new();
        private LinkedList<int> linkedList = new();

        public string AddFirst(int size)
        {
            ArrayListWatch.Restart();
            for (int i = 0; i < size; i++)
            {
                arrayList.Add(1);
                for (int j = arrayList.Count - 2; j >= 0; j--)
                    arrayList[j + 1] = arrayList[j];

                arrayList[0] = rand();
            }
            ArrayListWatch.Stop();

            LinkedListWatch.Restart();
            for (int i = 0; i < size; i++)
            {
                linkedList.AddFirst(rand());
            }
            LinkedListWatch.Stop();

            return $"AddFirst:\n " +
                   $"\tArrayList  : {ArrayListWatch.Elapsed}\n" +
                   $"\tLinkedList : {LinkedListWatch.Elapsed}";
        }

        public string AddCenter(int size)
        {
            ArrayListWatch.Restart();
            for (int i = 0; i < size; i++)
            {
                arrayList.Add(1);
                for (int j = arrayList.Count - 2; j >= (arrayList.Count - 1) / 2; j--)
                    arrayList[j + 1] = arrayList[j];

                arrayList[(arrayList.Count - 1) / 2] = rand();
            }
            ArrayListWatch.Stop();

            LinkedListWatch.Restart();
            for (int i = 0; i < size; i++)
            {
                LinkedListNode<int> node = linkedList.First;
                for (int j = 0; j < (linkedList.Count - 1) / 2; j++)
                {
                    node = node.Next;
                }
                linkedList.AddAfter(node, new LinkedListNode<int>(rand()));
            }
            LinkedListWatch.Stop();

            return $"AddCenter:\n " +
                   $"\tArrayList  : {ArrayListWatch.Elapsed}\n" +
                   $"\tLinkedList : {LinkedListWatch.Elapsed}";
        }

        public string AddLast(int size)
        {
            ArrayListWatch.Restart();
            for (int i = 0; i < size; i++)
            {
                arrayList.Add(rand());
            }
            ArrayListWatch.Stop();

            LinkedListWatch.Restart();
            for (int i = 0; i < size; i++)
            {
                linkedList.AddLast(rand());
            }
            LinkedListWatch.Stop();

            return $"AddLast:\n " +
                   $"\tArrayList  : {ArrayListWatch.Elapsed}\n" +
                   $"\tLinkedList : {LinkedListWatch.Elapsed}";
        }

        public string SequentialAccess()
        {
            int test;
            ArrayListWatch.Restart();
            for (int i = 0; i < arrayList.Count; i++)
            {
                test = (int)arrayList[i];
            }
            ArrayListWatch.Stop();

            LinkedListWatch.Restart();
            for (LinkedListNode<int> node = linkedList.First; node != linkedList.Last;)
            {
                test = node.Value;
                node = node.Next;
            }
            LinkedListWatch.Stop();

            return $"SequentialAccess:\n " +
                   $"\tArrayList  : {ArrayListWatch.Elapsed}\n" +
                   $"\tLinkedList : {LinkedListWatch.Elapsed}";
        }

        public string RandomAccess()
        {
            int test;
            ArrayListWatch.Restart();
            for (int i = 0; i < arrayList.Count; i++)
            {
                test = (int)arrayList[rand(arrayList.Count)];
            }
            ArrayListWatch.Stop();

            LinkedListWatch.Restart();
            for (int i = 0; i < linkedList.Count; i++)
            {
                LinkedListNode<int> randnode = linkedList.First;
                for (int j = 1; j < rand(linkedList.Count - 1); j++)
                {
                    randnode = randnode.Next;
                }
                test = linkedList.Find(randnode.Value).Value;
            }
            LinkedListWatch.Stop();

            return $"RandomAccess:\n " +
                   $"\tArrayList  : {ArrayListWatch.Elapsed}\n" +
                   $"\tLinkedList : {LinkedListWatch.Elapsed}";
        }

        public string getLength()
        {
            return $"Length:" +
                   $"\tLinked:{linkedList.Count}\n" +
                   $"\tArray: {arrayList.Count}";
        }
    }
}