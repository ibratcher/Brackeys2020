using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter()
    {
        GameManager.instance.Win();
    }
}
