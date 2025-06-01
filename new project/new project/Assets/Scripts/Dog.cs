using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal,IMovable
{
    //가상함수 재정의

    public void Move()
    {
        Debug.Log("개가 빠르게 뛰어갑니다");
    }
}
