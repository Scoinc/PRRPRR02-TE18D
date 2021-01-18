using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Labb
{
    class DogOwner
    {

        public string _owner;

        public void TransferOwnership(string owner)
        {
            _owner = owner;
        }
    }
}
