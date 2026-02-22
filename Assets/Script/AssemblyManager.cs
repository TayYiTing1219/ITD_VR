using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class AssemblyManager : MonoBehaviour
{
    public XRSocketInteractor[] pieceSlots; // 3 sockets
    public GameObject assembledObject;      // the final combined object
    public GameObject[] individualPieces;   // hide these when assembled

    private int piecesInserted = 0;

    void Start()
    {
        foreach (var slot in pieceSlots)
            slot.selectEntered.AddListener(OnPieceInserted);

        assembledObject.SetActive(false);
    }

    void OnPieceInserted(SelectEnterEventArgs args)
    {
        piecesInserted++;
        if (piecesInserted >= pieceSlots.Length)
        {
            // All pieces inserted — spawn assembled object
            foreach (var slot in pieceSlots)
                slot.gameObject.SetActive(false);
            foreach (var p in individualPieces)
                p.SetActive(false);

            assembledObject.SetActive(true);
        }
    }
}