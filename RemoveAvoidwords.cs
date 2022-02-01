using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingandBST
{
    
    
        internal class RemoveAvoidwords
        {

            public struct KeyValue<K, V>
            {
                public K Key { get; set; }
                public V Value { get; set; }
            };

            public class Remove_Avoidable_word<K, V>
            {
                int size;
                public LinkedList<KeyValue<K, V>>[] items;

                public MapNode(int size)
                {
                    this.size = size;
                    this.items = new LinkedList<KeyValue<K, V>>[size];
                }



                public void Add(K key, V value)
                {
                    int position = GetArrayPosition(key);
                    LinkedList<KeyValue<K, V>> LinkedListofPosition = GetLinkedListPosition(position);
                    KeyValue<K, V> keyValue = new KeyValue<K, V>()
                    {
                        Key = key,
                        Value = value
                    };
                    LinkedListofPosition.AddLast(keyValue);
                }

                public int GetArrayPosition(K key)
                {
                    int hashcode = key.GetHashCode();
                    int position = hashcode % size;
                    return Math.Abs(position);
                }

                public LinkedList<KeyValue<K, V>> GetLinkedListPosition(int position)
                {
                    if (items[position] == null)
                    {
                        items[position] = new LinkedList<KeyValue<K, V>>();
                    }
                    return items[position];
                }
                public int CheckHash(K key)
                {
                    int position = GetArrayPosition(key);
                    LinkedList<KeyValue<K, V>> LinkedListofPosition = GetLinkedListPosition(position);
                    int count = 1;
                    bool found = false;
                    KeyValue<K, V> founditem = default(KeyValue<K, V>);

                    foreach (KeyValue<K, V> keyValue in LinkedListofPosition)
                    {
                        if (keyValue.Key.Equals(key))
                        {
                            count = Convert.ToInt32(keyValue.Value) + 1;
                            found = true;
                            founditem = keyValue;
                        }
                    }
                    if (found)
                    {
                        LinkedListofPosition.Remove(founditem);
                        return count;
                    }
                    else
                    {
                        return 1;
                    }

                }
                public void Remove(K key)
                {
                    int position = GetArrayPosition(key);
                    LinkedList<KeyValue<K, V>> linkedList = GetLinkedListPosition(position);
                    bool itemFound = false;
                    KeyValue<K, V> founditem = default(KeyValue<K, V>);
                    foreach (KeyValue<K, V> keyValue in linkedList)
                    {
                        if (keyValue.Key.Equals(key))
                        {
                            itemFound = true;
                            founditem = keyValue;
                        }
                    }
                    if (itemFound)
                    {
                        linkedList.Remove(founditem);

                    }
                }
                public void Display(K key)
                {
                    int position = GetArrayPosition(key);
                    LinkedList<KeyValue<K, V>> LinkedListofPosition = GetLinkedListPosition(position);
                    foreach (KeyValue<K, V> keyValue in LinkedListofPosition)
                    {
                        if (keyValue.Key.Equals(key))
                        {
                            Console.WriteLine("Key: " + keyValue.Key + "\t Value: " + keyValue.Value);
                        }

                    }
                }

            }
        }


    }
}
}
