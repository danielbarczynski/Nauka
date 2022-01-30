using System;

public interface IPolecenie
{
    void wykonaj();
}

public class KomendaWlacz : IPolecenie
{
    private Lampa _lampa;

    public KomendaWlacz(Lampa lampa)
    {
        _lampa = lampa;
    }
    public void wykonaj()
    {
        _lampa.wlacz();
    }
}

public class KomendaWylacz : IPolecenie
{
    private Lampa _lampa;

    public KomendaWylacz(Lampa lampa)
    {
        _lampa = lampa;
    }
    public void wykonaj()
    {
        _lampa.wylacz();
    }
}


public class Lampa
{
    private bool _stan;

    public Lampa()
    {
        _stan = false;
    }

    public void wlacz()
    {
        _stan = true;
    }

    public void wylacz()
    {
        _stan = false;
    }

    public bool sprawdz()
    {
        return _stan;
    }
}


public class Pilot
{
    private IPolecenie _polecenie;

    public void ustawPolecenie(IPolecenie polecenie)
    {
        _polecenie = polecenie;
    }

    public void wcisnijGuzik()
    {
        _polecenie.wykonaj();
    }
}


class Program
{
    static void Main(string[] args)
    {
        var lampa = new Lampa();
        var pilot = new Pilot();
        IPolecenie wlacz = new KomendaWlacz(lampa);
        IPolecenie wylacz = new KomendaWylacz(lampa);

        void displayState(Lampa lampa)
        {
            Console.WriteLine(lampa.sprawdz() ? "Lampa włączona" : "Lampa wyłączona");
        }

        displayState(lampa);

        pilot.ustawPolecenie(wlacz);
        pilot.wcisnijGuzik();
        displayState(lampa);

        pilot.ustawPolecenie(wylacz);
        pilot.wcisnijGuzik();
        displayState(lampa);
    }
}