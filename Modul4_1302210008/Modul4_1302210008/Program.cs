class Utama
{
    public static void Main(string[] args)
    {
        string masukan = Console.ReadLine();
        KodeBuah kodeBuah = new KodeBuah();
        kodeBuah.getKodeBuah(masukan);


        //SOAL2
        PosisiKarakterGame posisiKarakterGame = new PosisiKarakterGame();
        posisiKarakterGame.PlayerStateMachine();
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

class PosisiKarakterGame
{
    enum State { Tengkurap, Jongkok, Berdiri, Terbang };
    public void PlayerStateMachine()
    {
        State state = State.Berdiri;
        string command;
        string[] screenName = { "Tengkurap", "Jongkok", "Berdiri", "Terbang" };
        Console.WriteLine("Player " + screenName[(int)state]);
        Console.Write("Masukan Command: ");
        command = Console.ReadLine();
        while (command != "E")
        {
            switch (state)
            {
                case State.Tengkurap:
                    if (command == "W")
                        state = State.Jongkok;
                    else
                        state = State.Tengkurap;
                    break;
                case State.Jongkok:
                    if (command == "E")
                        state = State.Berdiri;
                    else if (command == "S")
                        state = State.Tengkurap;
                    else
                        state = State.Jongkok;
                    break;
                case State.Berdiri:
                    if (command == "W")
                    {
                        Console.WriteLine("Posisi TakeOFF");
                        state = State.Terbang;
                    }
                    else if (command == "S")
                        state = State.Jongkok;
                    else
                        state = State.Berdiri;
                    break;
                case State.Terbang:
                    if (command == "S")
                        state = State.Berdiri;
                    else if (command == "X") { Console.WriteLine("Posisi Landing"); 
                    state = State.Jongkok;}
                    else
                        state = State.Terbang;
                    break;
            }
            Console.WriteLine("Player " + screenName[(int)state]);
            Console.Write("Masukan Command: ");
            command = Console.ReadLine();
        }
        Console.WriteLine("Game END");
    }
}