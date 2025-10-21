using Unity.VisualScripting;
using UnityEngine;

public class TriggersActivity : MonoBehaviour
{
    public GameObject Orb;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered By: " + other.gameObject.name);
        Orb.SetActive(false);
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exited By: " + other.gameObject.name);
        Orb.SetActive(true);
    }
}
