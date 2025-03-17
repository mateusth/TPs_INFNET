package DR1_TP3;

public class TestaFiguras {
    public static void main(String[] args) {
        Circulo c1 = new Circulo();
        c1.Raio = 3.0;
        c1.calcularArea();

        Esfera e1 = new Esfera();
        e1.Raio = 5.0;
        e1.calcularVolume();
    }
}
