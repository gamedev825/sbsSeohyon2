using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
   public string Nmae { get; set; }

    //�����Լ�

    public virtual void Attack()
    {
        Debug.Log("�������");
    }
}
