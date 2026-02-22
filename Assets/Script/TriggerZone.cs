using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public GameObject nextToEnable;
    public TutorialManager tutorialManager; // Only Zone 3 needs this filled
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (triggered) return;
        if (other.CompareTag("Player"))
        {
            triggered = true;

            if (nextToEnable != null)
                nextToEnable.SetActive(true);

            if (tutorialManager != null)
                tutorialManager.EnableTeleportPhase();

            gameObject.SetActive(false);
        }
    }
}