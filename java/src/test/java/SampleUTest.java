import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.DisplayName;

public class SampleUTest {

    @Test()
    @DisplayName("should always fail")
    void shouldAlwaysFail() {
        assertFalse(true);
    }

    @Test()
    @DisplayName("add 1 to 3")
    void add1To3() {
        assertEquals(4, new Sample().addition(1, 3));
    }
}
