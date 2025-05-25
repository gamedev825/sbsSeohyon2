using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Weapon weapon;

    //Player�� ������

    public Player(string weaponName, int weaponDamage)
    {
        weapon = new Weapon(weaponName, weaponDamage); // Weapon�� �Ű����� ������ ȣ��
    }

    private void Start()
    {
        Debug.Log("Player's weapon : " + weapon.name + "with Damage" + weapon.damage);
    }
}
