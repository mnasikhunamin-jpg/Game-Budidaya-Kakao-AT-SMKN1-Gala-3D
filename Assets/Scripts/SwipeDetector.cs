using UnityEngine;

public class SwipeDetector : MonoBehaviour
{
    private Vector2 posisiSentuhanAwal;
    private Vector2 posisiSentuhanAkhir;
    
    public GraftingManager manajerGrafting; 
    public float jarakMinimalSwipe = 50f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                posisiSentuhanAwal = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                posisiSentuhanAkhir = touch.position;
                PeriksaArahSwipe();
            }
        }
    }

    void PeriksaArahSwipe()
    {
        float jarakHorizontal = posisiSentuhanAkhir.x - posisiSentuhanAwal.x;

        if (Mathf.Abs(jarakHorizontal) > jarakMinimalSwipe)
        {
            if (manajerGrafting.tahapSaatIni == GraftingManager.TahapGrafting.PotongBatangBawah)
            {
                manajerGrafting.TambahKemajuan(0.25f); 
                Debug.Log("Batang tersayat...");
            }
        }
    }
}
