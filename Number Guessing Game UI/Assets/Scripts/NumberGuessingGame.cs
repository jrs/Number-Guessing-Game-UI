using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberGuessingGame : MonoBehaviour
{
    private int guess;
    [SerializeField] private int minValue;
    [SerializeField] private int maxValue;
    [SerializeField] private TextMeshProUGUI guessText;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    public void OnPressHigher()
    {
        minValue = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        maxValue = guess - 1;
        NextGuess();
    }

    public void NextGuess()
    {
        guess = Random.Range(minValue, maxValue + 1);
        guessText.text = guess.ToString();
    }
    void StartGame()
    {
        NextGuess();
    }
}
