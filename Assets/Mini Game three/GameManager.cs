using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//using Unity.VisualScripting;
//using UnityEditor.Experimental.GraphView;

public class GameManager : MonoBehaviour
{
    public Card[] cards;
    public Image cardDisplay1;
    public Image cardDisplay2;
    public InputField answerInput;
    public Text resultText;
    private Card[] selectedCards;
    // Start is called before the first frame update
    private void Start()
    {
        LoadCards();
        StartCoroutine(ShowCards());
    }

    private void LoadCards()
    {
        cards = new Card[52];
        for (int i = 0; i < 52; i++)
        {
            cards[i] = new Card
            {
                name = GetCardName(i),image = Resources.Load<Sprite>($"Cards/{GetCardName(i)}")
            };
        }
    }

    private string GetCardName(int index)
    {
        string[] suits = { "spade", "heart", "diamond", "clover" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        return suits[index / 13] + ranks[index % 13];
    }

    private IEnumerator ShowCards()
    {
        selectedCards = new Card[2];
        selectedCards[0] = cards[Random.Range(0, cards.Length)];
        selectedCards[1] = cards[Random.Range(0, cards.Length)];
        cardDisplay1.sprite = selectedCards[0].image;
        cardDisplay2.sprite = selectedCards[1].image;

        yield return new WaitForSeconds(3);

        cardDisplay1.sprite = null;
        cardDisplay2.sprite = null;

        answerInput.gameObject.SetActive(true);
    }

    public void CheckAnswer()
    {
        string answer = answerInput.text;
        string correctAnswer1 = selectedCards[0].name;
        string correctAnswer2 = selectedCards[1].name;

        if ((answer == correctAnswer1 + "," + correctAnswer2) || (answer == correctAnswer2 + "," + correctAnswer1))
           {
            resultText.text = "맞았어요!";
            }

        else
           {
            resultText.text = $"틀렸어요! 정댭은 : {correctAnswer1},{correctAnswer2} 이에요.";
            }
    }

    // Update is called once per frame
   
}
