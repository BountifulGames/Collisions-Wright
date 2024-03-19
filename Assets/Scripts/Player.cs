using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
