using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailShuffle 
{
    ArrayList emailTitle = new ArrayList()
    {
        "this"
    };
    ArrayList emailDescription = new ArrayList()
    {
        "that"
    };
    ArrayList emailLink = new ArrayList()
    {
        "yes"
    };

    public string Shuffle()
    {
        string combinedString = (string)emailTitle[Random.Range(0, emailTitle.Count)];
        combinedString += "\n";  
        combinedString += (string)emailDescription[Random.Range(0, emailDescription.Count)];
        combinedString += "\n";
        combinedString += (string)emailLink[Random.Range(0, emailLink.Count)];
        return combinedString;
    }
}
