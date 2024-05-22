using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placementSys : MonoBehaviour
{
    [SerializeField]
    private GameObject mouseInd, cellIndicator;

    [SerializeField]
    private inputMan inputMan;

    [SerializeField]
    private GridLayout grid;
 
    private void Update()
    {
        Vector3 mousePos = inputMan.GetSelectedMapPosition();
        Vector3Int gridPosition = grid.WorldToCell(mousePos);
        mouseInd.transform.position = mousePos;
        cellIndicator.transform.position = grid.CellToWorld(gridPosition);
    }
}
