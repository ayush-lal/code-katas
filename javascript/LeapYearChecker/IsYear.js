function leapYear(year) {
  return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
}

function testing() {
  return "hello";
}

module.exports = { leapYear, testing };
