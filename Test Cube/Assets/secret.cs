using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secret : MonoBehaviour
{
    [SerializeField]
    private KeyCode key;
    [SerializeField]
    private float vitesse = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            transform.Translate(new Vector3(0, 0, 1) * vitesse);
        }
        
    }
}