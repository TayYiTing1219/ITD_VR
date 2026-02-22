using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class Pedestal : MonoBehaviour
{
    public XRSocketInteractor socket;
    public GameObject completionUI;

    void Start()
    {
        socket.selectEntered.AddListener(OnObjectPlaced);
        completionUI.SetActive(false);
    }

    void OnObjectPlaced(SelectEnterEventArgs args)
    {
        completionUI.SetActive(true);
    }
}