using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestCardSelect : MonoBehaviour
{

    public Text card_one;
    public Text card_two;
    public Text card_three;
    public Text card_four;
    public Text card_five;
    public Text result_text;

    string result_string;
    string card_one_write;
    string card_two_write;
    string card_three_write;
    string card_four_write;
    string card_five_write;
    // Start is called before the first frame update
    void Start()
    {
        for (int o = 1; o < 6; o++)
        {
            if (o == 1)
            {
                result_string = "Jack of Hearts";
                card_one.text = result_string.ToString();
                card_one_write = result_string;
            }
            if (o == 2)
            {
                result_string = "Queen of Clubs";
                card_two.text = result_string.ToString();
                card_two_write = result_string;
            }
            if (o == 3)
            {
                result_string = "King of Spades";
                card_three.text = result_string.ToString();
                card_three_write = result_string;
            }
            if (o == 4)
            {
                result_string = "Ace of Diamonds";
                card_four.text = result_string.ToString();
                card_four_write = result_string;
            }
            if (o == 5)
            {
                result_string = "Seth my daddy";
                card_five.text = result_string.ToString();
                card_five_write = result_string;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            result_text.text = card_one_write.ToString();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            result_text.text = card_two_write.ToString();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            result_text.text = card_three_write.ToString();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            result_text.text = card_four_write.ToString();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            result_text.text = card_five_write.ToString();
        }
    }
}
