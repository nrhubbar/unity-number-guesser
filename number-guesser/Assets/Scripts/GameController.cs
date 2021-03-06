using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int currentGuess;
    public int turnCounter;
    public Text mainText;

    public Button[] gameButtons;
    public Button resetButton;

    private int floor = 0;
    private int ceiling = 101;

    // Start is called before the first frame update
    void Start()
    {
        GameSetup();
    }

    void GameSetup()
    {
        currentGuess = 50;
        turnCounter = 1;
        mainText.text = $"Is your number {currentGuess}?";
        resetButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GuessHigher()
    {
        turnCounter++;
        floor = currentGuess;
        int nextGuess = getHigherGuess();
        currentGuess = nextGuess;
        mainText.text = $"Is your number {nextGuess}?";
    }

    public void GuessLower()
    {
        turnCounter++;
        ceiling = currentGuess;
        int nextGuess = getLowerGuess();
        currentGuess = nextGuess;
        mainText.text = $"Is your number {nextGuess}?";
    }

    public void EndGame()
    {
        mainText.text = $"I knew your number was {currentGuess}, it only took {turnCounter} tries!";
        foreach (Button button in gameButtons)
        {
            button.gameObject.SetActive(false);
        }
        resetButton.gameObject.SetActive(true);
    }

    public void Reset()
    {
        currentGuess = 50;
        turnCounter = 1;
        floor = 0;
        ceiling = 101;
        mainText.text = $"Is your number {currentGuess}?";
        resetButton.gameObject.SetActive(false);
        foreach (Button button in gameButtons)
        {
            button.gameObject.SetActive(true);
        }
    }

    int getHigherGuess()
    {
        return (currentGuess + ceiling) / 2;
    }

    int getLowerGuess()
    {
        return (currentGuess + floor) / 2;
    }
}
