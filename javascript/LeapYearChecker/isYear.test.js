const { leapYear, testing } = require("./isYear.js");

describe("Testing leapYear() Implementation", () => {
  test.each([2000, 2012])("GivenValidLeapYear(%p)_ThenReturnTrue", (val) => {
    expect(leapYear(val)).toBe(true);
  });

  test.each([1900, 2019])(
    "GivenNonValidLeapYear(%p)_ThenReturnFalse",
    (val) => {
      expect(leapYear(val)).toBe(false);
    }
  );
});
