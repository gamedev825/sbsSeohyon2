using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    public void Eat()
    {
        Debug.Log("동물이 음식을 먹습니다");
    }
}

//인터페이스 구현

public interface IMovable
{
    void Move();
}
