using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp2.Model
{
    class User : BaseModel
    {
        private string _name;
        public string Name { get => _name; private set => _name = value; }

        private string _hashedPw;
        public string HashedPw { get => _hashedPw; private set => _hashedPw = value; }

        private string _note;
        public string MyProperty
        {
            get { return _note; }
            set { _note = value; }
        }
        
        

    }
}
