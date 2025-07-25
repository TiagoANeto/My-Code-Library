using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

[CreateAssetMenu(menuName = "InputRef")]
public class InputRef : ScriptableObject, InputClass.IPlayerActions //Interfaces dos Action Maps
{
    private InputClass inputClass; //Referencia da classe C# InputClassystem
    [HideInInspector] public bool isPressed;

    //Iniciando a classe das InputClass e passando as intancias de cada Action Map
    public void OnEnable()
    {
        if(inputClass == null)
        {
            inputClass = new InputClass();

            inputClass.Player.SetCallbacks(this);

            SetGameplay();
        }
    }

    public void OnDisable()
    {
        inputClass.Player.Disable();
    }

    //Ativação do Action Map do player in Game 
    public void SetGameplay()
    {
        inputClass.Player.Enable();
    }

    //Declaração dos Eventos que seram feitas as atribuições das InputClass
    public event Action<Vector2> MoveEvent;
    public event Action InteractEvent;
    public event Action<RaycastHit> MouseClickEvent;
    public event Action OpenMenuInGameEvent;

    public void OnMove(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        MoveEvent?.Invoke(context.ReadValue<Vector2>());
    }

    public void OnMouse(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // RaycastHit hit;

        // if(Physics.Raycast(ray, out hit, Mathf.Infinity) && context.performed)
        // {
        //     MouseClickEvent?.Invoke(hit);
        // }
    }

    public void OnInteract(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
    
        if(context.started)
        {
            Debug.Log("Tecla E foi pressionada");
            InteractEvent?.Invoke();
        }
    }

    public void OnMenuInGame(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            OpenMenuInGameEvent?.Invoke();
        }
    }

    public void OnJump(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {   
        
    }

    public void OnLook(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        
    }

    public void OnAttack(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
       
    }


    public void OnCrouch(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        
    }

    public void OnSprint(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        
    }

    public void OnPrevious(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        
    }

    public void OnNext(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        
    }
}