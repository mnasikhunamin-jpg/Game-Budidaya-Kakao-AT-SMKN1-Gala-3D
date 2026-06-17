using UnityEngine;
using UnityEngine.UI;

public class MesinHilirController : MonoBehaviour
{
    public Slider sliderSuhuRoasting;
    public Text teksIndikatorSuhu;
    public PascapanenManager pascapanenManager;

    private float suhuTargetOptimal = 120f;
    private float toleransiSuhu = 5f;

    void Update()
    {
        if (pascapanenManager.faseAktif == PascapanenManager.FasePascapanen.Roasting)
        {
            float suhuSaatIni = sliderSuhuRoasting.value * 200f;
            teksIndikatorSuhu.text = $"Suhu Mesin: {suhuSaatIni:F0}°C";
        }
    }

    public void ValidasiSuhuRoasting()
    {
        float suhuAkhir = sliderSuhuRoasting.value * 200f;
        if (Mathf.Abs(suhuAkhir - suhuTargetOptimal) <= toleransiSuhu)
        {
            pascapanenManager.faseAktif = PascapanenManager.FasePascapanen.PengolahanCokelat;
            pascapanenManager.UpdateFasePascapanen();
        }
        else
        {
            teksIndikatorSuhu.text = "Suhu tidak tepat! Atur ulang!";
        }
    }
}
