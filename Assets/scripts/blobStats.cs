using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blobStats : MonoBehaviour
{
    private Animator animator;

    public float baseATK;
    public float baseDEF;

    private float ATK;
    private float DEF;

    void Start()
    {
        animator = GetComponent<Animator>();

        ATK = baseATK;
        DEF = baseDEF;
    }

    void Update()
    {

    }

    public void OnHit(float dmg)
    {
        DEF = DEF - dmg;
        animator.SetBool("isTakingDMG", true);
    }

    void OnRest()
    {
        animator.SetBool("isTakingDMG", false);
    }
}