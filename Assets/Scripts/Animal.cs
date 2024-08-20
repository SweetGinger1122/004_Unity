using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird
{
    int wings   = 2;
    int legs    = 2;

    public void fly()
    {
        Debug.Log("I am flying. ");
    }
    public void sing()
    {
        Debug.Log("I am singing. ");
    }
}
public class Chicken
{
    int wings = 2;
    int beak  = 1;

    public void flutter()
    {
        Debug.Log("Kratarkk!!!");
    }
    public void yell()
    {
        Debug.Log("Cock a doodle doo!!");
    }
}
public class Crow : Bird
{
    Bomb bomb01 = new Bomb();


    public void attack()
    {
        bomb01.explod();
    }
}
public class Bomb
{
    public void explod()
    {
        Debug.Log("Boooooooooooommm!!!");
    }
}

public class Animal : MonoBehaviour
{
  
    void Start()
    {
        Bird somchai = new Bird();
        Bird cookie  = new Bird();

        somchai.fly();
        cookie.sing();

        Chicken somying = new Chicken();
        Chicken sompong = new Chicken();

        somying.flutter();
        sompong.yell();
        
    }

    void Update()
    {
        
    }
}
