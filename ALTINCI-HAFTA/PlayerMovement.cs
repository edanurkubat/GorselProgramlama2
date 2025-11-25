using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public float moveSpeed=50f;  //hareket hızı
   Rigidbody rb;   // fizik componenti

   ScoreManager scoreManager;
    
   private void Start() {
    rb = GetComponent<Rigidbody>();   // scriptin bağlı olduğu nesne üzerindeki compomenti bul
    scoreManager = FindFirstObjectByType<ScoreManager>();
   }

   private void FixedUpdate() {
    float moveX = Input.GetAxis("Horizontal");  //yatay hareket girdisi
    float moveZ = Input.GetAxis("Vertical");   //dikey hareket girdisi

    Vector3 movement = new Vector3(moveX, 0f, moveZ);   // oyuncunun gitmek istediği yönü belirle
    rb.AddForce(movement * moveSpeed);  //rigidbodye gitmek istediği yönde kuvvet uygula bu sayede hareketi sağlamış oluruz
   }
  
   private void OnTriggerEnter(Collider other) 
   {
        // Eğer oyuncu "pickup" tagına sahip bir nesneye çarparsa o nesneyi yoket
      if (other.CompareTag("Pickup")) 
      {
         Destroy(other.gameObject);
         scoreManager.CollectPickup();
      }
   }
}