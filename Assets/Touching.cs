using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touching : MonoBehaviour
{
    int CubesRemoved = 0;
    Vector3 StartStats;
    Quaternion Rotation;
    int i=18;
    Rigidbody Collider;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            StartCoroutine(CheckForSecondCollision(collision));
        }
    }

    private IEnumerator CheckForSecondCollision(Collision collision)
    {
        GameObject FirstColObject = collision.gameObject;
        yield return new WaitForSecondsRealtime(1);
        if (collision.gameObject.CompareTag("Cube") && collision.gameObject != FirstColObject)
        {
            Debug.Log("You lost the Game!");
        }
        else
        {
            switch (CubesRemoved % 6)
            {
                case 0:
                    StartStats = new Vector3(0, i * 0.52f + 0.32f, -1);
                    Rotation = Quaternion.identity;
                    break;
                case 1:
                    StartStats = new Vector3(0, i * 0.52f + 0.32f, 0);
                    Rotation = Quaternion.identity;
                    break;
                case 2:
                    StartStats = new Vector3(0, i * 0.52f + 0.32f, 1);
                    Rotation = Quaternion.identity;
                    break;
                case 3:
                    StartStats = new Vector3(-1, i * 0.52f + 0.32f, 0);
                    Rotation = Quaternion.AngleAxis(-90, Vector3.up);
                    break;
                case 4:
                    StartStats = new Vector3(0, i * 0.52f + 0.32f, 0);
                    Rotation = Quaternion.AngleAxis(-90, Vector3.up);
                    break;
                case 5:
                    StartStats = new Vector3(1, i * 0.52f + 0.32f, 0);
                    Rotation = Quaternion.AngleAxis(-90, Vector3.up);
                    i += 1;
                    break;
            }
            FirstColObject.transform.position = StartStats;
            FirstColObject.transform.rotation = Rotation;
            CubesRemoved += 1;
            Debug.Log("Score: " + CubesRemoved.ToString());
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
