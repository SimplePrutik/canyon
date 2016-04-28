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
        transform.position += transform.forward * 5 * Time.deltaTime;
        //transform.Rotate(new Vector3(0, 50, 0) * Time.deltaTime);
        
    }
}
