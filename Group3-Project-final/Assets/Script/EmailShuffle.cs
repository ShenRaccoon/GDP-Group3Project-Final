using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailShuffle 
{
    ArrayList emailTitle = new ArrayList()
    {

    };
    ArrayList emailDescription = new ArrayList()
    {

    };
    ArrayList emailLink = new ArrayList()
    {

    };

    public string Shuffle()
    {
        string combinedString = (string)emailTitle[Random.Range(0, emailTitle.Count)];
        combinedString += (string)emailDescription[Random.Range(0, emailDescription.Count)];
        combinedString += (string)emailLink[Random.Range(0, emailLink.Count)];
        return combinedString;
    }
}
