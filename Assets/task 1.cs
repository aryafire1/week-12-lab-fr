using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task1 : MonoBehaviour
{
    public List<string> nameLibrary = new List<string>()
       {
        "Mario",
        "Luigi",
        "Peach",
        "Bowser",
        "Iggy",
        "Morton",
        "Lemmy",
        "Ludwig",
        "Roy",
        "Wendy",
        "Larry",
        "Rosalina",
        "Daisy",
        "Yoshi",
        "Geno",
        "Mallow",
        "Mack",
        "Johnny",
        "Booster",
        "Smithy",
    };

    public List<string> lastnamelibrary = new List<string>()
    {
        "A.",
        "B.",
        "C.",
        "D.",
        "E.",
        "F.",
        "G.",
        "H.",
        "I.",
        "J.",
        "K.",
        "L.",
        "M.",
        "N.",
        "O.",
        "P.",
        "Q.",
        "R.",
        "S.",
        "T.",
    };

    private Queue<string> loginQueue = new Queue<string>();
    private bool isSimulating = false;

    IEnumerator Start()
    {
        isSimulating = true;
        while (isSimulating)
        {
            yield return new WaitForSeconds(Random.Range(1f, 3f));
            AddRandomPlayer();
        }
    }

    void AddRandomPlayer()
    {
        string randomName = nameLibrary[Random.Range(0, nameLibrary.Count)];
        string randomLastName = lastnamelibrary[Random.Range(0, nameLibrary.Count)];

        loginQueue.Enqueue(randomName);
        Debug.Log(randomName + randomLastName + " has been added to the Queue.");
        StartCoroutine(LoginPlayer(randomName));
    }
    IEnumerator LoginPlayer(string playerName)
    {
        Debug.Log("Logging in" + playerName +  "...");
        yield return new WaitForSeconds(Random.Range(2f, 5f));
        Debug.Log(playerName + " has logged in.");
        loginQueue.Dequeue();
    }
}
