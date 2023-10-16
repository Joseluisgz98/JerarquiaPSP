public class Rectangulo : Punto{
    public int ancho;
    public int alto;

    public Rectangulo (int ancho,int alto) : base(x,y){
        this.ancho = ancho;
        this.alto = alto;
    }
}