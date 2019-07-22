using UnityEngine;

public class CollisionLog : MonoBehaviour
{
    ArmControl ac;

    float yDiff;
    public float contactDistance;
    float yInitPos;

    private void Start()
    {
        ac = FindObjectOfType<ArmControl>();
        contactDistance = 5.0f;
        yInitPos = transform.position.y;
    }

    private void PickUpResponse(Collision collision)
    {
        if (collision.gameObject.CompareTag("Arm"))
        {
            if (transform.position.y >= yInitPos)
            {
                transform.position = new Vector3(0, ac.LeftArm.position.y - yDiff, 0);
            }

            transform.rotation = Quaternion.identity;
        }
    }


    /*
    private void OnCollisionEnter(Collision collision)
    {
        yDiff = Mathf.Abs(ac.LeftArm.position.y - transform.position.y);
        //PickUpResponse(collision);     
    }

    private void OnCollisionStay(Collision collision)
    {
        PickUpResponse(collision);

        if (collision.gameObject.CompareTag("Arm"))
        {
            //print("Collision Count: " + collision.contactCount);
            //print("FFS: " + collision.collider);
            //print("Position: " + collision.transform.position);
            //print("Contacts: " + collision.contacts);

            foreach (ContactPoint contact in collision.contacts)
            {
                Debug.DrawLine(contact.point, contact.point + contact.normal, Color.red, 0, true);
                Debug.Log("Contact Point: " + contact.point);
                Debug.Log("End Point: " + contact.normal);
                contactDistance = contact.separation;
                //Debug.Log("Separation: " + contactDistance);
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Arm"))
        {
            contactDistance = 5.0f;
        }
    }
    */
}