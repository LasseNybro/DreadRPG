using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startup : MonoBehaviour
{

    public GameObject MyPrefab;
    int TowerHeight = 18;
    Vector3 StartStats1;
    Vector3 StartStats2;
    Vector3 StartStats3;
    GameObject NewCube;
    Quaternion Rotation;
    int Once=0;

    // Start is called before the first frame update
    void Start()
    {
        if (Once == 0)
        {
            for (int i = 0; i < TowerHeight; i++)
            {
                if (i % 2 == 0)
                {
                    StartStats1 = new Vector3(0, i * 0.52f + 0.32f, -1);
                    StartStats2 = new Vector3(0, i * 0.52f + 0.32f, 0);
                    StartStats3 = new Vector3(0, i * 0.52f + 0.32f, 1);
                    Rotation = Quaternion.identity;
                }
                else
                {
                    StartStats1 = new Vector3(-1, i * 0.52f + 0.32f, 0);
                    StartStats2 = new Vector3(0, i * 0.52f + 0.32f, 0);
                    StartStats3 = new Vector3(1, i * 0.52f + 0.32f, 0);
                    Rotation = Quaternion.AngleAxis(-90, Vector3.up);
                }
                NewCube = Instantiate(MyPrefab, StartStats1, Rotation);
                NewCube.transform.localScale += new Vector3(0, Random.Range(-2, 2)/100f, 0);
                NewCube = Instantiate(MyPrefab, StartStats2, Rotation);
                NewCube.transform.localScale += new Vector3(0, Random.Range(-2, 2)/100f, 0);
                NewCube = Instantiate(MyPrefab, StartStats3, Rotation);
                NewCube.transform.localScale += new Vector3(0, Random.Range(-2, 2)/100f, 0);
            }
            Once++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
