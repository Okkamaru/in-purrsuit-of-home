using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public Animator anim;

    public int maxHealth = 40;
    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        animator.SetTrigger("Hurt");

        if (currentHealth < 40)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy died! ");

        animator.SetBool("IsDead", true);

        GetComponent<Collider2D>().enabled = false;
        anim.speed = 0;
        this.enabled = false;
    }

}
