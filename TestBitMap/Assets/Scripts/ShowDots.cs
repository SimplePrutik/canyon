using UnityEngine;
using System.Collections;

public class ShowDots : MonoBehaviour {

    int X = -625;
    int Y = -130;
    public UnityEngine.UI.InputField SX;
    public UnityEngine.UI.InputField SY;
    

    void Position() {
        int x = 0;
        try
        {
            x = System.Convert.ToInt32(SX.text);
        }
        catch (System.Exception)
        {
            x = 0;
            SX.text = "";
        }
        if (x < 0) {
            x = 0;
            SX.text = "0";
        }
        if (x > 180) {
            x = 180;
            SX.text = "180";
        }

        int y = 0;
        try {
            y = System.Convert.ToInt32(SY.text);
        } catch (System.Exception) {
            y = 0;
            SY.text = "";
        }
        if (y < 0) {
            SY.text = "0";
            y = 0;
        }
        if (y > 100) {
            y = 100;
            SY.text = "100";
        }

        transform.position = new Vector3(119 + (float)(527.0 / 180.0) * x, 202 + (float)(285.0 / 100.0) * y, 0);
        //transform.position = new Vector3(119 + x, 202 +  y, 0);
    }



    // Use this for initialization
    void Start () {

        Position();

    }

    // Update is called once per frame
    void Update () {

        Position();

    }
}
