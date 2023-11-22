using UnityEngine;

public class Playercontroller : MonoBehaviour
{

    public float speed;
    public KeyCode up;
    public KeyCode down;
    private Rigidbody rb;
    private float boundaryZ = 9.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bool pressedUp = Input.GetKey(this.up);
        bool pressedDown = Input.GetKey(this.down);

        if(pressedUp)
        {
            rb.velocity = Vector3.forward * speed;
        }
        if(pressedDown)
        {
            rb.velocity = Vector3.back * speed;
        }
        if(!pressedUp && !pressedDown)
        {
            rb.velocity = Vector3.zero;
        }
        ClampPlayerPosition();
    }
    void ClampPlayerPosition()
    {
        // Clamp the player's x position to stay within the specified boundaries
        Vector3 clampedPosition = transform.position;
        clampedPosition.z = Mathf.Clamp(clampedPosition.z, -boundaryZ, boundaryZ);
        transform.position = clampedPosition;
    }
}