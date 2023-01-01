using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur2 : MonoBehaviour
{

    [SerializeField] private GameObject stand;
    [SerializeField] private GameObject crouch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            stand.SetActive(true); //happens once you let go of S key
            crouch.SetActive(false);      
        }
    }
}
