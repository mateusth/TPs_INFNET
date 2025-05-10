import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertThrows;

public class ScientificCalculatorTest {
    @BeforeEach
    void setUp() {
        calc = new ScientificCalculator();
    }
    private ScientificCalculator calc;

    //testes basicos
    @Test void shouldAddTwoNumbersCorrectly() { assertEquals(5.0, calc.add(2.0, 3.0)); }
    @Test void shouldSubtractTwoNumbersCorrectly() { assertEquals(6.0, calc.subtract(10.0, 4.0)); }
    @Test void shouldReturnCorrectSquareRootPositive() { assertEquals(2.0, calc.squareRoot(4.0)); }

    //Testes avançados
    @Test void shouldReturnCorrectLogResult() { assertEquals(Math.log(10), calc.log(10.0), 0.0001); }

    //testes de erros
    @Test void shouldThrowExceptionWhenDivideByZero() { assertThrows(IllegalArgumentException.class, () -> calc.divide(4.0, 0.)); }
    @Test void shouldThrowExceptionWhenSquareRootNegative() { assertThrows(IllegalArgumentException.class, () -> calc.squareRoot(-4.0)); }

    //teste de funcoes trigonometricas
    @Test void shouldReturnCorrectSinValue() { assertEquals(Math.sin(Math.toRadians(45)), calc.sin(45), 0.0001); }
}
