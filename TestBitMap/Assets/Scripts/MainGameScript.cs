using UnityEngine;
using System.Collections;

public class MainGameScript : MonoBehaviour {

    public GameObject Block;
    GameObject[,] MapArea = new GameObject[300, 300];

    void GenMap()
    {
        //точка отсчета
        Vector3 PointStart = new Vector3(0, 0, 0);
        //Debug.Log(System.IO.Directory.GetCurrentDirectory());
        System.Drawing.Bitmap image = new System.Drawing.Bitmap("Assets/Images/Map2.bmp", true);



        for (int X = 0; X < image.Width; X++)
            for (int Y = 0; Y < image.Height; Y++)
            {
                System.Drawing.Color color = image.GetPixel(X, Y);
                //if (X == 100 && Y == 100) {
                //    Debug.Log(color.ToString());
                //    Debug.Log(System.Drawing.Color.FromArgb(100, 134, 1));
                //    Debug.Log(color == System.Drawing.Color.FromArgb(100, 134, 1));
                //}
                if (color == System.Drawing.Color.FromArgb(255, 0, 0, 0))
                {
                    PointStart = new Vector3(X, image.Height - Y - 1, 0);
                    MapArea[X, image.Height - Y - 1] = (GameObject)Instantiate(Block, PointStart, Quaternion.identity);
                }
            }
    }

    // Use this for initialization
    void Start () {
        GenMap();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
