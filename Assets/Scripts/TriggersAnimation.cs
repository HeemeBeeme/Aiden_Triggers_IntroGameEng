using Unity.VisualScripting;
using UnityEngine;

public class TriggersAnimation : MonoBehaviour
{
    public Animator OrbAnimator;
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stayed By: " + other.gameObject.name);
        OrbAnimator.Play("OrbAnim");
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exited By: " + other.gameObject.name);
        OrbAnimator.Play("OrbFallAnim");
    }
}
