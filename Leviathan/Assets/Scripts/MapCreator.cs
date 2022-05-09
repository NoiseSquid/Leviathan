using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{
    public GameObject HexPrefab;
    public float HexSize;

    private float w;
    private float h;
    private float hSpace;
    private float vSpace;

    void Start()
    {
        w = Mathf.Sqrt(3) * HexSize;
        h = 2 * HexSize;
        hSpace = w;
        vSpace = h * 0.75f;

        CreateBlankMap(5, 5);
    }

    public void CreateBlankMap(int width, int height)
    {
        for (int col = 0; col < width; col++)
        {
            for (int row = 0; row < height; row++)
            {
                var hexGO = Instantiate(HexPrefab, GetHexPosition(col, row), Quaternion.identity, transform);
                hexGO.name = string.Format("Hex_{0}_{1}", col, row);
            }
        }
    }

    private Vector3 GetHexPosition(int col, int row)
    {
        return new Vector3((col * hSpace) + (row * hSpace / 2), 0, vSpace * row);
    }
}
