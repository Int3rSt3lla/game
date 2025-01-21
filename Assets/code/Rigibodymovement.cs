
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]         //Tell Unity to add theses components to the gameobject this code is attached to.
[RequireComponent(typeof(BoxCollider2D))]       //We will still need to tweak some of the settings.
public class RigidbodyMovement : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;

    bool isMoving = false;

    public float moveSpeed = 5f;
    

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float moveInputX = Input.GetAxisRaw("Horizontal"); // For horizontal movement (left/right)
        float moveInputY = Input.GetAxisRaw("Vertical");   // For vertical movement (up/down)

        // Normalise the vector so that we don't move faster when moving diagonally.
        Vector2 moveDirection = new Vector2(moveInputX, moveInputY);
        moveDirection.Normalize();

        // Assign velocity directly to the Rigidbody
        rb2d.velocity = moveDirection * moveSpeed;
        Debug.Log("speed=" + rb2d.velocity);

        if (rb2d.velocity.magnitude > 0.1f)
        
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        animator.SetBool("IsMoving", isMoving);

        if (rb2d.velocity.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (rb2d.velocity.x < 0)
        {
            spriteRenderer.flipX = true;
        }
    }
}