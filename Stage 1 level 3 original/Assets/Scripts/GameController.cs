using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private Sprite bgImage;

    public Sprite[] puzzles;
    public List<Sprite> gamepuzzles = new List<Sprite>();

    public List<Button> btns = new List<Button>();

    private bool firstGuess, secondGuess;

    private int countGuesses;
    private int countCorrectGuesses;
    private int gameGuesses;

    private int firstGuessIndex, secondGuessIndex;

    private string firstGuessPuzzle, secondGuessPuzzle;

    void Start()
    {
        GetButtons();
        AddListeners();
        AddGamePuzzles();
        Shuffle(gamepuzzles);
        gameGuesses = gamepuzzles.Count / 2;

    }
    void GetButtons()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");

        for (int i = 0; i < objects.Length; i++)
        {
            btns.Add(objects[i].GetComponent<Button>());
            btns[i].image.sprite = bgImage;

        }
    }
    void AddGamePuzzles()
    {
        int looper = btns.Count;
        int index = 0;

        for (int i = 0; i < looper; i++)
        {
            if (index == looper / 2)
            {
                index = 0;
            }
            gamepuzzles.Add(puzzles[index]);

            index++;
        }
    }
    void AddListeners()
    {
        foreach (Button btn in btns)
        {
            btn.onClick.AddListener(() => PickAPuzzle());
        }
    }
    public void PickAPuzzle()
    {
        string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        if (!firstGuess)
        {
            firstGuess = true;

            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            firstGuessPuzzle = gamepuzzles[firstGuessIndex].name;
            btns[firstGuessIndex].image.sprite = gamepuzzles[firstGuessIndex];

        }
        else if (!secondGuess)
        {
            secondGuess = true;

            secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            secondGuessPuzzle = gamepuzzles[secondGuessIndex].name;
            btns[secondGuessIndex].image.sprite = gamepuzzles[secondGuessIndex];
            countGuesses++;
            StartCoroutine(CheckIfThePuzzleMatches());


        }
    }
    IEnumerator CheckIfThePuzzleMatches()
    {
        {
            yield return new WaitForSeconds(1f);

            if (firstGuessPuzzle == secondGuessPuzzle)
            {
                yield return new WaitForSeconds(.5f);
                btns[secondGuessIndex].interactable = false;
                btns[firstGuessIndex].interactable = false;

                btns[firstGuessIndex].image.color = new Color(0, 0, 0, 0);
                btns[secondGuessIndex].image.color = new Color(0, 0, 0, 0);

                CheckIfTheGameIsFinished();
            }
            else
            {
                yield return new WaitForSeconds(.5f);

                btns[firstGuessIndex].image.sprite = bgImage;
                btns[secondGuessIndex].image.sprite = bgImage;
            }
            yield return new WaitForSeconds(.5f);

            firstGuess = secondGuess = false;




        }
        void CheckIfTheGameIsFinished()
        {
            countCorrectGuesses++;

            if (countCorrectGuesses == gameGuesses)
            {
                Debug.Log("Game Is Finished");
                Debug.Log("It Took You" + countGuesses + "many guesses to finish the game");
            }
        }

    }
    void Shuffle(List<Sprite> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Sprite temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
}
