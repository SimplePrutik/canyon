using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

    public bool feel;

    void OnTriggerEnter(Collider other)
    {
        //if (other.name == "Map(Clone)")
        //    feel = true;
        other.GetComponent<SpriteRenderer>().color = Color.green;
    }

    void onTriggerExit(Collider other)
    {
        other.GetComponent<SpriteRenderer>().color = Color.red;
    }
}
