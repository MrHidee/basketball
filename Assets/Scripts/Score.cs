using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : Item
{
    public int scoreValue = 1;

    override public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            base.OnTriggerEnter(other);
            LevelManager.instance.addScore(scoreValue);
        }
    }
}
