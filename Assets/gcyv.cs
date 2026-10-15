using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gcyv : MonoBehaviour
{
    // Start is called before the first frame update

   List<int> dane = new List<int>{ 1, 3, 3, 1, 2, 2, 3, 1, 3, 2 };
    List<int> jedynki = new List<int>();
    List<int> dwojki = new List<int>();
    List<int> trojki = new List<int>();


    // Update is called once per frame
    void Start()
    {
        foreach (int i in dane)
        {
            if (i == 1)
            {
                jedynki.Add(i);

            }
            else if (i == 2)

            {
                dwojki.Add(i);

            }
            else if (i == 3)
                trojki.Add(i);
        }

    

        Debug.Log("Jedynki: " + jedynki.Count);
        Debug.Log("dwojki: " + dwojki.Count);
        Debug.Log("trojki: " + trojki.Count);
        Debug.Log("Dane: " + dane.Count);




    }
    
        
    
}
