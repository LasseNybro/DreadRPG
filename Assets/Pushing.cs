using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pushing : MonoBehaviour
{
    UnityEvent m_MyEvent;
    public Rigidbody RBody;
    Rigidbody MovingBody;
    Renderer Render;
    Camera PCCamera;
    Vector3 DirectionOfView;
    Vector3 StartMousePos;

    private Color startcolor;
    
    void OnMouseEnter()
    {
        Render = GetComponent<Renderer>();
        startcolor = Render.material.color;
        Render.material.color = Color.yellow;
    }
    void OnMouseExit()
    {
        Render.material.color = startcolor;
    }
    
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            DirectionOfView = new Vector3(0 - PCCamera.transform.position.x, 0, 0 - PCCamera.transform.position.z);
            RBody.AddForce(DirectionOfView.normalized * 20, ForceMode.Impulse);
        }
        
        if (Input.GetMouseButton(0))
        {
            if (Input.GetMouseButtonDown(0))
            {
                MovingBody = RBody;
                StartMousePos = Input.mousePosition;
            }
            if (MovingBody==RBody) {
                RBody.MovePosition((RBody.transform.position + Input.mousePosition - StartMousePos));
            }
        }

    }
    // Start is called before the first frame update
    private void Start()
    {
        PCCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
}
