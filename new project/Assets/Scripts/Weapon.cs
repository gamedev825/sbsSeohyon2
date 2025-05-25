using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    public string name;
    public int damage;

    //기본 생성자

    public Weapon()
    {
        name = "Unknown";
        damage = 10;
    }

    //매개변수가 있는 생성자

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
}
