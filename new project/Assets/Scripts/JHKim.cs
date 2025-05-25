using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jhkim : Human // Human 클래스를 상속받음
{
    // Start is called before the first frame update
    void Start()
    {
        myName = "김정현";
        Debug.Log(myName);
        Eat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
