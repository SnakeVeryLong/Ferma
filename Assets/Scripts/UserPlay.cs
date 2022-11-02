using UnityEngine;

public class UserPlay : MonoBehaviour
{
   //public float speed = 1.5f;

    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        transform.position = new Vector3(pos.x, pos.y, transform.position.z);

        //float hor = Input.GetAxisRaw("Horizontal");

        //Vector3 dir = new Vector3(hor, 0f, 0f);
        //transform.Translate(dir.normalized * Time.deltaTime * speed); 
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("tree")){
            Destroy(collision.gameObject);
        }
    }

}
