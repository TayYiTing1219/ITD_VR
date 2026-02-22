using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject teleportArea1;
    public GameObject teleportArea2;
    public GameObject congratsUI;

    private int teleportCount = 0;

    // Called by TriggerZone3
    public void EnableTeleportPhase()
    {
        teleportArea1.SetActive(true);
    }

    public void OnTeleportCompleted()
    {
        teleportCount++;
        if (teleportCount == 1)
        {
            teleportArea1.SetActive(false);
            teleportArea2.SetActive(true);
        }
        else if (teleportCount >= 2)
        {
            teleportArea2.SetActive(false);
            congratsUI.SetActive(true);
        }
    }
}