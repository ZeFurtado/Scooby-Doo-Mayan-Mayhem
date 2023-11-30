using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Scooby : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float velocidade = 0.7f;
        float xKey = Input.GetAxis("Horizontal");
        float yKey = Input.GetAxis("Vertical");

        Vector3 position = new Vector3();
        position.Set(xKey, yKey, 0);

        float timeSinceLastFrame = Time.deltaTime;

        Vector3 translation = position * velocidade * timeSinceLastFrame;

        transform.Translate(translation);

        Debug.Log(xKey);
        Debug.Log(yKey);
    }
}
