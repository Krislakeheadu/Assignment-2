using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onFlip : MonoBehaviour
{
    //Declare variables
    public string[,] animal = new string[2, 4];

    // Start is called before the first frame update
    void Start()
    {
        animal = GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().cardFaces;
    }

    //On mouse click determine if there are already 2 cards up before timer is up
    void OnMouseDown()
    {
        //If less than 2 cards, flip the clicked on card and send its tag to Script GameObject
        if (GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().cardsUp < 1)
        {
            GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().timeLeft = 1f;
            name = this.tag;
            if (animal[name[4] - '0', name[6] - '0'] == "cat")
            {
                this.GetComponent<SpriteRenderer>().sprite = GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().cat;
            }
            else if (animal[name[4] - '0', name[6] - '0'] == "cow")
            {
                this.GetComponent<SpriteRenderer>().sprite = GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().cow;
            }
            else if (animal[name[4] - '0', name[6] - '0'] == "mouse")
            {
                this.GetComponent<SpriteRenderer>().sprite = GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().mouse;
            }
            else if (animal[name[4] - '0', name[6] - '0'] == "sheep")
            {
                this.GetComponent<SpriteRenderer>().sprite = GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().sheep;
            }
            GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().card1 = name;
            GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().cardsUp++;
        } else if (GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().cardsUp < 2)
        {
            GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().timeLeft = 1f;
            name = this.tag;
            if (animal[name[4] - '0', name[6] - '0'] == "cat")
            {
                this.GetComponent<SpriteRenderer>().sprite = GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().cat;
            }
            else if (animal[name[4] - '0', name[6] - '0'] == "cow")
            {
                this.GetComponent<SpriteRenderer>().sprite = GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().cow;
            }
            else if (animal[name[4] - '0', name[6] - '0'] == "mouse")
            {
                this.GetComponent<SpriteRenderer>().sprite = GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().mouse;
            }
            else if (animal[name[4] - '0', name[6] - '0'] == "sheep")
            {
                this.GetComponent<SpriteRenderer>().sprite = GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().sheep;
            }
            GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().card2 = name;
            GameObject.FindGameObjectWithTag("Script").GetComponent<cardPicking>().cardsUp++;
        }
    }
}
