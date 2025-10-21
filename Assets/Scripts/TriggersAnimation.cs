using Unity.VisualScripting;
using UnityEngine;

public class TriggersAnimation : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered By: " + other.gameObject.name);
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stayed By: " + other.gameObject.name);
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exited By: " + other.gameObject.name);
    }
}
