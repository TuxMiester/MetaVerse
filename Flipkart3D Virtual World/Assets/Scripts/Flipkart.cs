using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Flipkart : Cart
{
    
    List<Category> cat;
    void Fit(string[] comp, string[] names)
    {
        List<GameObject> go;
        for(int i = 0; i < comp.Length; i++)
        {
            go = GameObject.FindGameObjectsWithTag(comp[i]).ToList();
            for(int j = 0; j < go.Count; j++)
            {
                go[j].tag = names[j];
            }
        }
    }

}
