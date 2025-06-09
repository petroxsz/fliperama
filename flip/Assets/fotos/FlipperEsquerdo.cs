using UnityEngine;

public class FlipperEsquerdo : MonoBehaviour
{
    private HingeJoint2D hinge;

    public float for�a = 1000f;
    public KeyCode tecla = KeyCode.A;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
    }

    void Update()
    {
        JointMotor2D motor = hinge.motor;

        if (Input.GetKey(tecla))
        {
            motor.motorSpeed = -for�a; 
        }
        else
        {
            motor.motorSpeed = for�a; 
        }

        hinge.motor = motor;
    }
}