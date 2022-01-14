using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int currentGuess;
    public int turnCounter;
    public TextObject mainText;

    private const int FLOOR_VALUE = 0;
    private const int MAX_VALUE = 100;

    // Start is called before the first frame update
    void Start()
    {
        GameSetup();
    }

    void GameSetup()
    {
        currentGuess = 50;
        turnCounter = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int getHigherGuess()
    {
        return (currentGuess + MAX_VALUE) / 2;
    }

    int getLowerGuess()
    {
        return (currentGuess + FLOOR_VALUE) / 2;
    }
}
