using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{

    public string myName; //�̸�
    public int myAge; // ����
    public float myHeight; //Ű
    bool isSolo; //

    public void Eat()
    {
        Debug.Log("�Դ´�");
    }

    public void Sleep()
    {
        Debug.Log("����");
    }

    public void PowerPush()
    {
        Debug.Log("���� ����");
    }

}
