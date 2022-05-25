using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuEvents : MonoBehaviour
{
    public GameObject gameContainer;
    public Button startGameButton;

    // Start is called before the first frame update
    void Start()
    {
        startGameButton.onClick.AddListener(StartGame_OnClick);
    }

    void StartGame_OnClick()
    {
        gameContainer.GetComponent<GameContainer>().GenerateGame();
    }
}
