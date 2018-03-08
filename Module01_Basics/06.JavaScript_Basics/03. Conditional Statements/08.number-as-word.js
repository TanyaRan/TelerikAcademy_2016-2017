function solve(args) {
  let n = args[0],
      lastDigit,
      middleDigit,
      firstDigit,
      teenGroup,
      output = "",
      str;

  if (n.length === 1) {
    lastDigit = +n;
    middleDigit = 0;
    firstDigit = 0;
    teenGroup = 0;
  }
  else if (n.length === 2) {
    n = +n;
    lastDigit = n%10;
    middleDigit = n/10 | 0;
    middleDigit = middleDigit%10;
    firstDigit = 0;
    teenGroup = +n;
  }
  else {
    n = +n;
    lastDigit = n%10;
    middleDigit = n/10 | 0;
    middleDigit = middleDigit%10;
    firstDigit = n/100 | 0;
    teenGroup = n - firstDigit*100;
  }

  if (firstDigit > 0) {
    if (middleDigit === 0 && lastDigit === 0) {
      str = units(firstDigit)
      output += capitalize(str);
      output += " hundred"
    }
    else if (middleDigit === 0 && lastDigit > 0) {
      str = units(firstDigit)
      output += capitalize(str);
      output += " hundred and "
      output += units(lastDigit);
    }
    else if (middleDigit > 1) {
      str = units(firstDigit)
      output += capitalize(str);
      output += " hundred and "
      output += tens(middleDigit);
      output += " " + units(lastDigit);
    }
    else if (teenGroup > 9 && teenGroup < 20) {
      str = units(firstDigit)
      output += capitalize(str);
      output += " hundred and "
      output += teens(teenGroup);
    }
  }
  else {
      if (middleDigit === 0 && lastDigit === 0) {
        output += "Zero";
      }
      else if (middleDigit === 0 && lastDigit > 0) {
        str = units(lastDigit);
        output += capitalize(str);
      }
      else if (middleDigit > 1) {
        str = tens(middleDigit);
        output += capitalize(str);
        output += " " + units(lastDigit);
      }
      else if (teenGroup > 9 && teenGroup < 20) {
        str = teens(teenGroup);
        output += capitalize(str);
      }
    }

    console.log(output);

  function units(lastDigit) {
    var unitsList = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
    var answer = "" + unitsList[lastDigit] + "";
    return answer;
  }

  function tens(middleDigit) {
    var tensList = ["", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
    var answer = "" + tensList[middleDigit - 1] + "";
    return answer;
  }

  function teens(teenGroup) {
    var teensList = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" ];
    var answer = "" + teensList[teenGroup - 10] + "";
    return answer;
  }

  function capitalize(str) {
    var result = str.charAt(0).toUpperCase() + str.slice(1);
    return result;
  }
}

// solve(['94']);
// solve(['129']);
// solve(['871']);