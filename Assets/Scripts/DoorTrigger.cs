using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door = null;

    [SerializeField]
    Transform target = null;

    [SerializeField]
    Transform plateTarget = null;
    
    [SerializeField]
    Transform unpressedButton = null;

    public float speed = 0.025f;

    public bool isTriggered = false;
    private Vector3 velocity = Vector3.zero;

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
            door.transform.position = Vector3.MoveTowards(door.transform.position, target.position, speed);
            transform.position = Vector3.MoveTowards(transform.position, plateTarget.position, speed);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, unpressedButton.position, speed);
        }
    }
}
