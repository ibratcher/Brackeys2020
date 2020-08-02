using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBody : MonoBehaviour
{
    private bool isRewinding = false;

    List<Vector3> positions;
    // Start is called before the first frame update
    void Start()
    {
        positions = new List<Vector3>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartRewind();
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            StopRewind();
        }
    }
    
    void FixedUpdate()
    {
        if (isRewinding)
        {
            Rewind();
        }
        else
        {
            Record();
        }
    }

    void Rewind()
    {
        if(positions.Count > 0)
        {
            transform.position = positions[0];
            positions.RemoveAt(0);
        }
        else
        {
            StopRewind();
        }
    }

    void Record()
    {
        positions.Insert(0, transform.position);
    }

    public void StartRewind()
    {
        isRewinding = true;
    }

    public void StopRewind()
    {
        isRewinding = false;
    }
    
    public bool IsRewinding(){
        return isRewinding;
    }
}
