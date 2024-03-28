using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task2 : MonoBehaviour
{

    string[] names ={
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

    string[] newNames ={
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
    };

    HashSet<string> nameHash = new HashSet<string>();
    HashSet<string> dupeHash = new HashSet<string>();

    // Start is called before the first frame update
    void Start()
    {
        //PrintArray();
        nameHash.Add("test");

        PrintHash();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrintArray()
    {
        foreach(var item in names)
    {
        Debug.Log(item.ToString());
    }
    }

    void PrintHash()
    {
        foreach(var item in nameHash)
    {
        Debug.Log(item.ToString());
    }
    }

}
