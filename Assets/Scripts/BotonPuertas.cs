using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPuertas : MonoBehaviour
{
    Animator _animator;

    private void Start()
    {
        _animator=GetComponentInParent<Animator>();
    }

    private void Update()
    {
        Debug.Log(_animator.GetBool("character_nearby"));
    }
    public void abrirCerrarPuerta()
    {
        
        if (_animator.GetBool("character_nearby"))
        {
            _animator.SetBool("character_nearby", false);
        }else
        {
            _animator.SetBool("character_nearby", true);
        }
    }
}
