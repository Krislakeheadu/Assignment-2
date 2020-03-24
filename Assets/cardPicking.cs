using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardPicking : MonoBehaviour
{
    //Declare variables
    public string[,] cardFaces = new string[2, 4];
    public Sprite down;
    public Sprite cat;
    public Sprite cow;
    public Sprite mouse;
    public Sprite sheep;
    public string card1;
    public string card2;
    int matches = 0;
    int count = 2;
    public int cardsUp = 0;
    public float timeLeft = 0f;
    System.Random rnd = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("gameover").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("replay").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("replay").GetComponent<BoxCollider2D>().enabled = false;
        card1 = "";
        card2 = "";
        //Initializes the cards
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                cardFaces[i, j] = "down";
            }
        }

        //Randomly selects cards to be cat, cow, sheep, and mouse
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                cats();
            }
        }

        count = 2;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                cows();
            }
        }

        count = 2;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                mice();
            }
        }

        count = 2;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                sheeps();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Counts down timer
        timeLeft -= Time.deltaTime;
        //If there are 2 cards that just got flipped, check if they are matching
        //If yes, increase match count and reset card count
        //If no, flip the cards back down
        if (cardsUp == 2)
        {
            if(GameObject.FindGameObjectWithTag(card1).GetComponent<SpriteRenderer>().sprite == GameObject.FindGameObjectWithTag(card2).GetComponent<SpriteRenderer>().sprite && card1 != "" && card2 != "")
            {
                GameObject.FindGameObjectWithTag(card1).GetComponent<BoxCollider2D>().enabled = false;
                GameObject.FindGameObjectWithTag(card2).GetComponent<BoxCollider2D>().enabled = false;
                matches++;
                cardsUp = 0;
                card1 = "";
                card2 = "";
            } else if(timeLeft <= 0)
            {
                GameObject.FindGameObjectWithTag(card1).GetComponent<SpriteRenderer>().sprite = down;
                GameObject.FindGameObjectWithTag(card2).GetComponent<SpriteRenderer>().sprite = down;
                cardsUp = 0;
            }
        }

        if(matches == 4)
        {
            GameObject.FindGameObjectWithTag("gameover").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.FindGameObjectWithTag("replay").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.FindGameObjectWithTag("replay").GetComponent<BoxCollider2D>().enabled = true;
        }
    }
    public void cats()
    {
        int x = rnd.Next(0, 2);
        int y = rnd.Next(0, 4);
        if (count > 0)
        {
            if (cardFaces[x, y] == "down")
            {
                cardFaces[x, y] = "cat";
                count--;
            }
            else
            {
                cats();
            }
        }
    }

    public void cows()
    {
        int x = rnd.Next(0, 2);
        int y = rnd.Next(0, 4);
        if (count > 0)
        {
            if (cardFaces[x, y] == "down")
            {
                cardFaces[x, y] = "cow";
                count--;
            }
            else
            {
                cows();
            }
        }
    }

    public void mice()
    {
        int x = rnd.Next(0, 2);
        int y = rnd.Next(0, 4);
        if (count > 0)
        {
            if (cardFaces[x, y] == "down")
            {
                cardFaces[x, y] = "mouse";
                count--;
            }
            else
            {
                mice();
            }
        }
    }

    public void sheeps()
    {
        int x = rnd.Next(0, 2);
        int y = rnd.Next(0, 4);
        if (count > 0)
        {
            if (cardFaces[x, y] == "down")
            {
                cardFaces[x, y] = "sheep";
                count--;
            }
            else
            {
                sheeps();
            }
        }
    }
}
