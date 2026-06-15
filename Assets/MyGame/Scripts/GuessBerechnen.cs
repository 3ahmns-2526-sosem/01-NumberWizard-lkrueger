using TMPro;
using UnityEngine;

public class GuessBerechnen : MonoBehaviour
{
    public int min = 1;
    public int max = 100;
    public int guess;

    [SerializeField] private TextMeshProUGUI guessText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CalculateNextGuess();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CalculateNextGuess()
    {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();
    }
}
