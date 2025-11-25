using UnityEngine;


//toplanabilir kapsülleri zemin üzerinde oluşturacak script
public class PickupManager : MonoBehaviour
{
    public GameObject pickup;   // kapsül prefabı
    public GameObject ground; // zemin nesnesi
    public int amount;  // doğacak kapsül adedi


    void Start()
    {
        // zemin boyutlarını al, Plane nesnesi 10*10 birim olduğundan zeminin scale değerini 10 ile çarparak boyutuna ulaştık.
        float groundSizeX = ground.transform.localScale.x * 10f;
        float groundSizeZ = ground.transform.localScale.z * 10f;

        for(int i = 0; i < amount; i++) 
        {
            // zemin boyunca rastgele x ve z konumu belirle
            float randomX = Random.Range(-groundSizeX / 2f, groundSizeX / 2f);
            float randomZ = Random.Range(-groundSizeZ / 2f, groundSizeZ / 2f);

          // kapsülün doğacağı konumu belirle
            Vector3 location = new Vector3(randomX, 3f, randomZ);
            Instantiate(pickup, location, Quaternion.identity);  // kapsülü belirlenen rastgele konumda oluştur

        }
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
