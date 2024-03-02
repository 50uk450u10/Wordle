using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordleModel : MonoBehaviour
{
    int currentAttempt;
    Cell[,] cells = new Cell[6, 5];
    [SerializeField] TextAsset possibleAnswersAsset;
    [SerializeField] TextAsset allowedWordsAsset;
    string correctAnswer;
    string[] possibleAnswers;
    string[] allowedWords;

    void Start()
    {
        possibleAnswers = possibleAnswersAsset.ToString().Split('\n');
        allowedWords = allowedWordsAsset.ToString().Split('\n');
    }

    void Setup()
    {

    }

    /*bool IsValidGuess(string s)
    {

    }*/

    void UpdateCells()
    {

    }
}
