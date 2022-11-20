using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer Target;
    [SerializeField] private float Changing_Speed;
    private void Start()
    {
        Target = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        
    }
}
