using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Weapon weapon;

    //Player의 생성자

    public Player(string weaponName, int weaponDamage)
    {
        weapon = new Weapon(weaponName, weaponDamage); // Weapon의 매개변수 생성자 호출
    }

    private void Start()
    {
        Debug.Log("Player's weapon : " + weapon.name + "with Damage" + weapon.damage);
    }
}
