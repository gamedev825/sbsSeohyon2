using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PotionScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Potion potion = new SmallPotion();
        potion.FillHp();

        potion = new MiddlePotion();
        potion.FillHp();

        potion = new LargePotion();
        potion.FillHp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
