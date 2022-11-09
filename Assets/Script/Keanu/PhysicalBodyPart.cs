using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class PhysicalBodyPart : MonoBehaviour
{
    [SerializeField] private Transform Target;
    private ConfigurableJoint _configurableJoint;
    private Quaternion _startRoation;

    private void Start()
    {
        _configurableJoint = GetComponent<ConfigurableJoint>();
        _startRoation = Quaternion.Inverse(Target.localRotation);
    }

    private void FixedUpdate()
    {
        _configurableJoint.targetRotation = Quaternion.Inverse(Target.localRotation)* _startRoation;
    }
}
