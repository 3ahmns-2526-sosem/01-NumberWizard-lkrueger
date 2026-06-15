using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GuessBerechnen : MonoBehaviour
{
    [SerializeField] private int startMin = 1;
    [SerializeField] private int startMax = 100;

    public int min = 1;
    public int max = 100;
    public int guess;

    [SerializeField] private TextMeshProUGUI guessText;

    [SerializeField] private Button higherButton;
    [SerializeField] private Button lowerButton;
    [SerializeField] private Button correctButton;

    void Start()
    {
        CalculateNextGuess();
    }

    void CalculateNextGuess()
    {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();
    }

    public void HigherButtonPressed()
    {
        min = guess + 1;
        CalculateNextGuess();
    }
    public void OnLowerPressed()
    {
        max = guess - 1;
        CalculateNextGuess();
    }
    public void OnCorrectPressed()
    {
        if (guessText != null)
        {
            guessText.text = guess + "! I Guessed Correct!!!";
        }
        SetButtonsInteractable(false);
    }
    void SetButtonsInteractable(bool state)
    {
        if (higherButton != null) higherButton.interactable = state;
        if (lowerButton != null) lowerButton.interactable = state;
        if (correctButton != null) correctButton.interactable = state;
    }
    private void ResetGame()
    {
        min = startMin;
        max = startMax;
        SetButtonsInteractable(true);
        CalculateNextGuess();
    }
    public void OnRestartPressed()
    {
        ResetGame();
    }
}
