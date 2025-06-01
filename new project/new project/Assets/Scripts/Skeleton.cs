using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy
{
    //가상함수 재정의

    public override void Die()
    {
        Debug.Log("스켈레톤 사망");
    }
}
