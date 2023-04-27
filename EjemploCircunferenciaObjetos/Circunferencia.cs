namespace EjemploCircunferenciaObjetos;
public class Circunferencia
{
    //atributo
    public double Radio2 { get; private set; }

    private double radio;

    public double Radio
    {
        set
        {
            if (value <= 0)
                throw new Exception("Radio invalido");
            radio = value;
        }
        get
        {
            return radio;
        }
    }

    //RECOMENDADO !!
    public void SetRadio(double unRadio)
    {
        if (unRadio <= 0)
            throw new Exception("Radio invalido");
        radio = unRadio;
    }

    //forma clasica
    // public double GetRadio()
    // {
    //     return radio;
    // }

    //forma nueva
    public double GetRadio() => radio;

    //métodos
    public Circunferencia(double unRadio)
    {
        SetRadio(unRadio);

        //this.Radio = unRadio;
    }


    public double CalcularArea() => Math.PI * radio * radio;

    public double CalcularPerimetro() => Math.PI * 2 * radio;
}