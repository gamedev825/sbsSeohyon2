
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public List<int> myList = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        myList.Add(5);
        myList.Add(10);

        myList.Insert(1, 7);
        myList.Add(15);

        myList.Remove(5);
        myList.RemoveAt(1);

        Debug.Log("���Ȯ��");

        for (int i = 0; i < myList.Count; i++)
        {
            Debug.Log(i + " ��° �̴Ͼ� ��ȯ");
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
