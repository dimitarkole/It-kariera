using System;
using System.Collections.Generic;
using System.Text;

namespace Delegats
{
    public delegate void NameChangeEventHandler();

    class Dispatcher
    {
        public string Name
        {
            get { return Name; }
            set {

                var NameChangeEventArgs =new  NameChangeEventArgs (value);
                Name = NameChangeEventArgs.Name;
            }
        }


        public NameChangeEventHandler NameChange { get; set; }


        public void OnNameChange(NameChangeEventArgs args)
        {

        }

    }
}
