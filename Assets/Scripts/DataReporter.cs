using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class DataReporter : MonoBehaviour
{
    private string urlGoogleForm = "https://google.com";

    public void KirimRaporSiswa(string nama, string kelas, int m1, int m2, int m3, int m4m5)
    {
        StartCoroutine(PostDataDataCoroutine(nama, kelas, m1, m2, m3, m4m5));
    }

    IEnumerator PostDataDataCoroutine(string nama, string kelas, int m1, int m2, int m3, int m4m5)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.111111111", nama);
        form.AddField("entry.222222222", kelas);
        form.AddField("entry.333333333", m1.ToString());
        form.AddField("entry.444444444", m2.ToString());
        form.AddField("entry.555555555", m3.ToString());
        form.AddField("entry.666666666", m4m5.ToString());

        using (UnityWebRequest www = UnityWebRequest.Post(urlGoogleForm, form))
        {
            yield return www.SendWebRequest();
            if (www.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Rapor praktikum siswa berhasil dikirim ke Guru Pengawas!");
            }
        }
    }
}
