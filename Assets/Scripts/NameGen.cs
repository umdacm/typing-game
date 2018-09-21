using System.IO;

public class NameGen {

    // Create a System.Random object rand
    public System.Random rand = new System.Random();

    // Create a string array lines containing names
    public string[] lines = File.ReadAllLines("Assets/Scripts/name.txt");

    // returns a random name
    public string GetName() {

        return lines[rand.Next(lines.Length)];

    }

    public void NamesInUse() {

        // STUB

    }

    public bool CheckInput(string name){

        // STUB
        return false;

    }
}

/* TODO
 * 
 * Function to add inUse names to an array
 * Function to check if inputed name is in array
 *  If so, remove name from array and delete that clone bubble
 * 
 */