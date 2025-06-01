using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal,IMovable
{
    //가상함수 재정의

    public void Move()
    {
        Debug.Log("고양이 이동중");
    }
}
