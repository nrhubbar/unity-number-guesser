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
            mainText.text = $"Is your number {state.CurrentGuess}?";
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
            state = new NumberGuesserState(getNextGuess(state.CurrentGuess, state.Ceiling), state.TurnCounter + 1, state.CurrentGuess, state.Ceiling);

            mainText.text = $"Is your number {state.CurrentGuess}?";
        }

        public void GuessLower()
        {
            state = new NumberGuesserState(getNextGuess(state.CurrentGuess, state.Floor), state.TurnCounter + 1, state.Floor, state.CurrentGuess);
            mainText.text = $"Is your number {state.CurrentGuess}?";
        }

        public void EndGame()
        {
            mainText.text = $"I knew your number was {state.CurrentGuess}, it only took {state.TurnCounter} tries!";
            foreach (Button button in gameButtons)
            {
                button.gameObject.SetActive(false);
            }
            resetButton.gameObject.SetActive(true);
        }

        public void Reset()
        {
            state = new NumberGuesserState();
            mainText.text = $"Is your number {state.CurrentGuess}?";
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
