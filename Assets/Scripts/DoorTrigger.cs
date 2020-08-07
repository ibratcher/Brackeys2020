using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    
    public GameObject door;

    [SerializeField]
    Transform target = null;

    [SerializeField]
    Transform plateTarget = null;
    
    [SerializeField]
    Transform unpressedButton = null;

    public float speed = 0.025f;

    public bool isTriggered = false;
    public bool movingDoor = false;
    private Vector3 velocity = Vector3.zero;

    void Awake()
    {
        door = GameObject.Find("Door");
        target = GameObject.Find("Target").GetComponent<Transform>();
    }

    void OnTriggerEnter(Collider col)
    {
        isTriggered = true;
    }

    void OnTriggerExit(Collider col)
    {
        isTriggered = false;
    }
    
    void Update()
    {
        if(isTriggered)
        {
            movingDoor = true;
            //door.transform.position = Vector3.MoveTowards(door.transform.position, target.position, speed);
            transform.position = Vector3.MoveTowards(transform.position, plateTarget.position, speed);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, unpressedButton.position, speed);
        }
        if(movingDoor)
        {
            door.transform.position = Vector3.MoveTowards(door.transform.position, target.position, speed);
        }
    }
    public void moveDoor()
    {
        door.transform.position = Vector3.MoveTowards(door.transform.position, target.position, speed);
    }
}
