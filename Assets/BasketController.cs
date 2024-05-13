using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip bombSe;
    AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.aud = GetComponent<AudioSource>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            Debug.Log("Tag=Apple");
        }
        else
        {
            Debug.Log("Tag=Bomb");
        }

        Destroy(other.gameObject);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //rayでクリックしたところを光線を飛ばす
            //Raycastメソッド 戻り値はtrueかfalse 
            //Mathf.Infinityはrayの光線を無限に伸ばす　
            //baketのcolliderにぶつかるまで
            //out hit は参照渡し　outhit で初期化して、floatx,zに渡される
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                //ray光線がぶつかったものを破壊する処理
                // Destroy(hit.collider.gameObject);

                //Mathf.RoundToIntは四捨五入用のメソッド

                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
            }
        }
    }
}
