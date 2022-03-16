using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryHomework
{
    class MyDictionary<K, V>
    {
        K[] _arrayKeys;
        V[] _arrayValues;

        public MyDictionary()
        {
            _arrayKeys = new K[0];
            _arrayValues = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] _tempArrayKeys = _arrayKeys;
            V[] _tempArrayValues = _arrayValues;
            _arrayKeys = new K[_arrayKeys.Length + 1];
            _arrayValues = new V[_arrayValues.Length + 1];
            bool isThatKeyExist = false;

            for (int i = 0; i < _tempArrayKeys.Length; i++)
            {
                if (_tempArrayKeys[i].Equals(key))
                {
                    Console.WriteLine("Bu Plaka Zaten Kayıtlı ! ");
                    isThatKeyExist = true;
                    break;
                }
            }
            if (isThatKeyExist == false)
            {
                for (int i = 0; i < _tempArrayKeys.Length; i++)
                {
                    _arrayKeys[i] = _tempArrayKeys[i];
                    _arrayValues[i] = _tempArrayValues[i];
                }
                _arrayKeys[_arrayKeys.Length - 1] = key;
                _arrayValues[_arrayValues.Length - 1] = value;
            }
        }

        public void ShowAll()
        {
            for (int i = 0; i < _arrayKeys.Length; i++)
            {
                Console.WriteLine(_arrayKeys[i] + "  -  " + _arrayValues[i]);
            }
        }
    }
}
