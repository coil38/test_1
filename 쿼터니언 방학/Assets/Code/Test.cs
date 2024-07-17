using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    // public int _int = 0;               //while문

    //public int[] ints = new int[10];    ////for , foreach문

    public List<ItemObject> itemObjectList = new List<ItemObject>();

    void Start()
    {
        /*


while (_int < 3)
{
   Debug.Log(_int);
   _int++;
}


*/         //while문
        /*
        for (int i = 0; i < ints.Length; i++)
        {
            ints[i] = Random.Range(0, 20);
        }

        foreach(int i in ints)
        {
            if (i % 2 == 0)
                Debug.Log(i);
        }

        for(int i = 0; i < ints.Length; i++)
        {
            if (ints[i] % 2 == 0)
                Debug.Log(ints[i]);
        }*/         //for , foreach문
        /*
        intList.Add(23);
        intList.Add(23);
        intList.Add(23);
        intList.Clear();
        intList.Contains(12);
*/

        Debug.Log(itemObjectList[0].name);
        Debug.Log(itemObjectList[0].age);
        Debug.Log(itemObjectList[0].id);

    }

}
