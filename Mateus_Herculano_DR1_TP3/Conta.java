package DR1_TP3;

public class Conta {
    public String titular;
    public int numero;
    public String agencia;
    public double saldo;
    public String dataAbertura;


    public void saca(double valor) {
        if (valor > 0 && valor <= saldo) {
            saldo -= valor;
            System.out.println("Saque de R$" + valor + " realizado com sucesso. Seu novo saldo é: R$" + saldo);
        } else {
            System.out.println("Saque inválido.");
        }
    }

    public void deposita(double valor) {
        if (valor > 0) {
            saldo += valor;
            System.out.println("Depósito de R$" + valor + " realizado com sucesso. Seu novo saldo é: R$" + saldo);
        } else {
            System.out.println("Depósito inválido.");
        }
    }

    public void calculaRendimento() {
        double rendimento = saldo * 0.1;
        System.out.println("Seu rendimento mensal foi de :" + rendimento);
    }
}
