using UnityEngine;
using System.Collections;

public abstract class Item : MonoBehaviour
{

    virtual public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           
        }
    }
}
