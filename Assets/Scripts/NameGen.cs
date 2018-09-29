using System.IO;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class NameGen {
    // Create a System.Random object rand
    public static System.Random rand = new System.Random();

    // Create a string array lines containing names
    private static string[] lines = File.ReadAllLines("Assets/Scripts/name.txt");

    // returns a random name
    public static string GetName() {
        return lines[rand.Next(lines.Length)];
    }
}

/* TODO
 * 
 * Function to add inUse names to an array
 * Function to check if inputed name is in array
 *  If so, remove name from array and delete that clone bubble
 * 
 */