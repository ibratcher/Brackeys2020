using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10;
    public float jumpForce = 10;

    public CharacterController controller;
    public TimeBody timeBody;

    private Vector3 moveDirection;
    public float gravityScale = 1.5f;

    //public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();   
        timeBody = GetComponent<TimeBody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*rb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y, rb.velocity.z);

        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }*/

        moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, moveDirection.z);

        if(controller.isGrounded)
        {
            if(Input.GetKeyDown(KeyCode.W))
            {
                moveDirection.y = jumpForce;
            }
        }
        if(Input.GetKeyDown(KeyCode.S) && !controller.isGrounded)
        {
            moveDirection.y = -jumpForce / 2;
        }

        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        if(!timeBody.IsRewinding())
        {
            controller.Move(moveDirection * Time.deltaTime);
        }
    }
    
}
