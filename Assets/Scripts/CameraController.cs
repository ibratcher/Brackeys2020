using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;

    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = target.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position - offset;

        transform.LookAt(target);
    }
    
}
