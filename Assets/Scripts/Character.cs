using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float vel;
    public Vector2 direction;
    public float impulse;
    public Rigidbody2D rb;
    public Animator animator;
    public float circleRadius = 0.01f;
    public Vector2 low;
    public bool isOnFloor;
    public LayerMask floorLayer;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        
    }

    void FixedUpdate(){
        rb.linearVelocity = new Vector2(vel * direction.x, rb.linearVelocityY);
        isOnFloor = Physics2D.OverlapCircle(transform.position+(Vector3)low, circleRadius, floorLayer);
        animator.SetBool("isOnFloor", isOnFloor);
    }
    public void Movement(InputAction.CallbackContext val){
        direction = val.ReadValue<Vector2>();
        if(direction.x > 0){
            transform.localEulerAngles = new Vector2(0, 0);
            animator.SetBool("isWalking", true);
        } else if(direction.x < 0){ 
            transform.localEulerAngles = new Vector2(0, 180);
            animator.SetBool("isWalking", true);

        } else animator.SetBool("isWalking", false);

    }

    void OnDrawGizmosSelected(){
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position + (Vector3)low, circleRadius);
    }

    public void Jump(InputAction.CallbackContext val){
        if (val.started && isOnFloor){
            rb.linearVelocity = Vector2.zero;
            rb.AddForce(Vector2.up * impulse);
        }
    }
}
