using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    public string name;
    public int damage;

    //�⺻ ������

    public Weapon()
    {
        name = "Unknown";
        damage = 10;
    }

    //�Ű������� �ִ� ������

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
}
