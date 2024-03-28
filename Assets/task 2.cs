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
        Debug.Log("Created the name array: " + names[0] + names[1] + names[2] + names[3] + names[4] + names[5] + names[6] + names[7] + names[8] + names[9] + names[10] + names[11] + names[12] + names[13] + names[14] +  names[15] + names[16] + names[17] + names[18] + names[19]);
        //PrintArray();
        AddArray();
        AddNewArray();
        nameHash.IntersectWith(dupeHash);
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

    void AddArray()
    {
        for(int i=0; i<19; i++){
            nameHash.Add(names[i]);
        }

        /*nameHash.Add(names[0]);
        nameHash.Add(names[1]);
        nameHash.Add(names[2]);
        nameHash.Add(names[3]);
        nameHash.Add(names[4]);
        nameHash.Add(names[5]);
        nameHash.Add(names[6]);
        nameHash.Add(names[7]);
        nameHash.Add(names[8]);
        nameHash.Add(names[9]);
        nameHash.Add(names[10]);
        nameHash.Add(names[11]);
        nameHash.Add(names[12]);
        nameHash.Add(names[13]);
        nameHash.Add(names[14]);
        nameHash.Add(names[15]);
        nameHash.Add(names[16]);
        nameHash.Add(names[17]);
        nameHash.Add(names[18]);
        nameHash.Add(names[19]);*/

    }

    void AddNewArray()
    {
        /*for(int i=0; i<14; i++){
            dupeHash.Add(newNames[i]);
        }
        nuclear bomb*/

        dupeHash.Add(newNames[0]);
        dupeHash.Add(newNames[1]);
        dupeHash.Add(newNames[2]);
        dupeHash.Add(newNames[3]);
        dupeHash.Add(newNames[4]);
        dupeHash.Add(newNames[5]);
        dupeHash.Add(newNames[6]);
        dupeHash.Add(newNames[7]);
        dupeHash.Add(newNames[8]);
        dupeHash.Add(newNames[9]);
        dupeHash.Add(newNames[10]);
        dupeHash.Add(newNames[11]);
        dupeHash.Add(newNames[12]);
        dupeHash.Add(newNames[13]);
        dupeHash.Add(newNames[14]);
    }

}
