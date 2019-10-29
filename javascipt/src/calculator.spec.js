describe("fail", function () {
  it("should always fail", function () {
    expect(false).toBe(true);
  });
});

describe("add", function() {
  it("add 1 to 3", function() {
    var calculator = new Calculator();
    expect(calculator.addition(1, 3)).toBe(4);
  });

  it("add 2 to 3", function() {
    var calculator = new Calculator();
    expect(calculator.addition(2, 3)).toBe(5);
  });
});
