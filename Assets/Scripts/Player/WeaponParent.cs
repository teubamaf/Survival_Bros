using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponParent : MonoBehaviour
{
    public Vector2 PointerPosition { get; set; }

    public Animator animator;
    public float delay = 0.3f;

    private bool attackBlocked;

    private void Update() {

        Vector2 direction = (PointerPosition - (Vector2)transform.position).normalized;
        transform.right = direction;

        Vector2 scale = transform.localScale;
        if(direction.x < 0) {
            scale.y = -1;
        } else if( direction.x > 0) {
            scale.y = 1;
        }
        transform.localScale = scale;

        
    }

    public void Attack() {
        if(attackBlocked) return;
        animator.SetTrigger("Attack");
        attackBlocked = true;
        StartCoroutine(DelayAttack());
    }

    private IEnumerator DelayAttack() {
        yield return new WaitForSeconds(delay);
        attackBlocked = false;
    }
}
