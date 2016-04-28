using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
    bool SensorForward()
    {
        return true;
    }

	// Update is called once per frame
	void Update ()
    {
        transform.position += transform.forward * 3 * Time.deltaTime;
        
    }
}
