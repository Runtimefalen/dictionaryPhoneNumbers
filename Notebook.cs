using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp
{
    public class Notebook
    {
        private Dictionary<string, NotebookItem> _dictionary = new Dictionary<string, NotebookItem>();

        public void Create(string firstName, string middleName, string lastName, string phoneNumber)
        {
            var newItem = new NotebookItem
            {
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                PhoneNumber = phoneNumber
            };

            _dictionary.Add(newItem.FIO, newItem);
        }

        public NotebookItem Read(string key)
        {
            return _dictionary[key];
        }

        public void Remove(string key)
        {
            _dictionary.Remove(key);
        }

        public string[] List()
        {
            return _dictionary.Keys.ToArray();
        }
    }
}
