using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    public void Eat()
    {
        Debug.Log("������ ������ �Խ��ϴ�");
    }
}

//�������̽� ����

public interface IMovable
{
    void Move();
}
