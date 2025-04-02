public class Questao_8 {

    static class Funcionario{
        String nome;
        double salarioBase;

        public Funcionario(String nome, double salarioBase) {
            this.nome = nome;
            this.salarioBase = salarioBase;
        }
    }

    static class Gerente extends Funcionario {
        public Gerente(String nome, double salarioBase) {
            super(nome, salarioBase*1.2);
        };
    }

    static class Estagiario extends Funcionario {
        public Estagiario(String nome, double salarioBase) {
            super(nome, salarioBase*0.8);
        }
    }

    public static void main(String[] args) {
        Gerente g = new Gerente("Mateus", 10000);
        Estagiario e = new Estagiario("Marcos", 2000);
        System.out.printf("Salario do Gerente %s: %.2f.\nSalario do Estagiario %s: %.2f",g.nome, g.salarioBase,e.nome, e.salarioBase);
    }
}
