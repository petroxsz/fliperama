using UnityEngine;

public class FlipperController : MonoBehaviour
{
    public KeyCode teclaAcionar = KeyCode.A; 
    private HingeJoint2D hinge;
    private JointMotor2D motor;

    public float forca = 1000f;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        motor = hinge.motor;
    }

    void Update()
    {
        if (Input.GetKey(teclaAcionar))
        {
            motor.motorSpeed = -forca; 
            hinge.motor = motor;
            hinge.useMotor = true;
        }
        else
        {
            motor.motorSpeed = forca; 
            hinge.motor = motor;
            hinge.useMotor = true;
        }
    }
}
