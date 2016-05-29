using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Penetration : MonoBehaviour {
    public List<GameObject> sensors;
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < sensors.Count; ++i)
            if (sensors[i].GetComponent<Feeling>().feel)
            {
                switch (name)
                {
                    case "Prutik1":
                        GetComponentInParent<ExpertSystem>().l_s = i;
                        break;
                    case "Prutik2":
                        GetComponentInParent<ExpertSystem>().middle_s = i;
                        break;
                    case "Prutik3":
                        GetComponentInParent<ExpertSystem>().r_s = i;
                        break;
                    default:
                        Debug.Log("Какая-то хуйня");
                        break;
                }
                continue;
            }
                

	}
}
