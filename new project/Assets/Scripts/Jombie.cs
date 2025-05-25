using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jombie : Enemy
{
    //가상함수 재정의

    public override void Die()
    {
        Debug.Log("좀비 사망");
    }
}
