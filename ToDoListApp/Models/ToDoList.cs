using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp.Models
{
    internal class ToDoList : INotifyPropertyChanged
    {
        private bool _isDone;
        private string _text;

        public DateTime CreateDate { get; set; } = DateTime.Now;        

        public bool IsDone { 
            get { return _isDone; }
            set { _isDone = value; }
        }

        public string text
        {
            get { return _text; }
            set { _text = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
