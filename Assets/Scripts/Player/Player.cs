using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Vector2 pointerInput, movementInput;

    private WeaponParent weaponParent;

    private AgentMover agentMover;
    
    [SerializeField]
    private InputActionReference movement, attack, pointerPosition;
    // Start is called before the first frame update

    private void OnEnable()
    {
        attack.action.performed += PerformAttack;
    }

    private void OnDisable() {
        attack.action.performed -= PerformAttack;
    }
    private void PerformAttack(InputAction.CallbackContext obj)
    {
        Debug.Log("Attack");
        weaponParent.Attack();
    }

    private void Awake()
    {
        agentMover = GetComponent<AgentMover>();
        weaponParent = GetComponentInChildren<WeaponParent>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        pointerInput = GetPointerInput();
        weaponParent.PointerPosition = pointerInput;
        movementInput = movement.action.ReadValue<Vector2>().normalized;

        agentMover.MovementInput = movementInput;

       
    }

    private Vector2 GetPointerInput()
    {
        Vector3 mousePos = pointerPosition.action.ReadValue<Vector2>();
        mousePos.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}
