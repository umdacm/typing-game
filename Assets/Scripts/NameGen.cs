using System.IO;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class NameGen {

    private string curName;
    private List<string> namesInUse = new List<string>();

    // Create a System.Random object rand
    public System.Random rand = new System.Random();

    // Create a string array lines containing names
    public string[] lines = File.ReadAllLines("Assets/Scripts/name.txt");

    // returns a random name
    public string GetName() {
        curName = lines[rand.Next(lines.Length)];
        NamesInUse(); // this is mostly just testing the function
        return curName;

    }

    public void NamesInUse() {
       
        if (!namesInUse.Contains(curName))
        {
            namesInUse.Add(curName);
        }
        
    } 

    public bool CheckInput(string name){

        return namesInUse.Contains(name);

    }
}

/* TODO
 * 
 * Function to add inUse names to an array
 * Function to check if inputed name is in array
 *  If so, remove name from array and delete that clone bubble
 * 
 */