//Copied this class from the Microsoft website to see if I can incorporate item ID's for easier implentation
//Did not work out, more complicated and would have required a lot of code to be rewritten to implement



//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Text_Based_Game
//{
//    public class Item : IEquatable<Item>, IComparable<Item>
//    {
//        public string ItemName { get; set; }

//        public int ItemId { get; set; }

//        public override string ToString()
//        {
//            return "ID: " + ItemId + "   Name: " + ItemName;
//        }

//        public string[] ToArray(List<Item> _)
//        {
//            string[] result = { ItemName };
//            return result;
//        }

//        public override bool Equals(object obj)
//        {
//            if (obj == null) return false;
//            Item objAsPart = obj as Item;
//            if (objAsPart == null) return false;
//            else return Equals(objAsPart);
//        }
//        public int SortByNameAscending(string name1, string name2)
//        {

//            return name1.CompareTo(name2);
//        }

//        // Default comparer for Part type.
//        public int CompareTo(Item comparePart)
//        {
//            // A null value means that this object is greater.
//            if (comparePart == null)
//                return 1;

//            else
//                return this.ItemId.CompareTo(comparePart.ItemId);
//        }
//        public override int GetHashCode()
//        {
//            return ItemId;
//        }
//        public bool Equals(Item other)
//        {
//            if (other == null) return false;
//            return (this.ItemId.Equals(other.ItemId));
//        }
//        // Should also override == and != operators.
//    }
//}
