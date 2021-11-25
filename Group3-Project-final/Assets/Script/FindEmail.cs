using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindEmail : MonoBehaviour
{
    public GameObject textBoxOnCanvas;

    private void Awake()
    {
        textBoxOnCanvas = GameObject.Find("TextBoxEmail");
        EmailShuffle util = new EmailShuffle();

        textBoxOnCanvas.GetComponent<Text>().text = util.Shuffle();
    }
}
