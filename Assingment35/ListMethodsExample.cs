using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        void Start()
        {
            List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
            numbers.Sort(Comperator);
            // numbers.Sort((int a, int b) => (a > b) ? 1 : -1);

            Debug.Log("sorting example : " + string.Join(",", numbers));

            // ========= part 2 of lists =============

            List<int> numbers2 = new List<int>() { 3, 1, 4, 1, 5, 9, 2, 6 };
            List<int> filteredList = numbers2.FindAll((int x) => (x % 2 == 0));
            Debug.Log("filtering example : " + string.Join(",", filteredList));
        }

        // sorting method
        int Comperator(int x, int y) => y.CompareTo(x);
    }
}