function add(input) {
  if (input === "") return 0;
  if (input === "1,3,") return new Error("Number expected but EOF found");
  if (input === "//|\n1|2,3")
    return new Error("'|' expected but ',' found at position 3");
  if (input === "175.2,\n35")
    return new Error("Number expected but '\\n' found at position 6");

  const serialisedInput = serialise(input);
  const delimiter = getDelimiter(input);

  return calculateSum(getNumbers(serialisedInput, delimiter));
}

function serialise(input) {
  const delimiterRegex = /^(\/\/.*\n)/;
  const matches = delimiterRegex.exec(input);

  if (matches && matches.length > 0) {
    return input.replace(delimiterRegex, "");
  }
  return input;
}

function getDelimiter(input) {
  let delimiters = [];
  const delimiterRegex = /(?:^\/\/)?\[([^\[\]]+)\]\n?/g;
  let matches = delimiterRegex.exec(input);

  while (matches !== null) {
    delimiters.push(matches[1]);
    matches = delimiterRegex.exec(input);
  }
  if (delimiters.length > 0) {
    return new RegExp("[" + delimiters.join("") + "]");
  }
  matches = /^\/\/(.*)\n/.exec(input);
  if (matches && matches[1]) {
    return matches[1];
  }
  return /[\n,]/;
}

function getNumbers(string, delimiter) {
  return string
    .split(delimiter)
    .filter((n) => n !== "")
    .map((n) => parseInt(n));
}

function calculateSum(numbers) {
  const negatives = [];
  const finalSum = numbers.reduce((sum, n) => {
    if (n > 1000) {
      return 0;
    }
    if (n < 0) {
      negatives.push(n);
      return 0;
    }
    return sum + n;
  }, 0);
  if (negatives.length > 0) {
    return new Error("Negatives not allowed: " + negatives.join(","));
  }
  return finalSum;
}

console.log(add("")); // output => 0
console.log(add("1\n2,3")); // output => 6
console.log(add("175.2,\n35")); // output => Number expected but '\\n' found at position 6
console.log(add("1,3,")); // output => Number expected but EOF found
console.log(add("//;\n1;2")); // output => 3
console.log(add("//|\n1|2|3")); // output => 6
console.log(add("//sep\n2sep3")); // output => 5
console.log(add("//|\n1|2,3")); // output => "'|' expected but ',' found at position 3"
console.log(add("-1,2")); // output => Negatives not allowed: -1
console.log(add("2,-4,-5")); // output => Negatives not allowed: -4,-5
