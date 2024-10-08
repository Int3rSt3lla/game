using UnityEngine;

public class PlayerSprint : MonoBehaviour
{

    private Rigidbody2D rb;
    public int baseSpeed;
    public int sprint;
    private int currentSpeed;
     Vector3 moveDirection;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update ()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            currentSpeed = baseSpeed + sprint;
        }
        else
        {
            currentSpeed = baseSpeed;
        }
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3 (moveHorizontal, 0.0f, moveVertical);

    }

    void FixedUpdate ()
    {
        rb.AddForce (moveDirection * currentSpeed);
    }
}

