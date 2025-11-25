using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   public Transform player;   // oyuncu karakterinin ekrandaki konumu
   public Vector3 offset = new Vector3( 0, 45, -45);     //oyuncu ile kamera arasındaki mesafe

   private void LateUpdate ()
   {
    transform.position = player.position + offset;     // bu scriptin bağlı olduğu nesnenin konumunu, oyuncuya ve mesafaeye gçre günceller }

   }
}