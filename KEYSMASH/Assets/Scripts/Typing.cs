using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typing : MonoBehaviour
{
    // need word bank
    public Text wordOutput = null;
    private string remainingWord = string.Empty;
    private string currentWord = "trojan"; // placeholder
    
    private void Start()
    {
        SetCurrentWord();
    }

    private void SetCurrentWord()
    {
        // get word from word bank
        SetRemainingWord(currentWord);
    }

    private void SetRemainingWord(string NewString)
    {
        remainingWord = NewString;
        wordOutput.text = remainingWord;
    }

    private void Update()
    {
        
    }

    private void CheckInput()
    {

    }

    private void EnterLetter(string typedLetter)
    {

    }

    private bool IsCorrectLetter(string letter)
    {
        return false;
    }

    private void RemoveLetter()
    {

    }

    private bool IsWordComplete()
    {

    }
}
