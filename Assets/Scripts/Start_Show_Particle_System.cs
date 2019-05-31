using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Show_Particle_System : MonoBehaviour

    {
    public GameObject particlesystem;


    // Start is called before the first frame update
    void Start()
    {
        particlesystem.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
