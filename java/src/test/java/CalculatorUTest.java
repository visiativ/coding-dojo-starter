import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.DisplayName;

public class CalculatorUTest {

    @Test()
    @DisplayName("should always fail")
    void shouldAlwaysFail() {
        assertFalse(true);
    }

    @Test()
    @DisplayName("add 1 to 3")
    void add1To3() {
        assertEquals(4, new Calculator().addition(1, 3));
    }

    @Test()
    @DisplayName("add 2 to 3")
    void add2To3() {
        assertEquals(5, new Calculator().addition(2, 3));
    }
}
