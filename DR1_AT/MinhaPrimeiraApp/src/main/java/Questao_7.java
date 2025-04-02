public class Questao_7 {
    static class Aluno {
        String nome;
        int matricula;
        double nota1, nota2, nota3, media;
        public void calcularMedia() {
            media = (nota1 + nota2 + nota2)/3;
            System.out.printf("Media das notas: %.1f\n", media);
        }
        public void verificarAprovacao() {
           if (media >= 7) {
               System.out.printf("Ola %s, voce foi aprovado com media: %.1f", nome, media);
           } else {
               System.out.printf("Ola %s, voce foi reprovado com media: %.1f",nome, media);
           }
        }
    }
    public static void main(String[] args) {
        Aluno a1 = new Aluno();
        a1.nome = "Mateus";
        a1.matricula = 123456;
        a1.nota1 = 9.5;
        a1.nota2 = 10;
        a1.nota3 = 9.0;
        a1.calcularMedia();
        a1.verificarAprovacao();
    }
}
