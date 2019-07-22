using UnityEngine;

public class ArmControl : MonoBehaviour
{
    public Transform LeftArm;
    public Transform RightArm;

    float yInitPos;

    CollisionLog cL;

    private void Start()
    {
        cL = FindObjectOfType<CollisionLog>();
        yInitPos = LeftArm.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            if (cL.contactDistance > 0)
            {
                LeftArm.Translate(transform.forward * Time.deltaTime);
                RightArm.Translate(-transform.forward * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.X))
        {
            LeftArm.Translate(Vector3.back * Time.deltaTime);
            RightArm.Translate(Vector3.forward * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            LeftArm.Translate(Vector3.up * Time.deltaTime);
            RightArm.Translate(Vector3.up * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (LeftArm.position.y > yInitPos & RightArm.position.y > yInitPos)
            {
                LeftArm.Translate(Vector3.down * Time.deltaTime);
                RightArm.Translate(Vector3.down * Time.deltaTime);
            }
        }
    }
}
