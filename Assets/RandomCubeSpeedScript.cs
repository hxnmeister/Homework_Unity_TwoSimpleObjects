using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCubeScript : MonoBehaviour
{
    private const float MAX_X_POSITION = 15F;
    private const float MIN_X_POSITION = -15F;

    [SerializeField]
    private float x_translate = 0.01f;

    [SerializeField] 
    private float x_duration = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(x_translate * x_duration, 0, 0);

        if(transform.position.x > MAX_X_POSITION || transform.position.x < MIN_X_POSITION)
        {
            x_duration = UnityEngine.Random.value * (x_duration >= 0 ? -10 : 10);
        }
    }
}
