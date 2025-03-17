package DR1_TP3;

import java.sql.SQLOutput;

public class Esfera {
    double Raio;

    public void calcularVolume() {
        System.out.println("O volume da esfera é: " + (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio));
    }
}
