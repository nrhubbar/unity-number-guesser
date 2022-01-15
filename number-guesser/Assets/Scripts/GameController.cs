using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using State;
namespace NumberGuesser
{
    public class GameController : MonoBehaviour
    {

        private NumberGuesserState state;
        public Text mainText;

        public Button[] gameButtons;
        public Button resetButton;

        // Start is called before the first frame update
        void Start()
        {
            GameSetup();
        }

        void GameSetup()
        {
            state = new NumberGuesserState();
            mainText.text = $"Is your number {state.GetCurrentGuess()}?";
            resetButton.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey("escape"))
            {
                Application.Quit();
            }
        }

        public void GuessHigher()
        {
            state = new NumberGuesserState(getNextGuess(state.GetCurrentGuess(), state.GetCeiling()), state.GetTurnCounter() + 1, state.GetCurrentGuess(), state.GetCeiling());

            mainText.text = $"Is your number {state.GetCurrentGuess()}?";
        }

        public void GuessLower()
        {
            state = new NumberGuesserState(getNextGuess(state.GetCurrentGuess(), state.GetFloor()), state.GetTurnCounter() + 1, state.GetFloor(), state.GetFloor());
            mainText.text = $"Is your number {state.GetCurrentGuess()}?";
        }

        public void EndGame()
        {
            mainText.text = $"I knew your number was {state.GetCurrentGuess()}, it only took {state.GetTurnCounter()} tries!";
            foreach (Button button in gameButtons)
            {
                button.gameObject.SetActive(false);
            }
            resetButton.gameObject.SetActive(true);
        }

        public void Reset()
        {
            state = new NumberGuesserState();
            mainText.text = $"Is your number {state.GetCurrentGuess()}?";
            resetButton.gameObject.SetActive(false);
            foreach (Button button in gameButtons)
            {
                button.gameObject.SetActive(true);
            }
        }

        public void Exit()
        {
            Application.Quit();
        }

        int getNextGuess(int currentGuess, int guessModifier)
        {
            return (currentGuess + guessModifier) / 2;
        }
    }
}
