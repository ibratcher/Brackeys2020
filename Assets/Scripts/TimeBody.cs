using System.Collections.Generic;
using UnityEngine;

public class TimeBody : MonoBehaviour
{
    public bool isRewinding = false;
    public float rewindTime = 10f;

    [SerializeField]
    private GameObject rewindImage = null;

    List<PointInTime> pointsInTime;
    // Start is called before the first frame update
    void Start()
    {
        pointsInTime = new List<PointInTime>();
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
            rewindImage.SetActive(true);
        }
        else
        {
            Record();
            rewindImage.SetActive(false);
        }
    }

    void Rewind()
    {
        if(pointsInTime.Count > 0)
        {
            PointInTime pointInTime = pointsInTime[0];
            transform.position = pointInTime.position;
            transform.rotation = pointInTime.rotation;
            pointsInTime.RemoveAt(0);
        }
        else
        {
            StopRewind();
        }
    }

    void Record()
    {
        if(pointsInTime.Count > Mathf.Round(rewindTime / Time.fixedDeltaTime))
        {
            pointsInTime.RemoveAt(pointsInTime.Count - 1);
        }
        pointsInTime.Insert(0, new PointInTime(transform.position, transform.rotation));
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
