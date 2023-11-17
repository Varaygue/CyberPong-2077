using UnityEngine;

public class SphereController : MonoBehaviour
{
    public float thrust = 600.0f;

    public void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.right * -thrust);

    }

}