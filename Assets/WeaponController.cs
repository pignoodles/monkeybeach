using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
   /* public GameObject Longsword;
    public bool CanAttack = true;
    public float AttackCooldown = 1.0f;

    public bool isAttacking = false;

    public AudioClip SwordAttackSound;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            if (CanAttack)
            {
                LongswordAttack();
            }
    }
                
    public void LongswordAttack()
    {
        isAttacking = true;
        CanAttack = false;
        Animator anim = Longsword.GetComponent<Animator>();
        anim.SetTrigger("Attack");
        StartCoroutine(ResetAttackCooldown());
        AudioSource ac = GetComponent<AudioSource>();
        ac.PlayOneShot(SwordAttackSound);

    }

    IEnumerator ResetAttackCooldown()
    {
        StartCoroutime(ResetAttackBool());
        yield return new WaitForSeconds(AttackCooldown);
        
        CanAttack = true;
    }

    IEnumerator ResetAttackBool()
    {
        yield return new WaitForSeconds(1.0f);
        isAttacking = false;

    } */
}
