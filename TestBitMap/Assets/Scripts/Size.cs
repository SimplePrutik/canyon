using UnityEngine;
using System.Collections;

public class Size : MonoBehaviour {

    public UnityEngine.UI.Dropdown sensor;

	void Start () {
        transform.localScale *= System.Convert.ToInt32(sensor.itemText) * 0.1f;
	}
	
	void Update () {
	
	}
}
