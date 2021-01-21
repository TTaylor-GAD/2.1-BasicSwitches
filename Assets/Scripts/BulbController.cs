using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour
{
    private bool bulbOff = true;

    private Animator bulbAnimator;



    void Awake()
    {
        bulbAnimator = gameObject.GetComponent<Animator>();

        turnOff();
    }

    public void turnOff()
    {
        bulbOff = true;
        bulbAnimator.SetBool("BulbOff", bulbOff);
    }

    public void turnOn()
    {
        bulbOff = true;
        bulbAnimator.SetBool("BulbOn", bulbOff);
    }

}
