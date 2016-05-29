using UnityEngine;
using System.Collections;

public class Feeling : MonoBehaviour {

    public bool feel;

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Map(Clone)")
            feel = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Map(Clone)")
            feel = true;
    }

}
