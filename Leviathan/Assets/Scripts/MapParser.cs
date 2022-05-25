using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using LeviathanEngine;

public class MapParser : MonoBehaviour
{
    public Material ocean;
    public Material grass;

    public void Parse(HexMap mapState)
    {
        for (int col = 0; col < mapState.width; col++)
        {
            for (int row = 0; row < mapState.height; row++)
            {
                UpdateTile(col, row, mapState.hexes[col, row]);
            }
        }
    }

    private void UpdateTile(int col, int row, HexProperties hexProperties)
    {
        var hexGO = GameObject.Find(string.Format("Hex_{0}_{1}", col, row));

        if (hexProperties.terrain == "sea" || hexProperties.terrain == "ocean")
        {
            hexGO.GetComponentInChildren<MeshRenderer>().material = ocean;
        }
        else
        {
            hexGO.GetComponentInChildren<MeshRenderer>().material = grass;
        }
    }
}
