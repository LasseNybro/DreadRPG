using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera MCamera;
    float CameraAngle= Mathf.PI;
    float CameraDist=12;

    // Start is called before the first frame update
    void Start()
    {
        //CameraDist = Mathf.Sqrt(MCamera.transform.position.x * MCamera.transform.position.x + MCamera.transform.position.z + MCamera.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            CameraAngle += 1/180f*Mathf.PI;
            float X = Mathf.Sin(CameraAngle)* CameraDist;
            float Z = Mathf.Cos(CameraAngle)* CameraDist;
            MCamera.transform.position = new Vector3(X, MCamera.transform.position.y, Z);
            MCamera.transform.eulerAngles = new Vector3(MCamera.transform.eulerAngles.x, MCamera.transform.eulerAngles.y+1, MCamera.transform.eulerAngles.z);
        }
        if (Input.GetKey("d"))
        {
            CameraAngle -= 1 / 180f * Mathf.PI;
            float X = Mathf.Sin(CameraAngle) * CameraDist;
            float Z = Mathf.Cos(CameraAngle) * CameraDist;
            MCamera.transform.position = new Vector3(X, MCamera.transform.position.y, Z);
            MCamera.transform.eulerAngles = new Vector3(MCamera.transform.eulerAngles.x, MCamera.transform.eulerAngles.y - 1, MCamera.transform.eulerAngles.z);
        }
        if (Input.GetKey("w") && MCamera.transform.position.y<=10)
        {
            MCamera.transform.position = new Vector3(MCamera.transform.position.x, MCamera.transform.position.y+0.1f, MCamera.transform.position.z);
        }
        if (Input.GetKey("s") && MCamera.transform.position.y >= 1.5)
        {
            MCamera.transform.position = new Vector3(MCamera.transform.position.x, MCamera.transform.position.y - 0.1f, MCamera.transform.position.z);
        }
    }
}
