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
        for (int i = 0; i < 3; i++)
            rules.Add(new List<List<List<KeyValuePair<int, int>>>>());

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                rules[i].Add(new List<List<KeyValuePair<int, int>>>());

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                for (int k = 0; k < 3; k++)
                    rules[i][j].Add(new List<KeyValuePair<int, int>>());

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                for (int k = 0; k < 3; k++)
                    for (int ll = 0; ll < 3; ll++)
                        rules[i][j][k].Add(new KeyValuePair<int, int>());

        while ((s = sr.ReadLine()) != null)
        {
            List<int> l = new List<int>();
            char[] charSeparators = new char[] { ' ', '\n' };
            string[] values = s.Split(charSeparators);

            int x0 = System.Convert.ToInt32(values[0]);
            int x1 = System.Convert.ToInt32(values[1]);
            int x2 = System.Convert.ToInt32(values[2]);
            int x3 = System.Convert.ToInt32(values[3]);
            int x4 = System.Convert.ToInt32(values[4]);
            int x5 = System.Convert.ToInt32(values[5]);


            rules[x0][x1][x2][x3] = new KeyValuePair<int, int>(x4, x5);
            //Debug.Log(rules[x0][x1][x2][x3].Key);
            //Debug.Log(rules[x0][x1][x2][x3].Value);


        }

        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
