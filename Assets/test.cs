using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{
    int sdvigx;
    int sdvigy;
    public GameObject grassss;
    public GameObject trava;
    int min = -1;
    int mux = 2;
    void Start()
    {
        InvokeRepeating("Generate", 1f, 1);
    }

    void Update()
    {
        sdvigy = Random.Range(min, mux);
        sdvigy = sdvigy * 1;

    }

    void Generate()
    {
        if (sdvigy == -1) { GameObject grass = (GameObject)Instantiate(grassss, new Vector2(sdvigx, sdvigy), Quaternion.identity); }
        if (sdvigy == 0) { GameObject grass = (GameObject)Instantiate(trava, new Vector2(sdvigx, sdvigy), Quaternion.identity); sdvigx++; }
        
    }

}
