using UnityEngine;
using System.Collections;

public class Speed : MonoBehaviour {

    [Header("Zero")]
    public float z1;
    public float z2;
    public float z3;
    public float z4;

    [Header("One")]
    public float o1;
    public float o2;
    public float o3;
    public float o4;

    [Header("Two")]
    public float t1;
    public float t2;
    public float t3;
    public float t4;

    public UnityEngine.UI.Dropdown Input;


    void Start()
    {
        float val = 0;
        if (Input.value == 0)
            val = 1;
        if (Input.value == 1)
            val = 1.5f;
        else
            val = 1.7f;

        z1 *= val;
        z2 *= val;
        z3 *= val;
        z4 *= val;

        o1 *= val;
        o2 *= val;
        o3 *= val;
        o4 *= val;

        t1 *= val;
        t2 *= val;
        t3 *= val;
        t4 *= val;
    }

}
