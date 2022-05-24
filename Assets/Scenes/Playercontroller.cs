using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public GameObject Sphere;

    public float speed;
    public float rotationSpeed;
    float num1;

    public bool isAble;

    void Start()
    {
        isAble = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += new Vector3(0, 0, speed);
            transform.Translate(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.position -= new Vector3(0, 0, speed);
            transform.Translate(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles -= new Vector3(0, rotationSpeed, 0);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles += new Vector3(0, rotationSpeed, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clon;
            clon = Instantiate(Sphere);
            clon.transform.position = transform.position - new Vector3(0, 0, -1);
            clon.transform.localScale += new Vector3 (num1, num1, num1);
            num1 += 0.1f;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "EnablerCube")
        {
            isAble = true;
        }
        if (col.gameObject.name == "DesablerCube")
        {
            isAble = false;
        }
    }


}
