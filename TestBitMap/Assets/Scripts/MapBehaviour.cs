using UnityEngine;
using System.Collections;

public class MapBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Something has entered this zone.");
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Something has entered this zone.");
    }
    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Something has entered this zone.");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("something has hit me");
    }

    // Update is called once per frame
    void Update () {
	
	}
}
