using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMods : MonoBehaviour
{
    float dist;
    [SerializeField] float minDist = 7.0f;
    [SerializeField] GameObject go;
    public GameObject text;
    public GameObject panel;

    void Update()
    {

        dist = (transform.position - go.transform.position).magnitude;
        if (dist <= minDist)
        {
            if (!panel.activeSelf)
            {
                text.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                text.SetActive(false);


                go.GetComponent<Shop>().UIenabler();

                
            }

        }
        if(dist>minDist && text.activeSelf)
        {
            text.SetActive(false);
        }

    }
}
