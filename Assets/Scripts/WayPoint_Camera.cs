using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint_Camera : MonoBehaviour
{

    float speed = 0.5f;
    public Transform target;
    public bool cameramove;

    // Start is called before the first frame update
    void Start()
    {
        cameramove = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cameramove = true;
        }

        if (cameramove)
        {
            transform.LookAt(new Vector3(target.position.x, target.position.y, target.position.z));
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }


    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag=="WayPoint")
        {
            target = other.gameObject.GetComponent<WayPoint>().nextPoint;
            transform.LookAt(new Vector3(target.position.x, target.position.y, target.position.z));
        }
    }

    void cameraMovement()
    {


    }

}
