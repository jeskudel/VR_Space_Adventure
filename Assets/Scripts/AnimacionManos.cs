using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AnimacionManos : MonoBehaviour
{
    [SerializeField]
    private ActionBasedController _controlador;
    [SerializeField]
    private Animator _animador;

    private const string ANIMATOR_GRIP_PARAM = "Grip";
    private const string ANIMATOR_TRIGGER_PARAM = "Trigger";
    private float _grip_value = 0f;
    private float _trigger_value = 0f;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _grip_value = _controlador.selectActionValue.action.ReadValue<float>();
        _trigger_value = _controlador.activateActionValue.action.ReadValue<float>();

        _animador.SetFloat(ANIMATOR_GRIP_PARAM, _grip_value);
        _animador.SetFloat(ANIMATOR_TRIGGER_PARAM, _trigger_value);
    }
}
