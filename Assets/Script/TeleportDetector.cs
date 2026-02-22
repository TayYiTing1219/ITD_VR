using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;

public class TeleportDetector : MonoBehaviour
{
    public TutorialManager tutorialManager;
    private TeleportationArea teleportArea;

    void Start()
    {
        teleportArea = GetComponent<TeleportationArea>();
        teleportArea.teleporting.AddListener(OnTeleport);
    }

    void OnTeleport(TeleportingEventArgs args)
    {
        // Small delay so teleport finishes before we switch areas
        Invoke(nameof(NotifyManager), 0.5f);
    }

    void NotifyManager()
    {
        tutorialManager.OnTeleportCompleted();
    }
}