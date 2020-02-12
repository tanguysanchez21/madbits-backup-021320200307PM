using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atk : MonoBehaviour
{
    private Animator animator;
    public GameObject sword;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(animator.GetBool("attack") == false && Input.touchCount > 0)
        {
            animator.SetBool("attack", true);
        }
        else
        {
            animator.SetBool("attack", false);
        }
    }

    void Fire()
    {
        GameObject projectile = Instantiate(sword, transform.position, Quaternion.identity);
        projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(5.0f, 0.0f);
    }
}
