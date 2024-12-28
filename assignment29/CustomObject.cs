using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace assignment29
{
    public class CustomObject 
    {
        public int ID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public CustomObject(string name, int id)
        {
            this.ID = id;
            this.Name = name;
        }
        public override string ToString()
        {
            return $"the name is {Name} and the id is {ID}";
        }
        public override bool Equals(object o)
        {
            return this.ID == ((CustomObject)o).ID;
        }
        public static bool operator ==(CustomObject o1, CustomObject o2)
        {
            return o1.ID == o2.ID;

        }
        public static bool operator !=(CustomObject o1, CustomObject o2)
        {
            return o1.ID != o2.ID;
        }
    }
}