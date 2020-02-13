using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knightStats : MonoBehaviour
{
    public float baseATK;
    public float baseDEF;

    private float ATK;
    private float DEF;
    
    void Start()
    {
        ATK = baseATK;
        DEF = baseDEF;
    }

    void Update()
    {
        
    }

    public float GetATK()
    {
        return this.ATK;
    }
}
