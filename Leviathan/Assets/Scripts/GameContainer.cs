using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using LeviathanEngine;

public class GameContainer : MonoBehaviour
{
    public GameObject mapContainer;

    private Game_POC game;

    public void GenerateGame()
    {
        Debug.Log("Starting game...");

        var gParams = new GameParameters();
        gParams.width = 5;
        gParams.height = 5;
        game = new Game_POC(gParams);

        mapContainer.GetComponent<MapCreator>().CreateBlankMap(gParams.width, gParams.height);

        HexMap hexMap = game.GetMap(-1);
        mapContainer.GetComponent<MapParser>().Parse(hexMap);
    }
}
