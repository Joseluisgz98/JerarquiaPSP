public interface Grafico : EditorGrafico{
        public boolean mover (int x,int y){ 
            boolean fuera = true;
            if (x < 0 || x > 800 || y < 0 || y > 600){
                throw new GraficoFueraDePantallaException("El gráfico está fuera de la pantalla.");
                fuera = false;
                return fuera;
            }
        }
    public virtual string Dibujar(){

    }
}
    
   