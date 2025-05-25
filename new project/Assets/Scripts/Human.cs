using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{

    public string myName; //이름
    public int myAge; // 나이
    public float myHeight; //키
    bool isSolo; //

    public void Eat()
    {
        Debug.Log("먹는다");
    }

    public void Sleep()
    {
        Debug.Log("수면");
    }

    public void PowerPush()
    {
        Debug.Log("노폐물 배출");
    }

}
