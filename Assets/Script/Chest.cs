using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class Chest : MonoBehaviour
{
    public XRSocketInteractor keySlot;
    public GameObject lid;           // the lid/door to open
    public GameObject storedObject;  // the object inside

    void Start()
    {
        keySlot.selectEntered.AddListener(OnKeyInserted);
        storedObject.SetActive(false);
    }

    void OnKeyInserted(SelectEnterEventArgs args)
    {
        // Open the chest
        lid.transform.localRotation = Quaternion.Euler(-90, 0, 0); // simple open animation
        storedObject.SetActive(true);
        keySlot.gameObject.SetActive(false); // remove the socket once used
    }
}