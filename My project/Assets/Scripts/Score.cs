using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    TextMeshPro scoreOutput;
    private void Awake()
    {
        scoreOutput = GameObject.Find(name: "Score").GetComponent<TextMeshPro>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
