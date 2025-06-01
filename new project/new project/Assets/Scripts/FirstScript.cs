
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    private IMovable mover;

    public IMovable Mover
    {
        get { return mover; }
        set { mover = value; }
    }

    void Start()
    {
        mover = new Dog();
        mover.Move();

        mover = new Cat();
        mover.Move();
    }    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
