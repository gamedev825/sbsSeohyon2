using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Weapon myWeapon;

    private void Start()
    {
        myWeapon = new Sword();
        myWeapon.Attack();

        myWeapon = new Gun();
        myWeapon.Attack();
    }
}
