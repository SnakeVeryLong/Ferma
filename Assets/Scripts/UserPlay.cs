using UnityEngine;

public class UserPlay : MonoBehaviour
{
   //public float speed = 1.5f;

    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
          this.transform.Translate(pos.x * Time.deltaTime, pos.y * Time.deltaTime, 0, Camera.main.transform);
 Vector3 pos2 = new Vector3(this.transform.position.x, pos.y, 0);

      //  var angle = Mathf.Atan2((pos - transform.position).y, (pos - transform.position).x) * Mathf.Rad2Deg;
      //  rb.AddForce(-90f, 0, angle);
       //this.transform.rotation = Quaternion.Euler(-90f, 0, -angle);
         // Debug.Log(Quaternion.Angle(Quaternion.Euler(pos2), Quaternion.Euler(transform.position)));
        
      

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
