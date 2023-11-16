using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Parameters")]
    public bool canMove = true;
    public float movingSpeed = 5;

    // Update is called once per frame
    void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,v*movingSpeed);
    }
}
