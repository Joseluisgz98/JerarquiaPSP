public class GraficoFueraDePantallaException : [System.Serializable]
public class GraficoFueraDePantallaExceptionException : System.Exception
{
    public GraficoFueraDePantallaExceptionException() { }
    public GraficoFueraDePantallaExceptionException(string message) : base(message) { }
    public GraficoFueraDePantallaExceptionException(string message, System.Exception inner) : base(message, inner) { }
    protected GraficoFueraDePantallaExceptionException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}