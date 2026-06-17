using UnityEngine;
using UnityEngine.UI;

public class PenanamanManager : MonoBehaviour
{
    public enum ProsesTanam { PasangAjir, GaliLubang, PupukDasar, TanamBibit, Selesai }
    public ProsesTanam faseTanam = ProsesTanam.PasangAjir;

    public Text teksInstruksi;
    public int jumlahCangkulan = 0;
    private const int TARGET_CANGKULAN = 6;

    public GameObject modelAjir;
    public GameObject modelLubangTanamAnimate;
    public GameObject modelBibitKakao;

    void Start() => UpdateFaseTanam();

    public void UpdateFaseTanam()
    {
        switch (faseTanam)
        {
            case ProsesTanam.PasangAjir:
                teksInstruksi.text = "KETUK pada area tanah untuk memasang Ajir Jarak Tanam (3x3 meter)!";
                break;
            case ProsesTanam.GaliLubang:
                teksInstruksi.text = "SWIPE ke bawah untuk menggali lubang ukuran 60x60x60 cm!";
                break;
            case ProsesTanam.PupukDasar:
                teksInstruksi.text = "DRAG karung kompos dan SP-36 ke dalam lubang tanam!";
                break;
            case ProsesTanam.TanamBibit:
                teksInstruksi.text = "SERET bibit kakao ke tengah lubang, lalu timbun dengan tanah!";
                break;
            case ProsesTanam.Selesai:
                teksInstruksi.text = "Proses penanaman selesai!";
                break;
        }
    }

    public void InputCangkul()
    {
        if (faseTanam == ProsesTanam.GaliLubang)
        {
            jumlahCangkulan++;
            float progress = (float)jumlahCangkulan / TARGET_CANGKULAN;
            modelLubangTanamAnimate.transform.localScale = new Vector3(1f, progress, 1f);

            if (jumlahCangkulan >= TARGET_CANGKULAN)
            {
                faseTanam = ProsesTanam.PupukDasar;
                UpdateFaseTanam();
            }
        }
    }
}
