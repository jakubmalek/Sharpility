﻿using System.Collections.Generic;
using Sharpility.Extensions;

namespace Sharpility.Util
{
    public static class Dictionaries
    {
        public static IDictionary<T, TV> Create<T, TV>(params KeyValuePair<T, TV>[] entries)
        {
            var dictionary = new Dictionary<T, TV>();
            dictionary.PutAll(entries);
            return dictionary;
        }

        public static IDictionary<T, TV> Create<T, TV>(T key, TV value)
        {
            var dictionary = new Dictionary<T, TV>();
            dictionary.Put(key, value);
            return dictionary;
        }

        # region QuickDictionaryCreate

        public static IDictionary<T, TV> Create<T, TV>(T key1, TV value1, T key2, TV value2)
        {
            var dictionary = new Dictionary<T, TV>();
            dictionary.Put(key1, value1);
            dictionary.Put(key2, value2);
            return dictionary;
        }

        public static IDictionary<T, TV> Create<T, TV>(T key1, TV value1, T key2, TV value2, T key3, TV value3)
        {
            var dictionary = new Dictionary<T, TV>();
            dictionary.Put(key1, value1);
            dictionary.Put(key2, value2);
            dictionary.Put(key3, value3);
            return dictionary;
        }

        public static IDictionary<T, TV> Create<T, TV>(T key1, TV value1, T key2, TV value2, T key3, TV value3, T key4, TV value4)
        {
            var dictionary = new Dictionary<T, TV>();
            dictionary.Put(key1, value1);
            dictionary.Put(key2, value2);
            dictionary.Put(key3, value3);
            dictionary.Put(key4, value4);
            return dictionary;
        }

        public static IDictionary<T, TV> Create<T, TV>(T key1, TV value1, T key2, TV value2, T key3, TV value3, T key4, TV value4, T key5, TV value5)
        {
            var dictionary = new Dictionary<T, TV>();
            dictionary.Put(key1, value1);
            dictionary.Put(key2, value2);
            dictionary.Put(key3, value3);
            dictionary.Put(key4, value4);
            dictionary.Put(key5, value5);
            return dictionary;
        }

        public static IDictionary<T, TV> Create<T, TV>(T key1, TV value1, T key2, TV value2, T key3, TV value3, T key4, TV value4, T key5, TV value5, 
            T key6, TV value6)
        {
            var dictionary = new Dictionary<T, TV>();
            dictionary.Put(key1, value1);
            dictionary.Put(key2, value2);
            dictionary.Put(key3, value3);
            dictionary.Put(key4, value4);
            dictionary.Put(key5, value5);
            dictionary.Put(key6, value6);
            return dictionary;
        }

        public static IDictionary<T, TV> Create<T, TV>(T key1, TV value1, T key2, TV value2, T key3, TV value3, T key4, TV value4, T key5, TV value5, 
            T key6, TV value6, T key7, TV value7)
        {
            var dictionary = new Dictionary<T, TV>();
            dictionary.Put(key1, value1);
            dictionary.Put(key2, value2);
            dictionary.Put(key3, value3);
            dictionary.Put(key4, value4);
            dictionary.Put(key5, value5);
            dictionary.Put(key6, value6);
            dictionary.Put(key7, value7);
            return dictionary;
        }

        public static IDictionary<T, TV> Create<T, TV>(T key1, TV value1, T key2, TV value2, T key3, TV value3, T key4, TV value4, T key5, TV value5, 
            T key6, TV value6, T key7, TV value7, T key8, TV value8)
        {
            var dictionary = new Dictionary<T, TV>();
            dictionary.Put(key1, value1);
            dictionary.Put(key2, value2);
            dictionary.Put(key3, value3);
            dictionary.Put(key4, value4);
            dictionary.Put(key5, value5);
            dictionary.Put(key6, value6);
            dictionary.Put(key7, value7);
            dictionary.Put(key8, value8);
            return dictionary;
        }

        public static IDictionary<T, TV> Create<T, TV>(T key1, TV value1, T key2, TV value2, T key3, TV value3, T key4, TV value4, T key5, TV value5, 
            T key6, TV value6, T key7, TV value7, T key8, TV value8, T key9, TV value9)
        {
            var dictionary = new Dictionary<T, TV>();
            dictionary.Put(key1, value1);
            dictionary.Put(key2, value2);
            dictionary.Put(key3, value3);
            dictionary.Put(key4, value4);
            dictionary.Put(key5, value5);
            dictionary.Put(key6, value6);
            dictionary.Put(key7, value7);
            dictionary.Put(key8, value8);
            dictionary.Put(key9, value9);
            return dictionary;
        }

        public static IDictionary<T, TV> Create<T, TV>(T key1, TV value1, T key2, TV value2, T key3, TV value3, T key4, TV value4, T key5, TV value5, 
            T key6, TV value6, T key7, TV value7, T key8, TV value8, T key9, TV value9, T key10, TV value10)
        {
            var dictionary = new Dictionary<T, TV>();
            dictionary.Put(key1, value1);
            dictionary.Put(key2, value2);
            dictionary.Put(key3, value3);
            dictionary.Put(key4, value4);
            dictionary.Put(key5, value5);
            dictionary.Put(key6, value6);
            dictionary.Put(key7, value7);
            dictionary.Put(key8, value8);
            dictionary.Put(key9, value9);
            dictionary.Put(key10, value10);
            return dictionary;
        }

        # endregion QuickDictionaryCreate

        public static KeyValuePair<T, TV> Entry<T, TV>(T key, TV value)
        {
            return new KeyValuePair<T, TV>(key: key, value: value);
        }

        public static IDictionary<T, TV> Empty<T, TV>()
        {
            return new Dictionary<T, TV>();
        }
    }
}
