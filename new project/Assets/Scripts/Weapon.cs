using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
   public string Nmae { get; set; }

    //가상함수

    public virtual void Attack()
    {
        Debug.Log("무기공격");
    }
}
