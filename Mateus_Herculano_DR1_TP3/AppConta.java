package DR1_TP3;

public class AppConta {
    public static void main(String[] args) {
        Conta c1 = new Conta();
        c1.titular = "Mateus";
        c1.numero = 1234;
        c1.agencia = "Av. Brasil";
        c1.saldo = 10000.0;
        c1.dataAbertura = "10/01/2025";

        System.out.println("Seu saldo é de R$: " + c1.saldo);
        c1.saca(1000);
        c1.deposita(200);
        c1.calculaRendimento();
    }
}
