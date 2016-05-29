using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ReadMatrix : MonoBehaviour {

    public List<List<List<List<KeyValuePair<int, int>>>>> rules;


    void Start () {
        System.IO.StreamReader sr = new System.IO.StreamReader("rules.txt");
        //Debug.Log(sr);
        rules = new List<List<List<List<KeyValuePair<int, int>>>>>();
        System.String s;
        while ((s = sr.ReadLine()) != null)
        {
            List<int> l = new List<int>();
            char[] charSeparators = new char[] { ' ', '\n' };
            string[] values = s.Split(charSeparators);
            //Debug.Log(values[i]);
            //l.Add(System.Convert.ToInt32(values[i]));
            //rules.Add(new List<List<List<KeyValuePair<int, int>>>>());
            //rules.Add(new List<List<List<KeyValuePair<int, int>>>>());
            //rules.Add(new List<List<List<KeyValuePair<int, int>>>>());
            //rules[System.Convert.ToInt32(values[0])][System.Convert.ToInt32(values[1])][System.Convert.ToInt32(values[2])][System.Convert.ToInt32(values[3])] = new KeyValuePair<int, int>(System.Convert.ToInt32(values[4]), System.Convert.ToInt32(values[5]));
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
