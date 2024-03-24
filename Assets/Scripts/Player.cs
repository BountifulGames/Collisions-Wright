using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//////////////////////////////////////////////
//Assignment/Lab/Project: Collisions
//Name: Hunter Wright
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 3/25/2024
/////////////////////////////////////////////

public class Player
{
    private int health = 100;
    private int score = 0;

    public int Health
    {
        get { return health; }
        set { health = Mathf.Max(value, 0); }
    }

    public int Score
    {
        get { return score; }
        set { score = value; }
    }
}
