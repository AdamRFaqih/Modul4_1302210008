class Utama
{
    public static void Main(string[] args)
    {
        string masukan = Console.ReadLine();
        KodeBuah kodeBuah = new KodeBuah();
        kodeBuah.getKodeBuah(masukan);
    }
}

class KodeBuah
{
    enum State { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka, NULL}
    string[] kode = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "K00", "L00", "M00", "N00", "O00", "NONE" };

    

    public void getKodeBuah(string masukan)
    {
        State state = State.NULL;
        switch (masukan)
        {
            case "Apel":
                state = State.Apel;
                break;
            case "Aprikot":
                state = State.Aprikot;
                break;
            case "Alpukat":
                state = State.Alpukat;
                break;
            case "Pisang":
                state = State.Pisang;
                break;
            case "Paprika":
                state = State.Paprika;
                break;
            case "Blackberry":
                state = State.Blackberry;
                break;
            case "Ceri":
                state = State.Ceri;
                break;
            case "Kelapa":
                state = State.Kelapa;
                break;
            case "Jagung":
                state = State.Jagung;
                break;
            case "Kurma":
                state = State.Kurma;
                break;
            case "Durian":
                state = State.Durian;
                break;
            case "Anggur":
                state = State.Anggur;
                break;
            case "Melon":
                state = State.Melon;
                break;
            case "Semangka":
                state = State.Semangka;
                break;
        }
        Console.WriteLine("Kode " + kode[(int)state]);
    }
}