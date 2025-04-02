public class Questao_9 {
    static class ContaBancaria {
        public String titular;
        private double saldo;

        public double getSaldo() { return saldo; }
        public void setSaldo(double saldo) {
            this.saldo = saldo;
        }

        void depositar(double valor) {
            saldo = getSaldo() + valor;
            System.out.printf("Deposito de R$%.2f realizado com sucesso.\n",valor);
        }
        void sacar(double valor) {
            if(valor <= saldo) {
                saldo -= valor;
                System.out.printf("Saque de R$%.2f realizado com sucesso.\n",valor);
            } else {
                System.out.println("Saldo insuficiente.");
            }
        }
        void exibirSaldo() {
            System.out.printf("Saldo do titular %s: R$%.2f.\n",titular, saldo);
        }
    }
    public static void main(String[] args) {
        ContaBancaria c = new ContaBancaria();
        c.titular = "Mateus";
        c.sacar(1000);
        c.depositar(2000);
        c.sacar(500);
        c.exibirSaldo();
    }
}
