using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField]
    int _max;

    [SerializeField]
    int _min;

    private int _guess;

    [SerializeField]
    private TextMeshProUGUI _guessText;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    public void OnPressHigher()
    {
        if (_min < _max && _guess != _max)
        {
            _min = _guess + 1;
            NextGuess();
        }
    }

    public void OnPressLower()
    {
        if (_min < _max)
        {
            _max = _guess - 1;
            NextGuess();
        }
    }

    public void OnPressSuccess()
    {

    }

    private void StartGame()
    {
        NextGuess();
    }

    private void NextGuess()
    {
        _guess = Random.Range(_min, _max + 1);
        _guessText.text = _guess.ToString();
    }
}
